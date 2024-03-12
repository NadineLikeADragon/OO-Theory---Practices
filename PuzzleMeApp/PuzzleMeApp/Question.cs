using PuzzleMeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleMeApp
{
    public class Question
    {
        public string QuestionText { get; set; }
        public string Answer { get;  set; }
        public int Marks { get;  set; }

        public Question(string questionText, string answer, int marks)
        {
            QuestionText = questionText;
            Answer = answer;
            Marks = marks;
        }

        public virtual string Print()
        {
            return "Question Text: " + QuestionText + "\nAnswer: " + Answer + "\nMarks:" +Marks;
        }
        public virtual string PrintWithoutAnswer()
        {
            string questionInfo = "Question Text: " + QuestionText + "\nMarks: " + Marks;
            return questionInfo;
        }
    }
}