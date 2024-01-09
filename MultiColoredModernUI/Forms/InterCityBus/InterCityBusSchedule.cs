using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace MultiColoredModernUI.Forms.InterCityBus
{
    public partial class InterCityBusSchedule : Form
    {
        MssqlInterCityBus sql = new MssqlInterCityBus();

        List<string> buff = new List<string>();
        List<string> lstCell = new List<string>();
        List<List<string>> tlstCell = new List<List<string>>();

        int iBtnCheck = 0;

        public InterCityBusSchedule()
        {
            InitializeComponent();
        }

        private void sFileLoadBtn_Click(object sender, EventArgs e)
        {
            string query = "insert into NTBBus values\n";

            sql.DeleteBusSchedule();

            string path = @""; // OpenFileDialog에서 받은 경로를 담을 변수
            OpenFileDialog dialog = new OpenFileDialog(); // 생성자 생성
            dialog.InitialDirectory = @"D:\";

            if (dialog.ShowDialog() == DialogResult.OK) // ShowDialog()로 화면 띄우기
            {
                path = dialog.FileName; // 선택한 파일의 경로 받기
                                        // 그 외 필요한 내용 적기
            }

            guna2TextBox1.Text = path;
            string fileName = path.Substring(path.LastIndexOf(@"\") + 1);
            ReadExcelData(path, query); // 엑셀파일 읽기

            List<List<string>> sch = new List<List<string>>();

            sch = sql.SelectBusSchedule();

            for (int i = 0; i < sch.Count; i++)
            {
                guna2DataGridView1.Rows.Add(sch[i].ToArray());
            }

     
        }

        void ReadExcelData(string fileExcel, string query)
        {

            string qSchedule = query;

            if (File.Exists(fileExcel) == false)
            {
                return;
            }

            Excel.Application excelApp = null;
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

                    // 가져온 행(row) 만큼 반복
                    for (int row = 2; row <= range.Rows.Count; row++)
                    {

                        // 가져온 열(row) 만큼 반복
                        for (int column = 1; column <= range.Columns.Count; column++)
                        {
                            object obj = (range.Cells[row, column] as Excel.Range).Value2;

                            index++;

                            if (obj == null)
                                obj = "0";

                            string str = obj.ToString();  // 셀 데이터 가져옴

                            if (str == "0")
                                lstCell.Add("NULL"); // 리스트에 할당
                            else if (column == 2 || column == 7 || column == 8)
                                lstCell.Add("'" + str + "'"); // 리스트에 할당
                            else
                                lstCell.Add("" + str + ""); // 리스트에 할당
                        }



                        qSchedule += "(" + string.Join(",", lstCell.ToArray()) + ")"; // 표시용 데이터 추가


                        if (index == 999)
                        {
                            index = 0;

                            sql.InsertBusSchedule(qSchedule);

                            qSchedule = query;
                        }
                        else
                        {
                            if (row >= 2 && row < range.Rows.Count)
                                qSchedule += ",\n";
                        }
                    }
                }

                sql.InsertBusSchedule(qSchedule);

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

        private void sFileUpdateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
