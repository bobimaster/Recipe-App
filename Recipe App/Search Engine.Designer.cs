namespace Recipe_App
{
    partial class Search_Engine
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
            LabelForIngridients = new Label();
            LabelForCookingTime = new Label();
            TextBoxIngridients = new TextBox();
            TextBoxMaxCookTime = new TextBox();
            ButtonSearch = new Button();
            SuspendLayout();
            // 
            // LabelForIngridients
            // 
            LabelForIngridients.AutoSize = true;
            LabelForIngridients.Location = new Point(14, 224);
            LabelForIngridients.Name = "LabelForIngridients";
            LabelForIngridients.Size = new Size(212, 20);
            LabelForIngridients.TabIndex = 0;
            LabelForIngridients.Text = "Enter the ingredients you have:";
            LabelForIngridients.Click += LabelForIngridients_Click;
            // 
            // LabelForCookingTime
            // 
            LabelForCookingTime.AutoSize = true;
            LabelForCookingTime.Location = new Point(14, 259);
            LabelForCookingTime.Name = "LabelForCookingTime";
            LabelForCookingTime.Size = new Size(257, 20);
            LabelForCookingTime.TabIndex = 1;
            LabelForCookingTime.Text = "Set your cooking time limit (minutes):";
            LabelForCookingTime.Click += LabelForCookingTime_Click;
            // 
            // TextBoxIngridients
            // 
            TextBoxIngridients.Location = new Point(277, 219);
            TextBoxIngridients.Name = "TextBoxIngridients";
            TextBoxIngridients.Size = new Size(333, 27);
            TextBoxIngridients.TabIndex = 2;
            TextBoxIngridients.TextChanged += textBox1_TextChanged;
            // 
            // TextBoxMaxCookTime
            // 
            TextBoxMaxCookTime.Location = new Point(277, 252);
            TextBoxMaxCookTime.Name = "TextBoxMaxCookTime";
            TextBoxMaxCookTime.Size = new Size(333, 27);
            TextBoxMaxCookTime.TabIndex = 3;
            TextBoxMaxCookTime.TextChanged += textBox2_TextChanged;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(635, 216);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(99, 69);
            ButtonSearch.TabIndex = 4;
            ButtonSearch.Text = "Search";
            ButtonSearch.UseVisualStyleBackColor = true;
            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // Search_Engine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(ButtonSearch);
            Controls.Add(TextBoxMaxCookTime);
            Controls.Add(TextBoxIngridients);
            Controls.Add(LabelForCookingTime);
            Controls.Add(LabelForIngridients);
            Location = new Point(241, 216);
            Name = "Search_Engine";
            Text = "Search_Engine";
            Load += Search_Engine_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelForIngridients;
        private Label LabelForCookingTime;
        private TextBox TextBoxIngridients;
        private TextBox TextBoxMaxCookTime;
        private Button ButtonSearch;
    }
}