namespace Câmara_mento___Juan_Montoya
{
    partial class MenuScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.newGameLabel = new System.Windows.Forms.Label();
            this.howToPlayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Salmon;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Title.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(34, 56);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(329, 75);
            this.Title.TabIndex = 0;
            this.Title.Text = "Câmara-mento";
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Black;
            this.exitLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exitLabel.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitLabel.Location = new System.Drawing.Point(34, 518);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(122, 75);
            this.exitLabel.TabIndex = 1;
            this.exitLabel.Text = "Exit";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // newGameLabel
            // 
            this.newGameLabel.AutoSize = true;
            this.newGameLabel.BackColor = System.Drawing.Color.Black;
            this.newGameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.newGameLabel.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newGameLabel.Location = new System.Drawing.Point(34, 249);
            this.newGameLabel.Name = "newGameLabel";
            this.newGameLabel.Size = new System.Drawing.Size(256, 75);
            this.newGameLabel.TabIndex = 2;
            this.newGameLabel.Text = "New Game";
            this.newGameLabel.Click += new System.EventHandler(this.newGameLabel_Click);
            // 
            // howToPlayLabel
            // 
            this.howToPlayLabel.AutoSize = true;
            this.howToPlayLabel.BackColor = System.Drawing.Color.Black;
            this.howToPlayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.howToPlayLabel.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToPlayLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.howToPlayLabel.Location = new System.Drawing.Point(34, 389);
            this.howToPlayLabel.Name = "howToPlayLabel";
            this.howToPlayLabel.Size = new System.Drawing.Size(325, 75);
            this.howToPlayLabel.TabIndex = 3;
            this.howToPlayLabel.Text = "How To Play";
            this.howToPlayLabel.Click += new System.EventHandler(this.howToPlayLabel_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Câmara_mento___Juan_Montoya.Properties.Resources.MenuScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.howToPlayLabel);
            this.Controls.Add(this.newGameLabel);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.Title);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(1091, 663);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label newGameLabel;
        private System.Windows.Forms.Label howToPlayLabel;
    }
}
