using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleMeApp
{
    public partial class QuizForm : Form
    {
        private Quiz currentQuiz;
        public QuizForm()
        {
            InitializeComponent();
        }

        private void lblInstructions_Click(object sender, EventArgs e)
        {

        }

        private void txtInstructions_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            QuestionForm questionForm = new QuestionForm();
            questionForm.ShowDialog();

            Question question = questionForm.GetQuestion();
            if (question != null)
            {
                currentQuiz.AddQuestion(question);
                txtSummary.Text = currentQuiz.Print();
                txtSummary.Visible = true;
            }

        }

        private void txtModNm_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                int marks1 = Convert.ToInt32(txtMarks.Text);
                currentQuiz = new Quiz(txtModNm.Text, txtDescription.Text, marks1);
                txtSummary.Text = currentQuiz.Print();
                txtSummary.Visible = true;
                btnTeacherCopy.Visible = true;
                btnStudentCopy.Visible = true;


        }

        private void btnTeacherCopy_Click(object sender, EventArgs e)
        {
            if (currentQuiz != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Save Quiz File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            
                            writer.WriteLine("Module Name: " + currentQuiz.ModuleName);
                            writer.WriteLine("Description: " + currentQuiz.Description);
                            writer.WriteLine("Marks: " + currentQuiz.Marks);

                            writer.WriteLine("Questions:");
                            foreach (Question question in currentQuiz.Questions)
                            {
                                writer.WriteLine(question.Print());
                            }
                        }

                        MessageBox.Show("Quiz saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while saving the quiz: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No quiz data available to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStudentCopy_Click(object sender, EventArgs e)
        {
            if (currentQuiz != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Save Quiz File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.WriteLine("Module Name: " + currentQuiz.ModuleName);
                            writer.WriteLine("Description: " + currentQuiz.Description);
                            writer.WriteLine("Marks: " + currentQuiz.Marks);

                            writer.WriteLine("Questions:");
                            foreach (Question question in currentQuiz.Questions)
                            {
                                writer.WriteLine(question.PrintWithoutAnswer());
                            }
                        }

                        MessageBox.Show("Quiz saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while saving the quiz: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No quiz data available to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
