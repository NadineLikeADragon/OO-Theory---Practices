using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleMeApp
{
    internal class TrueOrFalse : Question
    {
       

        public String TORF { get; set; }
        public TrueOrFalse(string questionText, string answer, int marks, String tRue) : base(questionText, answer, marks)
        {
            this.TORF = tRue;
        }
        public override string Print()
        {
            string questionInfo = base.Print();

            questionInfo += "\nTrueOrFalse: " + TORF;

            return questionInfo;
        }
        public override string PrintWithoutAnswer()
        {
            string questionInfo = base.PrintWithoutAnswer();
            questionInfo += "\nTrueOrFalse: " + TORF;

            return questionInfo;
        }
    }
}
