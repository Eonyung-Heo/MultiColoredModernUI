using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Text.RegularExpressions;
using System.IO;
//using ChromeDriverUpdater;
using System.Data.SqlClient;

using System.Threading;

namespace MultiColoredModernUI.Forms.Airplane
{
    public partial class AirData : Form
    {
        protected ChromeDriverService _driverService = null;
        protected ChromeOptions _options = null;
        protected ChromeDriver _driver = null;

        List<List<string>> DataList = new List<List<string>>();
        List<string> Data = new List<string>();
        int RouteCount;
        int kk = 0;

        public AirData()
        {
            InitializeComponent();

            try
            {
                _driverService = ChromeDriverService.CreateDefaultService();
                //브라우져 숨기기
                _driverService.HideCommandPromptWindow = true;

                //드라이버 자동 업데이트 실행
                //Airplane_chromeDriverUpdate();

                _options = new ChromeOptions();
                //_options.AddArgument("headless");
                _options.AddArgument("disable-gpu");
                _options.AddArgument("-no-sandbox");
                _options.AddArgument("--start-maximized");

            }
            catch (Exception exc)
            {
                Trace.WriteLine(exc.Message);
            }
        }
        /*
        //크롬 드라이버 자동업데이트 코드
        public void Airplane_chromeDriverUpdate()
        {
            try
            {
                var path = System.Windows.Forms.Application.StartupPath;
                new Updater().Update(path + "\\chromedriver.exe");

            }
            catch (UpdateFailException exc)
            {
                // ...
            }
        }*/

        // 크롬드라이버 종료
        private void Air_ChromeDriverTermination_BT_Click(object sender, EventArgs e)
        {
            try
            {
                _driver.Dispose();
                MessageBox.Show("종료되었습니다.");
            }
            catch
            {
                MessageBox.Show("사용한 드라이버가 열려있지 않습니다.");
            }
        }
        
        //항공시간표 링크
        private void Air_Pagelink_BT_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.airport.co.kr/gimpo/cms/frCon/index.do?MENU_ID=1060");
        }


