using System;
using System.Windows.Forms;

namespace AppPME
{
    public partial class FrmPME : Form
    {
        public FrmPME()
        {
            InitializeComponent();
        }
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void evaluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int aciertos = 0;
            if (RbR3H.Checked == true)
            {
                aciertos++;
            }
            if (RbR2G.Checked == true)
            {
                aciertos++;
            }
            MessageBox.Show("Obtuviste  " + aciertos + "  aciertos");
            if (DialogResult != DialogResult.OK)
            {
                RbR2G.Checked = false;
                RbR1G.Checked = false;
                RbR3G.Checked = false;
                RbR1H.Checked = false;
                RbR2H.Checked = false;
                RbR3H.Checked = false;
            }
        }
    }
}
