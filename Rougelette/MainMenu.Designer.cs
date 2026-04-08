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
            btnNewGame = new Button();
            btnExit = new Button();
            txtUser = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(86, 442);
            btnNewGame.Margin = new Padding(3, 4, 3, 4);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(137, 52);
            btnNewGame.TabIndex = 1;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(671, 442);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(137, 52);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(380, 369);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(137, 39);
            txtUser.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(380, 325);
            label1.Name = "label1";
            label1.Size = new Size(137, 40);
            label1.TabIndex = 4;
            label1.Text = "Username:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.RougeletteTitle;
            pictureBox1.Location = new Point(150, 11);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(567, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(907, 600);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Controls.Add(btnExit);
            Controls.Add(btnNewGame);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMainMenu";
            Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNewGame;
        private Button btnExit;
        private TextBox txtUser;
        private Label label1;
        private PictureBox pictureBox1;
    }
}