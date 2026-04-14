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
            pictureBox3 = new PictureBox();
            btnWheelBuy = new Button();
            pictureBox4 = new PictureBox();
            btnExtraMoney = new Button();
            btnExtraMoney2 = new Button();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            btnExtraLife = new Button();
            lstItems = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.merchant;
            pictureBox1.Location = new Point(306, 12);
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
            lblCoins.Location = new Point(83, 12);
            lblCoins.Name = "lblCoins";
            lblCoins.Size = new Size(100, 30);
            lblCoins.TabIndex = 15;
            lblCoins.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(79, 30);
            label2.TabIndex = 14;
            label2.Text = "Coins: ";
            // 
            // lblGreetings
            // 
            lblGreetings.BackColor = SystemColors.ActiveCaptionText;
            lblGreetings.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGreetings.ForeColor = SystemColors.ButtonHighlight;
            lblGreetings.Location = new Point(204, 148);
            lblGreetings.Name = "lblGreetings";
            lblGreetings.Size = new Size(339, 35);
            lblGreetings.TabIndex = 16;
            lblGreetings.Text = "Stay Awhile and Listen";
            lblGreetings.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRouge
            // 
            btnRouge.Location = new Point(663, 12);
            btnRouge.Name = "btnRouge";
            btnRouge.Size = new Size(125, 51);
            btnRouge.TabIndex = 17;
            btnRouge.Text = "Leave Shop";
            btnRouge.UseVisualStyleBackColor = true;
            btnRouge.Click += btnRouge_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.regent_forge;
            pictureBox2.Location = new Point(10, 208);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(113, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // btnBigSword
            // 
            btnBigSword.Location = new Point(10, 277);
            btnBigSword.Margin = new Padding(3, 2, 3, 2);
            btnBigSword.Name = "btnBigSword";
            btnBigSword.Size = new Size(113, 53);
            btnBigSword.TabIndex = 19;
            btnBigSword.Text = "Buy A Big Sword\r\n2 Gold";
            btnBigSword.UseVisualStyleBackColor = true;
            btnBigSword.Click += btnBigSword_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.spin1;
            pictureBox3.Location = new Point(175, 208);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(134, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // btnWheelBuy
            // 
            btnWheelBuy.Location = new Point(175, 277);
            btnWheelBuy.Margin = new Padding(3, 2, 3, 2);
            btnWheelBuy.Name = "btnWheelBuy";
            btnWheelBuy.Size = new Size(134, 53);
            btnWheelBuy.TabIndex = 21;
            btnWheelBuy.Text = "Buy Random Wheel\r\n4 Gold";
            btnWheelBuy.UseVisualStyleBackColor = true;
            btnWheelBuy.Click += btnWheelBuy_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.spin1;
            pictureBox4.Location = new Point(350, 208);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(128, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // btnExtraMoney
            // 
            btnExtraMoney.Location = new Point(350, 277);
            btnExtraMoney.Margin = new Padding(3, 2, 3, 2);
            btnExtraMoney.Name = "btnExtraMoney";
            btnExtraMoney.Size = new Size(128, 53);
            btnExtraMoney.TabIndex = 23;
            btnExtraMoney.Text = "Buy Extra Return from Number \r\n10  Gold";
            btnExtraMoney.UseVisualStyleBackColor = true;
            btnExtraMoney.Click += btnExtraMoney_Click;
            // 
            // btnExtraMoney2
            // 
            btnExtraMoney2.Location = new Point(175, 416);
            btnExtraMoney2.Margin = new Padding(3, 2, 3, 2);
            btnExtraMoney2.Name = "btnExtraMoney2";
            btnExtraMoney2.Size = new Size(134, 53);
            btnExtraMoney2.TabIndex = 24;
            btnExtraMoney2.Text = "Buy Extra Return from Colour \r\n10  Gold";
            btnExtraMoney2.UseVisualStyleBackColor = true;
            btnExtraMoney2.Click += btnExtraMoney2_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.spin1;
            pictureBox5.Location = new Point(175, 346);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(134, 64);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 25;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.spin1;
            pictureBox6.Location = new Point(10, 346);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(116, 64);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 26;
            pictureBox6.TabStop = false;
            // 
            // btnExtraLife
            // 
            btnExtraLife.Location = new Point(12, 416);
            btnExtraLife.Margin = new Padding(3, 2, 3, 2);
            btnExtraLife.Name = "btnExtraLife";
            btnExtraLife.Size = new Size(113, 53);
            btnExtraLife.TabIndex = 27;
            btnExtraLife.Text = "Buy an Extra Chance \r\n3 Gold";
            btnExtraLife.UseVisualStyleBackColor = true;
            btnExtraLife.Click += btnExtraLife_Click;
            // 
            // lstItems
            // 
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 15;
            lstItems.Location = new Point(572, 211);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(216, 454);
            lstItems.TabIndex = 28;
            // 
            // frmItemShop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(800, 690);
            Controls.Add(lstItems);
            Controls.Add(btnExtraLife);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(btnExtraMoney2);
            Controls.Add(btnExtraMoney);
            Controls.Add(pictureBox4);
            Controls.Add(btnWheelBuy);
            Controls.Add(pictureBox3);
            Controls.Add(btnBigSword);
            Controls.Add(pictureBox2);
            Controls.Add(btnRouge);
            Controls.Add(lblGreetings);
            Controls.Add(lblCoins);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "frmItemShop";
            Text = "ItemShop";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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
        private PictureBox pictureBox3;
        private Button btnWheelBuy;
        private PictureBox pictureBox4;
        private Button btnExtraMoney;
        private Button btnExtraMoney2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button btnExtraLife;
        private ListBox lstItems;
    }
}