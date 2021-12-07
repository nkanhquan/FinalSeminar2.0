namespace TestForm
{
    partial class Testingform
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
            TestForm.MulQuestion mulQuestion1 = new TestForm.MulQuestion();
            this.btStart = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btBack = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btHighlight = new System.Windows.Forms.Button();
            this.Testcodelb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.testCtrl1 = new TestForm.TestCtrl();
            this.clockuserCtrl = new TestForm.UserControl2();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStart.Location = new System.Drawing.Point(726, 90);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(210, 58);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(726, 251);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(744, 579);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyUp);
            // 
            // btBack
            // 
            this.btBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBack.Location = new System.Drawing.Point(726, 189);
            this.btBack.Margin = new System.Windows.Forms.Padding(10);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(98, 49);
            this.btBack.TabIndex = 5;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btNext
            // 
            this.btNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btNext.Location = new System.Drawing.Point(844, 189);
            this.btNext.Margin = new System.Windows.Forms.Padding(10);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(98, 49);
            this.btNext.TabIndex = 5;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSubmit.Location = new System.Drawing.Point(955, 90);
            this.btSubmit.Margin = new System.Windows.Forms.Padding(10);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(210, 58);
            this.btSubmit.TabIndex = 5;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(1506, 251);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(140, 579);
            this.listBox2.TabIndex = 6;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btHighlight
            // 
            this.btHighlight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btHighlight.Location = new System.Drawing.Point(955, 189);
            this.btHighlight.Name = "btHighlight";
            this.btHighlight.Size = new System.Drawing.Size(98, 48);
            this.btHighlight.TabIndex = 8;
            this.btHighlight.Text = "Highlight";
            this.btHighlight.UseVisualStyleBackColor = true;
            this.btHighlight.Click += new System.EventHandler(this.btHighlight_Click);
            // 
            // Testcodelb
            // 
            this.Testcodelb.AutoSize = true;
            this.Testcodelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Testcodelb.Location = new System.Drawing.Point(139, 218);
            this.Testcodelb.Name = "Testcodelb";
            this.Testcodelb.Size = new System.Drawing.Size(155, 37);
            this.Testcodelb.TabIndex = 9;
            this.Testcodelb.Text = "TestCode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(139, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(142, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(5, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(5, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 37);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID:";
            // 
            // testCtrl1
            // 
            this.testCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            mulQuestion1.Ans = null;
            mulQuestion1.CorrectAnswer = null;
            mulQuestion1.Ques = null;
            mulQuestion1.Topic = null;
            this.testCtrl1.Content = mulQuestion1;
            this.testCtrl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.testCtrl1.Location = new System.Drawing.Point(12, 258);
            this.testCtrl1.Name = "testCtrl1";
            this.testCtrl1.Question = "";
            this.testCtrl1.Size = new System.Drawing.Size(1134, 577);
            this.testCtrl1.TabIndex = 3;
            // 
            // clockuserCtrl
            // 
            this.clockuserCtrl._mm = 0;
            this.clockuserCtrl._ss = 0;
            this.clockuserCtrl.Location = new System.Drawing.Point(-15, 9);
            this.clockuserCtrl.Margin = new System.Windows.Forms.Padding(0);
            this.clockuserCtrl.Name = "clockuserCtrl";
            this.clockuserCtrl.Size = new System.Drawing.Size(679, 106);
            this.clockuserCtrl.TabIndex = 2;
            // 
            // Testingform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1658, 855);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Testcodelb);
            this.Controls.Add(this.btHighlight);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.testCtrl1);
            this.Controls.Add(this.clockuserCtrl);
            this.Controls.Add(this.btStart);
            this.Name = "Testingform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Testingform_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btStart;
        private TestForm.UserControl2 clockuserCtrl;
        private TestCtrl testCtrl1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btHighlight;
        private System.Windows.Forms.Label Testcodelb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

