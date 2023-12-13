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

namespace MultiColoredModernUI.Forms.Ship
{
    public partial class ShipData : Form
    {
        protected ChromeDriverService _driverService = null;
        protected ChromeOptions _options = null;
        protected ChromeDriver _driver = null;
        DateTime today = DateTime.Today;
        string calendar = "";
        string Address_S = "";
        string Address_E = "";

        List<string> A_Code = new List<string>();
        List<string> B_Code = new List<string>();
        List<string> C_Code = new List<string>();
        List<string> D_Code = new List<string>();
        public IWebElement Page;
        public IWebElement Num_Click;


        List<List<string>> DataList = new List<List<string>>();
        List<string> Data = new List<string>();

        List<string> ShipName = new List<string>();
        List<string> StartTime = new List<string>();
        List<string> TimeRequired = new List<string>();
        List<string> Rank = new List<string>();
        List<string> AdultFee = new List<string>();
        List<string> YouthFee = new List<string>();
        List<string> SeniorFee = new List<string>();
        List<string> ChildFee = new List<string>();
        List<string> RemainingSeat = new List<string>();
        List<string> Reservation = new List<string>();

        string date = DateTime.Now.ToString("yyyyMMdd");

        List<string> KoreaLanguage = new List<string>() { "가", "나", "다", "라", "마", "바", "사", "아", "자", "차", "카", "타", "파", "하" };

        string fileName;

