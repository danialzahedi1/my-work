namespace MysteryN
{
    partial class cheesepic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cheesepic));
            this.btnEatCheeseDzah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEatCheeseDzah
            // 
            this.btnEatCheeseDzah.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEatCheeseDzah.Location = new System.Drawing.Point(39, 150);
            this.btnEatCheeseDzah.Name = "btnEatCheeseDzah";
            this.btnEatCheeseDzah.Size = new System.Drawing.Size(204, 201);
            this.btnEatCheeseDzah.TabIndex = 0;
            this.btnEatCheeseDzah.Text = "Eat the cheese";
            this.btnEatCheeseDzah.UseVisualStyleBackColor = true;
            this.btnEatCheeseDzah.Click += new System.EventHandler(this.button1_Click);
            // 
            // cheesepic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1070, 523);
            this.Controls.Add(this.btnEatCheeseDzah);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cheesepic";
            this.Text = "cheesepic";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEatCheeseDzah;
    }
}