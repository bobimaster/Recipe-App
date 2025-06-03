using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe_App
{
    public partial class Favorite_Recipes : Form
    {
        public Favorite_Recipes()
        {
            InitializeComponent();
            GetInfoFromFile();
        }
        protected int index = 0;
        protected List<(string title, string imageURL, string ingridients, string instructions)> favoriteRecepies = new List<(string title, string imageURL, string ingridients, string instructions)>();
        protected string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "favorite_recipis.txt");

        private void GetInfoFromFile()
        {

            if (!File.Exists(filePath))
            {
                MessageBox.Show("No favorite file found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string curentTitle = string.Empty;
            string curentImageURL = string.Empty;
            string curentIngridients = string.Empty;
            string curentInstructions = string.Empty;
            string selection = string.Empty;
            bool newRecepie = false;

            foreach (string line in File.ReadLines(filePath))
            {
                if (line == "===")
                {
                    if (newRecepie)
                    {
                        favoriteRecepies.Add((curentTitle, curentImageURL, curentIngridients, curentInstructions));
                        curentTitle = string.Empty;
                        curentImageURL = string.Empty;
                        curentIngridients = string.Empty;
                        curentInstructions = string.Empty;
                        selection = string.Empty;
                    }
                    newRecepie = !newRecepie;
                }
                else if (line == "---")
                    selection = string.Empty;
                else if (line.StartsWith("Title: "))
                {
                    selection = "title";
                    curentTitle = line.Substring(7);
                }
                else if (line.StartsWith("ImageURL: "))
                {
                    selection = "imageURL";
                    curentImageURL = line.Substring(10);
                }
                else if (line.StartsWith("Ingridients: "))
                {
                    selection = "ingridients";
                    curentIngridients = line.Substring(13);
                }
                else if (line.StartsWith("Instructions: "))
                {
                    selection = "instructions";
                    curentInstructions = line.Substring(14);
                }
                else
                {
                    switch (selection)
                    {
                        case "ingridients": curentIngridients += "\n" + line; break;
                        case "instructions": curentInstructions += "\n" + line; break;
                    }
                }
            }
            if (favoriteRecepies.Count > 0)
                Display();
            else
            {
                LabelForTitle.Text = "No recepies found";
                ButtonUnfavorite.Visible = false;
                ButtonPrevious.Visible = false;
                ButtonNext.Visible = false;
            }
        }
        private void Display()
        {
            var recepie = favoriteRecepies[index];
            LabelForTitle.Text = recepie.title;
            RichTextBoxIngridients.Text = recepie.ingridients;
            RichTextBoxInstructions.Text = recepie.instructions;
            try
            {
                PictureBoxRecipe.Load(recepie.imageURL);
            }
            catch
            {
                PictureBoxRecipe.Image = null;
            }

            ButtonUnfavorite.Visible = true;
            ButtonNext.Visible = index < favoriteRecepies.Count - 1;
            ButtonPrevious.Visible = index > 0;
        }
        private void Favorite_Recipes_Load(object sender, EventArgs e)
        {
            ManageThemes.ApplyTheme(this);
        }

        private void LabelForTitle_Click(object sender, EventArgs e)
        {

        }

        private void LableForIngridients_Click(object sender, EventArgs e)
        {

        }

        private void LabelForInstructions_Click(object sender, EventArgs e)
        {

        }

        private void RichTextBoxIngridients_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBoxInstructions_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBoxRecipe_Click(object sender, EventArgs e)
        {

        }

        private void ButtonUnfavorite_Click(object sender, EventArgs e)
        {
            var recepie = favoriteRecepies[index];
            var prompt = MessageBox.Show($"Are you sure you want to remove '{recepie.title}' from favorites?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (prompt == DialogResult.Yes)
            {
                favoriteRecepies.RemoveAt(index);

                var toWrite = new List<string>();
                foreach (var line in favoriteRecepies)
                {
                    toWrite.Add($"===");
                    toWrite.Add($"---");
                    toWrite.Add($"Title: {line.title}");
                    toWrite.Add($"---");
                    toWrite.Add($"ImageURL: {line.imageURL}");
                    toWrite.Add($"---");
                    toWrite.Add($"Ingridients: {line.ingridients}");
                    toWrite.Add($"---");
                    toWrite.Add($"Instructions: {line.instructions}");
                    toWrite.Add("---");
                    toWrite.Add($"===");
                }
                File.WriteAllLines(filePath, toWrite);

                if (index >= favoriteRecepies.Count)
                    index = favoriteRecepies.Count - 1;

                if (favoriteRecepies.Count > 0)
                    Display();
                else
                {
                    LabelForTitle.Text = "No recepies found";
                    RichTextBoxIngridients.Clear();
                    RichTextBoxInstructions.Clear();
                    PictureBoxRecipe.Image = null;

                    ButtonUnfavorite.Visible = false;
                    ButtonNext.Visible = false;
                    ButtonPrevious.Visible = false;
                }
            }
        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            index--;
            Display();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (index < favoriteRecepies.Count - 1)
            {
                index++;
                Display();
            }
        }
    }
}
