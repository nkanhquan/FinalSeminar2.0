using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm
{
    public class MulQuestion
    {
        //Attribute
        private String ques;
        private List<string> ans;
        private string tpc;
        private string correctAns;

        //Properties
        public string Ques 
        {
            get { return ques; }
            set { ques = value; } 
        }

        public List<string> Ans
        {
            get { return ans; }
            set { ans =value ;  }
        }

        public string Topic 
        {
            get { return tpc; }
            set { tpc = value; }
        }

        public string CorrectAnswer
        {
            get { return correctAns; }
            set { correctAns = value; }
        }


        //Constructor
        public MulQuestion()
        {
            ques = "";
            ans = new List<string>();
            tpc = "";
        }

        public MulQuestion(string tmpQues, string tmpTopic , List<string> tmpAns)
        {
            ques = tmpQues;
            ans = new List<string>(tmpAns);
            tpc = tmpTopic;
        }

        public MulQuestion(MulQuestion that)
        {
            if (that == null) return;
            else
            {
                this.ques = that.ques;
                this.ans = that.ans;
                this.tpc = that.tpc;
                this.CorrectAnswer = that.CorrectAnswer;
            }
        }

        public override string ToString()
        {
            return ques;
        }
    }
}
