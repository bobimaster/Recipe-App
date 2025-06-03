namespace Recipe_App
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PictureBoxFileIcon = new PictureBox();
            LableForFileInfo = new Label();
            FavoriteRecipeButton = new Button();
            ButtonYes = new Button();
            ButtonNo = new Button();
            ButtonLightDarkMode = new Button();
            ButtonSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBoxFileIcon).BeginInit();
            SuspendLayout();
            // 
            // PictureBoxFileIcon
            // 
            PictureBoxFileIcon.Location = new Point(256, 16);
            PictureBoxFileIcon.Name = "PictureBoxFileIcon";
            PictureBoxFileIcon.Size = new Size(26, 31);
            PictureBoxFileIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxFileIcon.TabIndex = 0;
            PictureBoxFileIcon.TabStop = false;
            PictureBoxFileIcon.Click += PictureBoxFileIcon_Click;
            // 
            // LableForFileInfo
            // 
            LableForFileInfo.AutoSize = true;
            LableForFileInfo.Location = new Point(298, 21);
            LableForFileInfo.Name = "LableForFileInfo";
            LableForFileInfo.Size = new Size(50, 20);
            LableForFileInfo.TabIndex = 1;
            LableForFileInfo.Text = "label1";
            LableForFileInfo.Click += LableForFileInfo_Click;
            // 
            // FavoriteRecipeButton
            // 
            FavoriteRecipeButton.Location = new Point(414, 248);
            FavoriteRecipeButton.Name = "FavoriteRecipeButton";
            FavoriteRecipeButton.Size = new Size(174, 84);
            FavoriteRecipeButton.TabIndex = 3;
            FavoriteRecipeButton.Text = "Favorites";
            FavoriteRecipeButton.UseVisualStyleBackColor = true;
            FavoriteRecipeButton.Click += FavoriteRecipeButton_Click;
            // 
            // ButtonYes
            // 
            ButtonYes.Location = new Point(591, 21);
            ButtonYes.Name = "ButtonYes";
            ButtonYes.Size = new Size(42, 31);
            ButtonYes.TabIndex = 4;
            ButtonYes.Text = "Yes";
            ButtonYes.TextAlign = ContentAlignment.TopCenter;
            ButtonYes.UseVisualStyleBackColor = true;
            ButtonYes.Click += ButtonYes_Click;
            // 
            // ButtonNo
            // 
            ButtonNo.Location = new Point(639, 21);
            ButtonNo.Name = "ButtonNo";
            ButtonNo.Size = new Size(42, 31);
            ButtonNo.TabIndex = 5;
            ButtonNo.Text = "No";
            ButtonNo.UseVisualStyleBackColor = true;
            ButtonNo.Click += ButtonNo_Click;
            // 
            // ButtonLightDarkMode
            // 
            ButtonLightDarkMode.Location = new Point(754, 547);
            ButtonLightDarkMode.Name = "ButtonLightDarkMode";
            ButtonLightDarkMode.Size = new Size(131, 37);
            ButtonLightDarkMode.TabIndex = 6;
            ButtonLightDarkMode.Text = "☼ Light Mode";
            ButtonLightDarkMode.UseVisualStyleBackColor = true;
            ButtonLightDarkMode.Click += ButtonLightDarkMode_Click;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(219, 248);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(174, 84);
            ButtonSearch.TabIndex = 7;
            ButtonSearch.Text = "Search Recipes";
            ButtonSearch.UseVisualStyleBackColor = true;
            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 600);
            Controls.Add(ButtonSearch);
            Controls.Add(ButtonLightDarkMode);
            Controls.Add(ButtonNo);
            Controls.Add(ButtonYes);
            Controls.Add(FavoriteRecipeButton);
            Controls.Add(LableForFileInfo);
            Controls.Add(PictureBoxFileIcon);
            Name = "MainForm";
            Text = "Boboskus Recipe Search Tool";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBoxFileIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PictureBoxFileIcon;
        private Label LableForFileInfo;
        private Button FavoriteRecipeButton;
        private Button ButtonYes;
        private Button ButtonNo;
        private Button ButtonLightDarkMode;
        private Button ButtonSearch;
    }
}
