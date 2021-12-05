using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Answerctrl : UserControl
    {
       
        //get the radio button change
        
        public string Label
        {
            get { return lbAns.Text; }
            set { lbAns.Text = value; }
        }

        public RadioButton Answer
        {
            get { return radioAns ; }
            set { radioAns = value; }
        }
       
        public Answerctrl()
        {
            InitializeComponent();
        }

        private void Answerctrl_Load(object sender, EventArgs e)
        {

        }

        private void radioAns_CheckedChanged(object sender, EventArgs e)
        {
          
        }
    }
}
