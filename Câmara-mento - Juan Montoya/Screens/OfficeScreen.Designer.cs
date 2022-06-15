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
            this.CamDownTimer = new System.Windows.Forms.Timer(this.components);
            this.camDown = new System.Windows.Forms.PictureBox();
            this.amTimer = new System.Windows.Forms.Label();
            this.FaceOffice = new System.Windows.Forms.PictureBox();
            this.JakeOffice = new System.Windows.Forms.PictureBox();
            this.UndyingOffice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bringCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaceOffice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JakeOffice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UndyingOffice)).BeginInit();
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
            this.bringCamera.Location = new System.Drawing.Point(27, 34);
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
            this.hideTable.Click += new System.EventHandler(this.hideTable_Click);
            // 
            // CamDownTimer
            // 
            this.CamDownTimer.Enabled = true;
            this.CamDownTimer.Interval = 500;
            this.CamDownTimer.Tick += new System.EventHandler(this.CamDownTimer_Tick);
            // 
            // camDown
            // 
            this.camDown.Image = ((System.Drawing.Image)(resources.GetObject("camDown.Image")));
            this.camDown.Location = new System.Drawing.Point(3, 0);
            this.camDown.Name = "camDown";
            this.camDown.Size = new System.Drawing.Size(1085, 619);
            this.camDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.camDown.TabIndex = 2;
            this.camDown.TabStop = false;
            // 
            // amTimer
            // 
            this.amTimer.AutoSize = true;
            this.amTimer.BackColor = System.Drawing.Color.White;
            this.amTimer.Font = new System.Drawing.Font("Vladimir Script", 36F);
            this.amTimer.Location = new System.Drawing.Point(916, 34);
            this.amTimer.Name = "amTimer";
            this.amTimer.Size = new System.Drawing.Size(130, 73);
            this.amTimer.TabIndex = 3;
            this.amTimer.Text = "clock";
            // 
            // FaceOffice
            // 
            this.FaceOffice.BackColor = System.Drawing.Color.Transparent;
            this.FaceOffice.Image = ((System.Drawing.Image)(resources.GetObject("FaceOffice.Image")));
            this.FaceOffice.Location = new System.Drawing.Point(-834, -58);
            this.FaceOffice.Name = "FaceOffice";
            this.FaceOffice.Size = new System.Drawing.Size(2568, 923);
            this.FaceOffice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FaceOffice.TabIndex = 4;
            this.FaceOffice.TabStop = false;
            this.FaceOffice.Visible = false;
            // 
            // JakeOffice
            // 
            this.JakeOffice.BackColor = System.Drawing.Color.Transparent;
            this.JakeOffice.Image = ((System.Drawing.Image)(resources.GetObject("JakeOffice.Image")));
            this.JakeOffice.Location = new System.Drawing.Point(534, 55);
            this.JakeOffice.Name = "JakeOffice";
            this.JakeOffice.Size = new System.Drawing.Size(655, 473);
            this.JakeOffice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.JakeOffice.TabIndex = 5;
            this.JakeOffice.TabStop = false;
            this.JakeOffice.Visible = false;
            // 
            // UndyingOffice
            // 
            this.UndyingOffice.BackColor = System.Drawing.Color.Transparent;
            this.UndyingOffice.Image = ((System.Drawing.Image)(resources.GetObject("UndyingOffice.Image")));
            this.UndyingOffice.Location = new System.Drawing.Point(-113, -278);
            this.UndyingOffice.Name = "UndyingOffice";
            this.UndyingOffice.Size = new System.Drawing.Size(1237, 1036);
            this.UndyingOffice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UndyingOffice.TabIndex = 6;
            this.UndyingOffice.TabStop = false;
            this.UndyingOffice.Visible = false;
            // 
            // OfficeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Câmara_mento___Juan_Montoya.Properties.Resources.Office_Lighted;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.amTimer);
            this.Controls.Add(this.hideTable);
            this.Controls.Add(this.bringCamera);
            this.Controls.Add(this.camDown);
            this.Controls.Add(this.FaceOffice);
            this.Controls.Add(this.JakeOffice);
            this.Controls.Add(this.UndyingOffice);
            this.Name = "OfficeScreen";
            this.Size = new System.Drawing.Size(1091, 663);
            ((System.ComponentModel.ISupportInitialize)(this.bringCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaceOffice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JakeOffice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UndyingOffice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox bringCamera;
        private System.Windows.Forms.PictureBox hideTable;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer CamDownTimer;
        private System.Windows.Forms.PictureBox camDown;
        private System.Windows.Forms.Label amTimer;
        private System.Windows.Forms.PictureBox FaceOffice;
        private System.Windows.Forms.PictureBox JakeOffice;
        private System.Windows.Forms.PictureBox UndyingOffice;
    }
}
