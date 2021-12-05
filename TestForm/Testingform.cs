using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
namespace TestForm
{
    public partial class Testingform : Form
    {
        public Info stuInfo = new Info() ;
        public BindingList<MulQuestion> quesDb = new BindingList<MulQuestion>() ;
        public BindingList<Status> unCheck = new BindingList<Status>();
        private int tmpIndex = 0;
       
        public Testingform()
        {
            InitializeComponent();
            clockuserCtrl.uscEClock_Exit += new UserControl2.uscEClock_ExitHandle(Clock_uscEClock_Exit);
        }

        void Clock_uscEClock_Exit()
        {
            testCtrl1.Enabled = false;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            //set Time for clock 
            clockuserCtrl._ss = 15*quesDb.Count;
            clockuserCtrl.Start();
            btStart.Enabled = false;
            testCtrl1.GetIndex(0);
            testCtrl1.CreateList(quesDb.Count);  
            listBox1.DataSource = quesDb;
            listBox2.DataSource = unCheck;
            testCtrl1.Enabled = true;
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check listbox before change 
            testCtrl1.Changed(tmpIndex);
            UpdateStatus(tmpIndex);
            int index = listBox1.SelectedIndex;
            if (index > -1)
            {
               
                listBox2.SelectedIndex = index;
                listBox2.DataSource = null;
                listBox2.DataSource = unCheck;
                testCtrl1.Content = quesDb[index];
                testCtrl1.GetIndex(index);
                tmpIndex = index;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            testCtrl1.Enabled = false;
            pictureBox1.Image = imageList1.Images[0];
           
           
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (listBox1.SelectedIndex > -1)
            {

                quesDb[index].CorrectAnswer=testCtrl1.Check();
                testCtrl1.Changed(index);
                UpdateStatus(index);
                listBox2.DataSource = null;
                listBox2.DataSource = unCheck;
                if (listBox1.SelectedIndex == listBox1.Items.Count - 1)
                {                   
                    MessageBox.Show("Out of question ");
                    return;
                }
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                testCtrl1.GetIndex(listBox1.SelectedIndex);
                testCtrl1.Content = quesDb[listBox1.SelectedIndex];
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
          
            int index = listBox1.SelectedIndex;
            if (listBox1.SelectedIndex > -1)
            {

                quesDb[index].CorrectAnswer = testCtrl1.Check();
                testCtrl1.Changed(index);
                UpdateStatus(index);
                listBox2.DataSource = null;
                listBox2.DataSource = unCheck;
                if (listBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Out of question ");
                    return;
                }
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
                testCtrl1.GetIndex(listBox1.SelectedIndex);
                testCtrl1.Content = quesDb[listBox1.SelectedIndex];
            }

        }
        private void Output()
        {
            for (int i = 0; i < quesDb.Count(); i++)
            {
                BindingList<MulQuestion> list = quesDb;
                XmlWriter xml = XmlWriter.Create("TestResult" + ".xml", new XmlWriterSettings() { Indent = true });
                {
                    xml.WriteStartElement("StudentAnswer");
                        xml.WriteStartElement("Student");
                        xml.WriteStartElement("StudentName");
                        xml.WriteValue(stuInfo.Name);
                        xml.WriteEndElement();
                        xml.WriteStartElement("StudentID");
                        xml.WriteValue(stuInfo.ID);
                        xml.WriteEndElement();
                        xml.WriteEndElement();
                        xml.WriteStartElement("Test");
                        foreach (var item in list)
                        {
                            xml.WriteStartElement("Question");
                            xml.WriteStartElement("Topic");
                            xml.WriteValue(item.Topic);
                            xml.WriteEndElement();
                            xml.WriteStartElement("Content");
                            xml.WriteValue(item.Ques);
                            xml.WriteEndElement();
                            xml.WriteStartElement("Answer");
                            xml.WriteValue(item.CorrectAnswer);
                            xml.WriteEndElement();
                            xml.WriteEndElement();
                        }
                        xml.WriteEndElement();
                    xml.WriteEndElement();
                    xml.Close();
                }
            }
        }
        void UpdateStatus(int index )
        {       
            if (testCtrl1.Check() == "")
                unCheck[index].st = "chua lam ";
            else unCheck[index].st = "da lam";

        }
        private void btSubmit_Click(object sender, EventArgs e)
        {
            Output();
            MessageBox.Show("Submit Success");
            this.Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int index = listBox2.SelectedIndex;
            if(index >-1)
            {
               
            }
        }
    }
}
