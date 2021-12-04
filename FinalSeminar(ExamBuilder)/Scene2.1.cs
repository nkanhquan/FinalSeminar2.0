using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSeminar_ExamBuilder_
{
    public partial class Scene2_1 : Form
    {
        public int numQues = 0;
        public Scene2_1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumOfQues.Text, out int tmp) && tmp > 0)
            {
                numQues = tmp;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter a number higher than 0", "Wrong format", MessageBoxButtons.OK);
                txtNumOfQues.Text = string.Empty;
            }

        }
    }
}
