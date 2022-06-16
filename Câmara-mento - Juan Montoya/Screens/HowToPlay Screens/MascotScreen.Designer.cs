namespace Câmara_mento___Juan_Montoya
{
    partial class MascotScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MascotScreen));
            this.backLabel = new System.Windows.Forms.Label();
            this.Transition = new System.Windows.Forms.PictureBox();
            this.TransitionTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Transition)).BeginInit();
            this.SuspendLayout();
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.backLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.backLabel.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backLabel.Location = new System.Drawing.Point(459, 401);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(144, 75);
            this.backLabel.TabIndex = 6;
            this.backLabel.Text = "Back";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            // 
            // Transition
            // 
            this.Transition.BackColor = System.Drawing.Color.Transparent;
            this.Transition.Image = ((System.Drawing.Image)(resources.GetObject("Transition.Image")));
            this.Transition.Location = new System.Drawing.Point(-2, -2);
            this.Transition.Name = "Transition";
            this.Transition.Size = new System.Drawing.Size(1090, 668);
            this.Transition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Transition.TabIndex = 8;
            this.Transition.TabStop = false;
            // 
            // TransitionTimer
            // 
            this.TransitionTimer.Enabled = true;
            this.TransitionTimer.Interval = 200;
            this.TransitionTimer.Tick += new System.EventHandler(this.TransitionTimer_Tick);
            // 
            // MascotScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Câmara_mento___Juan_Montoya.Properties.Resources.HowToPlay;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.Transition);
            this.Name = "MascotScreen";
            this.Size = new System.Drawing.Size(1083, 655);
            ((System.ComponentModel.ISupportInitialize)(this.Transition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.PictureBox Transition;
        private System.Windows.Forms.Timer TransitionTimer;
    }
}
