namespace Rougelette
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            picTitle = new PictureBox();
            btnNewGame = new Button();
            ((System.ComponentModel.ISupportInitialize)picTitle).BeginInit();
            SuspendLayout();
            // 
            // picTitle
            // 
            picTitle.Image = (Image)resources.GetObject("picTitle.Image");
            picTitle.Location = new Point(75, 33);
            picTitle.Name = "picTitle";
            picTitle.Size = new Size(632, 73);
            picTitle.SizeMode = PictureBoxSizeMode.StretchImage;
            picTitle.TabIndex = 0;
            picTitle.TabStop = false;
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(331, 186);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(120, 39);
            btnNewGame.TabIndex = 1;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNewGame);
            Controls.Add(picTitle);
            Name = "frmMainMenu";
            Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)picTitle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picTitle;
        private Button btnNewGame;
    }
}