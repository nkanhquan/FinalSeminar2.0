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
    public partial class ExamEditorOption : Form
    {
        public int Scene = 1;
        public string path = "";
        public ExamEditorOption()
        {
            InitializeComponent();
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            Scene = 1;
            this.Hide();
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            Scene = 2;
            this.Hide();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            Scene = 3;

            openFileDialog1.Filter = "|*.xml";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
            }
            this.Hide();
        }
    }
}
