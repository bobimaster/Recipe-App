using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Recipe_App
{
    public partial class Search_Engine : Form
    {
        public Search_Engine()
        {
            InitializeComponent();
        }

        private void Search_Engine_Load(object sender, EventArgs e)
        {
            ManageThemes.ApplyTheme(this);
        }

        private void LabelForIngridients_Click(object sender, EventArgs e)
        {

        }

        private void LabelForCookingTime_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private async void ButtonSearch_Click(object sender, EventArgs e)
        {
            string ingridients = TextBoxIngridients.Text;
            string maxcocktime = TextBoxMaxCookTime.Text;
            string apiKey = "697f6cdc8716475b824fc4be60ec02ea";
            string url = $"https://api.spoonacular.com/recipes/findByIngredients?ingredients={ingridients}&number=1&ranking=1&apiKey={apiKey}";

            if (!string.IsNullOrEmpty(maxcocktime))
                url += $"&maxReadyTime={maxcocktime}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string reponce = await client.GetStringAsync(url);
                    JsonArray recipes = JsonNode.Parse(reponce).AsArray();

                    if (recipes.Count == 0)
                    {
                        MessageBox.Show("No recepies found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var recepie = recipes[0];
                    int recepieID = recepie["id"].GetValue<int>();
                    string title = recepie["title"].ToString();
                    string imigeURL = recepie["image"].ToString();

                    await GetMoreDetails(recepieID, title, imigeURL, apiKey);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private async Task GetMoreDetails(int recepieID, string title, string imageURL, string apiKey)
        {
            string infoUrl = $"https://api.spoonacular.com/recipes/{recepieID}/information?includeNutrition=false&apiKey={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string info = await client.GetStringAsync(infoUrl);
                    JsonNode JSONinfo = JsonNode.Parse(info);
                    var ingredientsList = JSONinfo["extendedIngredients"].AsArray();
                    StringBuilder ingridients = new StringBuilder();

                    foreach (var item in ingredientsList)
                        ingridients.AppendLine(item["original"].ToString());

                    string ingridientsText = ingridients.ToString();
                    string instructionsText = JSONinfo["instructions"]?.ToString() ?? "No instructions found";

                    var detailsForm = new Found_Recipe(title, imageURL, ingridientsText, instructionsText);
                    detailsForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
