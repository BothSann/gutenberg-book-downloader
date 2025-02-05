using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        private Dictionary<string, (string textUrl, string imageUrl)> bookUrls;

        public Form1()
        {
            InitializeComponent();
            InitializeBookUrls();
            LoadBooksManually();
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            btn_Download.Click += Btn_Download_Click;
        }

        private void InitializeBookUrls()
        {
            bookUrls = new Dictionary<string, (string textUrl, string imageUrl)>
            {
                { "The Key Note, by Clara Louise Burnham", ("ftp://gutenberg.pglaf.org/5/2/1/1/52110/52110.txt", "ftp://gutenberg.pglaf.org/5/2/1/1/52110/52110-h/images/cover.jpg") },
                { "EBook of Ama Stelaro, by Nuno Baena", ("ftp://gutenberg.pglaf.org/5/2/1/1/52111/52111-0.txt", "ftp://gutenberg.pglaf.org/5/2/1/1/52111/52111-h/images/cover.jpg") },
                { "Chats on Autographs, by Alexander Meyrick Broadley", ("ftp://gutenberg.pglaf.org/5/2/1/1/52112/52112-0.txt", "ftp://gutenberg.pglaf.org/5/2/1/1/52112/52112-h/images/cover.jpg") },
                { "Fifteen Days, by Mary Lowell Putnam", ("ftp://gutenberg.pglaf.org/5/2/1/1/52113/52113-8.txt", "ftp://gutenberg.pglaf.org/5/2/1/1/52113/52113-h/images/titlepage.jpg") },
                { "The History and Romance of Crime; Spanish Prisons, by Arthur Griffiths", ("ftp://gutenberg.pglaf.org/5/2/1/1/52114/52114-8.txt", "ftp://gutenberg.pglaf.org/5/2/1/1/52114/52114-h/images/cover.jpg") },
                { "Songs for All Seasons, by Cora C. Bass", ("ftp://gutenberg.pglaf.org/5/2/1/1/52115/52115-0.txt", "ftp://gutenberg.pglaf.org/5/2/1/1/52115/52115-h/images/cover.jpg") },
                { "The Canadian Druggist, by William J. Dyas", ("ftp://gutenberg.pglaf.org/5/2/1/1/52116/52116-0.txt", "ftp://gutenberg.pglaf.org/5/2/1/1/52116/52116-h/images/cover.jpg") },
                { "Collectivism and the Social Monarchy, by Joseph von Neupauer", ("https://gutenberg.pglaf.org/5/2/1/1/52117/52117-8.txt", "ftp://gutenberg.pglaf.org/5/2/1/1/52117/52117-h/images/cover.jpg") },
                { "The Wanderer Between Worlds, by Walter Flex", ("ftp://gutenberg.pglaf.org/5/2/1/1/52118/52118-0.txt", "ftp://gutenberg.pglaf.org/5/2/1/1/52118/52118-h/images/cover.jpg") },
                { "History of Greece, Volume 8 (of 12), by George Grote", ("ftp://gutenberg.pglaf.org/5/2/1/1/52119/52119-0.txt", "ftp://gutenberg.pglaf.org/5/2/1/1/52119/52119-h/images/cover.jpg") }
            };
        }

        private void LoadBooksManually()
        {
            foreach (var bookTitle in bookUrls.Keys)
            {
                listBox1.Items.Add(bookTitle);
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBook = listBox1.SelectedItem.ToString();
            if (bookUrls.TryGetValue(selectedBook, out var urls))
            {
                LoadBookDetailsFromFtp(urls.textUrl, urls.imageUrl);
            }
        }

        private void LoadBookDetailsFromFtp(string textUrl, string imageUrl)
        {
            FtpWebRequest textRequest = (FtpWebRequest)WebRequest.Create(textUrl);
            textRequest.Method = WebRequestMethods.Ftp.DownloadFile;

            try
            {
                using (FtpWebResponse textResponse = (FtpWebResponse)textRequest.GetResponse())
                using (StreamReader textReader = new StreamReader(textResponse.GetResponseStream()))
                {
                    string bookText = textReader.ReadToEnd();
                    richTextBox1.Text = bookText;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading book text: " + ex.Message);
            }

            FtpWebRequest imageRequest = (FtpWebRequest)WebRequest.Create(imageUrl);
            imageRequest.Method = WebRequestMethods.Ftp.DownloadFile;

            try
            {
                using (FtpWebResponse imageResponse = (FtpWebResponse)imageRequest.GetResponse())
                using (Stream imageStream = imageResponse.GetResponseStream())
                {
                    pictureBox1.Image = Image.FromStream(imageStream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading book cover: " + ex.Message);
            }
        }

        private void Btn_Download_Click(object sender, EventArgs e)
        {
            string selectedBook = listBox1.SelectedItem.ToString();
            if (bookUrls.TryGetValue(selectedBook, out var urls))
            {
                DownloadBookText(urls.textUrl, selectedBook);
            }
        }

        private void DownloadBookText(string textUrl, string bookName)
        {
            FtpWebRequest textRequest = (FtpWebRequest)WebRequest.Create(textUrl);
            textRequest.Method = WebRequestMethods.Ftp.DownloadFile;

            try
            {
                using (FtpWebResponse textResponse = (FtpWebResponse)textRequest.GetResponse())
                using (StreamReader textReader = new StreamReader(textResponse.GetResponseStream()))
                {
                    string bookText = textReader.ReadToEnd();
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string baseFileName = "Story";
                    string fileExtension = ".txt";
                    string filePath = Path.Combine(desktopPath, baseFileName + fileExtension);
                    int fileIndex = 1;

                    if (!Directory.Exists(desktopPath))
                    {
                        Directory.CreateDirectory(desktopPath);
                    }

                    while (File.Exists(filePath))
                    {
                        filePath = Path.Combine(desktopPath, $"{baseFileName}{fileIndex}{fileExtension}");
                        fileIndex++;
                    }

                    File.WriteAllText(filePath, bookText);
                    Label_DownloadBook.Text = "Download complete!";

                    MessageBox.Show($"Download complete! The file has been saved to: {filePath}", "Download Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error downloading book text: " + ex.Message);
            }
        }
    }
}



