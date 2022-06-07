namespace Câmara_mento___Juan_Montoya
{
    partial class GameMenuScreen
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
            this.easyLabel = new System.Windows.Forms.Label();
            this.mediumLabel = new System.Windows.Forms.Label();
            this.hardLabel = new System.Windows.Forms.Label();
            this.endlessLabel = new System.Windows.Forms.Label();
            this.backhtpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // easyLabel
            // 
            this.easyLabel.AutoSize = true;
            this.easyLabel.BackColor = System.Drawing.Color.Black;
            this.easyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.easyLabel.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.easyLabel.Location = new System.Drawing.Point(37, 47);
            this.easyLabel.Name = "easyLabel";
            this.easyLabel.Size = new System.Drawing.Size(133, 75);
            this.easyLabel.TabIndex = 3;
            this.easyLabel.Text = "Easy";
            this.easyLabel.Click += new System.EventHandler(this.easyLabel_Click);
            // 
            // mediumLabel
            // 
            this.mediumLabel.AutoSize = true;
            this.mediumLabel.BackColor = System.Drawing.Color.Black;
            this.mediumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mediumLabel.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mediumLabel.Location = new System.Drawing.Point(37, 156);
            this.mediumLabel.Name = "mediumLabel";
            this.mediumLabel.Size = new System.Drawing.Size(199, 75);
            this.mediumLabel.TabIndex = 4;
            this.mediumLabel.Text = "Medium";
            this.mediumLabel.Click += new System.EventHandler(this.mediumLabel_Click);
            // 
            // hardLabel
            // 
            this.hardLabel.AutoSize = true;
            this.hardLabel.BackColor = System.Drawing.Color.Black;
            this.hardLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hardLabel.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hardLabel.Location = new System.Drawing.Point(37, 270);
            this.hardLabel.Name = "hardLabel";
            this.hardLabel.Size = new System.Drawing.Size(144, 75);
            this.hardLabel.TabIndex = 5;
            this.hardLabel.Text = "Hard";
            this.hardLabel.Click += new System.EventHandler(this.hardLabel_Click);
            // 
            // endlessLabel
            // 
            this.endlessLabel.AutoSize = true;
            this.endlessLabel.BackColor = System.Drawing.Color.Black;
            this.endlessLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.endlessLabel.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endlessLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.endlessLabel.Location = new System.Drawing.Point(37, 431);
            this.endlessLabel.Name = "endlessLabel";
            this.endlessLabel.Size = new System.Drawing.Size(185, 75);
            this.endlessLabel.TabIndex = 6;
            this.endlessLabel.Text = "Endless";
            this.endlessLabel.Click += new System.EventHandler(this.endlessLabel_Click);
            // 
            // backhtpLabel
            // 
            this.backhtpLabel.AutoSize = true;
            this.backhtpLabel.BackColor = System.Drawing.Color.Black;
            this.backhtpLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.backhtpLabel.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backhtpLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backhtpLabel.Location = new System.Drawing.Point(879, 520);
            this.backhtpLabel.Name = "backhtpLabel";
            this.backhtpLabel.Size = new System.Drawing.Size(144, 75);
            this.backhtpLabel.TabIndex = 7;
            this.backhtpLabel.Text = "Back";
            this.backhtpLabel.Click += new System.EventHandler(this.backhtpLabel_Click);
            // 
            // GameMenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Câmara_mento___Juan_Montoya.Properties.Resources.GameMenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.backhtpLabel);
            this.Controls.Add(this.endlessLabel);
            this.Controls.Add(this.hardLabel);
            this.Controls.Add(this.mediumLabel);
            this.Controls.Add(this.easyLabel);
            this.Name = "GameMenuScreen";
            this.Size = new System.Drawing.Size(1091, 663);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label easyLabel;
        private System.Windows.Forms.Label mediumLabel;
        private System.Windows.Forms.Label hardLabel;
        private System.Windows.Forms.Label endlessLabel;
        private System.Windows.Forms.Label backhtpLabel;
    }
}
