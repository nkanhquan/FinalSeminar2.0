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
    public partial class Form2 : Form
    {
        Testingform f2 = new Testingform();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2.ShowDialog();
            this.Close();
            //get info student to form 1 
            f2.stuInfo.Name = textBox1.Text;
            f2.stuInfo.ID = textBox2.Text;

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            // tạo hộp thoại mở tập tin
            OpenFileDialog dlg = new OpenFileDialog();
            // chỉ mở các tập tin .txt
            dlg.Filter = "Chon tap tin .xml|*.xml";
            // hiển thị hộp thoại
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filePath = dlg.FileName;
                string topicName = "";
                BindingList<MulQuestion> tmpLstQues = new BindingList<MulQuestion>();
                using (XmlReader xml = XmlReader.Create(filePath))
                {
                    //Read the topic and its name
                    xml.ReadToFollowing("Test");
                    while (xml.ReadToFollowing("Question"))
                    {
                        MulQuestion tmpQues = new MulQuestion();
                        tmpQues.Topic = topicName;

                        //Read the amount of answers
                        xml.MoveToAttribute("numAns");
                        int num = int.Parse(xml.Value);

                        //Read the question
                        xml.ReadToFollowing("Content");
                        tmpQues.Ques = xml.ReadElementContentAsString();
                        //Read topic 
                        xml.ReadToFollowing("Topic");
                        tmpQues.Topic = xml.ReadElementContentAsString();

                        //Read the answers
                        List<string> tmpLstAns = new List<string>();
                        for (int j = 0; j < num; ++j)
                        {
                            xml.ReadToFollowing("Answer");
                            string buffer = "";
                            buffer = xml.ReadElementContentAsString();
                            tmpLstAns.Add(buffer);
                        }
                        tmpQues.Ans = tmpLstAns;

                        ////Read the correct answer
                        //xml.ReadToFollowing("Correct");
                        //string correctAns = xml.ReadElementContentAsString();
                        //tmpQues.CorrectAnswer = correctAns;

                        f2.quesDb.Add(tmpQues);
                        // add status 
                        Status tmpStatus = new Status();
                        f2.unCheck.Add(tmpStatus);
                    }
       
                }
            }
           
        }


    }
    
}
