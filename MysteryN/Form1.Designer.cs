namespace MysteryN
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnStartDzah = new System.Windows.Forms.Button();
            this.btnHelpDzah = new System.Windows.Forms.Button();
            this.btnCheese = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDanialZahediDzah = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnStartDzah
            // 
            this.btnStartDzah.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartDzah.BackColor = System.Drawing.Color.Transparent;
            this.btnStartDzah.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStartDzah.BackgroundImage")));
            this.btnStartDzah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartDzah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartDzah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartDzah.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartDzah.ForeColor = System.Drawing.Color.IndianRed;
            this.btnStartDzah.Location = new System.Drawing.Point(100, 375);
            this.btnStartDzah.Name = "btnStartDzah";
            this.btnStartDzah.Size = new System.Drawing.Size(279, 131);
            this.btnStartDzah.TabIndex = 0;
            this.btnStartDzah.UseVisualStyleBackColor = false;
            this.btnStartDzah.Click += new System.EventHandler(this.startGame);
            // 
            // btnHelpDzah
            // 
            this.btnHelpDzah.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelpDzah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelpDzah.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpDzah.Location = new System.Drawing.Point(112, 532);
            this.btnHelpDzah.Name = "btnHelpDzah";
            this.btnHelpDzah.Size = new System.Drawing.Size(94, 42);
            this.btnHelpDzah.TabIndex = 1;
            this.btnHelpDzah.Text = "Help";
            this.btnHelpDzah.UseVisualStyleBackColor = true;
            this.btnHelpDzah.Click += new System.EventHandler(this.help_Click);
            // 
            // btnCheese
            // 
            this.btnCheese.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheese.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheese.Location = new System.Drawing.Point(239, 532);
            this.btnCheese.Name = "btnCheese";
            this.btnCheese.Size = new System.Drawing.Size(125, 42);
            this.btnCheese.TabIndex = 2;
            this.btnCheese.Text = "Picture of cheese";
            this.btnCheese.UseVisualStyleBackColor = true;
            this.btnCheese.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(444, -4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 31);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDanialZahediDzah
            // 
            this.lblDanialZahediDzah.AutoSize = true;
            this.lblDanialZahediDzah.BackColor = System.Drawing.Color.Transparent;
            this.lblDanialZahediDzah.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanialZahediDzah.ForeColor = System.Drawing.Color.White;
            this.lblDanialZahediDzah.Location = new System.Drawing.Point(160, 343);
            this.lblDanialZahediDzah.Name = "lblDanialZahediDzah";
            this.lblDanialZahediDzah.Size = new System.Drawing.Size(161, 29);
            this.lblDanialZahediDzah.TabIndex = 4;
            this.lblDanialZahediDzah.Text = "Danial Zahedi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(478, 598);
            this.Controls.Add(this.lblDanialZahediDzah);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheese);
            this.Controls.Add(this.btnHelpDzah);
            this.Controls.Add(this.btnStartDzah);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Title Screen";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnHelpDzah;
        private System.Windows.Forms.Button btnCheese;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStartDzah;
        private System.Windows.Forms.Label lblDanialZahediDzah;
    }
}

