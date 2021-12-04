using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FinalSeminar_ExamBuilder_
{
    public partial class mainForm : Form
    {
        private BindingList<MulQuestion> lstQues;
        private Dictionary<string, List<MulQuestion>> quesDb = new Dictionary<string, List<MulQuestion>>();
        private List<string> lstTopic = new List<string>();

        public mainForm()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDatabase(@"Question Database");
            StartupProtocol();
            lbQuestion.DataSource = lstQues;
        }

        private void StartupProtocol()
        {
            lstQues = new BindingList<MulQuestion>();

            this.Hide();
            this.Enabled = false;
            this.Show();

            ExamEditorOption f2 = new ExamEditorOption();
            f2.ShowDialog();

            if (f2.Scene == 2) //Scene 2: Randomize number of question
            {
                //Ask for the amount of question
                Scene2_1 sc2 = new Scene2_1();
                sc2.ShowDialog();
                int numQues = sc2.numQues;
                sc2.Close();

                //Randomize selected number of question
                for(int i = 0; i < numQues; ++i)
                {
                    MulQuestion tmp = RandomizeQuestion();
                    if (!CheckExistedQuestion(tmp))
                        lstQues.Add(tmp);
                    else
                        --i;
                }
            }
            else if (f2.Scene == 3) //Scene 3: Open an existed exam
            {
                string filePath = f2.path;

                ImportExam(filePath);
            }
            else //Scene 1: Customize new exam
            {
                
            }

            f2.Close();
            this.Enabled = true;
        }

        private void LoadDatabase(string direct)
        {
            //Get every .xml file in the folder
            string[] files = Directory.GetFiles(direct, "*.xml");

            //Go through every xml it got
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
            cbxTopic.DataSource = lstTopic;
        }

        private void lbQuesDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbQuesDB.SelectedIndex != -1)
            {
                MulQuestion pickedQues = (MulQuestion)lbQuesDB.SelectedItem;
                questionCtrl.UpdateQuestion(pickedQues);
            }
        }

        private void cbxTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTopic.SelectedIndex != -1) 
            {
                string index = (string)cbxTopic.SelectedItem;
                lbQuesDB.DataSource = quesDb[index];
                lbQuesDB.SelectedIndex = -1;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (questionCtrl.Content != null)
            {
                MulQuestion tmp = new MulQuestion(questionCtrl.Content);
                lstQues.Add(tmp);
                lbQuestion.SelectedIndex = -1;

                //lbQuestion.DataSource = null;
                //lbQuestion.DataSource = lstQues;
            }
        }

        private void lbQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbQuestion.SelectedIndex != -1)
            {
                questionCtrl.UpdateQuestion((MulQuestion)lbQuestion.SelectedItem);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lbQuestion.SelectedIndex;
            if (index != -1)
                lstQues.RemoveAt(index);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = lbQuestion.SelectedIndex;

            if (index != -1)
                lstQues[index] = new MulQuestion(questionCtrl.Content);
        }

        public MulQuestion RandomizeQuestion()
        {
            MulQuestion tmpQues = new MulQuestion();
            Random rd = new Random();

            //Select a random topic
            int rdIndex = rd.Next(lstTopic.Count);
            string rdTopic = lstTopic[rdIndex];

            //Select a random question in the randomized topic
            rdIndex = rd.Next(quesDb[rdTopic].Count);
            if(quesDb[rdTopic].Count > 0)
                tmpQues = new MulQuestion(quesDb[rdTopic][rdIndex]);

            return tmpQues;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            MulQuestion rdQues = RandomizeQuestion();
            questionCtrl.UpdateQuestion(rdQues);
            //lbQuesDB.SelectedIndex = -1;
        }

        private void btnUpArrow_Click(object sender, EventArgs e)
        {
            int index = lbQuestion.SelectedIndex;

            if (index > 0)
            {
                //Swap position
                MulQuestion tmp = lstQues[index];
                lstQues[index] = lstQues[index - 1];
                lstQues[index - 1] = tmp;

                //Keep the index on the current item
                lbQuestion.SelectedIndex = index - 1;
            }
        }

        private void btnDownArrow_Click(object sender, EventArgs e)
        {
            int index = lbQuestion.SelectedIndex;

            if (index < lstQues.Count - 1)
            {
                //Swap position
                MulQuestion tmp = lstQues[index];
                lstQues[index] = lstQues[index + 1];
                lstQues[index + 1] = tmp;

                //Keep the index on the current item
                lbQuestion.SelectedIndex = index + 1;
            }
        }

        public bool CheckExistedQuestion(MulQuestion ques)
        {
            for (int i = 0; i < lstQues.Count; ++i)
                if (ques.Ques == lstQues[i].Ques)
                    return true;
            return false;
        }

        private void ExportExam(string path)
        {
            using (XmlWriter xml = XmlWriter.Create(path, new XmlWriterSettings() { Indent = true }))
            {
                //Test
                xml.WriteStartElement("Test");

                foreach(var i in lstQues)
                {
                    //Start of Question
                    string numAns = i.Ans.Count.ToString();
                    xml.WriteStartElement("Question");
                    xml.WriteAttributeString("numAns", numAns);

                    //Content
                    xml.WriteStartElement("Content");
                    xml.WriteValue(i.Ques);
                    xml.WriteEndElement();

                    //Topic
                    xml.WriteStartElement("Topic");
                    xml.WriteValue(i.Topic);
                    xml.WriteEndElement();

                    //Answer
                    foreach(var ans in i.Ans)
                    {
                        xml.WriteStartElement("Answer");
                        xml.WriteValue(ans);
                        xml.WriteEndElement();
                    }

                    //End of Question
                    xml.WriteEndElement();
                }

                xml.WriteEndElement();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDlg.Filter = "|*.xml";

            if(saveFileDlg.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDlg.FileName;

                ExportExam(filePath);
                //FileInfo file = new FileInfo(filePath);
                //string tmp = file.DirectoryName + '\n' + file.Name + '\n' + file.Extension + '\n' + file.FullName;
                //MessageBox.Show(tmp);
            }
        }

        private void ImportExam(string path)
        {
            using(XmlReader xml = XmlReader.Create(path))
            {
                //Read the test
                xml.ReadToFollowing("Test");

                while(xml.ReadToFollowing("Question"))
                {
                    int numAns;
                    string buffer = "";
                    MulQuestion tmpQues = new MulQuestion();

                    //Read the question and number of answer
                    xml.MoveToAttribute("numAns");
                    numAns = int.Parse(xml.Value);

                    //Read the content of the question
                    xml.ReadToFollowing("Content");
                    buffer = xml.ReadElementContentAsString();
                    tmpQues.Ques = buffer;

                    //Read the topic
                    xml.ReadToFollowing("Topic");
                    buffer = xml.ReadElementContentAsString();
                    tmpQues.Topic = buffer;

                    //Read the answers
                    for (int i = 0; i < numAns; ++i)
                    {
                        string tmpAns;

                        xml.ReadToFollowing("Answer");
                        buffer = xml.ReadElementContentAsString();
                        tmpAns = buffer;
                        tmpQues.Ans.Add(tmpAns);
                    }

                    //Input the question into the list
                    lstQues.Add(tmpQues);
                }


            }
        }
    }
}
