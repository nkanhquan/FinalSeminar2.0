using ExamEditor.Exam_marker;
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

namespace ExamEditor
{
    public partial class ExamEditor : Form
    {
        //Attributes
        private List<StudentExam> lstExam;
        private Dictionary<string, List<MulQuestion>> quesDb = new Dictionary<string, List<MulQuestion>>();

        //Constructor
        public ExamEditor()
        {
            InitializeComponent();
        }

        //Method
        private void MarkExamInFolder(string direct)
        {
            //Get every .xml files in the folder
            string[] files = Directory.GetFiles(direct, "*.xml");

            //Go through every file
            for (int i = 0; i < files.Length; ++i)
            {
                StudentExam tmpExam = new StudentExam();

                using (XmlReader xml = XmlReader.Create(files[i]))
                {
                    string buffer = "";
                    xml.ReadToFollowing("StudentAnswer");

                    //Student's info
                    xml.ReadToFollowing("Student");
                    
                    //Name
                    xml.ReadToFollowing("StudentName");
                    buffer = xml.ReadElementContentAsString();
                    tmpExam.Name = buffer;

                    //ID
                    xml.ReadToFollowing("StudentID");
                    buffer = xml.ReadElementContentAsString();
                    tmpExam.ID = buffer;

                    //Student's answers
                    xml.ReadToFollowing("Test");

                    while(xml.ReadToFollowing("Question"))
                    {
                        StudentAnswer tmpAns = new StudentAnswer();

                        //Read topic
                        xml.ReadToFollowing("Topic");
                        tmpAns.Topic = xml.ReadElementContentAsString();

                        //Read question content
                        xml.ReadToFollowing("Content");
                        tmpAns.Question = xml.ReadElementContentAsString();

                        //Read student's answer
                        xml.ReadToFollowing("Answer");
                        tmpAns.Answer = xml.ReadElementContentAsString();

                        //Check to see if the answer is correct
                        if (CheckAnswerCorrectOrNot(tmpAns) == 1)
                            ++tmpExam.NumCorrect;
                    }
                }
                lstExam.Add(tmpExam);
            }
        }

        private int CheckAnswerCorrectOrNot(StudentAnswer tmp)
        {
            foreach (var pair in quesDb)
            {
                if (tmp.Topic == pair.Key)
                {
                    foreach (var ques in pair.Value)
                    {
                        if (tmp.Question == ques.Ques)
                        {
                            if (tmp.Answer == ques.CorrectAnswer)
                                return 1;
                            else
                                return 0;
                        }
                    }
                    return -1;
                }
            }

            return -1;
        }

        private void btnExamMarker_Click(object sender, EventArgs e)
        {
            lstExam = new List<StudentExam>();
            string fileDirectory = "";
            string filePath = "";

            //Get the directory path
            if(openFolderDlg.ShowDialog() == DialogResult.OK)
            {
                fileDirectory = openFolderDlg.SelectedPath;

                MarkExamInFolder(fileDirectory);

                //Get the save path
                saveFileDlg.Filter = "|*.txt";
                if (saveFileDlg.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDlg.FileName;

                    ExportResult(filePath);
                }
            }


        }

        private void ExportResult(string filePath)
        {
            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.WriteLine("ID|Name|Number of correct answers");
                foreach(var i in lstExam)
                {
                    sw.WriteLine($"{i.ID}|{i.Name}|{i.NumCorrect}");
                }
            }

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
                }
            }
        }

        private void ExamEditor_Load(object sender, EventArgs e)
        {
            LoadDatabase(@"Question Database");
        }
    }
}