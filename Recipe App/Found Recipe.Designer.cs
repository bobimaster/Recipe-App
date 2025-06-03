namespace Recipe_App
{
    partial class Found_Recipe
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
            LabelRecipeTitle = new Label();
            LabelForIngridients = new Label();
            LabelForInstructions = new Label();
            RichTextBoxForIngridients = new RichTextBox();
            RIchTextBoxForInstructions = new RichTextBox();
            PictureBoxForRecipe = new PictureBox();
            ButtonFavorite = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBoxForRecipe).BeginInit();
            SuspendLayout();
            // 
            // LabelRecipeTitle
            // 
            LabelRecipeTitle.AutoSize = true;
            LabelRecipeTitle.Font = new Font("Segoe UI", 18F);
            LabelRecipeTitle.Location = new Point(48, 29);
            LabelRecipeTitle.Name = "LabelRecipeTitle";
            LabelRecipeTitle.Size = new Size(97, 41);
            LabelRecipeTitle.TabIndex = 0;
            LabelRecipeTitle.Text = "label1";
            LabelRecipeTitle.Click += LabelRecipeTitle_Click;
            // 
            // LabelForIngridients
            // 
            LabelForIngridients.AutoSize = true;
            LabelForIngridients.Font = new Font("Segoe UI", 12F);
            LabelForIngridients.Location = new Point(41, 97);
            LabelForIngridients.Name = "LabelForIngridients";
            LabelForIngridients.Size = new Size(110, 28);
            LabelForIngridients.TabIndex = 1;
            LabelForIngridients.Text = "Ingredients";
            LabelForIngridients.Click += LabelForIngridients_Click;
            // 
            // LabelForInstructions
            // 
            LabelForInstructions.AutoSize = true;
            LabelForInstructions.Font = new Font("Segoe UI", 12F);
            LabelForInstructions.Location = new Point(303, 97);
            LabelForInstructions.Name = "LabelForInstructions";
            LabelForInstructions.Size = new Size(113, 28);
            LabelForInstructions.TabIndex = 2;
            LabelForInstructions.Text = "Instructions";
            LabelForInstructions.Click += LabelForInstructions_Click;
            // 
            // RichTextBoxForIngridients
            // 
            RichTextBoxForIngridients.Location = new Point(41, 129);
            RichTextBoxForIngridients.Name = "RichTextBoxForIngridients";
            RichTextBoxForIngridients.ReadOnly = true;
            RichTextBoxForIngridients.Size = new Size(221, 419);
            RichTextBoxForIngridients.TabIndex = 3;
            RichTextBoxForIngridients.Text = "";
            RichTextBoxForIngridients.TextChanged += RichTextBoxForIngridients_TextChanged;
            // 
            // RIchTextBoxForInstructions
            // 
            RIchTextBoxForInstructions.BackColor = SystemColors.Control;
            RIchTextBoxForInstructions.Location = new Point(303, 129);
            RIchTextBoxForInstructions.Name = "RIchTextBoxForInstructions";
            RIchTextBoxForInstructions.ReadOnly = true;
            RIchTextBoxForInstructions.Size = new Size(228, 419);
            RIchTextBoxForInstructions.TabIndex = 4;
            RIchTextBoxForInstructions.Text = "";
            RIchTextBoxForInstructions.TextChanged += RIchTextBoxForInstructions_TextChanged;
            // 
            // PictureBoxForRecipe
            // 
            PictureBoxForRecipe.Location = new Point(576, 97);
            PictureBoxForRecipe.Name = "PictureBoxForRecipe";
            PictureBoxForRecipe.Size = new Size(290, 291);
            PictureBoxForRecipe.TabIndex = 5;
            PictureBoxForRecipe.TabStop = false;
            PictureBoxForRecipe.Click += PictureBoxForRecipe_Click;
            // 
            // ButtonFavorite
            // 
            ButtonFavorite.Location = new Point(750, 532);
            ButtonFavorite.Name = "ButtonFavorite";
            ButtonFavorite.Size = new Size(114, 40);
            ButtonFavorite.TabIndex = 6;
            ButtonFavorite.Text = "★ Favorite";
            ButtonFavorite.UseVisualStyleBackColor = true;
            ButtonFavorite.Click += ButtonFavorite_Click;
            // 
            // Found_Recipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(ButtonFavorite);
            Controls.Add(PictureBoxForRecipe);
            Controls.Add(RIchTextBoxForInstructions);
            Controls.Add(RichTextBoxForIngridients);
            Controls.Add(LabelForInstructions);
            Controls.Add(LabelForIngridients);
            Controls.Add(LabelRecipeTitle);
            Name = "Found_Recipe";
            Text = "Found_Recipe";
            Load += Found_Recipe_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBoxForRecipe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelRecipeTitle;
        private Label LabelForIngridients;
        private Label LabelForInstructions;
        private RichTextBox RichTextBoxForIngridients;
        private RichTextBox RIchTextBoxForInstructions;
        private PictureBox PictureBoxForRecipe;
        private Button ButtonFavorite;
    }
}