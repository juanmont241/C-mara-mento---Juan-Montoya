namespace Câmara_mento___Juan_Montoya
{
    partial class TableScreen
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
            this.hideTable = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hideTable)).BeginInit();
            this.SuspendLayout();
            // 
            // hideTable
            // 
            this.hideTable.BackColor = System.Drawing.Color.Transparent;
            this.hideTable.BackgroundImage = global::Câmara_mento___Juan_Montoya.Properties.Resources.TableButton;
            this.hideTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hideTable.Location = new System.Drawing.Point(337, 34);
            this.hideTable.Name = "hideTable";
            this.hideTable.Size = new System.Drawing.Size(368, 50);
            this.hideTable.TabIndex = 2;
            this.hideTable.TabStop = false;
            this.hideTable.Click += new System.EventHandler(this.hideTable_Click);
            // 
            // TableScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Câmara_mento___Juan_Montoya.Properties.Resources.Table;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.hideTable);
            this.Name = "TableScreen";
            this.Size = new System.Drawing.Size(1091, 663);
            ((System.ComponentModel.ISupportInitialize)(this.hideTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox hideTable;
    }
}
