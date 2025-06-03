using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe_App
{
    public partial class Found_Recipe : Form
    {
        private string Title;
        private string imigeURL;
        private string ingridients;
        private string instrictons;
        public Found_Recipe(string title, string imageURL, string ingridients, string instrictions)
        {
            InitializeComponent();
            this.Title = title;
            this.imigeURL = imageURL;
            this.ingridients = ingridients;
            this.instrictons = instrictions;

            Display();
        }
        string CleanHTMLGarbage(string html)
        {
            return Regex.Replace(html, "<.*?>", "").Trim();
        }
        private void Display()
        {
            LabelRecipeTitle.Text = Title;
            RichTextBoxForIngridients.Text = ingridients;
            RIchTextBoxForInstructions.Text = CleanHTMLGarbage(instrictons);

            var request = WebRequest.Create(imigeURL);
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
                PictureBoxForRecipe.Image = Bitmap.FromStream(stream);
        }

        private void Found_Recipe_Load(object sender, EventArgs e)
        {
            ManageThemes.ApplyTheme(this);
        }

        private void LabelRecipeTitle_Click(object sender, EventArgs e)
        {

        }

        private void LabelForIngridients_Click(object sender, EventArgs e)
        {

        }

        private void LabelForInstructions_Click(object sender, EventArgs e)
        {

        }

        private void RichTextBoxForIngridients_TextChanged(object sender, EventArgs e)
        {

        }

        private void RIchTextBoxForInstructions_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBoxForRecipe_Click(object sender, EventArgs e)
        {

        }

        private void ButtonFavorite_Click(object sender, EventArgs e)
        {
            string desktopFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopFilePath, "favorite_recipis.txt");

            string title = LabelRecipeTitle.Text;
            string imageURL = imigeURL;
            string ingredients = RichTextBoxForIngridients.Text.Trim();
            string instructions = RIchTextBoxForInstructions.Text.Trim();

            List<string> toWrite = new List<string>();
            toWrite.Add($"===");
            toWrite.Add($"---");
            toWrite.Add($"Title: {title}");
            toWrite.Add($"---");
            toWrite.Add($"ImageURL: {imageURL}");
            toWrite.Add($"---");
            toWrite.Add($"Ingridients: {ingredients}");
            toWrite.Add($"---");
            toWrite.Add($"Instructions: {CleanHTMLGarbage(instructions)}");
            toWrite.Add("---");
            toWrite.Add($"===");

            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);

                if (File.Exists(filePath) && !fileContent.Contains($"Title: {title}"))
                {
                    MessageBox.Show("Recipe added to Favorites", "Recipe Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    File.AppendAllLines(filePath, toWrite);
                }
                else if (fileContent.Contains($"Title: {title}"))
                {
                    MessageBox.Show("Recipe already in Favorites", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("No File found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
