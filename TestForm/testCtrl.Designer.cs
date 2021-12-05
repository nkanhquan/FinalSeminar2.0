namespace TestForm
{
    partial class TestCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Quest = new System.Windows.Forms.Label();
            this.QuestText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Quest
            // 
            this.Quest.AutoSize = true;
            this.Quest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quest.Location = new System.Drawing.Point(3, 15);
            this.Quest.Name = "Quest";
            this.Quest.Size = new System.Drawing.Size(82, 22);
            this.Quest.TabIndex = 0;
            this.Quest.Text = "Question";
            // 
            // QuestText
            // 
            this.QuestText.AutoSize = true;
            this.QuestText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.QuestText.Location = new System.Drawing.Point(107, 15);
            this.QuestText.Name = "QuestText";
            this.QuestText.Size = new System.Drawing.Size(58, 22);
            this.QuestText.TabIndex = 2;
            this.QuestText.Text = "label1";
            // 
            // TestCtrl
            // 
            this.Controls.Add(this.QuestText);
            this.Controls.Add(this.Quest);
            this.Name = "TestCtrl";
            this.Size = new System.Drawing.Size(562, 548);
            this.Load += new System.EventHandler(this.TestCtrl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label labelQst;
        private System.Windows.Forms.TextBox txtQest;
        private TestForm.Answerctrl answerctrl1;
        private System.Windows.Forms.Label Quest;
        private System.Windows.Forms.Label QuestText;
    }
}
