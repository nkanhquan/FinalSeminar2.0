using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamEditor.Exam_marker
{
    public class StudentExam
    {
        //Properties
        public string Name { get; set; }
        public string ID { get; set; }
        public int NumCorrect { get; set; }

        //Constructor
        public StudentExam()
        {
            Name = "";
            ID = "";
            NumCorrect = 0;
        }

        //Method
        public override string ToString()
        {
            return Name + '\t' + ID + '\t' + NumCorrect;
        }
    }
}
