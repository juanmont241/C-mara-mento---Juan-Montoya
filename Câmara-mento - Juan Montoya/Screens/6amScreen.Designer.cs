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
            // _6amScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Câmara_mento___Juan_Montoya.Properties.Resources.VictoryScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this._6am);
            this.Name = "_6amScreen";
            this.Size = new System.Drawing.Size(1085, 619);
            ((System.ComponentModel.ISupportInitialize)(this._6am)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _6am;
        private System.Windows.Forms.Timer _6amTimer;
    }
}
