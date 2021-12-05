using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamEditor.Exam_marker
{
    class ExamComparer : IComparer<StudentExam>
    {
        public int Compare(StudentExam x, StudentExam y)
        {
            if (x.NumCorrect > y.NumCorrect)
                return -1;
            if (x.NumCorrect < y.NumCorrect)
                return 1;
            return 0;
        }
    }
}
