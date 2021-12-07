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
namespace FinalSeminar
{
    public partial class Form1 : Form
    {
        private BindingList<string> lstTopic = new BindingList<string>();
        private Dictionary<string, BindingList<MulQuestion>> quesDb = new Dictionary<string, BindingList<MulQuestion>>();
        public Form1()
        {
            InitializeComponent();
            
        }
        void ImportAllTopicQuestion(string direct)
        {
            string[] files = Directory.GetFiles(direct, "*.xml");
        
            for (int i = 0; i < files.Length; ++i)
            {
                string topicName = "";
                BindingList<MulQuestion> tmpLstQues = new BindingList<MulQuestion>();

                using (XmlReader xml = XmlReader.Create(files[i]))
                {
                    //Read the topic and its name
                    xml.ReadToFollowing("Topic");
                    xml.MoveToAttribute("name");
                    topicName = xml.Value;

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
       
        private void Output(string direct)
        {
           for(int i=0;i<quesDb.Count();i++)
            {
                BindingList<MulQuestion> list = quesDb[lstTopic[i]];
                XmlWriter xml = XmlWriter.Create(direct+"\\"+lstTopic[i] + ".xml", new XmlWriterSettings() { Indent = true });
                {

                    xml.WriteStartElement("Topic");
                    xml.WriteAttributeString("name", lstTopic[i]);
                    foreach (var item in list)
                    {
                        xml.WriteStartElement("Question");
                        xml.WriteAttributeString("numAns", item.Ans.Count().ToString());
                        xml.WriteStartElement("Content");
                        xml.WriteValue(item.Ques) ;
                        xml.WriteEndElement();
                        for (int j = 0; j < item.Ans.Count(); j++)
                        {
                            xml.WriteStartElement("Answer");
                            xml.WriteValue(item.Ans[j]);
                            xml.WriteEndElement();
                        }
                        xml.WriteStartElement("Correct");
                        xml.WriteValue(item.CorrectAnswer);
                        xml.WriteEndElement();
                        xml.WriteEndElement();
                    }
                    xml.WriteEndElement();
                    xml.Close();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ImportAllTopicQuestion(@"Question Database");
            comboBox1.DataSource = lstTopic;
            questionCtrl1.Topic.DataSource = lstTopic;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index > -1)
            {
                string topic = (string)comboBox1.SelectedItem;
                comboBox1.Text = topic ;
                listBox1.DataSource = quesDb[topic];
            }
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index > -1)
            {
               MulQuestion temp = (MulQuestion)listBox1.SelectedItem;
                questionCtrl1.Content= temp ;
                questionCtrl1.lstTopic = lstTopic;
            }
            
        }
        void AddNew_topic(string Topic,MulQuestion Quest)
        {
           foreach(var tmp in lstTopic)
            {
                if (tmp == Topic)
                {
                    quesDb[Topic].Add(Quest); 
                    return;
                }
            }
            BindingList<MulQuestion> listQuest = new BindingList<MulQuestion>();
            listQuest.Add(Quest);
            quesDb.Add(Topic,listQuest);
            lstTopic.Add(Topic);
            comboBox1.Text = Topic;
            comboBox1.DataSource = null;
            comboBox1.DataSource = lstTopic;


        }
        private void btAdd_Click(object sender, EventArgs e)
        {           
            MulQuestion tmp = questionCtrl1.Content;
            if (questionCtrl1.Check_Empty()) return;
            string topicName = tmp.Topic;
            AddNew_topic(topicName, tmp);
            listBox1.DataSource = null;
            listBox1.DataSource = quesDb[topicName];
            listBox1.SelectedIndex = -1;
            questionCtrl1.clear();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string topicName = comboBox1.SelectedItem.ToString();
            if (index > -1)
           {

                quesDb[topicName].RemoveAt(index);
                listBox1.DataSource = null;
                listBox1.DataSource = quesDb[topicName];      
            }
            listBox1.SelectedIndex = -1;
            questionCtrl1.clear();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string topicName = comboBox1.SelectedItem.ToString();
            string tmpTopic = questionCtrl1.Content.Topic;
            if (topicName != tmpTopic)
            {
                //change questiondb when you change topic question 
                quesDb[topicName].RemoveAt(index);
                quesDb[tmpTopic].Add(questionCtrl1.Content);
                comboBox1.SelectedItem = tmpTopic ;
                //listBox1.DataSource = null;
                //listBox1.DataSource = quesDb[topicName];

            }
            else
            {
                quesDb[topicName][index] = questionCtrl1.Content;
            }
            listBox1.DataSource = null;
            listBox1.DataSource = quesDb[tmpTopic];
            //clear the listbox 
            listBox1.SelectedIndex = -1;
            questionCtrl1.clear();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Output(@"Question Database");
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            questionCtrl1.clear();
        }
    }


}
