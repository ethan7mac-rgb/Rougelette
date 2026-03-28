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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.merchant;
            pictureBox1.Location = new Point(302, 12);
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
            lblGreetings.Location = new Point(251, 193);
            lblGreetings.Name = "lblGreetings";
            lblGreetings.Size = new Size(257, 30);
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
            // frmItemShop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(800, 690);
            Controls.Add(btnRouge);
            Controls.Add(lblGreetings);
            Controls.Add(lblCoins);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "frmItemShop";
            Text = "ItemShop";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblCoins;
        private Label label2;
        private Label lblGreetings;
        private Button btnRouge;
    }
}