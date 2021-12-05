
namespace FinalSeminar_ExamBuilder_
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            FinalSeminar_ExamBuilder_.MulQuestion mulQuestion1 = new FinalSeminar_ExamBuilder_.MulQuestion();
            this.lbQuestion = new System.Windows.Forms.ListBox();
            this.btnUpArrow = new System.Windows.Forms.Button();
            this.btnDownArrow = new System.Windows.Forms.Button();
            this.cbxTopic = new System.Windows.Forms.ComboBox();
            this.lbQuesDB = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.questionCtrl = new FinalSeminar_ExamBuilder_.QuestionCtrl2_0();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExamCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbQuestion
            // 
            this.lbQuestion.FormattingEnabled = true;
            this.lbQuestion.ItemHeight = 16;
            this.lbQuestion.Location = new System.Drawing.Point(16, 12);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(339, 532);
            this.lbQuestion.TabIndex = 0;
            this.lbQuestion.SelectedIndexChanged += new System.EventHandler(this.lbQuestion_SelectedIndexChanged);
            // 
            // btnUpArrow
            // 
            this.btnUpArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpArrow.BackgroundImage")));
            this.btnUpArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpArrow.Location = new System.Drawing.Point(361, 221);
            this.btnUpArrow.Name = "btnUpArrow";
            this.btnUpArrow.Size = new System.Drawing.Size(27, 47);
            this.btnUpArrow.TabIndex = 1;
            this.btnUpArrow.UseVisualStyleBackColor = true;
            this.btnUpArrow.Click += new System.EventHandler(this.btnUpArrow_Click);
            // 
            // btnDownArrow
            // 
            this.btnDownArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDownArrow.BackgroundImage")));
            this.btnDownArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDownArrow.Location = new System.Drawing.Point(361, 274);
            this.btnDownArrow.Name = "btnDownArrow";
            this.btnDownArrow.Size = new System.Drawing.Size(27, 47);
            this.btnDownArrow.TabIndex = 2;
            this.btnDownArrow.UseVisualStyleBackColor = true;
            this.btnDownArrow.Click += new System.EventHandler(this.btnDownArrow_Click);
            // 
            // cbxTopic
            // 
            this.cbxTopic.FormattingEnabled = true;
            this.cbxTopic.Location = new System.Drawing.Point(938, 12);
            this.cbxTopic.Name = "cbxTopic";
            this.cbxTopic.Size = new System.Drawing.Size(354, 24);
            this.cbxTopic.TabIndex = 4;
            this.cbxTopic.SelectedIndexChanged += new System.EventHandler(this.cbxTopic_SelectedIndexChanged);
            // 
            // lbQuesDB
            // 
            this.lbQuesDB.FormattingEnabled = true;
            this.lbQuesDB.ItemHeight = 16;
            this.lbQuesDB.Location = new System.Drawing.Point(938, 42);
            this.lbQuesDB.Name = "lbQuesDB";
            this.lbQuesDB.Size = new System.Drawing.Size(354, 500);
            this.lbQuesDB.TabIndex = 5;
            this.lbQuesDB.SelectedIndexChanged += new System.EventHandler(this.lbQuesDB_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1301, 77);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 33);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1301, 116);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 33);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(1301, 194);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(99, 33);
            this.btnRandom.TabIndex = 8;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1301, 155);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 33);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // questionCtrl
            // 
            this.questionCtrl.BackColor = System.Drawing.Color.White;
            this.questionCtrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            mulQuestion1.Ans = ((System.Collections.Generic.List<string>)(resources.GetObject("mulQuestion1.Ans")));
            mulQuestion1.CorrectAnswer = null;
            mulQuestion1.Ques = "";
            mulQuestion1.Topic = "";
            this.questionCtrl.Content = mulQuestion1;
            this.questionCtrl.Location = new System.Drawing.Point(403, 12);
            this.questionCtrl.Name = "questionCtrl";
            this.questionCtrl.Size = new System.Drawing.Size(514, 533);
            this.questionCtrl.TabIndex = 10;
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1301, 233);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 33);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1311, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Exam\'s Code";
            // 
            // txtExamCode
            // 
            this.txtExamCode.Location = new System.Drawing.Point(1304, 324);
            this.txtExamCode.Name = "txtExamCode";
            this.txtExamCode.Size = new System.Drawing.Size(100, 22);
            this.txtExamCode.TabIndex = 13;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 557);
            this.Controls.Add(this.txtExamCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.questionCtrl);
            this.Controls.Add(this.cbxTopic);
            this.Controls.Add(this.lbQuesDB);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDownArrow);
            this.Controls.Add(this.btnUpArrow);
            this.Controls.Add(this.lbQuestion);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbQuestion;
        private System.Windows.Forms.Button btnUpArrow;
        private System.Windows.Forms.Button btnDownArrow;
        private System.Windows.Forms.ComboBox cbxTopic;
        private System.Windows.Forms.ListBox lbQuesDB;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnUpdate;
        private QuestionCtrl2_0 questionCtrl;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExamCode;
    }
}

