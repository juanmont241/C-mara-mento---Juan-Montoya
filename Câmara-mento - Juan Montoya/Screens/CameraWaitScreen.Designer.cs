namespace Câmara_mento___Juan_Montoya
{
    partial class CameraWaitScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraWaitScreen));
            this.CamUpTimer = new System.Windows.Forms.Timer(this.components);
            this.CamUp = new System.Windows.Forms.PictureBox();
            this.camMap = new System.Windows.Forms.PictureBox();
            this.cam1 = new System.Windows.Forms.PictureBox();
            this.cam5 = new System.Windows.Forms.PictureBox();
            this.cam2 = new System.Windows.Forms.PictureBox();
            this.cam6 = new System.Windows.Forms.PictureBox();
            this.bringOutCamera = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CamUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bringOutCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // CamUpTimer
            // 
            this.CamUpTimer.Enabled = true;
            this.CamUpTimer.Interval = 500;
            this.CamUpTimer.Tick += new System.EventHandler(this.CamUpTimer_Tick);
            // 
            // CamUp
            // 
            this.CamUp.BackColor = System.Drawing.Color.Black;
            this.CamUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CamUp.BackgroundImage")));
            this.CamUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CamUp.Location = new System.Drawing.Point(3, 0);
            this.CamUp.Name = "CamUp";
            this.CamUp.Size = new System.Drawing.Size(1088, 627);
            this.CamUp.TabIndex = 0;
            this.CamUp.TabStop = false;
            // 
            // camMap
            // 
            this.camMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("camMap.BackgroundImage")));
            this.camMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.camMap.Location = new System.Drawing.Point(743, 395);
            this.camMap.Name = "camMap";
            this.camMap.Size = new System.Drawing.Size(307, 219);
            this.camMap.TabIndex = 1;
            this.camMap.TabStop = false;
            // 
            // cam1
            // 
            this.cam1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cam1.BackgroundImage")));
            this.cam1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cam1.Location = new System.Drawing.Point(778, 418);
            this.cam1.Name = "cam1";
            this.cam1.Size = new System.Drawing.Size(77, 58);
            this.cam1.TabIndex = 2;
            this.cam1.TabStop = false;
            this.cam1.Click += new System.EventHandler(this.cam1_Click);
            // 
            // cam5
            // 
            this.cam5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cam5.BackgroundImage")));
            this.cam5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cam5.Location = new System.Drawing.Point(778, 558);
            this.cam5.Name = "cam5";
            this.cam5.Size = new System.Drawing.Size(87, 56);
            this.cam5.TabIndex = 3;
            this.cam5.TabStop = false;
            this.cam5.Click += new System.EventHandler(this.cam5_Click);
            // 
            // cam2
            // 
            this.cam2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cam2.BackgroundImage")));
            this.cam2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cam2.Location = new System.Drawing.Point(942, 420);
            this.cam2.Name = "cam2";
            this.cam2.Size = new System.Drawing.Size(77, 56);
            this.cam2.TabIndex = 4;
            this.cam2.TabStop = false;
            this.cam2.Click += new System.EventHandler(this.cam2_Click);
            // 
            // cam6
            // 
            this.cam6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cam6.BackgroundImage")));
            this.cam6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cam6.Location = new System.Drawing.Point(930, 558);
            this.cam6.Name = "cam6";
            this.cam6.Size = new System.Drawing.Size(77, 56);
            this.cam6.TabIndex = 5;
            this.cam6.TabStop = false;
            // 
            // bringOutCamera
            // 
            this.bringOutCamera.BackColor = System.Drawing.Color.Transparent;
            this.bringOutCamera.BackgroundImage = global::Câmara_mento___Juan_Montoya.Properties.Resources.Bring_Up_Monitor;
            this.bringOutCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bringOutCamera.Location = new System.Drawing.Point(34, 411);
            this.bringOutCamera.Name = "bringOutCamera";
            this.bringOutCamera.Size = new System.Drawing.Size(86, 225);
            this.bringOutCamera.TabIndex = 6;
            this.bringOutCamera.TabStop = false;
            this.bringOutCamera.Click += new System.EventHandler(this.bringOutCamera_Click);
            // 
            // CameraWaitScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Câmara_mento___Juan_Montoya.Properties.Resources.Five_nights_camara_layout;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.bringOutCamera);
            this.Controls.Add(this.cam6);
            this.Controls.Add(this.cam2);
            this.Controls.Add(this.cam5);
            this.Controls.Add(this.cam1);
            this.Controls.Add(this.camMap);
            this.Controls.Add(this.CamUp);
            this.DoubleBuffered = true;
            this.Name = "CameraWaitScreen";
            this.Size = new System.Drawing.Size(1091, 663);
            ((System.ComponentModel.ISupportInitialize)(this.CamUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cam6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bringOutCamera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer CamUpTimer;
        private System.Windows.Forms.PictureBox CamUp;
        private System.Windows.Forms.PictureBox camMap;
        private System.Windows.Forms.PictureBox cam1;
        private System.Windows.Forms.PictureBox cam5;
        private System.Windows.Forms.PictureBox cam2;
        private System.Windows.Forms.PictureBox cam6;
        private System.Windows.Forms.PictureBox bringOutCamera;
    }
}
