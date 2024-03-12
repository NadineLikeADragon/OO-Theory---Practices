using PuzzleMeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class MultipleChoice : Question
{
    public String ChoiceA { get; set; }
    public String ChoiceB { get; set; }
    public String ChoiceC { get; set; }
    public String ChoiceD { get; set; }

    public MultipleChoice(String questionText, String answer, int marks, String choiceA, String choiceB, String choiceC, String choiceD)
        : base(questionText, answer, marks)
    {
        this.ChoiceA = choiceA;
        this.ChoiceB = choiceB;
        this.ChoiceC = choiceC;
        this.ChoiceD = choiceD;
    }

    public override string Print()
    {
        string questionInfo = base.Print();

        questionInfo += "\nChoice A: " + ChoiceA + "\nChoice B: " + ChoiceB + "\nChoice C:" + ChoiceC + "\nChoice D: " + ChoiceD;

        return questionInfo;
    }
    public override string PrintWithoutAnswer()
    {
        string questionInfo = base.PrintWithoutAnswer();
        questionInfo += "\nChoice A: " + ChoiceA + "\nChoice B: " + ChoiceB + "\nChoice C:" + ChoiceC + "\nChoice D: " + ChoiceD;
        return questionInfo;
    }
}