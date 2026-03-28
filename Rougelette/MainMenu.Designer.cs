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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)picTitle).BeginInit();
            SuspendLayout();
            // 
            // picTitle
            // 
            picTitle.Image = (Image)resources.GetObject("picTitle.Image");
            picTitle.Location = new Point(86, 44);
            picTitle.Margin = new Padding(3, 4, 3, 4);
            picTitle.Name = "picTitle";
            picTitle.Size = new Size(722, 97);
            picTitle.SizeMode = PictureBoxSizeMode.StretchImage;
            picTitle.TabIndex = 0;
            picTitle.TabStop = false;
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(378, 248);
            btnNewGame.Margin = new Padding(3, 4, 3, 4);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(137, 52);
            btnNewGame.TabIndex = 1;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // button1
            // 
            button1.Location = new Point(378, 324);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(137, 52);
            button1.TabIndex = 2;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(907, 600);
            Controls.Add(button1);
            Controls.Add(btnNewGame);
            Controls.Add(picTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMainMenu";
            Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)picTitle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picTitle;
        private Button btnNewGame;
        private Button button1;
    }
}