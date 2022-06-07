namespace Câmara_mento___Juan_Montoya
{
    partial class HowToPlayScreen
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
            this.generalLabel = new System.Windows.Forms.Label();
            this.mascotLabel = new System.Windows.Forms.Label();
            this.backLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generalLabel
            // 
            this.generalLabel.AutoSize = true;
            this.generalLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.generalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.generalLabel.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generalLabel.Location = new System.Drawing.Point(315, 199);
            this.generalLabel.Name = "generalLabel";
            this.generalLabel.Size = new System.Drawing.Size(193, 75);
            this.generalLabel.TabIndex = 3;
            this.generalLabel.Text = "General";
            this.generalLabel.Click += new System.EventHandler(this.generalLabel_Click);
            // 
            // mascotLabel
            // 
            this.mascotLabel.AutoSize = true;
            this.mascotLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mascotLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mascotLabel.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mascotLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mascotLabel.Location = new System.Drawing.Point(563, 199);
            this.mascotLabel.Name = "mascotLabel";
            this.mascotLabel.Size = new System.Drawing.Size(198, 75);
            this.mascotLabel.TabIndex = 4;
            this.mascotLabel.Text = "Mascots";
            this.mascotLabel.Click += new System.EventHandler(this.mascotLabel_Click);
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.backLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.backLabel.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backLabel.Location = new System.Drawing.Point(452, 369);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(144, 75);
            this.backLabel.TabIndex = 5;
            this.backLabel.Text = "Back";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            // 
            // HowToPlayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Câmara_mento___Juan_Montoya.Properties.Resources.HowToPlay;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.mascotLabel);
            this.Controls.Add(this.generalLabel);
            this.Name = "HowToPlayScreen";
            this.Size = new System.Drawing.Size(1087, 659);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label generalLabel;
        private System.Windows.Forms.Label mascotLabel;
        private System.Windows.Forms.Label backLabel;
    }
}
