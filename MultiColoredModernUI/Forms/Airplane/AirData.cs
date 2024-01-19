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
        List<string> Data_Index = new List<string>();
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
                    Thread.Sleep(2000);
                    for (int RouteListCount = 1; RouteListCount <= RouteCount; RouteListCount++)
                    {
                        string S_AirStart = "";
                        string S_Airport = "";
                        string E_AirStart = "";
                        string E_Airport = "";
                        //[항공사],[항공편]
                        Data.AddRange(_driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[1]/p/span[1]/a")).Text.Replace("(", "/").Replace(")", "").Split('/').ToList());
                        //[출발지],[도착지]
                        var Data_SE = _driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[1]/p/span[2]")).Text.Replace("에서", "!").Split('!').ToList();
                        if (Data_SE[0] == "서울/김포")
                        {
                            S_AirStart = "서울";
                            S_Airport = "김포국제공항";
                        }
                        else if (Data_SE[0] == "부산/김해")
                        {
                            S_AirStart = "부산";
                            S_Airport = "김해국제공항";
                        }
                        else if (Data_SE[0] == "포항/포항경주")
                        {
                            S_AirStart = "포항";
                            S_Airport = "포항공항";
                        }
                        else if (Data_SE[0] == "청주")
                        {
                            S_AirStart = "청주/대전";
                            S_Airport = "청주국제공항";
                        }
                        else if (Data_SE[0] == "여수")
                        {
                            S_AirStart = "여수/순천";
                            S_Airport = "여수공항";
                        }/*
                        else if (Data_SE[0] == "진주/사천")
                        {
                            S_AirStart = "진주";
                            S_Airport = "사천공항";
                        }*/
                        else if (Data_SE[0] == "원주")
                        {
                            S_AirStart = "원주/횡성";
                            S_Airport = "원주공항";
                        }
                        else
                        {
                            S_AirStart = Data_SE[0].ToString();
                            S_Airport = Data_SE[0].ToString() + "공항";
                        }
                        Data.Add(S_AirStart);
                        Data.Add(S_Airport);

                        if (Data_SE[1] == "서울/김포")
                        {
                            E_AirStart = "서울";
                            E_Airport = "김포국제공항";
                        }
                        else if (Data_SE[1] == "부산/김해")
                        {
                            E_AirStart = "부산";
                            E_Airport = "김해국제공항";
                        }
                        else if (Data_SE[1] == "포항/포항경주")
                        {
                            E_AirStart = "포항";
                            E_Airport = "포항공항";
                        }
                        else if (Data_SE[1] == "청주")
                        {
                            E_AirStart = "청주/대전";
                            E_Airport = "청주국제공항";
                        }
                        else if (Data_SE[1] == "여수")
                        {
                            E_AirStart = "여수/순천";
                            E_Airport = "여수공항";
                        }/*
                        else if (Data_SE[1] == "진주/사천")
                        {
                            E_AirStart = "진주";
                            E_Airport = "사천공항";
                        }*/
                        else if (Data_SE[1] == "원주")
                        {
                            E_AirStart = "원주/횡성";
                            E_Airport = "원주공항";
                        }
                        else
                        {
                            E_AirStart = Data_SE[1].ToString();
                            E_Airport = Data_SE[1].ToString() + "공항";
                        }
                        Data.Add(E_AirStart);
                        Data.Add(E_Airport);
                        //출발시간
                        Data.Add(_driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[2]")).Text);
                        //도착시간
                        Data.Add(_driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[3]")).Text);
                        //운항요일
                        string day = "";
                        for (int daycount = 4; daycount <= 10; daycount++)
                        {
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
                        IWebElement DataSlicing_1 = _driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[11]"));
                        var Data_p = DataSlicing_1.FindElements(By.TagName("p"));
                        if (Data_p.Count <= 1)
                        {
                            Data.AddRange(_driver.FindElement(By.XPath($"//*[@id='outTbody']/tr[{RouteListCount}]/td[11]")).Text.Replace(" ~ ", "!").Split('!'));
                            DataList.Add(Data.ToList());
                            if (Air_DataGridViewData.InvokeRequired)
                            {
                                Air_DataGridViewData.BeginInvoke(new MethodInvoker(delegate ()
                                {
                                    Air_DataGridViewData.Rows.Add(DataList[kk][0], DataList[kk][1], DataList[kk][2], DataList[kk][3], DataList[kk][4], DataList[kk][5], DataList[kk][6], DataList[kk][7], DataList[kk][8], DataList[kk][9], DataList[kk][10]);
                                    kk++;
                                }));
                            }
                        }
                        else if (Data_p.Count >= 2)
                        {
                            Thread.Sleep(2000);
                            int n = 0;
                            for (int AirRouteCount = 1; AirRouteCount <= Data_p.Count; AirRouteCount++)
                            {
                                string DataSlicing_2 = DataSlicing_1.Text;
                                string DataSlicing_3 = DataSlicing_2.Substring(n, 23);
                                Data_Index.AddRange(DataSlicing_3.Replace("\r\n", "!").Replace(" ~ ", "!").Split('!'));
                                Data.AddRange(Data_Index.ToList());
                                Thread.Sleep(2000);
                                DataList.Add(Data.ToList());
                                if (Air_DataGridViewData.InvokeRequired)
                                {
                                    Air_DataGridViewData.BeginInvoke(new MethodInvoker(delegate ()
                                    {
                                        Air_DataGridViewData.Rows.Add(DataList[kk][0], DataList[kk][1], DataList[kk][2], DataList[kk][3], DataList[kk][4], DataList[kk][5], DataList[kk][6], DataList[kk][7], DataList[kk][8], DataList[kk][9], DataList[kk][10]);
                                        kk++;
                                    }));
                                }
                                n = n + 23;
                                Data.Remove(Data[10]);
                                Data.Remove(Data[9]);
                                Data_Index.Clear();
                            }
                        }
                        //html/body/div[6]/div[2]/article/div[1]/div[3]/table/tbody/tr[169]
                        else
                        {
                            MessageBox.Show($"{RouteListCount}번 운항 기간 수집 중 오류입니다.");
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
            ///Air_DBupdate_BT.Enabled = false;
            //쓰레드 입혀서 작동
            Thread th1 = new Thread(new ThreadStart(Airplane_DataCrawling));
            th1.Start();
            //Air_DBupdate_BT.Enabled = true;


        }

        public void Air_SaveFileOpenFile()
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            // 다이얼 로그가 오픈되었을 때 최초의 경로 설정
            saveFile.InitialDirectory = @"C:";

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
            {
                // 헤더를 CSV 파일에 추가
                List<string> headerList = new List<string>();
                foreach (DataGridViewColumn column in Air_DataGridViewData.Columns)
                {
                    headerList.Add(column.HeaderText);
                }
                writer.WriteLine(string.Join(",", headerList));

                int rowCount = Air_DataGridViewData.Rows.Count;

                if (Air_DataGridViewData.AllowUserToAddRows == true)
                {
                    rowCount = rowCount - 1;
                }

                for (int i = 0; i < rowCount; i++)
                {
                    //리스트 초기화
                    List<string> strList = new List<string>();
                    
                    for (int j = 0; j < Air_DataGridViewData.Columns.Count; j++)
                    {
                        string value = Air_DataGridViewData[j, i].Value.ToString();
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

        private void Air_DBupdate_BT_Click(object sender, EventArgs e)
        {
            //select * from[TBInterCity_Airplane] ORDER BY IDX ASC
            //SELECT * FROM[TBInterCity_AirplaneInfo]

            //db접속정보
            string connectionString = "Server = 218.234.32.245,5242; Database = NaverODsay_Dev_Sub; uid = sa; pwd = yasdo12!@";
            string queryString = "INSERT INTO NaverODsay_Dev_Sub.dbo.TBInterCity_Airplane_CrawlingData (Company, Flight, Origin, OriginAirport, Destination, DestinationAirport, DepartureTime, ArrivalTime, Runday, StartDate, EndDate, CrawlingDataDay) " +
                "VALUES (@Company, @Flight, @Origin, @OriginAirport, @Destination, @DestinationAirport, @DepartureTime, @ArrivalTime, @Runday, @StartDate, @EndDate, @CrawlingDataDay)";
            string deleteString = "delete NaverODsay_Dev_Sub.dbo.TBInterCity_Airplane_CrawlingData";
            //INSERT INTO[TBInterCity_Airplane_CrawlingData] VALUES('대한항공', 'KE1803', '서울/김포', '부산/김해', cast('07:00:00' as datetime), cast('08:05:00' as datetime), '매일', cast('2023-12-19' as datetime), cast('2024-03-30' as datetime));

            string strSql = string.Format("insert AID_TOOL.dbo.TBAirport_History ");
            strSql += string.Format("values('{0}','Air_DBupdate'',getdate()')", StaticMain.userName);
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlCommand deletecommand = new SqlCommand(deleteString, connection);
                SqlCommand cmd = new SqlCommand(strSql, connection);
                int rowCount = Air_DataGridViewData.RowCount;
                
                connection.Open();
                cmd.ExecuteNonQuery();
                deletecommand.ExecuteNonQuery();
                try
                {
                    for (int jk = 0; jk < rowCount; jk++)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@Company", DataList[jk][0].ToString());
                        command.Parameters.AddWithValue("@Flight", DataList[jk][1].ToString());
                        command.Parameters.AddWithValue("@Origin", DataList[jk][2].ToString());
                        command.Parameters.AddWithValue("@OriginAirport", DataList[jk][3].ToString());
                        command.Parameters.AddWithValue("@Destination", DataList[jk][4].ToString());
                        command.Parameters.AddWithValue("@DestinationAirport", DataList[jk][5].ToString());
                        command.Parameters.AddWithValue("@DepartureTime", DataList[jk][6].ToString());
                        command.Parameters.AddWithValue("@ArrivalTime", DataList[jk][7].ToString());
                        command.Parameters.AddWithValue("@Runday", DataList[jk][8].ToString());
                        command.Parameters.AddWithValue("@StartDate", DataList[jk][9].ToString());
                        command.Parameters.AddWithValue("@EndDate", DataList[jk][10].ToString());
                        command.Parameters.AddWithValue("@CrawlingDataDay", DateTime.Today.ToString("yyyy-MM-dd"));

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
    }
}
