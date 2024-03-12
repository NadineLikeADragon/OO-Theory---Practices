namespace PuzzleMeApp
{
    partial class QuestionForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.gbQType = new System.Windows.Forms.GroupBox();
            this.rbNumerical = new System.Windows.Forms.RadioButton();
            this.rdMulti = new System.Windows.Forms.RadioButton();
            this.rbFreeForm = new System.Windows.Forms.RadioButton();
            this.rbTF = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtQtext = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.multipan = new System.Windows.Forms.Panel();
            this.txtMultiOptionD = new System.Windows.Forms.TextBox();
            this.txtMultiOptionC = new System.Windows.Forms.TextBox();
            this.txtMultiOptionB = new System.Windows.Forms.TextBox();
            this.txtMultiOptionA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boolpan = new System.Windows.Forms.Panel();
            this.rbBoolpanFalse = new System.Windows.Forms.RadioButton();
            this.rbBoolpanTrue = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.numpan = new System.Windows.Forms.Panel();
            this.txtYMax = new System.Windows.Forms.TextBox();
            this.txtYMin = new System.Windows.Forms.TextBox();
            this.txtXMax = new System.Windows.Forms.TextBox();
            this.txtXMin = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.freepan = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxWords = new System.Windows.Forms.TextBox();
            this.gbQType.SuspendLayout();
            this.multipan.SuspendLayout();
            this.boolpan.SuspendLayout();
            this.numpan.SuspendLayout();
            this.freepan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(184, 21);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(141, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Question";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(33, 75);
            this.lblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(67, 23);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Text: ";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(33, 126);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(97, 23);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Answer: ";
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarks.Location = new System.Drawing.Point(33, 173);
            this.lblMarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(76, 23);
            this.lblMarks.TabIndex = 3;
            this.lblMarks.Text = "Marks:";
            // 
            // gbQType
            // 
            this.gbQType.Controls.Add(this.rbNumerical);
            this.gbQType.Controls.Add(this.rdMulti);
            this.gbQType.Controls.Add(this.rbFreeForm);
            this.gbQType.Controls.Add(this.rbTF);
            this.gbQType.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQType.Location = new System.Drawing.Point(13, 225);
            this.gbQType.Margin = new System.Windows.Forms.Padding(4);
            this.gbQType.Name = "gbQType";
            this.gbQType.Padding = new System.Windows.Forms.Padding(4);
            this.gbQType.Size = new System.Drawing.Size(394, 106);
            this.gbQType.TabIndex = 5;
            this.gbQType.TabStop = false;
            this.gbQType.Text = "Type of Question: ";
            // 
            // rbNumerical
            // 
            this.rbNumerical.AutoSize = true;
            this.rbNumerical.Location = new System.Drawing.Point(29, 66);
            this.rbNumerical.Margin = new System.Windows.Forms.Padding(4);
            this.rbNumerical.Name = "rbNumerical";
            this.rbNumerical.Size = new System.Drawing.Size(134, 27);
            this.rbNumerical.TabIndex = 8;
            this.rbNumerical.TabStop = true;
            this.rbNumerical.Text = "Numerical";
            this.rbNumerical.UseVisualStyleBackColor = true;
            this.rbNumerical.CheckedChanged += new System.EventHandler(this.rbNumerical_CheckedChanged);
            // 
            // rdMulti
            // 
            this.rdMulti.AutoSize = true;
            this.rdMulti.Location = new System.Drawing.Point(29, 38);
            this.rdMulti.Margin = new System.Windows.Forms.Padding(4);
            this.rdMulti.Name = "rdMulti";
            this.rdMulti.Size = new System.Drawing.Size(189, 27);
            this.rdMulti.TabIndex = 7;
            this.rdMulti.TabStop = true;
            this.rdMulti.Text = "Multiple Choice";
            this.rdMulti.UseVisualStyleBackColor = true;
            this.rdMulti.CheckedChanged += new System.EventHandler(this.rdMulti_CheckedChanged);
            // 
            // rbFreeForm
            // 
            this.rbFreeForm.AutoSize = true;
            this.rbFreeForm.Location = new System.Drawing.Point(235, 66);
            this.rbFreeForm.Margin = new System.Windows.Forms.Padding(4);
            this.rbFreeForm.Name = "rbFreeForm";
            this.rbFreeForm.Size = new System.Drawing.Size(131, 27);
            this.rbFreeForm.TabIndex = 1;
            this.rbFreeForm.TabStop = true;
            this.rbFreeForm.Text = "Free Form";
            this.rbFreeForm.UseVisualStyleBackColor = true;
            this.rbFreeForm.CheckedChanged += new System.EventHandler(this.rbFreeForm_CheckedChanged);
            // 
            // rbTF
            // 
            this.rbTF.AutoSize = true;
            this.rbTF.Location = new System.Drawing.Point(235, 38);
            this.rbTF.Margin = new System.Windows.Forms.Padding(4);
            this.rbTF.Name = "rbTF";
            this.rbTF.Size = new System.Drawing.Size(140, 27);
            this.rbTF.TabIndex = 0;
            this.rbTF.TabStop = true;
            this.rbTF.Text = "True/False";
            this.rbTF.UseVisualStyleBackColor = true;
            this.rbTF.CheckedChanged += new System.EventHandler(this.rbTF_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(419, 60);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 89);
            this.button1.TabIndex = 6;
            this.button1.Text = "Finish Question Creation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtQtext
            // 
            this.txtQtext.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtext.Location = new System.Drawing.Point(173, 72);
            this.txtQtext.Name = "txtQtext";
            this.txtQtext.Size = new System.Drawing.Size(100, 31);
            this.txtQtext.TabIndex = 8;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(173, 123);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 31);
            this.txtAnswer.TabIndex = 9;
            // 
            // txtMarks
            // 
            this.txtMarks.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarks.Location = new System.Drawing.Point(173, 170);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(100, 31);
            this.txtMarks.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(419, 173);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 79);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel Question";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // multipan
            // 
            this.multipan.Controls.Add(this.txtMultiOptionD);
            this.multipan.Controls.Add(this.txtMultiOptionC);
            this.multipan.Controls.Add(this.txtMultiOptionB);
            this.multipan.Controls.Add(this.txtMultiOptionA);
            this.multipan.Controls.Add(this.label8);
            this.multipan.Controls.Add(this.label7);
            this.multipan.Controls.Add(this.label6);
            this.multipan.Controls.Add(this.label5);
            this.multipan.Controls.Add(this.label1);
            this.multipan.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multipan.Location = new System.Drawing.Point(13, 338);
            this.multipan.Name = "multipan";
            this.multipan.Size = new System.Drawing.Size(271, 164);
            this.multipan.TabIndex = 12;
            this.multipan.Visible = false;
            this.multipan.Paint += new System.Windows.Forms.PaintEventHandler(this.multipan_Paint);
            // 
            // txtMultiOptionD
            // 
            this.txtMultiOptionD.Location = new System.Drawing.Point(83, 126);
            this.txtMultiOptionD.Name = "txtMultiOptionD";
            this.txtMultiOptionD.Size = new System.Drawing.Size(185, 23);
            this.txtMultiOptionD.TabIndex = 8;
            // 
            // txtMultiOptionC
            // 
            this.txtMultiOptionC.Location = new System.Drawing.Point(83, 95);
            this.txtMultiOptionC.Name = "txtMultiOptionC";
            this.txtMultiOptionC.Size = new System.Drawing.Size(185, 23);
            this.txtMultiOptionC.TabIndex = 7;
            // 
            // txtMultiOptionB
            // 
            this.txtMultiOptionB.Location = new System.Drawing.Point(83, 64);
            this.txtMultiOptionB.Name = "txtMultiOptionB";
            this.txtMultiOptionB.Size = new System.Drawing.Size(185, 23);
            this.txtMultiOptionB.TabIndex = 6;
            // 
            // txtMultiOptionA
            // 
            this.txtMultiOptionA.Location = new System.Drawing.Point(83, 34);
            this.txtMultiOptionA.Name = "txtMultiOptionA";
            this.txtMultiOptionA.Size = new System.Drawing.Size(185, 23);
            this.txtMultiOptionA.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Option D: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Option C: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Option B: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Option A: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Insert your options below: ";
            // 
            // boolpan
            // 
            this.boolpan.Controls.Add(this.rbBoolpanFalse);
            this.boolpan.Controls.Add(this.rbBoolpanTrue);
            this.boolpan.Controls.Add(this.label3);
            this.boolpan.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boolpan.Location = new System.Drawing.Point(289, 338);
            this.boolpan.Name = "boolpan";
            this.boolpan.Size = new System.Drawing.Size(267, 164);
            this.boolpan.TabIndex = 13;
            this.boolpan.Visible = false;
            // 
            // rbBoolpanFalse
            // 
            this.rbBoolpanFalse.AutoSize = true;
            this.rbBoolpanFalse.Location = new System.Drawing.Point(15, 98);
            this.rbBoolpanFalse.Name = "rbBoolpanFalse";
            this.rbBoolpanFalse.Size = new System.Drawing.Size(60, 20);
            this.rbBoolpanFalse.TabIndex = 2;
            this.rbBoolpanFalse.TabStop = true;
            this.rbBoolpanFalse.Text = "False";
            this.rbBoolpanFalse.UseVisualStyleBackColor = true;
            // 
            // rbBoolpanTrue
            // 
            this.rbBoolpanTrue.AutoSize = true;
            this.rbBoolpanTrue.Location = new System.Drawing.Point(15, 53);
            this.rbBoolpanTrue.Name = "rbBoolpanTrue";
            this.rbBoolpanTrue.Size = new System.Drawing.Size(59, 20);
            this.rbBoolpanTrue.TabIndex = 1;
            this.rbBoolpanTrue.TabStop = true;
            this.rbBoolpanTrue.Text = "True";
            this.rbBoolpanTrue.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "True OR False";
            // 
            // numpan
            // 
            this.numpan.Controls.Add(this.txtYMax);
            this.numpan.Controls.Add(this.txtYMin);
            this.numpan.Controls.Add(this.txtXMax);
            this.numpan.Controls.Add(this.txtXMin);
            this.numpan.Controls.Add(this.label12);
            this.numpan.Controls.Add(this.label11);
            this.numpan.Controls.Add(this.label10);
            this.numpan.Controls.Add(this.label9);
            this.numpan.Controls.Add(this.label2);
            this.numpan.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numpan.Location = new System.Drawing.Point(12, 508);
            this.numpan.Name = "numpan";
            this.numpan.Size = new System.Drawing.Size(271, 189);
            this.numpan.TabIndex = 14;
            this.numpan.Visible = false;
            // 
            // txtYMax
            // 
            this.txtYMax.Location = new System.Drawing.Point(83, 163);
            this.txtYMax.Name = "txtYMax";
            this.txtYMax.Size = new System.Drawing.Size(96, 23);
            this.txtYMax.TabIndex = 9;
            // 
            // txtYMin
            // 
            this.txtYMin.Location = new System.Drawing.Point(84, 134);
            this.txtYMin.Name = "txtYMin";
            this.txtYMin.Size = new System.Drawing.Size(95, 23);
            this.txtYMin.TabIndex = 8;
            // 
            // txtXMax
            // 
            this.txtXMax.Location = new System.Drawing.Point(82, 102);
            this.txtXMax.Name = "txtXMax";
            this.txtXMax.Size = new System.Drawing.Size(97, 23);
            this.txtXMax.TabIndex = 7;
            // 
            // txtXMin
            // 
            this.txtXMin.Location = new System.Drawing.Point(82, 68);
            this.txtXMin.Name = "txtXMin";
            this.txtXMin.Size = new System.Drawing.Size(97, 23);
            this.txtXMin.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Y max: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Y min:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "X max:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "X min:  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please enter a min and  a max value \r\nyou want of X and Y to create a \r\nrandom nu" +
    "mber in that range: \r\n";
            // 
            // freepan
            // 
            this.freepan.Controls.Add(this.txtMaxWords);
            this.freepan.Controls.Add(this.label4);
            this.freepan.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freepan.Location = new System.Drawing.Point(289, 508);
            this.freepan.Name = "freepan";
            this.freepan.Size = new System.Drawing.Size(266, 189);
            this.freepan.TabIndex = 15;
            this.freepan.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Insert Your text based Question: ";
            // 
            // txtMaxWords
            // 
            this.txtMaxWords.Location = new System.Drawing.Point(75, 75);
            this.txtMaxWords.Name = "txtMaxWords";
            this.txtMaxWords.Size = new System.Drawing.Size(110, 23);
            this.txtMaxWords.TabIndex = 1;
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(567, 709);
            this.Controls.Add(this.freepan);
            this.Controls.Add(this.numpan);
            this.Controls.Add(this.boolpan);
            this.Controls.Add(this.multipan);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtQtext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbQType);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.gbQType.ResumeLayout(false);
            this.gbQType.PerformLayout();
            this.multipan.ResumeLayout(false);
            this.multipan.PerformLayout();
            this.boolpan.ResumeLayout(false);
            this.boolpan.PerformLayout();
            this.numpan.ResumeLayout(false);
            this.numpan.PerformLayout();
            this.freepan.ResumeLayout(false);
            this.freepan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.GroupBox gbQType;
        private System.Windows.Forms.RadioButton rbNumerical;
        private System.Windows.Forms.RadioButton rdMulti;
        private System.Windows.Forms.RadioButton rbFreeForm;
        private System.Windows.Forms.RadioButton rbTF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtQtext;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel multipan;
        private System.Windows.Forms.Panel boolpan;
        private System.Windows.Forms.Panel numpan;
        private System.Windows.Forms.Panel freepan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMultiOptionD;
        private System.Windows.Forms.TextBox txtMultiOptionC;
        private System.Windows.Forms.TextBox txtMultiOptionB;
        private System.Windows.Forms.TextBox txtMultiOptionA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtYMax;
        private System.Windows.Forms.TextBox txtYMin;
        private System.Windows.Forms.TextBox txtXMax;
        private System.Windows.Forms.TextBox txtXMin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbBoolpanFalse;
        private System.Windows.Forms.RadioButton rbBoolpanTrue;
        private System.Windows.Forms.TextBox txtMaxWords;
    }
}