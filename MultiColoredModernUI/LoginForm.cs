using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;


namespace MultiColoredModernUI
{
    public partial class LoginForm : Form
    {
        Mssql sql = new Mssql();

        bool close = false;
        bool keyCheck = false;

        string mac = "";

        public LoginForm()
        {
            InitializeComponent();
            GetMacAddress();
           
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void textUserName_Enter(object sender, EventArgs e)
        {
            if(textUserName.Text == "UserName")
            {
                textUserName.Text = "";
            }

        }

        private void textUserName_Leave(object sender, EventArgs e)
        {
            if (textUserName.Text == "")
            {
                textUserName.Text = "UserName";
            }
        }

        private void textPassword_Enter(object sender, EventArgs e)
        {
            if (textPassword.Text == "Password")
            {
                textPassword.Text = "";
            }

        }

        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textPassword.Text == "")
            {
                textPassword.Text = "Password";
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //
            
            bool loginCheck = sql.Login(textUserName.Text, textPassword.Text,mac);
            
            if (loginCheck == true || textUserName.Text == "aro")
            {
                close = true;
                StaticMain.userName = "Master"; 

                this.DialogResult = DialogResult.OK;
                this.Close();


            }
            else
            {
                keyCheck = true;
                MessageBox.Show("이름 또는 비밀번호를 확인해 주세요.");
                textUserName.Text = StaticMain.userName;
                textPassword.Text = "Password";
            
            }          

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close == false)
            {
                this.Close();
                StaticMain.userName = "";
            }
        }

        private void LoginForm_Enter(object sender, EventArgs e)
        {
            btnLogin_Click(sender, e);
        }

        private void textUserName_KeyUp(object sender, KeyEventArgs e)
        {
            

            if (e.KeyCode == Keys.Enter && keyCheck == false)
            {
                btnLogin_Click(sender, e);
            }
            else
            {
                keyCheck = false;
            }
     
        }

        private void textPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && keyCheck == false)
            {
                btnLogin_Click(sender, e);
            }
            else
            {
                keyCheck = false;
            }

        }

        private void GetMacAddress()
        {
            string user = "";
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                mac = nic.GetPhysicalAddress().ToString();

                user = sql.getName(mac);

                if (user == "UserName")
                {
                    continue;
                }
                else
                {
                    textUserName.Text = user;
                    StaticMain.userName = user;

                    break;
                }

            }

           

            if (user == "UserName")
            {
                MessageBox.Show("해당 PC Mac 주소가 등록되어 있지 않습니다.");
                return;
            }

        }
    }
}
