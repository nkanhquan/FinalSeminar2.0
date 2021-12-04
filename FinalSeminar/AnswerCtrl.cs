using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSeminar
{
    public partial class AnswerCtrl : UserControl
    {
        public bool isClosed = false;

        public string Label 
        {
            get { return lbAns.Text; }
            set { lbAns.Text = value; }
        }

        public string Answer
        {
            get { return txtAns.Text; }
            set { txtAns.Text = value; }
        }
        public AnswerCtrl()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.isClosed = true;
            this.Parent.Controls.Remove(this);
        }
    }
}
