namespace Câmara_mento___Juan_Montoya
{
    partial class RoofScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoofScreen));
            this.cam6 = new System.Windows.Forms.PictureBox();
            this.cam2 = new System.Windows.Forms.PictureBox();
            this.cam5 = new System.Windows.Forms.PictureBox();
            this.cam1 = new System.Windows.Forms.PictureBox();
            this.camMap = new System.Windows.Forms.PictureBox();
            this.bringOutCamera = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.amTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cam6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bringOutCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // cam6
            // 
            this.cam6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cam6.BackgroundImage")));
            this.cam6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cam6.Location = new System.Drawing.Point(933, 558);
            this.cam6.Name = "cam6";
            this.cam6.Size = new System.Drawing.Size(77, 56);
            this.cam6.TabIndex = 10;
            this.cam6.TabStop = false;
            // 
            // cam2
            // 
            this.cam2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cam2.BackgroundImage")));
            this.cam2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cam2.Location = new System.Drawing.Point(945, 420);
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
            this.cam5.Location = new System.Drawing.Point(781, 558);
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
            this.cam1.Location = new System.Drawing.Point(781, 418);
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
            this.camMap.Location = new System.Drawing.Point(746, 395);
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
            this.bringOutCamera.Location = new System.Drawing.Point(32, 410);
            this.bringOutCamera.Name = "bringOutCamera";
            this.bringOutCamera.Size = new System.Drawing.Size(86, 225);
            this.bringOutCamera.TabIndex = 11;
            this.bringOutCamera.TabStop = false;
            this.bringOutCamera.Click += new System.EventHandler(this.bringOutCamera_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // amTimer
            // 
            this.amTimer.AutoSize = true;
            this.amTimer.BackColor = System.Drawing.Color.White;
            this.amTimer.Font = new System.Drawing.Font("Vladimir Script", 36F);
            this.amTimer.Location = new System.Drawing.Point(923, 38);
            this.amTimer.Name = "amTimer";
            this.amTimer.Size = new System.Drawing.Size(130, 73);
            this.amTimer.TabIndex = 12;
            this.amTimer.Text = "clock";
            // 
            // RoofScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Câmara_mento___Juan_Montoya.Properties.Resources.Roof;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.amTimer);
            this.Controls.Add(this.bringOutCamera);
            this.Controls.Add(this.cam6);
            this.Controls.Add(this.cam2);
            this.Controls.Add(this.cam5);
            this.Controls.Add(this.cam1);
            this.Controls.Add(this.camMap);
            this.Name = "RoofScreen";
            this.Size = new System.Drawing.Size(1091, 663);
            ((System.ComponentModel.ISupportInitialize)(this.cam6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bringOutCamera)).EndInit();
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
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label amTimer;
    }
}
