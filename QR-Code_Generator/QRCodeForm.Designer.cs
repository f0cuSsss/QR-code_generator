namespace QR_Code_Generator
{
    partial class QRCodeForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRCodeForm));
            this.QRCode_Full = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.QRCode_Full)).BeginInit();
            this.SuspendLayout();
            // 
            // QRCode_Full
            // 
            this.QRCode_Full.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QRCode_Full.Location = new System.Drawing.Point(12, 12);
            this.QRCode_Full.Name = "QRCode_Full";
            this.QRCode_Full.Size = new System.Drawing.Size(396, 336);
            this.QRCode_Full.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QRCode_Full.TabIndex = 0;
            this.QRCode_Full.TabStop = false;
            // 
            // QRCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 360);
            this.Controls.Add(this.QRCode_Full);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QRCodeForm";
            this.Text = "Превью QR-code";
            ((System.ComponentModel.ISupportInitialize)(this.QRCode_Full)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox QRCode_Full;
    }
}