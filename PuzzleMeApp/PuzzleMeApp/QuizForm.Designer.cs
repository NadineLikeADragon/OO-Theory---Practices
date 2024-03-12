namespace PuzzleMeApp
{
    partial class QuizForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblModNm = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtModNm = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.txtInstructions = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSummary = new System.Windows.Forms.RichTextBox();
            this.btnStudentCopy = new System.Windows.Forms.Button();
            this.btnTeacherCopy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblModNm
            // 
            this.lblModNm.AutoSize = true;
            this.lblModNm.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModNm.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblModNm.Location = new System.Drawing.Point(53, 50);
            this.lblModNm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModNm.Name = "lblModNm";
            this.lblModNm.Size = new System.Drawing.Size(158, 23);
            this.lblModNm.TabIndex = 0;
            this.lblModNm.Text = "Module Name: ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDescription.Location = new System.Drawing.Point(53, 89);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(141, 23);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description: ";
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarks.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMarks.Location = new System.Drawing.Point(53, 128);
            this.lblMarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(82, 23);
            this.lblMarks.TabIndex = 2;
            this.lblMarks.Text = "Marks: ";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblInstructions.Location = new System.Drawing.Point(53, 165);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(146, 23);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "Instructions: ";
            this.lblInstructions.Click += new System.EventHandler(this.lblInstructions_Click);
            // 
            // txtModNm
            // 
            this.txtModNm.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModNm.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtModNm.Location = new System.Drawing.Point(261, 47);
            this.txtModNm.Margin = new System.Windows.Forms.Padding(4);
            this.txtModNm.Name = "txtModNm";
            this.txtModNm.Size = new System.Drawing.Size(132, 31);
            this.txtModNm.TabIndex = 4;
            this.txtModNm.TextChanged += new System.EventHandler(this.txtModNm_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtDescription.Location = new System.Drawing.Point(261, 85);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(132, 31);
            this.txtDescription.TabIndex = 5;
            // 
            // txtMarks
            // 
            this.txtMarks.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarks.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtMarks.Location = new System.Drawing.Point(261, 124);
            this.txtMarks.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(132, 31);
            this.txtMarks.TabIndex = 6;
            // 
            // txtInstructions
            // 
            this.txtInstructions.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstructions.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtInstructions.Location = new System.Drawing.Point(57, 191);
            this.txtInstructions.Margin = new System.Windows.Forms.Padding(4);
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(336, 70);
            this.txtInstructions.TabIndex = 7;
            this.txtInstructions.Text = "";
            this.txtInstructions.TextChanged += new System.EventHandler(this.txtInstructions_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAdd.Location = new System.Drawing.Point(445, 193);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 69);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Question";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 281);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "No# of Questions: ";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox1.Location = new System.Drawing.Point(261, 277);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 31);
            this.textBox1.TabIndex = 10;
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(57, 327);
            this.txtSummary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(533, 166);
            this.txtSummary.TabIndex = 11;
            this.txtSummary.Text = "";
            this.txtSummary.Visible = false;
            // 
            // btnStudentCopy
            // 
            this.btnStudentCopy.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentCopy.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnStudentCopy.Location = new System.Drawing.Point(157, 502);
            this.btnStudentCopy.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudentCopy.Name = "btnStudentCopy";
            this.btnStudentCopy.Size = new System.Drawing.Size(123, 84);
            this.btnStudentCopy.TabIndex = 12;
            this.btnStudentCopy.Text = "Print student Copy";
            this.btnStudentCopy.UseVisualStyleBackColor = true;
            this.btnStudentCopy.Visible = false;
            this.btnStudentCopy.Click += new System.EventHandler(this.btnStudentCopy_Click);
            // 
            // btnTeacherCopy
            // 
            this.btnTeacherCopy.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherCopy.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnTeacherCopy.Location = new System.Drawing.Point(357, 505);
            this.btnTeacherCopy.Margin = new System.Windows.Forms.Padding(4);
            this.btnTeacherCopy.Name = "btnTeacherCopy";
            this.btnTeacherCopy.Size = new System.Drawing.Size(123, 79);
            this.btnTeacherCopy.TabIndex = 13;
            this.btnTeacherCopy.Text = "Print Teacher Copy";
            this.btnTeacherCopy.UseVisualStyleBackColor = true;
            this.btnTeacherCopy.Visible = false;
            this.btnTeacherCopy.Click += new System.EventHandler(this.btnTeacherCopy_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(445, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 86);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add Header Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(629, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTeacherCopy);
            this.Controls.Add(this.btnStudentCopy);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtModNm);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblModNm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModNm;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtModNm;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.RichTextBox txtInstructions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox txtSummary;
        private System.Windows.Forms.Button btnStudentCopy;
        private System.Windows.Forms.Button btnTeacherCopy;
        private System.Windows.Forms.Button button1;
    }
}

