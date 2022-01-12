using System;
using System.Windows.Forms;

namespace VenomRAT_HVNC.Server.Forms
{
    // Token: 0x02000081 RID: 129
    public partial class FormFileSearcher : Form
    {
        // Token: 0x060004B8 RID: 1208 RVA: 0x00036E90 File Offset: 0x00036E90
        public FormFileSearcher()
        {
            this.InitializeComponent();
        }

        // Token: 0x060004B9 RID: 1209 RVA: 0x00036E9E File Offset: 0x00036E9E
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtExtnsions.Text) && this.numericUpDown1.Value > 0m)
            {
                base.DialogResult = DialogResult.OK;
            }
        }

        // Token: 0x060004BA RID: 1210 RVA: 0x000067A9 File Offset: 0x000067A9
        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}