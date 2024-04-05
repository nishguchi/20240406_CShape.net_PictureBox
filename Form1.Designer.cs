namespace WinFormsApp2
{
    partial class PictureBoxMain
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
            components = new System.ComponentModel.Container();
            pictureBox = new PictureBox();
            buttonShow = new Button();
            textBoxFile = new TextBox();
            folderBrowserDialogImage = new FolderBrowserDialog();
            listBoxFile = new ListBox();
            timerImage = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(12, 309);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(552, 379);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(443, 4);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(131, 36);
            buttonShow.TabIndex = 1;
            buttonShow.Text = "参照";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // textBoxFile
            // 
            textBoxFile.Location = new Point(12, 12);
            textBoxFile.Name = "textBoxFile";
            textBoxFile.ReadOnly = true;
            textBoxFile.Size = new Size(378, 23);
            textBoxFile.TabIndex = 2;
            textBoxFile.Text = "C:\\Users\\gugoo\\Downloads\\valentineIMGL7077_TP_V.jpg";
            // 
            // listBoxFile
            // 
            listBoxFile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxFile.FormattingEnabled = true;
            listBoxFile.ItemHeight = 15;
            listBoxFile.Location = new Point(12, 93);
            listBoxFile.Name = "listBoxFile";
            listBoxFile.Size = new Size(552, 199);
            listBoxFile.TabIndex = 3;
            listBoxFile.SelectedIndexChanged += listBoxFile_SelectedIndexChanged;
            // 
            // timerImage
            // 
            timerImage.Interval = 1000;
            timerImage.Tick += timerImage_Tick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(299, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(91, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 54);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 5;
            label1.Text = "画像表示時間";
            // 
            // PictureBoxMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 700);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(listBoxFile);
            Controls.Add(textBoxFile);
            Controls.Add(buttonShow);
            Controls.Add(pictureBox);
            Name = "PictureBoxMain";
            Text = "画像表示";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private Button buttonShow;
        private TextBox textBoxFile;
        private FolderBrowserDialog folderBrowserDialogImage;
        private ListBox listBoxFile;
        private System.Windows.Forms.Timer timerImage;
        private TextBox textBox1;
        private Label label1;
    }
}
