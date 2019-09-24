namespace QUT_MCQ
{
    partial class Form1
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
            this.log = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectedFile = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.log.Location = new System.Drawing.Point(64, 29);
            this.log.Multiline = true;
            this.log.Name = "textBox1";
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log.Size = new System.Drawing.Size(626, 283);
            this.log.TabIndex = 0;
            // 
            // startBtn
            // 
            this.startBtn.Enabled = false;
            this.startBtn.Location = new System.Drawing.Point(63, 344);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(627, 23);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start Generating";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log";
            // 
            // selectedFile
            // 
            this.selectedFile.Location = new System.Drawing.Point(64, 318);
            this.selectedFile.Name = "selectedFile";
            this.selectedFile.ReadOnly = true;
            this.selectedFile.Size = new System.Drawing.Size(315, 20);
            this.selectedFile.TabIndex = 4;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(385, 318);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(305, 20);
            this.browseBtn.TabIndex = 5;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(64, 374);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(626, 23);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Exit Program";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text files | *.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 431);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.selectedFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.log);
            this.Name = "Form1";
            this.Text = "QUT MCQ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox selectedFile;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