        public ShipData()
        {
            InitializeComponent();

            try
            {
                _driverService = ChromeDriverService.CreateDefaultService();
                //브라우져 숨기기
                _driverService.HideCommandPromptWindow = true;

                //드라이버 자동 업데이트 실행
                //Ship_chromeDriverUpdate();

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

        //가보고싶은섬 링크
        private void Ship_Pagelink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://island.haewoon.co.kr/island/html/menu02/sub04.aspx");
        }

        // 테스트 데이터 불러오기
        private void Ship_TestdataButton_Click(object sender, EventArgs e)
        {
            string connectionString_TEST = "Server = 218.234.32.245,5242; Database = TEST_Choi; uid = sa; pwd = yasdo12!@"; //계정
            string queryString_TEST = @"select * from TEST_Choi.[dbo].[ship_choi_00_Testdata]"; // 불러올 쿼리 (예시 데이터)
            using (SqlConnection connection = new SqlConnection(connectionString_TEST))
            {
                SqlCommand command = new SqlCommand(queryString_TEST, connection); //적용되는 코드
                connection.Open(); // 서버열기
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    Ship_DataGridViewData.Rows.Clear();//그리드뷰 초기화

                    while (reader.Read()) //한셀씩 불러와서 하나씩 넣기
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(Ship_DataGridViewData);

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row.Cells[i].Value = reader[i];
                        }

                        Ship_DataGridViewData.Rows.Add(row); // row에 저장된 셀들을 그리드뷰에 입력
                    }
                }
                catch (Exception exc)
                {
                    Trace.WriteLine(exc.Message);
                }
                finally
                {
                    connection.Close();
                    MessageBox.Show("완료되었습니다");
                }

            }
        }

        /*
        //크롬 드라이버 자동업데이트 코드
        public void Ship_chromeDriverUpdate()
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

        //캘린더의 년도월 대입 구문
        public void Ship_DateTimePickerSearch_ValueChanged(object sender, EventArgs e)
        {
            calendar = Ship_DateTimePickerSearch.Value.ToString("yyyy-MM-dd");
        }

        //크롤링
        public void Ship_DataCrawling()
        {
            //throw new NotImplementedException();
            try
            {
                string[] calendar_split = calendar.Split('-');



                _driver = new ChromeDriver(_driverService, _options);
                //크롬 드라이버 설정

                _driver.Navigate().GoToUrl("https://island.haewoon.co.kr/island/html/menu02/sub04.aspx");
                //사이트 호출

                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);
                //호출 과정 중 신호 약화시 대기?

                //항로검색
                IWebElement RouteSearch = _driver.FindElement(By.XPath("/html/body/form/div[3]/table/tbody/tr[2]/td/table/tbody/tr/td[3]/table/tbody/tr[3]/td/table/tbody/tr/td/table/tbody/tr[2]/td[4]/table/tbody/tr/td[8]/a"));
                //년도 검색
                IWebElement Year = _driver.FindElement(By.XPath("//*[@id='f_year']"));
                IWebElement Year1 = _driver.FindElement(By.XPath("//*[@id='f_year']/option[1]"));
                IWebElement Year2 = _driver.FindElement(By.XPath("//*[@id='f_year']/option[2]"));

                if (calendar_split[0] == "")
                {
                    RouteSearch.Click();
                }
                else
                    Year.Click();
                // 년도 매년 수정 (1월1일 기준 직전년도 사라짐)
                if (calendar_split[0] == today.Year.ToString())
                {
                    Year1.Click();
                }
                else if (calendar_split[0] == (today.Year+1).ToString())
                {
                    Year2.Click();
                }
                else
                {
                    MessageBox.Show("연도 오류입니다.");
                    _driver.Dispose();
                }
                //=============================================================================================
                IWebElement Month = _driver.FindElement(By.XPath("//*[@id='f_month']"));
                IWebElement Month_calendar_split = _driver.FindElement(By.XPath($"//*[@id='f_month']/option[{calendar_split[1]}]"));

                Month.Click();
                Regex rxm = new Regex(@"^[0-1][0-9]");
                //ㄴ regex를 통하여 임의의 수를 만든다.
                if (rxm.IsMatch(calendar_split[1]))
                {
                    //ㄴ 만든 regex를 통하여 입력받은 날을 비교하여 존재한다면(true값을 받는다면) 아래 구문을 읽는다.
                    Month_calendar_split.Click();
                }
                else
                    Console.Write("오류입니다.");
                //=============================================================================================
                IWebElement Day = _driver.FindElement(By.XPath("//*[@id='f_day']"));
                IWebElement Day_calendar_split = _driver.FindElement(By.XPath($"//*[@id='f_day']/option[{calendar_split[2]}]"));

                Day.Click();
                Regex rxd = new Regex(@"^[0-3][0-9]");
                if (rxd.IsMatch(calendar_split[2]))
                {
                    Day_calendar_split.Click();
                }
                else
                    Console.Write("오류입니다.");
                //=============================================================================================
                // 항로검색 클릭
                RouteSearch.Click();
                // 창전환
                _driver.SwitchTo().Window(_driver.WindowHandles[1]);


                for (var num_korea = 1; num_korea <= KoreaLanguage.Count * 2; num_korea += 2)
                //for (var num_korea = 7; num_korea <= 7; num_korea += 2)
                {
                    string Num = num_korea.ToString();
                    //가나다라마바사아자차카타파하 클릭
                    _driver.FindElement(By.XPath($"//*[@id='pnl_Default']/table[2]/tbody/tr[1]/td[{Num}]/a")).Click();

                    // 목적지 리스트가 공백일 경우 패스.
                    string vacuum = _driver.FindElement(By.XPath("//*[@id='pnl_Text']/div[2]/table")).Text;
                    if (vacuum == "")
                    {
                        continue;
                    }

                    IWebElement table = _driver.FindElement(By.XPath("//*[@id='pnl_Text']/div[2]/table"));
                    IWebElement tbody = table.FindElement(By.TagName("tbody"));
                    var tr = tbody.FindElements(By.TagName("tr"));

                    //여기에 공백을 제외한 td카운트의 갯수를 구하는법 찾기
                    //찾아서 데이터 값을 돌때 td카운트값이 넘어가면 A.Code 선택지 바꾸기.
                    var td = tbody.FindElements(By.TagName("td"));

                    /*
                    td 갯수 테스트
                    for (int abc = 1; abc <= td.Count; abc++)
                    {
                        Console.WriteLine(abc);
                    }
                    */

                    for (int sectionnum1 = 1; sectionnum1 <= tr.Count; sectionnum1++)
                    {
                        string sectionnum3 = sectionnum1.ToString();
                        for (int sectionnum2 = 1; sectionnum2 < 9; sectionnum2++)
                        {
                            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);
                            string sectionnum4 = sectionnum2.ToString();
                            // 목적지 리스트 - 도착지(섬 명)에 공백일 경우 패스
                            string EndList = _driver.FindElement(By.XPath($"//*[@id='pnl_Text']/div[2]/table/tbody/tr[{sectionnum3}]/td[{sectionnum4}]")).Text;

                            if (EndList == "")
                            {
                                continue;
                            }
                            else if (EndList != "")
                            {
                                // 섬명 하나씩 클릭
                                //IWebElement Page = _driver.FindElement(By.XPath($"//*[@id='pnl_Text']/div[2]/table/tbody/tr[{sectionnum3}]/td[{sectionnum4}]"));
                                _driver.FindElement(By.XPath($"//*[@id='pnl_Text']/div[2]/table/tbody/tr[{sectionnum3}]/td[{sectionnum4}]")).Click();
                            }

                            string EndList_x = _driver.FindElement(By.XPath("//*[@id='divContent']/table/tbody/tr[2]/td")).Text;
                            //IWebElement BackMove = _driver.FindElement(By.XPath("//*[@id='tb_start_ON']/tbody/tr/td[3]/a/img")); //재설정 눌러서 뒤로가기 삭제예정

                            //패스하거나 해당 엘리먼트값을 저장해둔다.
                            if (EndList_x == "선택하신 도착지의 항로가 없습니다.")
                            {
                                //_driver.FindElement(By.XPath("/html/body/form/table/tbody/tr/td/table/tbody/tr[4]/td/div/table[1]/tbody/tr/td[3]/a/img")).Click(); //재설정 눌러서 뒤로가기
                                _driver.Navigate().Back();
                                _driver.FindElement(By.XPath($"//*[@id='pnl_Default']/table[2]/tbody/tr[1]/td[{Num}]/a")).Click();
                                continue;
                            }
                            else if (EndList_x != "선택하신 도착지의 항로가 없습니다.")
                            {
                                _driver.FindElement(By.XPath("/html/body/form/table/tbody/tr/td/table/tbody/tr[4]/td/div/table[1]/tbody/tr/td[3]/a/img")).Click(); //재설정 눌러서 뒤로가기
                                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);
                                _driver.FindElement(By.XPath($"//*[@id='pnl_Default']/table[2]/tbody/tr[1]/td[{Num}]/a")).Click();
                                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);
                                // 경로 자체를 저장.
                                A_Code.Add($"//*[@id='pnl_Default']/table[2]/tbody/tr[1]/td[{Num}]/a");
                                B_Code.Add($"//*[@id='pnl_Text']/div[2]/table/tbody/tr[{sectionnum3}]/td[{sectionnum4}]");
                                C_Code.Add(_driver.FindElement(By.XPath($"//*[@id='pnl_Default']/table[2]/tbody/tr[1]/td[{Num}]/a")).Text);
                                D_Code.Add(_driver.FindElement(By.XPath($"//*[@id='pnl_Text']/div[2]/table/tbody/tr[{sectionnum3}]/td[{sectionnum4}]")).Text);
                                //*[@id="pnl_Default"]/table[2]/tbody/tr[1]/td[27]
                                //*[@id="pnl_Text"]/div[2]/table/tbody/tr[8]/td[8]
                                continue;

                            }
                        }
                    }
                }
                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);
                // 여기 아래에서부터 "가 나 다 라 마 ..." 넘어가는 순서가 문제있음
                int kk = 0;
                //저장해두었던 경로찾아 입력.
                for (int m = 1; m <= KoreaLanguage.Count * 2; m = m + 2)
                {
                    // 재설정을 눌렀기 때문에 창을 닫고 다시켬.
                    _driver.Close();
                    _driver.SwitchTo().Window(_driver.WindowHandles[0]);
                    _driver.FindElement(By.XPath("/html/body/form/div[3]/table/tbody/tr[2]/td/table/tbody/tr/td[3]/table/tbody/tr[3]/td/table/tbody/tr/td/table/tbody/tr[2]/td[4]/table/tbody/tr/td[8]/a")).Click();
                    _driver.SwitchTo().Window(_driver.WindowHandles[1]);
                    _driver.FindElement(By.XPath($"//*[@id='pnl_Default']/table[2]/tbody/tr[1]/td[{m}]/a")).Click();
                    _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);
                    //IWebElement A_Code1 = _driver.FindElement(By.XPath(A_Code[i]));

                    for (int j = 0; j < B_Code.Count; j++)
                    {
                        try
                        {
                            _driver.FindElement(By.XPath(A_Code[j])).Click();
                        }
                        catch
                        {
                            MessageBox.Show("A코드 오류.");
                        }
                        
                        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);

                        IWebElement GetAttribute1 = _driver.FindElement(By.XPath(B_Code[j])); // 엘리먼트 호출
                        string GetAttribute2 = GetAttribute1.GetAttribute("onmouseover"); // 필요데이터 추출
                        string[] style = GetAttribute2.Split('"'); // ="showNote(\"가사도\", \"전남 진도군 조도면 가사도리\", this)" / 데이터 구분
                        Address_E = style[1] + "(" + style[3] + ")"; // 가사도(전남 진도군 조도면 가사도리)

                        //IWebElement B_Code1 = _driver.FindElement(By.XPath(B_Code[j]));
                        try
                        {
                            _driver.FindElement(By.XPath(B_Code[j])).Click();
                        }
                        catch
                        {
                            MessageBox.Show("B코드 오류.");
                        }

                        IWebElement table_end = _driver.FindElement(By.XPath("//*[@id='pnlRouteSelect']/div[2]/table"));
                        IWebElement tbody_end = table_end.FindElement(By.TagName("tbody"));
                        var tr_end = tbody_end.FindElements(By.TagName("tr"));

                        for (int k = 1; k <= tr_end.Count; k++)
                        {
                            string k1 = k.ToString(); // int값 str로 변환
                            _driver.Manage().Window.Maximize();
                            try
                            {
                                Thread.Sleep(1000);
                                //ButtonClick
                                if (tr_end.Count >=20)
                                {
                                    int intk = 10;
                                    if (k>=12)
                                    {
                                        var kkk = k * intk;
                                        string script = $"window.scrollTo(0, document.body.scrollHeight - 150 + {kkk});";
                                        ((IJavaScriptExecutor)_driver).ExecuteScript(script);
                                    }
                                    
                                }
                                _driver.FindElement(By.XPath($"/html/body/form/table/tbody/tr/td/table/tbody/tr[5]/td/div/table/tbody/tr[2]/td/div/div[2]/table/tbody/tr[{k1}]/td[1]/input")).Click();
                            }
                            catch
                            {
                                MessageBox.Show("버튼 클릭 오류.");
                                //_driver.FindElement(By.XPath($"/html/body/form/table/tbody/tr/td/table/tbody/tr[5]/td/div/table/tbody/tr[2]/td/div/div[2]/table/tbody/tr[{k1}]/td[1]/input")).Click();
                                
                            }
                            

                            //창 아래로 내리기
                            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");

                            //상세 출발지 입력
                            Address_S = _driver.FindElement(By.XPath("//*[@id='NociteLayer2']")).Text;

                            IWebElement Pick = _driver.FindElement(By.XPath("//*[@id='frmRoute']/table/tbody/tr/td/table/tbody/tr[8]/td/a"));
                            try
                            {
                                Pick.Click(); // 선택완료
                            }
                            catch
                            {
                                MessageBox.Show("선택 완료 오류.");
                            }
                            _driver.SwitchTo().Window(_driver.WindowHandles[0]); // 창전환
                            IWebElement Search = _driver.FindElement(By.XPath("/html/body/form/div[3]/table/tbody/tr[2]/td/table/tbody/tr/td[3]/table/tbody/tr[3]/td/table/tbody/tr/td/table/tbody/tr[4]/td[4]/table/tbody/tr[1]/td[8]/input"));
                            try
                            {
                                //조회하기 클릭
                                Search.Click();
                            }
                            catch
                            {
                                MessageBox.Show("조회하기 오류.");
                            }
                            
                            

                            IWebElement tbody_a = _driver.FindElement(By.XPath("//*[@id='layer_DepartureAFare']/div/table/tbody"));
                            IWebElement tr_a = tbody_a.FindElement(By.TagName("tr"));
                            var tr_b = tbody_a.FindElements(By.TagName("tr"));

                            int c = 0;

                            string DataListText = _driver.FindElement(By.XPath("//*[@id='layer_DepartureAFare']/div/table/tbody/tr/td")).Text;
                            string DataListStrart = _driver.FindElement(By.XPath("//*[@id='F_PortNameView']")).Text;
                            string DataListEnd = _driver.FindElement(By.XPath("//*[@id='T_PortNameView']")).Text;
                            
                            //홈페이지창 데이터 입력
                            foreach (IWebElement tr_bb in tr_b)
                            {
                                if (DataListText != "항차정보가 존재하지 않습니다.")
                                {
                                    if (c % 2 == 0)
                                    {
                                        Data.Clear();

                                        var td_a = tr_bb.FindElements(By.TagName("td"));
                                        /*
                                        foreach (var td in td_a)
                                        {
                                            if (td.Text == ".")
                                                Data.Add("등급없음");
                                            else if (td.Text == "-")
                                                Data.Add("등급없음");
                                            else
                                                Data.Add(td.Text);
                                        }
                                        */

                                        //===============================================================================================
                                        //데이터가 잘못들어가는 경우가 있어 간단하게 구분하면서 중복이 나올경우 데이터를 넣지않음
                                        string[] test1 = Address_S.Split('(');
                                        if (DataListStrart == test1[0])
                                        {
                                            Data.Add(Address_S); // 출발지 상세주소
                                        }
                                        else
                                        {
                                            break;
                                        }
                                        //===============================================================================================
                                        string[] test2 = Address_E.Split('(');
                                        if (DataListEnd == test2[0])
                                        {
                                            Data.Add(Address_E); // 도착지 상세주소
                                        }
                                        else
                                        {
                                            break;
                                        }
                                        //===============================================================================================


                                        Data.Add(td_a[0].Text); // 선박명
                                        Data.Add(td_a[1].Text); // 출발시각


                                        //===============================================================================================
                                        // 소요시각

                                        if (td_a[2].Text != "-")
                                        {
                                            string[] TimeExchange = td_a[2].Text.Replace("시간 ", ":").Replace("분", "").Split(':');
                                            string hours1 = TimeExchange[0];
                                            string hours2 = TimeExchange[1];
                                            int min = int.Parse(hours1) * 60;
                                            int Time = int.Parse(hours2) + min;
                                            Data.Add(Time.ToString());
                                        }

                                        else
                                        {
                                            Data.Add(td_a[2].Text);
                                        }
                                        //===============================================================================================
                                        // 등급

                                        if (td_a[3].Text == ".")
                                        { Data.Add("등급없음"); }
                                        else if (td_a[3].Text == "-")
                                        { Data.Add("등급없음"); }
                                        else
                                        { Data.Add(td_a[3].Text); }

                                        //===============================================================================================
                                        Data.Add(td_a[4].Text); // 대인
                                        Data.Add(td_a[5].Text); // 중고
                                        Data.Add(td_a[6].Text); // 경로
                                        Data.Add(td_a[7].Text); // 소아
                                        Data.Add(td_a[8].Text); // 잔여석
                                        Data.Add(td_a[9].Text); // 예매
                                        //- 여기서 진도쉬미-가사도에서 오류발생 추측 데이터그리드뷰에서 14개가 넘어감..
                                        Data.Add(DataListStrart); // 출발지
                                        Data.Add(DataListEnd); // 도착지


                                        //딕셔너리에 추가한다.
                                        //DataList.Add(Data.ToList());

                                        List<List<string>> Data2 = new List<List<string>>();
                                        Data2.Add(Data.ToList());

                                        if (!DataList.Any() || !DataList.SequenceEqual(Data2))
                                        {
                                            DataList.Add(Data.ToList());
                                            Data2.Clear();
                                        }
                                        else
                                        {
                                            continue;
                                        }


                                    }
                                    else
                                    {
                                        c++;
                                        continue;
                                    }
                                    //데이터그리드뷰에 데이터 삽입

                                    if (Ship_DataGridViewData.InvokeRequired)
                                    {
                                        Ship_DataGridViewData.BeginInvoke(new MethodInvoker(delegate ()
                                        {
                                            //여기서 인덱스 오류남

                                            Ship_DataGridViewData.Rows.Add(DataList[kk][2], DataList[kk][3], DataList[kk][4], DataList[kk][5], DataList[kk][6], DataList[kk][7], DataList[kk][8], DataList[kk][9], DataList[kk][10], DataList[kk][11], DataList[kk][12], DataList[kk][13], DataList[kk][0], DataList[kk][1]);
                                            kk++;
                                        }));

                                    }

                                }
                                else
                                {
                                    continue;
                                }
                                c++;
                            }// 여기서 foreach가 끝남
                             //항로검색
                            try
                            {
                                _driver.FindElement(By.XPath("/html/body/form/div[3]/table/tbody/tr[2]/td/table/tbody/tr/td[3]/table/tbody/tr[3]/td/table/tbody/tr/td/table/tbody/tr[2]/td[4]/table/tbody/tr/td[8]/a")).Click();
                            }
                            catch
                            {
                                MessageBox.Show("재항로검색 오류.");
                            }
                            //팝업창 전환
                            _driver.SwitchTo().Window(_driver.WindowHandles[1]);
                            try
                            {
                                _driver.FindElement(By.XPath(A_Code[j])).Click(); // = A_Code1    
                            }
                            catch
                            {
                                MessageBox.Show("2A코드 오류.");
                            }
                            
                            try
                            {
                                _driver.FindElement(By.XPath(B_Code[j])).Click(); // = B_Code1
                            }
                            catch
                            {
                                MessageBox.Show("2B코드 오류.");
                            }
                            
                        }
                        _driver.Close();
                        _driver.SwitchTo().Window(_driver.WindowHandles[0]);
                        try
                        {
                            _driver.FindElement(By.XPath("/html/body/form/div[3]/table/tbody/tr[2]/td/table/tbody/tr/td[3]/table/tbody/tr[3]/td/table/tbody/tr/td/table/tbody/tr[2]/td[4]/table/tbody/tr/td[8]/a")).Click();
                        }
                        catch
                        {
                            MessageBox.Show($"{_driver.FindElement(By.XPath("/html/body/form/div[3]/table/tbody/tr[2]/td/table/tbody/tr/td[3]/table/tbody/tr[3]/td/table/tbody/tr/td/table/tbody/tr[2]/td[4]/table/tbody/tr/td[8]/a")).Text} 오류.");
                        }
                        
                        _driver.SwitchTo().Window(_driver.WindowHandles[1]);
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
                _driver.Dispose();
                MessageBox.Show("종료되었습니다.");
            }
        }

        //쓰레드1
        //에러이유 크로스 스레드를 써야함. 이유:스레드 작동 도중 ui는 변경되지않게 되어있는데 변경되어서.
        private void Ship_DataCollection_Click(object sender, EventArgs e)
        {
            //쓰레드 입혀서 작동
            Thread th1 = new Thread(new ThreadStart(Ship_DataCrawling));
            //th1.IsBackground = true;
            th1.Start();
        }

        // 크롬드라이버 종료
        private void Ship_ChromeDriverTermination_Click(object sender, EventArgs e)
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

        // 참고한 페이지 : https://verificationkr.tistory.com/18
        public void Ship_SaveFileOpenFile()
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

        // csv 다운로드
        private void Ship_DataDownload_Click(object sender, EventArgs e)
        {
            Ship_SaveFileOpenFile();
            using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.GetEncoding("utf-8")))
            {
                int rowCount = Ship_DataGridViewData.Rows.Count;

                if (Ship_DataGridViewData.AllowUserToAddRows == true)
                {
                    rowCount = rowCount - 1;
                }

                for (int i = 0; i < rowCount; i++)
                {
                    //리스트 초기화
                    List<string> strList = new List<string>();

                    for (int j = 0; j < Ship_DataGridViewData.Columns.Count; j++)
                    {
                        //strList.Add(Ship_DataGridViewData[j, i].Value.ToString());
                        //금액에서 ,가 있어서 데이터 수집시 오류가 발생함. 그래서 삭제하는 과정 추가
                        string value = Ship_DataGridViewData[j, i].Value.ToString();
                        value = value.Replace(",", "");
                        strList.Add(value);
                    }
                    String[] strArray = strList.ToArray(); //배열로 변환
                    //CSV 형식으로 변환
                    String strCsvData = String.Join(",", strArray);
                    writer.WriteLine(strCsvData);
                }

                MessageBox.Show("저장완료 ");
                writer.Close();
            }
        }

        // DB업데이트
        private void Ship_DBupdate_Click(object sender, EventArgs e)
        {
            //db접속정보
            string connectionString = "Server = 218.234.32.194,5242; Database = NEW_SHIP; uid = sa; pwd = yasdo12!@";
            string queryString = "INSERT INTO NEW_SHIP.dbo.TBShipCrawlingData (ShipName, StartTime, TimeRequired, Rank, AdultFee, YouthFee, SeniorFee, ChildFee, RemainingSeat, Reservation, Harbor_Name_S, Harbor_Name_E, Detailed_Harbor_Name_S, Detailed_Harbor_Name_E, Collection_date, Collection_day) " +
                "VALUES (@ShipName, @StartTime, @TimeRequired, @Rank, @AdultFee, @YouthFee, @SeniorFee, @ChildFee, @RemainingSeat, @Reservation, @Harbor_Name_S, @Harbor_Name_E, @Detailed_Harbor_Name_S, @Detailed_Harbor_Name_E, @Collection_date, @Collection_day)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                try
                {
                    for (int jk = 0; jk < DataList.Count; jk++)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@ShipName", DataList[jk][2].ToString());
                        command.Parameters.AddWithValue("@StartTime", DataList[jk][3].ToString());
                        command.Parameters.AddWithValue("@TimeRequired", DataList[jk][4].ToString());
                        command.Parameters.AddWithValue("@Rank", DataList[jk][5].ToString());
                        command.Parameters.AddWithValue("@AdultFee", DataList[jk][6].ToString());
                        command.Parameters.AddWithValue("@YouthFee", DataList[jk][7].ToString());
                        command.Parameters.AddWithValue("@SeniorFee", DataList[jk][8].ToString());
                        command.Parameters.AddWithValue("@ChildFee", DataList[jk][9].ToString());
                        command.Parameters.AddWithValue("@RemainingSeat", DataList[jk][10].ToString());
                        command.Parameters.AddWithValue("@Reservation", DataList[jk][11].ToString());
                        command.Parameters.AddWithValue("@Harbor_Name_S", DataList[jk][12].ToString());
                        command.Parameters.AddWithValue("@Harbor_Name_E", DataList[jk][13].ToString());
                        command.Parameters.AddWithValue("@Detailed_Harbor_Name_S", DataList[jk][0].ToString());
                        command.Parameters.AddWithValue("@Detailed_Harbor_Name_E", DataList[jk][1].ToString());
                        command.Parameters.AddWithValue("@Collection_date", DateTime.Today.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@Collection_day", calendar);


                        int rowsAffected = command.ExecuteNonQuery();

                    }
                }
                catch (Exception exc)
                {
                    Trace.WriteLine(exc.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            MessageBox.Show("완료되었습니다");
        }

        private void Ship_DataClear_Click(object sender, EventArgs e)
        {
            Ship_DataGridViewData.Rows.Clear();
        }
    }
}
