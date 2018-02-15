using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMascotMaciekP
{
    public partial class frmMathFormulae : Form
    {
        public frmMathFormulae()
        {
            InitializeComponent();
        }

        private void quadraticFormulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblFormula.Text = "(-b+-sqrt(b^2-4ac))/2a";
        }

        private void pythagoreanTheoremToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblFormula.Text = "a^2 + b^2 = c^2";
        }

        private void cosineLawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblFormula.Text = "c^2 = a^2 + b^2 -2abcosC";
        }

        private void uniformMotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblFormula.Text = "v = d/t";
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
