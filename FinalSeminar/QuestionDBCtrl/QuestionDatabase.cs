using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace FinalSeminar
{
    public partial class QuestionDatabase : UserControl
    {
      
        private List<string> lstTopic = new List<string>();
        private Dictionary<string, List<MulQuestion>> quesDb = new Dictionary<string, List<MulQuestion>>();
        
        public QuestionDatabase()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string index = (string)comboBox1.SelectedItem;
            listBox1.DataSource = quesDb[index];
        }

        private void QuestionDatabase_Load(object sender, EventArgs e)
        {
            ImportAllTopicQuestion(@"Question Database");
            comboBox1.DataSource = lstTopic;
        }

        public void ImportAllTopicQuestion(string direct)
        {
            string[] files = Directory.GetFiles(direct, "*.xml");

            for (int i = 0; i < files.Length; ++i) 
            {
                string topicName = "";
                List<MulQuestion> tmpLstQues = new List<MulQuestion>();

                using (XmlReader xml = XmlReader.Create(files[i]))
                {
                    //Read the topic and its name
                    xml.ReadToFollowing("Topic");
                    xml.MoveToAttribute("name");
                    topicName = xml.Value;

                    while(xml.ReadToFollowing("Question"))
                    {
                        MulQuestion tmpQues = new MulQuestion();
                        tmpQues.Topic = topicName;

                        //Read the amount of answers
                        xml.MoveToAttribute("numAns");
                        int num = int.Parse(xml.Value);

                        //Read the question
                        xml.ReadToFollowing("Content");
                        tmpQues.Ques = xml.ReadElementContentAsString();

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

                        //Read the correct answer
                        xml.ReadToFollowing("Correct");
                        string correctAns = xml.ReadElementContentAsString();
                        tmpQues.CorrectAnswer = correctAns;

                        tmpLstQues.Add(tmpQues);
                    }

                    quesDb.Add(topicName, tmpLstQues);
                    lstTopic.Add(topicName);
                }
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