        //크롤링
        public void Airplane_DataCrawling()
        {
            try
            {
                _driver = new ChromeDriver(_driverService, _options);
                //크롬 드라이버 설정

                _driver.Navigate().GoToUrl("https://www.airport.co.kr/gimpo/cms/frCon/index.do?MENU_ID=1060");
                //사이트 호출

                Thread.Sleep(2000);
                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                //호출 과정 중 신호 약화시 대기?

                // 공항 갯수 카운트
                IWebElement StartListCount = _driver.FindElement(By.XPath("/html/body/div[6]/div[2]/article/div[1]/div[2]/form/fieldset/div[2]/select"));
                var ListCountElements = StartListCount.FindElements(By.TagName("option"));
                
                // 크롤링
                for (var ListCountElementsCount = 1; ListCountElementsCount <= ListCountElements.Count; ListCountElementsCount++)
                {
                    // 공항 선택
                    StartListCount.Click();
                    _driver.FindElement(By.XPath($"/html/body/div[6]/div[2]/article/div[1]/div[2]/form/fieldset/div[2]/select/option[{ListCountElementsCount}]")).Click();

                    //출발 버튼
                    _driver.FindElement(By.XPath("//*[@id='sendForm']/fieldset/div[4]/span[2]/label")).Click();
                    _driver.FindElement(By.XPath("//*[@id='sendForm']/fieldset/button/span")).Click();
                    Thread.Sleep(2000);
                    //노선 갯수 카운트
                    IWebElement RouteCountList = _driver.FindElement(By.XPath("//*[@id='outTbody']"));
                    var RouteCountText = RouteCountList.Text;
                    RouteCount = RouteCountList.FindElements(By.TagName("tr")).Count;
                    if (RouteCountText == "검색된 데이터가 없습니다.")
                    {
                        continue;
                    }
                    for (var RouteListCount = 1; RouteListCount <= RouteCount; RouteListCount++)
                    {
                        //[항공사],[항공편]
                        Data.AddRange(_driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[1]/p/span[1]/a")).Text.Replace("(", "/").Replace(")", "").Split('/').ToList());
                        //[출발지],[도착지]
                        Data.AddRange(_driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[1]/p/span[2]")).Text.Replace("에서", "!").Split('!').ToList());
                        //*[@id="outTbody"]/tr[1]/td[1]
                        //*[@id="outTbody"]/tr[2]/td[1]
                        //출발시간
                        Data.Add(_driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[2]")).Text);
                        //도착시간
                        Data.Add(_driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[3]")).Text);
                        //운항요일
                        string day = "";
                        for (var daycount = 4; daycount <= 10; daycount++)
                        {
                            IWebElement element = _driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[{daycount}]"));

                            var innerHTML = element.GetAttribute("innerHTML");
                            
                            if (innerHTML.Contains("<img"))
                            {
                                var outerHTML = element.GetAttribute("outerHTML");
                                day = day + outerHTML.Substring(16,1);
                            }
                            else
                            {
                                continue;
                            }
                            if (day == "월화수목금토일")
                            {
                                day = "매일";
                            }
                        }
                        Data.Add(day);
                        //운항기간
                        var DatatestList = _driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[11]")).Text.Replace(" ~ ", "!").Split('!');
                        if (DatatestList.Length < 3)
                        {
                            Data.AddRange(_driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[11]")).Text.Replace(" ~ ", "!").Split('!'));
                            DataList.Add(Data.ToList());
                            if (Air_DataGridViewData.InvokeRequired)
                            {
                                Air_DataGridViewData.BeginInvoke(new MethodInvoker(delegate ()
                                {
                                    Air_DataGridViewData.Rows.Add(DataList[kk][0], DataList[kk][1], DataList[kk][2], DataList[kk][3], DataList[kk][4], DataList[kk][5], DataList[kk][6], DataList[kk][7], DataList[kk][8]);
                                    kk++;
                                }));
                            }
                        }
                        //운항기간이 2가지 일경우
                        else if (DatatestList.Length == 3)
                        {
                            var testdata1 = _driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[11]")).Text.Substring(0, 23);
                            var testdata2 = _driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[11]")).Text.Substring(23);
                            Data.AddRange(testdata1.Replace("\r\n", "!").Replace(" ~ ", "!").Split('!'));
                            Data.AddRange(testdata2.Replace("\r\n", "!").Replace(" ~ ", "!").Split('!'));
                            DataList.Add(Data.ToList());
                            if (Air_DataGridViewData.InvokeRequired)
                            {
                                Air_DataGridViewData.BeginInvoke(new MethodInvoker(delegate ()
                                {
                                    Air_DataGridViewData.Rows.Add(DataList[kk][0], DataList[kk][1], DataList[kk][2], DataList[kk][3], DataList[kk][4], DataList[kk][5], DataList[kk][6], DataList[kk][7], DataList[kk][8]);
                                    Air_DataGridViewData.Rows.Add(DataList[kk][0], DataList[kk][1], DataList[kk][2], DataList[kk][3], DataList[kk][4], DataList[kk][5], DataList[kk][6], DataList[kk][10], DataList[kk][11]);
                                    kk++;
                                }));
                            }
                        }
                        // 운항기간이 3가지 일 경우
                        else if (DatatestList.Length > 3)
                        {
                            var testdata1 = _driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[11]")).Text.Substring(0, 23);
                            var testdata2 = _driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[11]")).Text.Substring(23, 25);
                            var testdata3 = _driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[11]")).Text.Substring(48);
                            Data.AddRange(testdata1.Replace("\r\n", "!").Replace(" ~ ", "!").Split('!'));
                            Data.AddRange(testdata2.Replace("\r\n", "!").Replace(" ~ ", "!").Split('!'));
                            Data.AddRange(testdata3.Replace("\r\n", "!").Replace(" ~ ", "!").Split('!'));
                            DataList.Add(Data.ToList());
                            if (Air_DataGridViewData.InvokeRequired)
                            {
                                Air_DataGridViewData.BeginInvoke(new MethodInvoker(delegate ()
                                {
                                    Air_DataGridViewData.Rows.Add(DataList[kk][0], DataList[kk][1], DataList[kk][2], DataList[kk][3], DataList[kk][4], DataList[kk][5], DataList[kk][6], DataList[kk][7], DataList[kk][8]);
                                    Air_DataGridViewData.Rows.Add(DataList[kk][0], DataList[kk][1], DataList[kk][2], DataList[kk][3], DataList[kk][4], DataList[kk][5], DataList[kk][6], DataList[kk][10], DataList[kk][11]);
                                    Air_DataGridViewData.Rows.Add(DataList[kk][0], DataList[kk][1], DataList[kk][2], DataList[kk][3], DataList[kk][4], DataList[kk][5], DataList[kk][6], DataList[kk][13], DataList[kk][14]);
                                    kk++;
                                }));
                            }
                        }
                        else
                        {
                            MessageBox.Show("운항 기간 수집 중 오류입니다.");
                        }
                        Data.Clear();
                    }
                }
            }
            catch (Exception exc)
            {
                _driver.Dispose();
                Trace.WriteLine(exc.Message);
            }
            finally
            {
                MessageBox.Show("종료되었습니다.");
            }
        }

        private void Air_DataCollection_BT_Click(object sender, EventArgs e)
        {
            //쓰레드 입혀서 작동
            Thread th1 = new Thread(new ThreadStart(Airplane_DataCrawling));
            th1.Start();
        }
    }
}
