using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace MultiColoredModernUI.Forms.InterCityBus
{
    public partial class InterCityBusRoute : Form
    {
        MssqlInterCityBus sql = new MssqlInterCityBus();

        List<string> buff = new List<string>();
        List<string> lstCell = new List<string>();
        List<List<string>> tlstCell = new List<List<string>>();

        public InterCityBusRoute()
        {
            InitializeComponent();
            sFileCheckBtn.Enabled =false;
        }

        private void sFileLoadBtn_Click(object sender, EventArgs e)
        {

            string path = @""; // OpenFileDialog에서 받은 경로를 담을 변수
            OpenFileDialog dialog = new OpenFileDialog(); // 생성자 생성
            dialog.InitialDirectory = @"D:\";

            if (dialog.ShowDialog() == DialogResult.OK) // ShowDialog()로 화면 띄우기
            {
                path = dialog.FileName; // 선택한 파일의 경로 받기
                                        // 그 외 필요한 내용 적기
                sFileLoadBtn.Enabled = false;


                guna2ProgressBar1.Text = path;

                Thread t = new Thread(() => sFileLoad(path));
                t.Start();
            }

        }

        public void sFileLoad(string path)
        {

            string query = "INSERT INTO NTOOL_DATA_NEW.dbo.[07_1_tb_route_stops_Aro_Ex_Add] values \n";

            sql.DeleteTable("NTOOL_DATA_NEW.dbo.[07_1_tb_route_stops_Aro_Ex_Add]");

            string fileName = path.Substring(path.LastIndexOf(@"\") + 1);

            ReadExcelData(path, query);

            List<List<string>> sch = new List<List<string>>();

            sch = sql.CheckBusRoute();

            if (guna2DataGridView1.InvokeRequired)
            {
                guna2DataGridView1.BeginInvoke(new MethodInvoker(delegate ()
                {
                    if (sch.Count == 0)
                    {
                        sch = sql.SelectBusRoute();
                        sql.InsertBusRouteAll();
                        MessageBox.Show("노선 변경 리스트 업데이트 완료");
                    }
                    else
                    {
                        sFileCheckBtn.Enabled = true;
                        MessageBox.Show("Excel 파일 확인 필요");
                    }

                    guna2DataGridView1.Rows.Clear();

                    for (int i = 0; i < sch.Count; i++)
                    {
                        guna2DataGridView1.Rows.Add(sch[i].ToArray());
                    }

                    sFileLoadBtn.Enabled = true;

                }));
            }

        }

        void ReadExcelData(string fileExcel, string query)
        {

            string qSchedule = query;

            if (File.Exists(fileExcel) == false)
            {
                return;
            }

            Microsoft.Office.Interop.Excel.Application excelApp = null;
            Excel.Workbook workBook = null;
            buff.Clear();

            try
            {
                excelApp = new Excel.Application();                             // 엑셀 어플리케이션 생성
                workBook = excelApp.Workbooks.Open(fileExcel,
                    0,
                    true,
                    5,
                    "",
                    "",
                    true,
                    Excel.XlPlatform.xlWindows,
                    "\t",
                    false,
                    false,
                    0,
                    true,
                    1,
                    0);

                int index = 0;


                // Sheet항목들을 돌아가면서 내용을 확인
                foreach (Excel.Worksheet workSheet in workBook.Worksheets)
                {


                    Excel.Range range = workSheet.UsedRange;    // 사용중인 셀 범위를 가져오기

                    guna2ProgressBar1.Maximum = range.Rows.Count;

                    // 가져온 행(row) 만큼 반복
                    for (int row = 2; row <= range.Rows.Count; row++)
                    {
                        guna2ProgressBar1.Value = row;

                        index++;
                        // 가져온 열(row) 만큼 반복
                        for (int column = 1; column <= range.Columns.Count; column++)
                        {
                            object obj = (range.Cells[row, column] as Excel.Range).Value2;

                            if (column == 1 && obj == null)
                            {
                                index--;
                                break;
                            }

                            if (obj == null)
                                obj = "0";

                            string str = obj.ToString();  // 셀 데이터 가져옴

                            if (str == "0")
                                lstCell.Add("NULL"); // 리스트에 할당
                            else if (column == 2 || column == 4 || column == 6)
                                lstCell.Add("'" + str + "'"); // 리스트에 할당
                            else
                                lstCell.Add(str); // 리스트에 할당
                        }

                        if(lstCell.Count > 0)
                            qSchedule += "(" + string.Join(",", lstCell.ToArray()) + ")"; // 표시용 데이터 추가

                        if (index == 999)
                        {
                            index = 0;

                            qSchedule = qSchedule.TrimEnd(',', '\n');

                            sql.InsertNInterCityBus(qSchedule);

                            qSchedule = query;
                        }
                        else if (lstCell.Count > 0)
                        {
                            if (row >= 2 && row < range.Rows.Count)
                                qSchedule += ",\n";
                        }

                        lstCell.Clear();
                    }
                }


                qSchedule = qSchedule.TrimEnd(',', '\n');

                sql.InsertNInterCityBus(qSchedule);

                object missing = Type.Missing;
                object noSave = false;
                workBook.Close(noSave, missing, missing); // 엑셀 웨크북 종료
                excelApp.Quit();        // 엑셀 어플리케이션 종료
            }
            finally
            {
                ReleaseObject(workBook);
                ReleaseObject(excelApp);

            }

        }

        void ReleaseObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    // 객체 메모리 해제
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();   // 가비지 수집
            }
        }

        

        private void guna2DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            sFileCheckBtn.Enabled = true;
        }

        private void sFileCheckBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = -1;

            rowIndex = guna2DataGridView1.Rows.Count - 1;

            if (rowIndex > -1)
            {
                for (int i = 0; i <= rowIndex; i++)
                {
                    string query = "";

                    var Laneid = guna2DataGridView1.Rows[rowIndex].Cells[0].Value;
                    var LaneNo = guna2DataGridView1.Rows[rowIndex].Cells[1].Value;
                    var StationSequence = guna2DataGridView1.Rows[rowIndex].Cells[2].Value;
                    var Direction = guna2DataGridView1.Rows[rowIndex].Cells[3].Value;
                    var Stationid = guna2DataGridView1.Rows[rowIndex].Cells[4].Value;
                    var Namekor = guna2DataGridView1.Rows[rowIndex].Cells[5].Value;
                    
                    query = string.Format("update NTOOL_DATA_NEW.dbo.[07_1_tb_route_stops_Aro_Ex_Add] set stop_sequence={0}, up_down = '{1}',stop_id = {2}, stop_name = '{3}' " +
                    "where stop_sequence={0} and stop_id = {2} and route_id = {4} ", StationSequence, Direction,Stationid, Namekor, Laneid);

                    sql.UpdateNInterCityBus(query);
                }
            }

            List<List<string>> sch = new List<List<string>>();

            sch = sql.CheckBusRoute();

            sFileCheckBtn.Enabled = false;

            if (sch.Count == 0)
            {
                sch = sql.SelectBusSchedule();
                sql.InsertBusRouteAll();
                sFileCheckBtn.Enabled = false;
                MessageBox.Show("노선 변경 리스트 업데이트 완료");
            }
            else
            {
                MessageBox.Show("Excel 파일 확인 필요");
            }

            guna2DataGridView1.Rows.Clear();

            for (int i = 0; i < sch.Count; i++)
            {
                guna2DataGridView1.Rows.Add(sch[i].ToArray());
            }
        }
    }
}
