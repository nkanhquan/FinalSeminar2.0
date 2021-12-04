
namespace ExamEditor
{
    partial class ExamEditor
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
            this.btnQuesEditor = new System.Windows.Forms.Button();
            this.btnExamEditor = new System.Windows.Forms.Button();
            this.btnExamMarker = new System.Windows.Forms.Button();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.openFolderDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnQuesEditor
            // 
            this.btnQuesEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuesEditor.Location = new System.Drawing.Point(12, 29);
            this.btnQuesEditor.Name = "btnQuesEditor";
            this.btnQuesEditor.Size = new System.Drawing.Size(159, 55);
            this.btnQuesEditor.TabIndex = 0;
            this.btnQuesEditor.Text = "Question editor";
            this.btnQuesEditor.UseVisualStyleBackColor = true;
            // 
            // btnExamEditor
            // 
            this.btnExamEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExamEditor.Location = new System.Drawing.Point(177, 29);
            this.btnExamEditor.Name = "btnExamEditor";
            this.btnExamEditor.Size = new System.Drawing.Size(159, 55);
            this.btnExamEditor.TabIndex = 1;
            this.btnExamEditor.Text = "Exam editor";
            this.btnExamEditor.UseVisualStyleBackColor = true;
            this.btnExamEditor.Click += new System.EventHandler(this.btnExamEditor_Click);
            // 
            // btnExamMarker
            // 
            this.btnExamMarker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExamMarker.Location = new System.Drawing.Point(342, 29);
            this.btnExamMarker.Name = "btnExamMarker";
            this.btnExamMarker.Size = new System.Drawing.Size(159, 55);
            this.btnExamMarker.TabIndex = 2;
            this.btnExamMarker.Text = "Exam marker";
            this.btnExamMarker.UseVisualStyleBackColor = true;
            this.btnExamMarker.Click += new System.EventHandler(this.btnExamMarker_Click);
            // 
            // ExamEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 118);
            this.Controls.Add(this.btnExamMarker);
            this.Controls.Add(this.btnExamEditor);
            this.Controls.Add(this.btnQuesEditor);
            this.Name = "ExamEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam Editor";
            this.Load += new System.EventHandler(this.ExamEditor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuesEditor;
        private System.Windows.Forms.Button btnExamEditor;
        private System.Windows.Forms.Button btnExamMarker;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.FolderBrowserDialog openFolderDlg;
    }
}

