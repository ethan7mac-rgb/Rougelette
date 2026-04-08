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
            btnExit = new Button();
            txtUser = new TextBox();
            label1 = new Label();
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
            btnNewGame.Location = new Point(75, 332);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(120, 39);
            btnNewGame.TabIndex = 1;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(587, 332);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 39);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(335, 209);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(120, 33);
            txtUser.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(335, 176);
            label1.Name = "label1";
            label1.Size = new Size(120, 30);
            label1.TabIndex = 4;
            label1.Text = "Username:";
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(794, 450);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Controls.Add(btnExit);
            Controls.Add(btnNewGame);
            Controls.Add(picTitle);
            Name = "frmMainMenu";
            Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)picTitle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picTitle;
        private Button btnNewGame;
        private Button btnExit;
        private TextBox txtUser;
        private Label label1;
    }
}