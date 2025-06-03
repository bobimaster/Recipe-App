namespace Recipe_App
{
    partial class Favorite_Recipes
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
            LabelForTitle = new Label();
            LableForIngridients = new Label();
            LabelForInstructions = new Label();
            RichTextBoxIngridients = new RichTextBox();
            RichTextBoxInstructions = new RichTextBox();
            PictureBoxRecipe = new PictureBox();
            ButtonUnfavorite = new Button();
            ButtonPrevious = new Button();
            ButtonNext = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBoxRecipe).BeginInit();
            SuspendLayout();
            // 
            // LabelForTitle
            // 
            LabelForTitle.AutoSize = true;
            LabelForTitle.Font = new Font("Segoe UI", 18F);
            LabelForTitle.Location = new Point(48, 29);
            LabelForTitle.Name = "LabelForTitle";
            LabelForTitle.Size = new Size(97, 41);
            LabelForTitle.TabIndex = 0;
            LabelForTitle.Text = "label1";
            LabelForTitle.Click += LabelForTitle_Click;
            // 
            // LableForIngridients
            // 
            LableForIngridients.AutoSize = true;
            LableForIngridients.Font = new Font("Segoe UI", 9F);
            LableForIngridients.Location = new Point(41, 97);
            LableForIngridients.Name = "LableForIngridients";
            LableForIngridients.Size = new Size(83, 20);
            LableForIngridients.TabIndex = 1;
            LableForIngridients.Text = "Ingredients";
            LableForIngridients.Click += LableForIngridients_Click;
            // 
            // LabelForInstructions
            // 
            LabelForInstructions.AutoSize = true;
            LabelForInstructions.Location = new Point(303, 97);
            LabelForInstructions.Name = "LabelForInstructions";
            LabelForInstructions.Size = new Size(84, 20);
            LabelForInstructions.TabIndex = 2;
            LabelForInstructions.Text = "Instructions";
            LabelForInstructions.Click += LabelForInstructions_Click;
            // 
            // RichTextBoxIngridients
            // 
            RichTextBoxIngridients.Location = new Point(41, 129);
            RichTextBoxIngridients.Name = "RichTextBoxIngridients";
            RichTextBoxIngridients.ReadOnly = true;
            RichTextBoxIngridients.Size = new Size(221, 419);
            RichTextBoxIngridients.TabIndex = 3;
            RichTextBoxIngridients.Text = "";
            RichTextBoxIngridients.TextChanged += RichTextBoxIngridients_TextChanged;
            // 
            // RichTextBoxInstructions
            // 
            RichTextBoxInstructions.Location = new Point(303, 129);
            RichTextBoxInstructions.Name = "RichTextBoxInstructions";
            RichTextBoxInstructions.ReadOnly = true;
            RichTextBoxInstructions.Size = new Size(228, 419);
            RichTextBoxInstructions.TabIndex = 4;
            RichTextBoxInstructions.Text = "";
            RichTextBoxInstructions.TextChanged += RichTextBoxInstructions_TextChanged;
            // 
            // PictureBoxRecipe
            // 
            PictureBoxRecipe.Location = new Point(576, 97);
            PictureBoxRecipe.Name = "PictureBoxRecipe";
            PictureBoxRecipe.Size = new Size(290, 291);
            PictureBoxRecipe.TabIndex = 5;
            PictureBoxRecipe.TabStop = false;
            PictureBoxRecipe.Click += PictureBoxRecipe_Click;
            // 
            // ButtonUnfavorite
            // 
            ButtonUnfavorite.Location = new Point(759, 396);
            ButtonUnfavorite.Name = "ButtonUnfavorite";
            ButtonUnfavorite.Size = new Size(107, 39);
            ButtonUnfavorite.TabIndex = 6;
            ButtonUnfavorite.Text = " ☆ Unfavorite";
            ButtonUnfavorite.UseVisualStyleBackColor = true;
            ButtonUnfavorite.Click += ButtonUnfavorite_Click;
            // 
            // ButtonPrevious
            // 
            ButtonPrevious.Location = new Point(621, 519);
            ButtonPrevious.Name = "ButtonPrevious";
            ButtonPrevious.Size = new Size(107, 39);
            ButtonPrevious.TabIndex = 7;
            ButtonPrevious.Text = "Previous";
            ButtonPrevious.UseVisualStyleBackColor = true;
            ButtonPrevious.Click += ButtonPrevious_Click;
            // 
            // ButtonNext
            // 
            ButtonNext.Location = new Point(759, 519);
            ButtonNext.Name = "ButtonNext";
            ButtonNext.Size = new Size(105, 39);
            ButtonNext.TabIndex = 8;
            ButtonNext.Text = "Next";
            ButtonNext.UseVisualStyleBackColor = true;
            ButtonNext.Click += ButtonNext_Click;
            // 
            // Favorite_Recipes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(ButtonNext);
            Controls.Add(ButtonPrevious);
            Controls.Add(ButtonUnfavorite);
            Controls.Add(PictureBoxRecipe);
            Controls.Add(RichTextBoxInstructions);
            Controls.Add(RichTextBoxIngridients);
            Controls.Add(LabelForInstructions);
            Controls.Add(LableForIngridients);
            Controls.Add(LabelForTitle);
            Name = "Favorite_Recipes";
            Text = "Favorite_Recipes";
            Load += Favorite_Recipes_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBoxRecipe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelForTitle;
        private Label LableForIngridients;
        private Label LabelForInstructions;
        private RichTextBox RichTextBoxIngridients;
        private RichTextBox RichTextBoxInstructions;
        private PictureBox PictureBoxRecipe;
        private Button ButtonUnfavorite;
        private Button ButtonPrevious;
        private Button ButtonNext;
    }
}