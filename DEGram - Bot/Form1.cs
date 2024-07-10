using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DEGram___Bot
{
    public partial class Form1 : Form
    {
        App app = new App();
        public Form1()
        {
            InitializeComponent();
            app.refreshAccounts(accountsComboBox);
            app.startUp(accountsComboBox, hashtagCombobox, profileCombobox, adTextCombobox, selectPictureCombobox, previewPhotoPictureBox);
        }

        private void hesapeklebtn_Click(object sender, EventArgs e)
        {
            app.saveAccounts(accountsComboBox, kullaniciadikayitTxtBox, sifrekayitTxtBox);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            app.loginToAccount(accountsComboBox);
        }

        private void hashtagSaveBtn_Click(object sender, EventArgs e)
        {
            app.saveInputs(hashtagCombobox, "tag", hashtagCombobox, profileCombobox, adTextCombobox, selectPictureCombobox, previewPhotoPictureBox);
        }

        private void usernameSaveBtn_Click(object sender, EventArgs e)
        {
            app.saveInputs(profileCombobox, "userName", hashtagCombobox, profileCombobox, adTextCombobox, selectPictureCombobox, previewPhotoPictureBox);
        }

        private void adTextSaveBtn_Click(object sender, EventArgs e)
        {
            app.saveInputs(adTextCombobox, "adText", hashtagCombobox, profileCombobox, adTextCombobox, selectPictureCombobox, previewPhotoPictureBox);
        }

        private void selectPictureBtn_Click(object sender, EventArgs e)
        {
            app.selectPhoto();
            app.refreshCombobox(hashtagCombobox, profileCombobox, adTextCombobox, selectPictureCombobox, previewPhotoPictureBox);
        }

        private void startHashtagBtn_Click(object sender, EventArgs e)
        {
            app.hashtagBot(accountsComboBox, hashtagCombobox, adTextCombobox , postCountNumUpDown, cooldownNumUpDown);
        }

        private void startProfileBtn_Click(object sender, EventArgs e)
        {
            app.profileBot(accountsComboBox, profileCombobox, postCountNumUpDown, cooldownNumUpDown);
        }

        private void startSharePostBtn_Click(object sender, EventArgs e)
        {
            app.sharePost(accountsComboBox, adTextCombobox);
        }

        private void selectPictureCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            app.getPhotoPath(selectPictureCombobox, previewPhotoPictureBox);
        }
    }

    class App
    {
        string baseURL = "https://instagram.com";
        string hashtagURL = "https://www.instagram.com/explore/tags/";
        string profileURL = "https://www.instagram.com/";
        string postURL = "https://www.instagram.com/p/";
        string reelsURL = "https://www.instagram.com/reels/";

        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=data.accdb";
        string photoPath = "";

        public static ChromeDriverService service = ChromeDriverService.CreateDefaultService();
        public static ChromeDriver driver;

        public bool isLogged = false;
        public void startUp(System.Windows.Forms.ComboBox accountsComboBox, System.Windows.Forms.ComboBox hashtagCombobox, System.Windows.Forms.ComboBox userNameCombobox, System.Windows.Forms.ComboBox adTextCombobox, System.Windows.Forms.ComboBox photoCombobox, System.Windows.Forms.PictureBox previewPhotoPictureBox)
        {
            service.HideCommandPromptWindow = true;
            driver = new ChromeDriver(service);

            refreshAccounts(accountsComboBox);
            refreshCombobox(hashtagCombobox, userNameCombobox, adTextCombobox, photoCombobox, previewPhotoPictureBox);
        }
        public void saveAccounts(System.Windows.Forms.ComboBox accountsComboBox, System.Windows.Forms.TextBox kullaniciadikayitTxtBox, System.Windows.Forms.TextBox sifrekayitTxtBox)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO sayfa1 (kullaniciadi, sifre) VALUES (value1, value2)";
                    OleDbCommand command = new OleDbCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@value1", kullaniciadikayitTxtBox.Text);
                    command.Parameters.AddWithValue("@value2", sifrekayitTxtBox.Text);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Veriler başarıyla eklendi.");
                    refreshAccounts(accountsComboBox);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        public void saveInputs(System.Windows.Forms.ComboBox comboBox, string column, System.Windows.Forms.ComboBox hashtagCombobox, System.Windows.Forms.ComboBox userNameCombobox, System.Windows.Forms.ComboBox adTextCombobox, System.Windows.Forms.ComboBox photoCombobox, System.Windows.Forms.PictureBox photoPictureBox)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO sayfa2 (" + column + ") VALUES (value1)";
                    OleDbCommand command = new OleDbCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@value1", comboBox.Text);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Veriler başarıyla eklendi.");

                    refreshCombobox(hashtagCombobox, userNameCombobox, adTextCombobox, photoCombobox, photoPictureBox);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        public void refreshAccounts(System.Windows.Forms.ComboBox accountsComboBox)
        {
            string selectQuery = "SELECT kullaniciadi FROM [sayfa1]";
            List<string> kullaniciAdlari = new List<string>();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(selectQuery, connection);
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        kullaniciAdlari.Add(reader["kullaniciadi"].ToString());
                    }
                    accountsComboBox.DataSource = kullaniciAdlari;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        public void refreshCombobox(System.Windows.Forms.ComboBox hashtagCombobox, System.Windows.Forms.ComboBox userNameCombobox, System.Windows.Forms.ComboBox adTextCombobox, System.Windows.Forms.ComboBox photoCombobox, System.Windows.Forms.PictureBox photoPictureBox)
        {
            string selectQuery = "SELECT tag, userName, adText, photoName FROM [sayfa2]";
            List<string> tagList = new List<string>();
            List<string> userNameList = new List<string>();
            List<string> adTextList = new List<string>();
            List<string> photoNameList = new List<string>();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(selectQuery, connection);
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (!DBNull.Value.Equals(reader["tag"]) && !string.IsNullOrWhiteSpace(reader["tag"].ToString()))
                        {
                            tagList.Add(reader["tag"].ToString());
                        }
                        if (!DBNull.Value.Equals(reader["userName"]) && !string.IsNullOrWhiteSpace(reader["userName"].ToString()))
                        {
                            userNameList.Add(reader["userName"].ToString());
                        }
                        if (!DBNull.Value.Equals(reader["adText"]) && !string.IsNullOrWhiteSpace(reader["adText"].ToString()))
                        {
                            adTextList.Add(reader["adText"].ToString());
                        }
                        if (!DBNull.Value.Equals(reader["photoName"]) && !string.IsNullOrWhiteSpace(reader["photoName"].ToString()))
                        {
                            photoNameList.Add(reader["photoName"].ToString());
                        }
                    }
                    hashtagCombobox.DataSource = tagList;
                    userNameCombobox.DataSource = userNameList;
                    adTextCombobox.DataSource = adTextList;
                    photoCombobox.DataSource = photoNameList;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        public void selectPhoto()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg";
            dialog.Title = "Select a photo";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string photoName = Path.GetFileNameWithoutExtension(dialog.FileName);
                string photoPath = dialog.FileName;
                string insertQuery = "INSERT INTO [sayfa2] (photoName, photoPath) VALUES (@photoName, @photoPath)";
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand(insertQuery, connection);
                        command.Parameters.AddWithValue("@photoName", photoName);
                        command.Parameters.AddWithValue("@photoPath", photoPath);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Photo added successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        public void getPhotoPath(System.Windows.Forms.ComboBox PhotoNameCombobox, System.Windows.Forms.PictureBox pictureBox)
        {
            string selectedPhotoName = PhotoNameCombobox.SelectedItem.ToString();

            string query = "SELECT photoPath FROM sayfa2 WHERE photoName = @photoName";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@photoName", selectedPhotoName);
                connection.Open();
                photoPath = command.ExecuteScalar().ToString();
            }
            pictureBox.ImageLocation = photoPath;
        }

        public void loginToAccount(System.Windows.Forms.ComboBox accountsComboBox)
        {
            if (isLogged == false)
            {
                string passQuery = "SELECT sifre FROM [sayfa1] WHERE kullaniciadi=" + accountsComboBox.Text;
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        string usernameXpath = "/html/body/div[2]/div/div/div[1]/div/div/div/div[1]/section/main/article/div[2]/div[1]/div[2]/form/div/div[1]/div/label/input";
                        string passwordXpath = "/html/body/div[2]/div/div/div[1]/div/div/div/div[1]/section/main/article/div[2]/div[1]/div[2]/form/div/div[2]/div/label/input";
                        string loginBtnXpath = "/html/body/div[2]/div/div/div[1]/div/div/div/div[1]/section/main/article/div[2]/div[1]/div[2]/form/div/div[3]/button";

                        connection.Open();
                        string selectQuery = "SELECT sifre FROM sayfa1 WHERE kullaniciadi = @value1";
                        OleDbCommand command = new OleDbCommand(selectQuery, connection);
                        command.Parameters.AddWithValue("@value1", accountsComboBox.SelectedItem.ToString());
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string sifre = reader.GetString(0);
                                service.HideCommandPromptWindow = true;

                                driver.Navigate().GoToUrl(baseURL);

                                Thread.Sleep(5000);
                                IWebElement usernameElement = driver.FindElement(By.XPath(usernameXpath));
                                IWebElement passwordElement = driver.FindElement(By.XPath(passwordXpath));
                                usernameElement.SendKeys(accountsComboBox.Text);
                                passwordElement.SendKeys(sifre);
                                Thread.Sleep(1000);
                                IWebElement loginBtnElement = driver.FindElement(By.XPath(loginBtnXpath));
                                loginBtnElement.Click();
                                Thread.Sleep(5000);

                                isLogged = true;

                                //IWebElement noticeSkipElement = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div/div/div[1]/div[1]/div[2]/section/main/div/div/div/div/div"));
                                //noticeSkipElement.Click();
                                //Thread.Sleep(3000);
                                //IWebElement notNowElement = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/div/div[2]/div/div/div/div/div[2]/div/div/div[3]/button[2]"));
                                //notNowElement.Click();
                                //Thread.Sleep(3000);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else if (isLogged == true)
            {
                MessageBox.Show("Zaten giriş yaptınız !");
            }

        }

        public void hashtagBot(System.Windows.Forms.ComboBox accountsComboBox, System.Windows.Forms.ComboBox tagCombobox, System.Windows.Forms.ComboBox adTextCombobox, System.Windows.Forms.NumericUpDown numericUpDown, System.Windows.Forms.NumericUpDown cooldownNumUpDown)
        {
            int rowCount;
            int columnCount;
            int i = 1;
            int j = 1;
            int cooldown = Convert.ToInt32(cooldownNumUpDown.Value) * 1000;
            List<string> postList = new List<string>();

            string scrollDownJS = "window.scrollTo(0, document.body.scrollHeight)";
            string commentLineXpath = "/html/body/div[2]/div/div/div[1]/div/div/div/div[1]/div[1]/div[2]/section/main/div[1]/div[1]/article/div/div[2]/div/div[2]/section[3]/div/form/div/textarea";
            string postCommentXpath = "/html/body/div[2]/div/div/div[1]/div/div/div/div[1]/div[1]/div[2]/section/main/div[1]/div[1]/article/div/div[2]/div/div[2]/section[3]/div/form/div/div[2]/div";

            columnCount = Convert.ToInt32(numericUpDown.Value) % 3;
            rowCount = Convert.ToInt32(numericUpDown.Value) / 3;

            if (isLogged == false)
            {
                loginToAccount(accountsComboBox);
            }
            driver.Navigate().GoToUrl(hashtagURL + tagCombobox.Text);
            Thread.Sleep(4000);

            for (int z = 0; z < Convert.ToInt32(numericUpDown.Value) / 10; z++)
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript(scrollDownJS);
                Thread.Sleep(2000);
            }

            for (i = 1; i < rowCount + 1; i++)
            {
                for (j = 1; j < 4; j++)
                {
                    string postXpath = "/html/body/div[2]/div/div/div[1]/div/div/div/div[1]/div[1]/div[2]/section/main/article/div[2]/div/div[" + i + "]/div[" + j + "]/a";
                    IWebElement post = driver.FindElement(By.XPath(postXpath));
                    postList.Add(post.GetAttribute("href"));
                }
                j = 1;
            }

            for (int y = 0; y < postList.Count; y++)
            {
                driver.Navigate().GoToUrl(postList[y]);
                Thread.Sleep(3000);
                IWebElement commentLineElement = null;
                IWebElement postCommentElement = null;

                try
                {
                    commentLineElement = driver.FindElement(By.XPath(commentLineXpath));
                    commentLineElement.SendKeys(adTextCombobox.Text);
                }
                catch (OpenQA.Selenium.StaleElementReferenceException ex)
                {
                    commentLineElement = driver.FindElement(By.XPath(commentLineXpath));
                    commentLineElement.SendKeys(adTextCombobox.Text);
                }
                try
                {
                    postCommentElement = driver.FindElement(By.XPath(postCommentXpath));
                    postCommentElement.Click();
                }
                catch (OpenQA.Selenium.StaleElementReferenceException ex)
                {
                    postCommentElement = driver.FindElement(By.XPath(postCommentXpath));
                    postCommentElement.Click();
                }
                Thread.Sleep(cooldown);
            }
        }

        public void profileBot(System.Windows.Forms.ComboBox accountsComboBox, System.Windows.Forms.ComboBox profileCombobox, System.Windows.Forms.NumericUpDown numericUpDown, System.Windows.Forms.NumericUpDown cooldownNumUpDown)
        {
            List<string> postList = new List<string>();
            int rowCount;
            int i = 1;
            int j = 1;
            int cooldown = Convert.ToInt32(cooldownNumUpDown.Value) * 1000;

            string scrollDownJS = "window.scrollTo(0, document.body.scrollHeight)";
            string commentLineXpath = "/html/body/div[2]/div/div/div[1]/div/div/div/div[1]/div[1]/div[2]/section/main/div[1]/div[1]/article/div/div[2]/div/div[2]/section[3]/div/form/div/textarea";
            string postCommentXpath = "/html/body/div[2]/div/div/div[1]/div/div/div/div[1]/div[1]/div[2]/section/main/div[1]/div[1]/article/div/div[2]/div/div[2]/section[3]/div/form/div/div[2]/div";

            rowCount = Convert.ToInt32(numericUpDown.Value) / 3;

            if (isLogged == false)
            {
                loginToAccount(accountsComboBox);
            }
            driver.Navigate().GoToUrl(profileURL + profileCombobox.Text);
            Thread.Sleep(4000);

            for (int z = 0; z < Convert.ToInt32(numericUpDown.Value) / 5; z++)
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript(scrollDownJS);
                Thread.Sleep(2000);
            }

            for (i = 1; i < rowCount + 1; i++)
            {
                for (j = 1; j < 4; j++)
                {
                    string postXpath = "/html/body/div[2]/div/div/div[1]/div/div/div/div[1]/div[1]/div[2]/div[2]/section/main/div/div[3]/article/div[1]/div/div[" + i + "]/div[" + j + "]/a";
                    IWebElement post = driver.FindElement(By.XPath(postXpath));
                    postList.Add(post.GetAttribute("href"));
                }
                j = 1;
            }

            for (int y = 0; y < postList.Count; y++)
            {
                driver.Navigate().GoToUrl(postList[y]);
                Thread.Sleep(3000);
                IWebElement commentLineElement = null;
                IWebElement postCommentElement = null;
                try
                {
                    commentLineElement = driver.FindElement(By.XPath(commentLineXpath));
                    commentLineElement.SendKeys(".");
                }
                catch (OpenQA.Selenium.StaleElementReferenceException ex)
                {
                    commentLineElement = driver.FindElement(By.XPath(commentLineXpath));
                    commentLineElement.SendKeys(".");
                }
                try
                {
                    postCommentElement = driver.FindElement(By.XPath(postCommentXpath));
                    postCommentElement.Click();
                }
                catch (OpenQA.Selenium.StaleElementReferenceException ex)
                {
                    postCommentElement = driver.FindElement(By.XPath(postCommentXpath));
                    postCommentElement.Click();
                }
                Thread.Sleep(cooldown);
            }
        }

        public void sharePost(System.Windows.Forms.ComboBox accountsComboBox, System.Windows.Forms.ComboBox adTextCombobox)
        {
            if (isLogged == false)
            {
                loginToAccount(accountsComboBox);
            }
            driver.Navigate().GoToUrl(baseURL);
            Thread.Sleep(4000);

            string reminderSkipXpath = "/html/body/div[2]/div/div/div[2]/div/div/div[1]/div/div[2]/div/div/div/div/div[2]/div/div/div[3]/button[2]";
            string uploadPhotoBtnXpath = "/html/body/div[2]/div/div/div[1]/div/div/div/div[1]/div[1]/div[1]/div/div/div/div/div[2]/div[7]/div/div/a";
            string pastePhotoXpath = "/html/body/div[2]/div/div/div[2]/div/div/div[1]/div/div[3]/div/div/div/div/div[2]/div/div/div/div[2]/div[1]/form/input";
            string next1 = "/html/body/div[2]/div/div/div[2]/div/div/div[1]/div/div[3]/div/div/div/div/div[2]/div/div/div/div[1]/div/div/div[3]/div/div";
            string next2 = "/html/body/div[2]/div/div/div[2]/div/div/div[1]/div/div[3]/div/div/div/div/div[2]/div/div/div/div[1]/div/div/div[3]/div/div";
            string descriptionXpath = "/html/body/div[2]/div/div/div[2]/div/div/div[1]/div/div[3]/div/div/div/div/div[2]/div/div/div/div[2]/div[2]/div/div/div/div[2]/div[1]/textarea";
            string shareBtnXpath = "/html/body/div[2]/div/div/div[2]/div/div/div[1]/div/div[3]/div/div/div/div/div[2]/div/div/div/div[1]/div/div/div[3]/div/div";

            IWebElement reminderSkipElement = driver.FindElement(By.XPath(reminderSkipXpath));
            reminderSkipElement.Click();
            Thread.Sleep(800);

            IWebElement uploadPhotoBtnElement = driver.FindElement(By.XPath(uploadPhotoBtnXpath));
            uploadPhotoBtnElement.Click();
            Thread.Sleep(1500);

            IWebElement pastePhotoElement = driver.FindElement(By.XPath(pastePhotoXpath));
            pastePhotoElement.SendKeys(photoPath);
            Thread.Sleep(2500);

            IWebElement next1Element = driver.FindElement(By.XPath(next1));
            next1Element.Click();
            Thread.Sleep(2500);

            IWebElement next2Element = driver.FindElement(By.XPath(next2));
            next2Element.Click();
            Thread.Sleep(2500);

            IWebElement descriptionElement = driver.FindElement(By.XPath(descriptionXpath));
            descriptionElement.SendKeys(adTextCombobox.Text);
            Thread.Sleep(500);

            IWebElement shareBtnElement = driver.FindElement(By.XPath(shareBtnXpath));
            shareBtnElement.Click();
        }
    }
}
