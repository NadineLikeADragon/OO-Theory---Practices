using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleMeApp
{
    internal class FreeForm : Question
    {
       
        public int MaxWords { get; set; } 
        public FreeForm(string questionText, string answer, int marks, int maxWords) : base(questionText, answer, marks)
        {
            this.MaxWords = maxWords;
        }
        public override string Print()
        {
            string questionInfo = base.Print();

            questionInfo += "\nMaxWords: " + MaxWords;

            return questionInfo;
        }
        public override string PrintWithoutAnswer()
        {
            string questionInfo = base.PrintWithoutAnswer();
            questionInfo += "\nMaxWords: " + MaxWords;
            return questionInfo;
        }
    }
}
