using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleMeApp
{
    public partial class QuestionForm : Form
    {
        private Question question;
        public QuestionForm()
        {
            InitializeComponent();
        }
        
        private void rdMulti_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rdMulti.Checked)
            {
                this.multipan.Visible = true;
                this.numpan.Visible = false;
                this.boolpan.Visible = false;
                this.freepan.Visible = false;
            }
        }

        private void rbTF_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbTF.Checked)
            {
                this.multipan.Visible = false;
                this.numpan.Visible = false;
                this.boolpan.Visible = true;
                this.freepan.Visible = false;
            }
        }

        private void rbNumerical_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbNumerical.Checked)
            {
                this.multipan.Visible = false;
                this.numpan.Visible = true;
                this.boolpan.Visible = false;
                this.freepan.Visible = false;
            }
        }

        private void rbFreeForm_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbFreeForm.Checked)
            {
                this.multipan.Visible = false;
                this.numpan.Visible = false;
                this.boolpan.Visible = false;
                this.freepan.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.rdMulti.Checked)
            {
                    string marks = txtMarks.Text;
                    int marks1 = Convert.ToInt32(marks);
                    MultipleChoice multi = new MultipleChoice(txtQtext.Text, txtAnswer.Text, marks1, txtMultiOptionA.Text, txtMultiOptionB.Text, txtMultiOptionC.Text, txtMultiOptionD.Text);
                    question = multi;
                    this.Close();
                
            }
            else if (this.rbTF.Checked)
            {
                string TrUe =" ";
                string marks = txtMarks.Text;
                int marks1 = Convert.ToInt32(marks);
                if(rbBoolpanTrue.Checked)
                {
                     TrUe = "True";
                }
                else if (rbBoolpanFalse.Checked)
                {
                    TrUe = "False";
                }
               
                TrueOrFalse tf = new TrueOrFalse(txtQtext.Text, txtAnswer.Text, marks1, TrUe);
                question = tf;
                this.Close();
            }
            else if (this.rbNumerical.Checked)
            {
                string marks = txtMarks.Text;
                int marks1 = Convert.ToInt32(marks);
                string num1Min = txtXMin.Text;
                int num1min = Convert.ToInt32(num1Min);
                string num1Max = txtXMax.Text;
                int num1max = Convert.ToInt32(num1Max);
                string num2Min = txtYMin.Text;
                int num2min = Convert.ToInt32(num2Min);
                string num2Max = txtYMax.Text;
                int num2max = Convert.ToInt32(num2Max);
                Numerical num = new Numerical(txtQtext.Text, txtAnswer.Text, marks1, num1min,num1max,num2min,num2max);
                question = num;
                this.Close();
            }
            else if (this.rbFreeForm.Checked)
            {
                string marks = txtMarks.Text;
                int marks1 = Convert.ToInt32(marks);
                string max = txtMaxWords.Text;
                int maxW = Convert.ToInt32(max);
                FreeForm free = new FreeForm(txtQtext.Text, txtAnswer.Text, marks1,maxW);
                question =free;
                this.Close();
            }
        }

        private void multipan_Paint(object sender, PaintEventArgs e)
        {
            
        }
        public Question GetQuestion()
        {
            return question;
        }
    }
}
