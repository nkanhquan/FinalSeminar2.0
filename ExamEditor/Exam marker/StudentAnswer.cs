using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamEditor.Exam_marker
{
    class StudentAnswer
    {
        //Properties
        public string Topic { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        //Constructor
        public StudentAnswer()
        {
            Topic = "";
            Question = "";
            Answer = "";
        }
    }
}
