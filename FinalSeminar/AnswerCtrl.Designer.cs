
namespace FinalSeminar
{
    partial class AnswerCtrl
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
            this.lbAns = new System.Windows.Forms.Label();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAns
            // 
            this.lbAns.AutoSize = true;
            this.lbAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAns.Location = new System.Drawing.Point(0, 3);
            this.lbAns.Margin = new System.Windows.Forms.Padding(0);
            this.lbAns.Name = "lbAns";
            this.lbAns.Size = new System.Drawing.Size(54, 17);
            this.lbAns.TabIndex = 0;
            this.lbAns.Text = "Answer";
            // 
            // txtAns
            // 
            this.txtAns.Location = new System.Drawing.Point(57, 0);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(390, 22);
            this.txtAns.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(453, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(20, 20);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AnswerCtrl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.lbAns);
            this.Name = "AnswerCtrl";
            this.Size = new System.Drawing.Size(476, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAns;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.Button btnDelete;
    }
}
