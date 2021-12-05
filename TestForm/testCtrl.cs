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
    public partial class TestCtrl : UserControl
    {
        class RadioAnswer
        {
            public bool isChange = false;

            public bool isClosed = false;
            public Label lbAnswer { get; set; }

            public RadioButton rdAnswer { get; set; }

            public RadioAnswer()
            {
                lbAnswer = new Label();
                rdAnswer = new RadioButton();
            }

        }
        //Attribute
        private List<string> lstAns;
        private MulQuestion content;
        private List<RadioAnswer> lstAnsCtrl = new List<RadioAnswer>();
        private List<int> LstIndex = new List<int>();
        public int indexChange;
        //Properties
        public MulQuestion Content
        {
            get
            {
                if (!CheckEmptyBox())
                {
                    content = new MulQuestion();
                    //Question
                    content.Ques = QuestText.Text;
                    //Answer
                    lstAns = new List<string>();
                    foreach (var i in lstAnsCtrl)
                    {
                        lstAns.Add(i.rdAnswer.Text);
                    }
                    content.Ans = lstAns;
                }
                //else
                //MessageBox.Show("Please fill out all the boxes!", "Error", MessageBoxButtons.OK);
                return content;
            }
            set
            {

                content = new MulQuestion(value);
                //reset radio button  
                QuestText.Text = content.Ques;
                if (indexChange == null)
                {
                    Quest.Text = $"Question {1}";
                }
                else
                {
                    Quest.Text = $"Question {indexChange + 1}";
                }
                if (content.Ans == null) return;
                else
                {
                    for (int i = 0; i < content.Ans.Count(); i++)
                    {
                        //add new question if not enought
                        if (content.Ans.Count() > lstAnsCtrl.Count())
                        {
                            Add_Answer();
                        }
                        lstAnsCtrl[i].rdAnswer.Text = content.Ans[i];

                    }
                    //delete answer if the input have enought answer ; 
                    for (int i = content.Ans.Count(); i < lstAnsCtrl.Count; i++)
                    {
                        lstAnsCtrl[i].isClosed = true;
                        this.Controls.RemoveAt(this.Controls.Count - 1);
                        this.Controls.RemoveAt(this.Controls.Count - 1);
                        UpdateAnswer();
                        i--;
                    }
                }
                Reset();
                UpdateAnswer();
            }

        }
        public void Reset()
        {
            for (int i = 0; i < lstAnsCtrl.Count; i++)
            {

                if (i == LstIndex[indexChange])
                {
                    lstAnsCtrl[i].rdAnswer.Checked = true;
                }
                else
                {
                    lstAnsCtrl[i].rdAnswer.Checked = false;
                }

            }
        }
        public string Check()
        {
            for (int i = 0; i < lstAnsCtrl.Count; i++)
            {
                if (lstAnsCtrl[i].rdAnswer.Checked == true)
                {
                    return lstAnsCtrl[i].rdAnswer.Text;
                }
            }
            return "";

        }
        public void CreateList(int leng)
        {
            for (int i = 0; i < leng; i++)
            {
                LstIndex.Add(-1);
            }
        }
        public void Changed(int index)
        {
            //update index
            for (int i = 0; i < lstAnsCtrl.Count; i++)
            {
                if (lstAnsCtrl[i].rdAnswer.Checked == true)
                {
                    LstIndex[index] = i;
                    return;
                }
            }
        }
        //get positon question 
        public void GetIndex(int index)
        {
            indexChange = index;
        }
        void Add_Answer()
        {
            int i = lstAnsCtrl.Count;
            //Create new answer Control
            RadioAnswer tmpAnsCtrl = new RadioAnswer();
            if (tmpAnsCtrl != null)
            {
                Point tmp1 = new Point(3, 50 + i * 53);
                Point tmp2 = new Point(120, 50 + i * 53);
                tmpAnsCtrl.lbAnswer.Location = tmp1;
                this.Controls.Add(tmpAnsCtrl.lbAnswer);
                tmpAnsCtrl.lbAnswer.Text = $"Answer {i + 1}";
                tmpAnsCtrl.rdAnswer.Location = tmp2;
                this.Controls.Add(tmpAnsCtrl.rdAnswer);
                lstAnsCtrl.Add(tmpAnsCtrl);
            }
        }
        public void UpdateAnswer()
        {
            //Check and delete AnsCtrl that are removed
            for (int i = 0; i < lstAnsCtrl.Count; ++i)
            {
                if (lstAnsCtrl[i].isClosed)
                {
                    lstAnsCtrl.RemoveAt(i);
                    --i;
                }
            }
            for (int i = 0; i < lstAnsCtrl.Count; ++i)
            {
                lstAnsCtrl[i].lbAnswer.Location = new Point(3, 50 + i * 53);
                lstAnsCtrl[i].lbAnswer.Text = $"Answer {i + 1}:";

            }


        }
        public string Question
        {
            get { return QuestText.Text; }
            set { QuestText.Text = value; }
        }
        public TestCtrl()
        {
            InitializeComponent();
        }

        public bool CheckEmptyBox()
        {
            //Check question
            if (String.IsNullOrEmpty(QuestText.Text))
                return true;
            //Check answers
            foreach (var i in lstAnsCtrl)
            {
                if (String.IsNullOrEmpty(i.rdAnswer.Text))
                    return true;
            }
            return false;
        }
        void Default_setting()
        {
            //Default: 4 answer box and close button
            for (int i = 0; i < 4; ++i)
            {
                RadioAnswer tmpAnsCtrl = new RadioAnswer();
                tmpAnsCtrl.lbAnswer.Location = new Point(3, 50 + i * 53);
                tmpAnsCtrl.lbAnswer.Text = $"Answer {i + 1}";
                this.Controls.Add(tmpAnsCtrl.lbAnswer);
                tmpAnsCtrl.rdAnswer.Location = new Point(120, 50 + i * 53);
                tmpAnsCtrl.rdAnswer.Text = "";
                this.Controls.Add(tmpAnsCtrl.rdAnswer);
                lstAnsCtrl.Add(tmpAnsCtrl);

            }
        }
        //void Answer_Reset(int index)
        //{
        //    for (int i = 0; i < lstAnsCtrl.Count; i++)
        //    {
        //        if (i != index) lstAnsCtrl[i].Answer.Checked =  false;
        //    }
        //}
        //public void checkedChange()
        //{
        //    for(int i=0;i<lstAnsCtrl.Count;i++)
        //    {
        //        if (lstAnsCtrl[i].Answer.Checked==true)
        //        {
        //            Answer_Reset(i);
        //            content.CorrectAnswer = lstAnsCtrl[i].Answer.Text; 
        //            return;
        //        }
        //    }
        //}

        private void TestCtrl_Load(object sender, EventArgs e)
        {
            Default_setting();
        }

        private void txtQuest_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
