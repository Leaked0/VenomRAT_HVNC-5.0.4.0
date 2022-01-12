using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Server;
using VenomRAT_HVNC.HVNC.WebBuilder;
using KeyAuth;

namespace VenomRAT_HVNC.Server.Forms
{
    // Token: 0x02000091 RID: 145
    public partial class FormLogin : Form
    {
        // Token: 0x06000579 RID: 1401 RVA: 0x00041701 File Offset: 0x00041701
        public FormLogin()
        {
            InitializeComponent();
        }

        // Token: 0x0600057A RID: 1402 RVA: 0x00041710 File Offset: 0x00041710
        private void loginBtn_Click(object sender, EventArgs e)
        {
            //if (KeyAuthApp.license(key.Text))
            bool penis = true;
            if (penis)
            {
                if (!File.Exists("License.Venom"))
                {
                    File.WriteAllText("License.Venom", key.Text.Replace(" ", "").Replace("\t", ""));
                }
                Form1.islogin = true;
                WebBuilder.Username = key.Text.Replace(" ", "").Replace("\t", "");
                Close();
                MessageBox.Show("Login Success!", "Venom RAT", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            MessageBox.Show("Error Login, Please Contact Support!", "Venom RAT", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        // Token: 0x0600057B RID: 1403 RVA: 0x000417D7 File Offset: 0x000417D7
        private void Login_Load(object sender, EventArgs e)
        {
            //KeyAuthApp.init();
        }

        // Token: 0x0600057C RID: 1404 RVA: 0x000417E3 File Offset: 0x000417E3
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Form1.islogin)
            {
                Environment.Exit(0);
            }
        }

        // Token: 0x0600057D RID: 1405 RVA: 0x000417F2 File Offset: 0x000417F2
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://venomcontrol.com/");
        }

        // Token: 0x0600057E RID: 1406 RVA: 0x000417FF File Offset: 0x000417FF
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/venomrat");
        }

        // Token: 0x0600057F RID: 1407 RVA: 0x0004180C File Offset: 0x0004180C
        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (File.Exists("License.Venom"))
            {
                string text = File.ReadAllText("License.Venom").Replace(" ", "").Replace("\t", "");
                key.Text = text;
            }
        }

        // Token: 0x04000519 RID: 1305
        private static string name = "Venom5";

        // Token: 0x0400051A RID: 1306
        private static string ownerid = "TwksumQEaF";

        // Token: 0x0400051B RID: 1307
        private static string secret = "13b51211ec32a97e76356a6c65857de208506c2ac8d1beabfd22534f4fee9d6c";

        // Token: 0x0400051C RID: 1308
        private static string version = "1.0";

        // Token: 0x0400051D RID: 1309
        public static api KeyAuthApp = new api(name, ownerid, secret, version);
    }
}