namespace Câmara_mento___Juan_Montoya
{
    partial class CharPrepScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharPrepScreen));
            this.cam6 = new System.Windows.Forms.PictureBox();
            this.cam2 = new System.Windows.Forms.PictureBox();
            this.cam5 = new System.Windows.Forms.PictureBox();
            this.cam1 = new System.Windows.Forms.PictureBox();
            this.camMap = new System.Windows.Forms.PictureBox();
            this.bringOutCamera = new System.Windows.Forms.PictureBox();
            this.amTimer = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.JakeCam = new System.Windows.Forms.PictureBox();
            this.TurnOff = new System.Windows.Forms.PictureBox();
            this.Loadbutton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cam6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bringOutCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JakeCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loadbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // cam6
            // 
            this.cam6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cam6.BackgroundImage")));
            this.cam6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cam6.Location = new System.Drawing.Point(939, 566);
            this.cam6.Name = "cam6";
            this.cam6.Size = new System.Drawing.Size(77, 56);
            this.cam6.TabIndex = 10;
            this.cam6.TabStop = false;
            // 
            // cam2
            // 
            this.cam2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cam2.BackgroundImage")));
            this.cam2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cam2.Location = new System.Drawing.Point(951, 428);
            this.cam2.Name = "cam2";
            this.cam2.Size = new System.Drawing.Size(77, 56);
            this.cam2.TabIndex = 9;
            this.cam2.TabStop = false;
            this.cam2.Click += new System.EventHandler(this.cam2_Click);
            // 
            // cam5
            // 
            this.cam5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cam5.BackgroundImage")));
            this.cam5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cam5.Location = new System.Drawing.Point(787, 566);
            this.cam5.Name = "cam5";
            this.cam5.Size = new System.Drawing.Size(87, 56);
            this.cam5.TabIndex = 8;
            this.cam5.TabStop = false;
            this.cam5.Click += new System.EventHandler(this.cam5_Click);
            // 
            // cam1
            // 
            this.cam1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cam1.BackgroundImage")));
            this.cam1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cam1.Location = new System.Drawing.Point(787, 426);
            this.cam1.Name = "cam1";
            this.cam1.Size = new System.Drawing.Size(77, 58);
            this.cam1.TabIndex = 7;
            this.cam1.TabStop = false;
            this.cam1.Click += new System.EventHandler(this.cam1_Click);
            // 
            // camMap
            // 
            this.camMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("camMap.BackgroundImage")));
            this.camMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.camMap.Location = new System.Drawing.Point(752, 403);
            this.camMap.Name = "camMap";
            this.camMap.Size = new System.Drawing.Size(307, 219);
            this.camMap.TabIndex = 6;
            this.camMap.TabStop = false;
            // 
            // bringOutCamera
            // 
            this.bringOutCamera.BackColor = System.Drawing.Color.Transparent;
            this.bringOutCamera.BackgroundImage = global::Câmara_mento___Juan_Montoya.Properties.Resources.Bring_Up_Monitor;
            this.bringOutCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bringOutCamera.Location = new System.Drawing.Point(33, 403);
            this.bringOutCamera.Name = "bringOutCamera";
            this.bringOutCamera.Size = new System.Drawing.Size(86, 225);
            this.bringOutCamera.TabIndex = 11;
            this.bringOutCamera.TabStop = false;
            this.bringOutCamera.Click += new System.EventHandler(this.bringOutCamera_Click);
            // 
            // amTimer
            // 
            this.amTimer.AutoSize = true;
            this.amTimer.BackColor = System.Drawing.Color.White;
            this.amTimer.Font = new System.Drawing.Font("Vladimir Script", 36F);
            this.amTimer.Location = new System.Drawing.Point(929, 42);
            this.amTimer.Name = "amTimer";
            this.amTimer.Size = new System.Drawing.Size(130, 73);
            this.amTimer.TabIndex = 12;
            this.amTimer.Text = "clock";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // JakeCam
            // 
            this.JakeCam.Image = ((System.Drawing.Image)(resources.GetObject("JakeCam.Image")));
            this.JakeCam.Location = new System.Drawing.Point(13, -59);
            this.JakeCam.Name = "JakeCam";
            this.JakeCam.Size = new System.Drawing.Size(851, 664);
            this.JakeCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.JakeCam.TabIndex = 13;
            this.JakeCam.TabStop = false;
            this.JakeCam.Visible = false;
            // 
            // TurnOff
            // 
            this.TurnOff.Image = ((System.Drawing.Image)(resources.GetObject("TurnOff.Image")));
            this.TurnOff.Location = new System.Drawing.Point(621, 530);
            this.TurnOff.Name = "TurnOff";
            this.TurnOff.Size = new System.Drawing.Size(110, 92);
            this.TurnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TurnOff.TabIndex = 15;
            this.TurnOff.TabStop = false;
            this.TurnOff.Click += new System.EventHandler(this.TurnOff_Click_1);
            // 
            // Loadbutton
            // 
            this.Loadbutton.Image = ((System.Drawing.Image)(resources.GetObject("Loadbutton.Image")));
            this.Loadbutton.Location = new System.Drawing.Point(621, 536);
            this.Loadbutton.Name = "Loadbutton";
            this.Loadbutton.Size = new System.Drawing.Size(110, 92);
            this.Loadbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Loadbutton.TabIndex = 16;
            this.Loadbutton.TabStop = false;
            this.Loadbutton.Visible = false;
            // 
            // CharPrepScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Câmara_mento___Juan_Montoya.Properties.Resources.Char_Prep;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Loadbutton);
            this.Controls.Add(this.TurnOff);
            this.Controls.Add(this.amTimer);
            this.Controls.Add(this.bringOutCamera);
            this.Controls.Add(this.cam6);
            this.Controls.Add(this.cam2);
            this.Controls.Add(this.cam5);
            this.Controls.Add(this.cam1);
            this.Controls.Add(this.camMap);
            this.Controls.Add(this.JakeCam);
            this.Name = "CharPrepScreen";
            this.Size = new System.Drawing.Size(1091, 663);
            ((System.ComponentModel.ISupportInitialize)(this.cam6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bringOutCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JakeCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loadbutton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cam6;
        private System.Windows.Forms.PictureBox cam2;
        private System.Windows.Forms.PictureBox cam5;
        private System.Windows.Forms.PictureBox cam1;
        private System.Windows.Forms.PictureBox camMap;
        private System.Windows.Forms.PictureBox bringOutCamera;
        private System.Windows.Forms.Label amTimer;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox JakeCam;
        private System.Windows.Forms.PictureBox TurnOff;
        private System.Windows.Forms.PictureBox Loadbutton;
    }
}
