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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Testingform));
            TestForm.MulQuestion mulQuestion1 = new TestForm.MulQuestion();
            this.btStart = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btBack = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.testCtrl1 = new TestForm.TestCtrl();
            this.clockuserCtrl = new TestForm.UserControl2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStart.Location = new System.Drawing.Point(755, 45);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(334, 58);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(755, 241);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(620, 404);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btBack
            // 
            this.btBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBack.Location = new System.Drawing.Point(755, 131);
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
            this.btNext.Location = new System.Drawing.Point(873, 131);
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
            this.btSubmit.Location = new System.Drawing.Point(991, 131);
            this.btSubmit.Margin = new System.Windows.Forms.Padding(10);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(98, 49);
            this.btSubmit.TabIndex = 5;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(1424, 241);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(140, 404);
            this.listBox2.TabIndex = 6;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1468, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 38);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Star-icon.png");
            // 
            // testCtrl1
            // 
            this.testCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            mulQuestion1.Ans = null;
            mulQuestion1.CorrectAnswer = null;
            mulQuestion1.Ques = null;
            mulQuestion1.Topic = null;
            this.testCtrl1.Content = mulQuestion1;
            this.testCtrl1.Location = new System.Drawing.Point(98, 239);
            this.testCtrl1.Name = "testCtrl1";
            this.testCtrl1.Question = "";
            this.testCtrl1.Size = new System.Drawing.Size(586, 558);
            this.testCtrl1.TabIndex = 3;
            // 
            // clockuserCtrl
            // 
            this.clockuserCtrl._mm = 0;
            this.clockuserCtrl._ss = 0;
            this.clockuserCtrl.Location = new System.Drawing.Point(-139, -9);
            this.clockuserCtrl.Margin = new System.Windows.Forms.Padding(0);
            this.clockuserCtrl.Name = "clockuserCtrl";
            this.clockuserCtrl.Size = new System.Drawing.Size(670, 245);
            this.clockuserCtrl.TabIndex = 2;
            // 
            // Testingform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 794);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.testCtrl1);
            this.Controls.Add(this.clockuserCtrl);
            this.Controls.Add(this.btStart);
            this.Name = "Testingform";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

