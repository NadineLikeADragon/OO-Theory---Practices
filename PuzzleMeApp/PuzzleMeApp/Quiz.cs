using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleMeApp
{
    internal class Quiz
    {
        public string ModuleName { get;  set; }
        public string Description { get;  set; }
        public int Marks { get; set; }
        public List<Question> Questions { get;  set; }

        public Quiz(string moduleName, string description, int marks)
        {
            ModuleName = moduleName;
            Description = description;
            Marks = marks;
            Questions = new List<Question>();
        }

        public string Print()
        {
            var quizInfo = "Module Name:" +ModuleName+"\nDescription:"+ Description+"\nMarks: " +Marks;

            foreach (var question in Questions)
            {
                quizInfo += "\nQuestion:\n" + question.Print();
            }

            return quizInfo;
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }
    }
}
