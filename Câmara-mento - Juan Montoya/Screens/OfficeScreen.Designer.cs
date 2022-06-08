namespace Câmara_mento___Juan_Montoya
{
    partial class OfficeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfficeScreen));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.bringCamera = new System.Windows.Forms.PictureBox();
            this.hideTable = new System.Windows.Forms.PictureBox();
            this.CamDown = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bringCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // bringCamera
            // 
            this.bringCamera.BackColor = System.Drawing.Color.Transparent;
            this.bringCamera.BackgroundImage = global::Câmara_mento___Juan_Montoya.Properties.Resources.Bring_Up_Monitor;
            this.bringCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bringCamera.Location = new System.Drawing.Point(27, 17);
            this.bringCamera.Name = "bringCamera";
            this.bringCamera.Size = new System.Drawing.Size(86, 225);
            this.bringCamera.TabIndex = 0;
            this.bringCamera.TabStop = false;
            this.bringCamera.Click += new System.EventHandler(this.bringCamera_Click);
            // 
            // hideTable
            // 
            this.hideTable.BackColor = System.Drawing.Color.Transparent;
            this.hideTable.BackgroundImage = global::Câmara_mento___Juan_Montoya.Properties.Resources.TableButton;
            this.hideTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hideTable.Location = new System.Drawing.Point(346, 554);
            this.hideTable.Name = "hideTable";
            this.hideTable.Size = new System.Drawing.Size(368, 50);
            this.hideTable.TabIndex = 1;
            this.hideTable.TabStop = false;
            // 
            // CamDown
            // 
            this.CamDown.Image = ((System.Drawing.Image)(resources.GetObject("CamDown.Image")));
            this.CamDown.Location = new System.Drawing.Point(73, 126);
            this.CamDown.Name = "CamDown";
            this.CamDown.Size = new System.Drawing.Size(958, 537);
            this.CamDown.TabIndex = 2;
            this.CamDown.TabStop = false;
            this.CamDown.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(442, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // OfficeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Câmara_mento___Juan_Montoya.Properties.Resources.Office_Lighted;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hideTable);
            this.Controls.Add(this.bringCamera);
            this.Controls.Add(this.CamDown);
            this.Name = "OfficeScreen";
            this.Size = new System.Drawing.Size(1091, 663);
            ((System.ComponentModel.ISupportInitialize)(this.bringCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox bringCamera;
        private System.Windows.Forms.PictureBox hideTable;
        private System.Windows.Forms.PictureBox CamDown;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
