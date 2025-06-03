using System.Net;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Recipe_App
{
    public partial class MainForm : Form
    {
        private Color fileStatusColor = Color.White;
        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ManageThemes.darkMode = true;
            ManageThemes.ApplyTheme(this);
            FileStatus();
        }
        private void FileStatus()
        {
            string desktopFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopFilePath, "favorite_recipis.txt");
            string statusImageURL = string.Empty;

            if (File.Exists(filePath))
            {
                ButtonYes.Visible = false;
                ButtonNo.Visible = false;

                string favoriteRecipis = File.ReadAllText(filePath).Trim();
                if (string.IsNullOrEmpty(favoriteRecipis))
                {
                    LableForFileInfo.ForeColor = Color.Orange;
                    statusImageURL = "https://img.icons8.com/emoji/48/warning-emoji.png";
                    LableForFileInfo.Text = "favorite_recipis.txt found, no info inside file";
                    fileStatusColor = Color.Orange;
                }
                else
                {
                    LableForFileInfo.ForeColor = Color.Green;
                    statusImageURL = "https://img.icons8.com/color/48/ok--v1.png";
                    LableForFileInfo.Text = "favorite_recipis.txt found and ready";
                    fileStatusColor = Color.Green;
                }
            }
            else
            {
                LableForFileInfo.ForeColor = Color.Red;
                statusImageURL = "https://img.icons8.com/emoji/48/cross-mark-emoji.png";
                LableForFileInfo.Text = "No file found. Would you like to create one";
                fileStatusColor = Color.Red;

                ButtonYes.Visible = true;
                ButtonNo.Visible = true;
            }
            SearchForImage(statusImageURL);
        }
        private void SearchForImage(string URL)
        {
            try
            {
                var request = WebRequest.Create(URL);
                using (var responce = request.GetResponse())
                using (var stream = responce.GetResponseStream())
                    PictureBoxFileIcon.Image = System.Drawing.Bitmap.FromStream(stream);
            }
            catch
            {
                PictureBoxFileIcon.Image = null;
            }
        }

        private void PictureBoxFileIcon_Click(object sender, EventArgs e)
        {

        }

        private void FavoriteRecipeButton_Click(object sender, EventArgs e)
        {
            string desktopFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopFilePath, "favorite_recipis.txt");
            if (File.Exists(filePath))
            {
                this.Hide();
                Favorite_Recipes favorites = new Favorite_Recipes();
                favorites.ShowDialog();
                this.Show();
                FileStatus();
            }
            else
            {
                MessageBox.Show("No File found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void LableForFileInfo_Click(object sender, EventArgs e)
        {

        }

        private async void ButtonYes_Click(object sender, EventArgs e)
        {
            PictureBoxFileIcon.Image = null;
            ButtonYes.Visible = false;
            ButtonNo.Visible = false;

            string desktopFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopFilePath, "favorite_recipis.txt");
            File.Create(filePath).Close();
            LableForFileInfo.ForeColor = Color.Green;
            LableForFileInfo.Text = "File has been created on the desktop";
            SearchForImage("https://img.icons8.com/color/48/ok--v1.png");

            await Task.Delay(1500);
            LableForFileInfo.ForeColor = Color.Orange;
            LableForFileInfo.Text = "favorite_recipis.txt created, no info inside file";
            SearchForImage("https://img.icons8.com/emoji/48/warning-emoji.png");
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            LableForFileInfo.Text = "File missing. Favorite funktion unavelable";

            ButtonYes.Visible = false;
            ButtonNo.Visible = false;
        }

        private void ButtonLightDarkMode_Click(object sender, EventArgs e)
        {
            ManageThemes.darkMode = !ManageThemes.darkMode;
            ManageThemes.ApplyTheme(this);

            ButtonLightDarkMode.Text = ManageThemes.darkMode ? "☼ Light Mode" : "☾ Dark Mode";
            LableForFileInfo.ForeColor = fileStatusColor;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search_Engine searchForm = new Search_Engine();
            searchForm.ShowDialog();
            this.Show();
            FileStatus();
        }
    }
}
