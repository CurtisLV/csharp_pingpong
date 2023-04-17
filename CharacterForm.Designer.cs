namespace csharp_pingpong
{
    partial class CharacterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.someFaceCharacter = new System.Windows.Forms.PictureBox();
            this.thirdFace = new System.Windows.Forms.PictureBox();
            this.secondFace = new System.Windows.Forms.PictureBox();
            this.fourthFace = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.someFaceCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthFace)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(118, 32);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(565, 73);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Click a Character!";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // someFaceCharacter
            // 
            this.someFaceCharacter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("someFaceCharacter.BackgroundImage")));
            this.someFaceCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.someFaceCharacter.Location = new System.Drawing.Point(55, 192);
            this.someFaceCharacter.Name = "someFaceCharacter";
            this.someFaceCharacter.Size = new System.Drawing.Size(141, 141);
            this.someFaceCharacter.TabIndex = 1;
            this.someFaceCharacter.TabStop = false;
            // 
            // thirdFace
            // 
            this.thirdFace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("thirdFace.BackgroundImage")));
            this.thirdFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thirdFace.Location = new System.Drawing.Point(421, 192);
            this.thirdFace.Name = "thirdFace";
            this.thirdFace.Size = new System.Drawing.Size(141, 142);
            this.thirdFace.TabIndex = 2;
            this.thirdFace.TabStop = false;
            // 
            // secondFace
            // 
            this.secondFace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("secondFace.BackgroundImage")));
            this.secondFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.secondFace.Location = new System.Drawing.Point(238, 192);
            this.secondFace.Name = "secondFace";
            this.secondFace.Size = new System.Drawing.Size(141, 141);
            this.secondFace.TabIndex = 3;
            this.secondFace.TabStop = false;
            // 
            // fourthFace
            // 
            this.fourthFace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fourthFace.BackgroundImage")));
            this.fourthFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fourthFace.Location = new System.Drawing.Point(604, 192);
            this.fourthFace.Name = "fourthFace";
            this.fourthFace.Size = new System.Drawing.Size(141, 141);
            this.fourthFace.TabIndex = 4;
            this.fourthFace.TabStop = false;
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fourthFace);
            this.Controls.Add(this.secondFace);
            this.Controls.Add(this.thirdFace);
            this.Controls.Add(this.someFaceCharacter);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CharacterForm";
            this.Text = "Choose a Character!";
            ((System.ComponentModel.ISupportInitialize)(this.someFaceCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthFace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label titleLabel;
        private PictureBox someFaceCharacter;
        private PictureBox thirdFace;
        private PictureBox secondFace;
        private PictureBox fourthFace;
    }
}