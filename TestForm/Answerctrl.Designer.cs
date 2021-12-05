namespace TestForm
{
    partial class Answerctrl
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
            this.radioAns = new System.Windows.Forms.RadioButton();
            this.lbAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioAns
            // 
            this.radioAns.AutoSize = true;
            this.radioAns.Location = new System.Drawing.Point(82, -1);
            this.radioAns.Name = "radioAns";
            this.radioAns.Size = new System.Drawing.Size(113, 24);
            this.radioAns.TabIndex = 3;
            this.radioAns.TabStop = true;
            this.radioAns.Text = "Answertext";
            this.radioAns.UseVisualStyleBackColor = true;
            this.radioAns.CheckedChanged += new System.EventHandler(this.radioAns_CheckedChanged);
            // 
            // lbAns
            // 
            this.lbAns.AutoSize = true;
            this.lbAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAns.Location = new System.Drawing.Point(2, 3);
            this.lbAns.Margin = new System.Windows.Forms.Padding(0);
            this.lbAns.Name = "lbAns";
            this.lbAns.Size = new System.Drawing.Size(62, 20);
            this.lbAns.TabIndex = 2;
            this.lbAns.Text = "Answer";
            // 
            // Answerctrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioAns);
            this.Controls.Add(this.lbAns);
            this.Name = "Answerctrl";
            this.Size = new System.Drawing.Size(431, 341);
            this.Load += new System.EventHandler(this.Answerctrl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioAns;
        private System.Windows.Forms.Label lbAns;
    }
}
