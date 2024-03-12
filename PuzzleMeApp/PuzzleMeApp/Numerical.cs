using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleMeApp
{
    internal class Numerical : Question
    {
        public int num1Min { get; set; }
        public int num1Max { get; set; }
        public int num2Min { get; set; }
        public int num2Max { get; set; }
        public Numerical(String questionText, String answer, int marks, int num1min, int num1max, int num2min, int num2max)
          : base(questionText, answer, marks)
        {
            this.num1Min = num1min;
            this.num1Max = num1max;
            this.num2Min = num2min;
            this.num2Max = num2max;
        }

        public override string Print()
        {
            Random random = new Random();
            int num1 = random.Next(num1Min, num1Max + 1); 
            int num2 = random.Next(num2Min, num2Max + 1); 

            string questionInfo = base.Print();
            questionInfo += "\nRandom Number 1: " + num1;
            questionInfo += "\nRandom Number 2: " + num2;

            return questionInfo;
        }

        public override string PrintWithoutAnswer()
        {
            Random random = new Random();
            int num1 = random.Next(num1Min, num1Max + 1); 
            int num2 = random.Next(num2Min, num2Max + 1); 

            string questionInfo = base.PrintWithoutAnswer();
            questionInfo += "\nRandom Number 1: " + num1;
            questionInfo += "\nRandom Number 2: " + num2;

            return questionInfo;
        }
    }
}
