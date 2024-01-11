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
        string fileName;

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
                _options.AddArgument("headless");
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
                for (int ListCountElementsCount = 1; ListCountElementsCount <= ListCountElements.Count; ListCountElementsCount++)
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
                    string RouteCountText = RouteCountList.Text;
                    RouteCount = RouteCountList.FindElements(By.TagName("tr")).Count;
                    if (RouteCountText == "검색된 데이터가 없습니다.")
                    {
                        continue;
                    }
                    for (int RouteListCount = 1; RouteListCount <= RouteCount; RouteListCount++)
                    {
                        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000);
                        //[항공사],[항공편]
                        Data.AddRange(_driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[1]/p/span[1]/a")).Text.Replace("(", "/").Replace(")", "").Split('/').ToList());
                        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000); // 속도 제어
                        //[출발지],[도착지]
                        Data.AddRange(_driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[1]/p/span[2]")).Text.Replace("에서", "!").Split('!').ToList());
                        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000); // 속도 제어
                        //출발시간
                        Data.Add(_driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[2]")).Text);
                        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000); // 속도 제어
                        //도착시간
                        Data.Add(_driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[3]")).Text);
                        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000); // 속도 제어
                        //운항요일
                        string day = "";
                        for (int daycount = 4; daycount <= 10; daycount++)
                        {
                            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000); // 속도 제어
                            IWebElement element = _driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[{daycount}]"));


                            string innerHTML = element.GetAttribute("innerHTML");
                            
                            if (innerHTML.Contains("<img"))
                            {
                                string outerHTML = element.GetAttribute("outerHTML");
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
                        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000); // 속도 제어
                        string[] DatatestList = _driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[11]")).Text.Replace(" ~ ", "!").Split('!');
                        if (DatatestList.Length < 3)
                        {
                            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000); // 속도 제어
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
                        //html/body/div[6]/div[2]/article/div[1]/div[3]/table/tbody/tr[160]/td[11]/p[4]
                        else if (DatatestList.Length >= 3)
                        {
                            int n = 0;
                            int nk = 7;
                            int nm = 8;
                            for (int AirRouteCount = 1; AirRouteCount <= DatatestList.Length; AirRouteCount += 2)
                            {
                                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000); // 속도 제어
                                IWebElement DataSlicing_1 = _driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[11]"));
                                string DataSlicing_2 = DataSlicing_1.Text.Substring(n, 23);
                                Data.AddRange(DataSlicing_2.Replace("\r\n", "!").Replace(" ~ ", "!").Split('!'));
                                DataList.Add(Data.ToList());
                                if (Air_DataGridViewData.InvokeRequired)
                                {
                                    Air_DataGridViewData.BeginInvoke(new MethodInvoker(delegate ()
                                    {
                                        Air_DataGridViewData.Rows.Add(DataList[kk][0], DataList[kk][1], DataList[kk][2], DataList[kk][3], DataList[kk][4], DataList[kk][5], DataList[kk][6], DataList[kk][nk], DataList[kk][nm]);
                                        kk++;
                                    }));
                                } 
                                n = n + 23;
                                nk = nk + 2;
                                nm = nm + 2;
                            }
                            /*
                            string DataSlicing1 = _driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[11]")).Text.Substring(0, 23);
                            string DataSlicing2 = _driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[11]")).Text.Substring(23, 23);
                            string DataSlicing3 = _driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[11]")).Text.Substring(46);
                            Data.AddRange(DataSlicing1.Replace("\r\n", "!").Replace(" ~ ", "!").Split('!'));
                            Data.AddRange(DataSlicing2.Replace("\r\n", "!").Replace(" ~ ", "!").Split('!'));
                            Data.AddRange(DataSlicing3.Replace("\r\n", "!").Replace(" ~ ", "!").Split('!'));
                            DataList.Add(Data.ToList());
                            if (Air_DataGridViewData.InvokeRequired)
                            {
                                Air_DataGridViewData.BeginInvoke(new MethodInvoker(delegate ()
                                {
                                    Air_DataGridViewData.Rows.Add(DataList[kk][0], DataList[kk][1], DataList[kk][2], DataList[kk][3], DataList[kk][4], DataList[kk][5], DataList[kk][6], DataList[kk][7], DataList[kk][8]);
                                    Air_DataGridViewData.Rows.Add(DataList[kk][0], DataList[kk][1], DataList[kk][2], DataList[kk][3], DataList[kk][4], DataList[kk][5], DataList[kk][6], DataList[kk][9], DataList[kk][10]);
                                    Air_DataGridViewData.Rows.Add(DataList[kk][0], DataList[kk][1], DataList[kk][2], DataList[kk][3], DataList[kk][4], DataList[kk][5], DataList[kk][6], DataList[kk][11], DataList[kk][12]);
                                    kk++;
                                }));
                            }*/
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

        public void Air_SaveFileOpenFile()
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            // 다이얼 로그가 오픈되었을 때 최초의 경로 설정
            saveFile.InitialDirectory = @"D:";

            // 다이얼 로그의 제목
            saveFile.Title = "CSV 저장 위치 지정";

            // 기본 확장자
            saveFile.DefaultExt = "csv";

            // 파일 목록 필터링
            saveFile.Filter = "CSV files(*.csv) | *.csv";

            // ok버튼을 눌럿을대의 동작
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                // 경로와 파일명을 filename에 저장
                fileName = saveFile.FileName.ToString();
            }
        }

        private void Air_DataDownload_BT_Click(object sender, EventArgs e)
        {
            Air_SaveFileOpenFile();
            using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.GetEncoding("utf-8")))
            //using (StreamWriter writer = new StreamWriter("D:odsay_ship_.csv", false, Encoding.GetEncoding("utf-8")))
            {
                int rowCount = Air_DataGridViewData.Rows.Count;

                if (Air_DataGridViewData.AllowUserToAddRows == true)
                {
                    rowCount = rowCount - 1;
                }

                for (int i = 0; i < rowCount; i++)
                {
                    //리스트 초기화
                    List<string> strList = new List<string>();
                    /*
                    for (int j = 0; j < Air_DataGridViewData.Columns.Count; j++)
                    {
                        //strList.Add(Ship_DataGridViewData[j, i].Value.ToString());
                        //금액에서 ,가 있어서 데이터 수집시 오류가 발생함. 그래서 삭제하는 과정 추가
                        string value = Air_DataGridViewData[j, i].Value.ToString();
                        value = value.Replace(",", "");
                        strList.Add(value);
                    }*/
                    String[] strArray = strList.ToArray(); //배열로 변환
                    //CSV 형식으로 변환
                    String strCsvData = String.Join(",", strArray);
                    writer.WriteLine(strCsvData);
                }

                MessageBox.Show("저장완료 ");
                writer.Close();
            }
        }
    }
}
