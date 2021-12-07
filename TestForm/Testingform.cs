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
        public string testCode="";
        private string Timebegin="" ;
        private int tmpIndex =0;
        private int tmpIndex1 = 0;
        private int flag = 0;
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
            //get time
            Timebegin = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
            //enable button start 
            btStart.Enabled = false;
            Testcodelb.Text = testCode;
            //
            testCtrl1.GetIndex(0);
            testCtrl1.CreateList(quesDb.Count);
            listBox1.DataSource = quesDb;
            listBox2.DataSource = unCheck;
            testCtrl1.Enabled = true; 
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check listbox before change
            if (flag == 1)
            {
                quesDb[tmpIndex].CorrectAnswer = testCtrl1.Check();
                testCtrl1.Changed(tmpIndex);
                int index = listBox1.SelectedIndex;
                if (index > -1)
                {
                    listBox2.SelectedIndex = index;
                    testCtrl1.Content = quesDb[index];
                    testCtrl1.GetIndex(index);
                    //Check if index may identical 
                    if (tmpIndex != index)
                    {
                        flag = 0;
                        tmpIndex = index;
                    }
                }
            }
            else if (flag == 0)
            {
                quesDb[tmpIndex].CorrectAnswer = testCtrl1.Check();
                testCtrl1.Changed(tmpIndex);
                int index = listBox1.SelectedIndex;
                UpdateStatus(tmpIndex);
                if (index > -1)
                {
                    listBox2.SelectedIndex = index;
                    testCtrl1.Content = quesDb[index];
                    testCtrl1.GetIndex(index);
                    tmpIndex = index;    
                }
            }
           

        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            testCtrl1.Enabled = false;
            label2.Text = stuInfo.Name;
            label3.Text = stuInfo.ID;
           
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (listBox1.SelectedIndex > -1)
            {
                if (listBox1.SelectedIndex == listBox1.Items.Count - 1)
                {                   
                    MessageBox.Show("Out of question ");
                    return;
                }
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;       
            }
        }
        private void btBack_Click(object sender, EventArgs e)
        {
          
            int index = listBox1.SelectedIndex;
            if (listBox1.SelectedIndex > -1)
            {
                if (listBox1.SelectedIndex == 0)
                {
                    MessageBox.Show("Out of question ");
                    return;
                }
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
            }
        }
        private void Output()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            // chỉ lưu tập tin dạng .txt
            dlg.Filter = "Luu tap tin bai thi|*.xml";
            // hiển thị hộp thoại
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < quesDb.Count(); i++)
                {
                    string filePath = dlg.FileName;
                    BindingList<MulQuestion> list = quesDb;
                    XmlWriter xml = XmlWriter.Create(filePath, new XmlWriterSettings() { Indent = true });
                    {
                        xml.WriteStartElement("StudentAnswer");
                        //write sutdent info
                        xml.WriteStartElement("Student");
                        xml.WriteStartElement("StudentName");
                        xml.WriteValue(stuInfo.Name);
                        xml.WriteEndElement();
                        xml.WriteStartElement("StudentID");
                        xml.WriteValue(stuInfo.ID);
                        xml.WriteEndElement();
                        xml.WriteEndElement();
                        //write time start 
                        xml.WriteStartElement("Time");
                        xml.WriteValue(Timebegin);
                        xml.WriteEndElement();
                        //write test info
                        xml.WriteStartElement("Test");
                        //write test code
                        xml.WriteStartElement("TestCode");
                        xml.WriteValue(testCode);
                        xml.WriteEndElement();
                        //write student answer 
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
        }
        void UpdateStatus(int index )
        {
            if (tmpIndex1 == 1)
            {
                tmpIndex1 = 0;
                return;
            }
            else
            {
                if (testCtrl1.Check() == "")
                    unCheck[index].st = "Unchecked ";
                else unCheck[index].st = "Checked";
                listBox2.DataSource = null;
                listBox2.DataSource = unCheck;
            }
        }
        private void btSubmit_Click(object sender, EventArgs e)
        {
           
            int index = listBox1.SelectedIndex;
            if(index > -1)  quesDb[index].CorrectAnswer = testCtrl1.Check();
            DialogResult dialogResult = MessageBox.Show("Do you want to submit","Submit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Output();
                MessageBox.Show("Submit Success");
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        private void btHighlight_Click(object sender, EventArgs e)
        {
            flag = 1;
            tmpIndex1 = 1;
            int index = listBox1.SelectedIndex;
            unCheck[index].st = "SPECIAL";
            listBox2.SelectedItem = "SPECTIAL";
            listBox2.DataSource = null;
            listBox2.DataSource = unCheck;
        }
        private void listBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Up)
            {
                int index = listBox1.SelectedIndex;
                if (listBox1.SelectedIndex > -1)
                {
                    if (listBox1.SelectedIndex == 0)
                    {
                        MessageBox.Show("Out of question ");
                        return;
                    }
                    listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
                }
            }
            else if(e.KeyCode==Keys.Down)
            {
                int index = listBox1.SelectedIndex;
                if (listBox1.SelectedIndex > -1)
                {
                    if (listBox1.SelectedIndex > -1)
                    {
                        if (listBox1.SelectedIndex == listBox1.Items.Count - 1)
                        {
                            MessageBox.Show("Out of question ");
                            return;
                        }
                        listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                    }
                }
            }
        }

        private void Testingform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Output();
            MessageBox.Show("Submit Success");
        }
    }
}
