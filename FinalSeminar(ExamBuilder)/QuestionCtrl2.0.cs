using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSeminar_ExamBuilder_
{
    public partial class QuestionCtrl2_0 : UserControl
    {
        //Attributes
        private MulQuestion currentQues = new MulQuestion();
        private List<Label> lstAns = new List<Label>();
        private List<Label> lstAnsNum = new List<Label>();

        //Properties
        public MulQuestion Content 
        {
            get { return currentQues; }
            set
            {
                currentQues = new MulQuestion(value);
            }
        }

        //Constructor
        public QuestionCtrl2_0()
        {
            InitializeComponent();
        }

        //Function
        public void UpdateQuestion(MulQuestion pickedQues)
        {
            currentQues = new MulQuestion(pickedQues);

            //Drop every answer before add new ones
            DropAllAnswer();

            //Question, topic, correct answer
            lbQuestion.Text = currentQues.Ques;
            lbTopic.Text = currentQues.Topic;
            lbCorrect.Text = currentQues.CorrectAnswer;

            //Answers
            for (int i = 0; i < currentQues.Ans.Count; ++i)
            {
                Label ansNum = new Label();
                Label ansContent = new Label();

                //Answer number label
                ansNum.Location = new Point(18, 149 + 38 * i);
                ansNum.Size = new Size(55, 17);
                ansNum.Font = new Font("Microsoft Sans Serif", 8);
                ansNum.Text = $"Answer {i + 1}:";
                lstAnsNum.Add(ansNum);
                this.Controls.Add(ansNum);

                //Answer content label
                ansContent.Location = new Point(94, 149 + 38 * i);
                ansContent.Size = new Size(500, 17);
                ansContent.Font = new Font("Microsoft Sans Serif", 8);
                ansContent.Text = currentQues.Ans[i];
                lstAns.Add(ansContent);
                this.Controls.Add(ansContent);
            }

        }

        private void DropAllAnswer()
        {
            if (lstAns != null && lstAnsNum != null)
            {
                if(lstAns.Count != 0 && lstAnsNum.Count != 0)
                    for(int i = 0; i < lstAns.Count; ++i)
                    {
                        this.Controls.Remove(lstAns[i]);
                        this.Controls.Remove(lstAnsNum[i]);
                    }
            }

            lstAns.Clear();
            lstAnsNum.Clear();
        }
    }
}
