namespace Câmara_mento___Juan_Montoya
{
    partial class _6amScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_6amScreen));
            this._6am = new System.Windows.Forms.PictureBox();
            this._6amTimer = new System.Windows.Forms.Timer(this.components);
            this.easyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._6am)).BeginInit();
            this.SuspendLayout();
            // 
            // _6am
            // 
            this._6am.Image = ((System.Drawing.Image)(resources.GetObject("_6am.Image")));
            this._6am.Location = new System.Drawing.Point(3, -13);
            this._6am.Name = "_6am";
            this._6am.Size = new System.Drawing.Size(1079, 629);
            this._6am.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._6am.TabIndex = 0;
            this._6am.TabStop = false;
            // 
            // _6amTimer
            // 
            this._6amTimer.Enabled = true;
            this._6amTimer.Interval = 9000;
            this._6amTimer.Tick += new System.EventHandler(this._6amTimer_Tick);
            // 
            // easyLabel
            // 
            this.easyLabel.AutoSize = true;
            this.easyLabel.BackColor = System.Drawing.Color.Black;
            this.easyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.easyLabel.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.easyLabel.Location = new System.Drawing.Point(358, 58);
            this.easyLabel.Name = "easyLabel";
            this.easyLabel.Size = new System.Drawing.Size(331, 75);
            this.easyLabel.TabIndex = 4;
            this.easyLabel.Text = "You Survived!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(459, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 75);
            this.label1.TabIndex = 5;
            this.label1.Text = "Back";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // _6amScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Câmara_mento___Juan_Montoya.Properties.Resources.VictoryScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.easyLabel);
            this.Controls.Add(this._6am);
            this.Name = "_6amScreen";
            this.Size = new System.Drawing.Size(1085, 619);
            ((System.ComponentModel.ISupportInitialize)(this._6am)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _6am;
        private System.Windows.Forms.Timer _6amTimer;
        private System.Windows.Forms.Label easyLabel;
        private System.Windows.Forms.Label label1;
    }
}
