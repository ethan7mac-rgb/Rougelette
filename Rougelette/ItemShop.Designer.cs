namespace Rougelette
{
    partial class frmItemShop
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
            pictureBox1 = new PictureBox();
            lblCoins = new Label();
            label2 = new Label();
            lblGreetings = new Label();
            btnRouge = new Button();
            pictureBox2 = new PictureBox();
            btnBigSword = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.merchant;
            pictureBox1.Location = new Point(345, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblCoins
            // 
            lblCoins.BackColor = SystemColors.ActiveCaptionText;
            lblCoins.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCoins.ForeColor = SystemColors.ButtonHighlight;
            lblCoins.Location = new Point(95, 16);
            lblCoins.Name = "lblCoins";
            lblCoins.Size = new Size(114, 40);
            lblCoins.TabIndex = 15;
            lblCoins.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(14, 16);
            label2.Name = "label2";
            label2.Size = new Size(101, 37);
            label2.TabIndex = 14;
            label2.Text = "Coins: ";
            // 
            // lblGreetings
            // 
            lblGreetings.BackColor = SystemColors.ActiveCaptionText;
            lblGreetings.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGreetings.ForeColor = SystemColors.ButtonHighlight;
            lblGreetings.Location = new Point(287, 257);
            lblGreetings.Name = "lblGreetings";
            lblGreetings.Size = new Size(294, 40);
            lblGreetings.TabIndex = 16;
            lblGreetings.Text = "Stay Awhile and Listen";
            lblGreetings.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRouge
            // 
            btnRouge.Location = new Point(758, 16);
            btnRouge.Margin = new Padding(3, 4, 3, 4);
            btnRouge.Name = "btnRouge";
            btnRouge.Size = new Size(143, 68);
            btnRouge.TabIndex = 17;
            btnRouge.Text = "Leave Shop";
            btnRouge.UseVisualStyleBackColor = true;
            btnRouge.Click += btnRouge_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.regent_forge;
            pictureBox2.Location = new Point(11, 295);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(129, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // btnBigSword
            // 
            btnBigSword.Location = new Point(11, 369);
            btnBigSword.Name = "btnBigSword";
            btnBigSword.Size = new Size(129, 50);
            btnBigSword.TabIndex = 19;
            btnBigSword.Text = "Buy A Big Sword\r\n2 Gold";
            btnBigSword.UseVisualStyleBackColor = true;
            btnBigSword.Click += btnBigSword_Click;
            // 
            // frmItemShop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(914, 920);
            Controls.Add(btnBigSword);
            Controls.Add(pictureBox2);
            Controls.Add(btnRouge);
            Controls.Add(lblGreetings);
            Controls.Add(lblCoins);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmItemShop";
            Text = "ItemShop";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblCoins;
        private Label label2;
        private Label lblGreetings;
        private Button btnRouge;
        private PictureBox pictureBox2;
        private Button btnBigSword;
    }
}