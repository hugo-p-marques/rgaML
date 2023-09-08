namespace rgaML
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            loadButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(727, 321);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(12, 372);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(75, 23);
            loadButton.TabIndex = 1;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 345);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Load File";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(402, 343);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 3;
            label2.Text = "identification";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(516, 359);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 4;
            label3.Text = "---";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(402, 361);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 10);
            progressBar1.TabIndex = 5;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(402, 377);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(100, 10);
            progressBar2.TabIndex = 6;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(402, 393);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(100, 10);
            progressBar3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(516, 375);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 8;
            label4.Text = "---";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(516, 391);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 9;
            label5.Text = "---";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loadButton);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button loadButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private Label label4;
        private Label label5;
    }
}