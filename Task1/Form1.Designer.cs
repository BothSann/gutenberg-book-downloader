namespace Task1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Label_OurBooks = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_Download = new System.Windows.Forms.Button();
            this.Label_DownloadBook = new System.Windows.Forms.Label();
            this.Label_BookCover = new System.Windows.Forms.Label();
            this.Label_ReadBook = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(513, 134);
            this.listBox1.TabIndex = 0;
            // 
            // Label_OurBooks
            // 
            this.Label_OurBooks.AutoSize = true;
            this.Label_OurBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_OurBooks.ForeColor = System.Drawing.Color.Black;
            this.Label_OurBooks.Location = new System.Drawing.Point(219, 24);
            this.Label_OurBooks.Name = "Label_OurBooks";
            this.Label_OurBooks.Size = new System.Drawing.Size(88, 21);
            this.Label_OurBooks.TabIndex = 1;
            this.Label_OurBooks.Text = "Our Books";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(544, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 238);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(513, 200);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(694, 414);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(75, 23);
            this.btn_Download.TabIndex = 4;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            // 
            // Label_DownloadBook
            // 
            this.Label_DownloadBook.AutoSize = true;
            this.Label_DownloadBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DownloadBook.Location = new System.Drawing.Point(570, 418);
            this.Label_DownloadBook.Name = "Label_DownloadBook";
            this.Label_DownloadBook.Size = new System.Drawing.Size(104, 15);
            this.Label_DownloadBook.TabIndex = 5;
            this.Label_DownloadBook.Text = "Download Book->";
            // 
            // Label_BookCover
            // 
            this.Label_BookCover.AutoSize = true;
            this.Label_BookCover.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BookCover.Location = new System.Drawing.Point(620, 24);
            this.Label_BookCover.Name = "Label_BookCover";
            this.Label_BookCover.Size = new System.Drawing.Size(97, 21);
            this.Label_BookCover.TabIndex = 6;
            this.Label_BookCover.Text = "Book Cover";
            // 
            // Label_ReadBook
            // 
            this.Label_ReadBook.AutoSize = true;
            this.Label_ReadBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ReadBook.Location = new System.Drawing.Point(202, 204);
            this.Label_ReadBook.Name = "Label_ReadBook";
            this.Label_ReadBook.Size = new System.Drawing.Size(131, 21);
            this.Label_ReadBook.TabIndex = 7;
            this.Label_ReadBook.Text = "Read Book Here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_ReadBook);
            this.Controls.Add(this.Label_BookCover);
            this.Controls.Add(this.Label_DownloadBook);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label_OurBooks);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Label_OurBooks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.Label Label_DownloadBook;
        private System.Windows.Forms.Label Label_BookCover;
        private System.Windows.Forms.Label Label_ReadBook;
    }
}

