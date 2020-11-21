namespace QR_Code_Generator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.generText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EncodeQRcode = new System.Windows.Forms.Button();
            this.saveQRcode = new System.Windows.Forms.Button();
            this.copyQRcode = new System.Windows.Forms.Button();
            this.decryptQRcode = new System.Windows.Forms.Button();
            this.uploadQRcode = new System.Windows.Forms.Button();
            this.QRcode = new System.Windows.Forms.PictureBox();
            this.btnOpenNewTab = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.QRcode)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // generText
            // 
            this.generText.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generText.Location = new System.Drawing.Point(16, 58);
            this.generText.Multiline = true;
            this.generText.Name = "generText";
            this.generText.Size = new System.Drawing.Size(203, 26);
            this.generText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите текст";
            // 
            // EncodeQRcode
            // 
            this.EncodeQRcode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncodeQRcode.Location = new System.Drawing.Point(16, 100);
            this.EncodeQRcode.Name = "EncodeQRcode";
            this.EncodeQRcode.Size = new System.Drawing.Size(203, 28);
            this.EncodeQRcode.TabIndex = 2;
            this.EncodeQRcode.Text = "Закодировать QR-код";
            this.EncodeQRcode.UseVisualStyleBackColor = true;
            this.EncodeQRcode.Click += new System.EventHandler(this.EncodeQRcode_Click);
            // 
            // saveQRcode
            // 
            this.saveQRcode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveQRcode.Location = new System.Drawing.Point(16, 143);
            this.saveQRcode.Name = "saveQRcode";
            this.saveQRcode.Size = new System.Drawing.Size(203, 28);
            this.saveQRcode.TabIndex = 3;
            this.saveQRcode.Text = "Сохранить QR-код";
            this.saveQRcode.UseVisualStyleBackColor = true;
            this.saveQRcode.Click += new System.EventHandler(this.saveQRcode_Click);
            // 
            // copyQRcode
            // 
            this.copyQRcode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyQRcode.Location = new System.Drawing.Point(16, 188);
            this.copyQRcode.Name = "copyQRcode";
            this.copyQRcode.Size = new System.Drawing.Size(203, 28);
            this.copyQRcode.TabIndex = 4;
            this.copyQRcode.Text = "Копировать QR-код";
            this.copyQRcode.UseVisualStyleBackColor = true;
            this.copyQRcode.Click += new System.EventHandler(this.copyQRcode_Click);
            // 
            // decryptQRcode
            // 
            this.decryptQRcode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptQRcode.Location = new System.Drawing.Point(16, 234);
            this.decryptQRcode.Name = "decryptQRcode";
            this.decryptQRcode.Size = new System.Drawing.Size(203, 28);
            this.decryptQRcode.TabIndex = 5;
            this.decryptQRcode.Text = "Расшифровать QR-код";
            this.decryptQRcode.UseVisualStyleBackColor = true;
            this.decryptQRcode.Click += new System.EventHandler(this.decryptQRcode_Click);
            // 
            // uploadQRcode
            // 
            this.uploadQRcode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadQRcode.Location = new System.Drawing.Point(16, 279);
            this.uploadQRcode.Name = "uploadQRcode";
            this.uploadQRcode.Size = new System.Drawing.Size(203, 28);
            this.uploadQRcode.TabIndex = 6;
            this.uploadQRcode.Text = "Загрузить QR-код";
            this.uploadQRcode.UseVisualStyleBackColor = true;
            this.uploadQRcode.Click += new System.EventHandler(this.uploadQRcode_Click);
            // 
            // QRcode
            // 
            this.QRcode.Location = new System.Drawing.Point(245, 39);
            this.QRcode.Name = "QRcode";
            this.QRcode.Size = new System.Drawing.Size(275, 275);
            this.QRcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QRcode.TabIndex = 7;
            this.QRcode.TabStop = false;
            // 
            // btnOpenNewTab
            // 
            this.btnOpenNewTab.Enabled = false;
            this.btnOpenNewTab.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenNewTab.Location = new System.Drawing.Point(329, 320);
            this.btnOpenNewTab.Name = "btnOpenNewTab";
            this.btnOpenNewTab.Size = new System.Drawing.Size(191, 25);
            this.btnOpenNewTab.TabIndex = 8;
            this.btnOpenNewTab.Text = "Открыть в новой вкладке";
            this.btnOpenNewTab.UseVisualStyleBackColor = true;
            this.btnOpenNewTab.Click += new System.EventHandler(this.btnOpenNewTab_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(536, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьToolStripMenuItem});
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.цветToolStripMenuItem.Text = "Цвет";
            // 
            // выбратьToolStripMenuItem
            // 
            this.выбратьToolStripMenuItem.Name = "выбратьToolStripMenuItem";
            this.выбратьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.выбратьToolStripMenuItem.Text = "Выбрать";
            this.выбратьToolStripMenuItem.Click += new System.EventHandler(this.выбратьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(536, 353);
            this.Controls.Add(this.btnOpenNewTab);
            this.Controls.Add(this.QRcode);
            this.Controls.Add(this.uploadQRcode);
            this.Controls.Add(this.decryptQRcode);
            this.Controls.Add(this.copyQRcode);
            this.Controls.Add(this.saveQRcode);
            this.Controls.Add(this.EncodeQRcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generText);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(541, 365);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR-Code generator";
            ((System.ComponentModel.ISupportInitialize)(this.QRcode)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox generText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EncodeQRcode;
        private System.Windows.Forms.Button saveQRcode;
        private System.Windows.Forms.Button copyQRcode;
        private System.Windows.Forms.Button decryptQRcode;
        private System.Windows.Forms.Button uploadQRcode;
        private System.Windows.Forms.PictureBox QRcode;
        private System.Windows.Forms.Button btnOpenNewTab;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьToolStripMenuItem;
    }
}

