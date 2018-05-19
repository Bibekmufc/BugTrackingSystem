using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem
{
    public partial class SubmitReport : Form
    {
        public SubmitReport()
        {
            InitializeComponent();
        }

        private void SubmitReport_Load(object sender, EventArgs e)
        {
            txteditor.Language = FastColoredTextBoxNS.Language.CSharp;
        }

        private void Language_Click(object sender, EventArgs e)
        {

        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txteditor.Language = FastColoredTextBoxNS.Language.HTML;
        }

        private void jSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txteditor.Language = FastColoredTextBoxNS.Language.JS;
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txteditor.Language = FastColoredTextBoxNS.Language.CSharp;
        }

        private void pHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txteditor.Language = FastColoredTextBoxNS.Language.PHP;
        }
    }
}
