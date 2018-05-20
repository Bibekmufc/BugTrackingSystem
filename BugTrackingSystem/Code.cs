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
    public partial class Code : Form
    {
        public Code()
        {
            InitializeComponent();
        }


        //loading the submitted code into the textbox when "View Code" is clicked
        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {
            if (View_Bugs.Language == "C#")
            {
                fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp;
                fastColoredTextBox1.Text = View_Bugs.code;
            }
            else if (View_Bugs.Language == "HTML")
            {
                fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML;
                fastColoredTextBox1.Text = View_Bugs.code;
            }
             else if (View_Bugs.Language == "PHP")
            {
                fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.PHP;
                fastColoredTextBox1.Text = View_Bugs.code;
            }
             else if (View_Bugs.Language == "JS")
            {
                fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS;
                fastColoredTextBox1.Text = View_Bugs.code;
            }
        }
    }
}
