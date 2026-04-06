namespace Rougelette.Items
{
    partial class frmABigSwordOpt
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
            btnGold = new Button();
            btnOdds = new Button();
            btnBoth = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGold
            // 
            btnGold.Location = new Point(12, 183);
            btnGold.Name = "btnGold";
            btnGold.Size = new Size(58, 23);
            btnGold.TabIndex = 0;
            btnGold.Text = "Gold";
            btnGold.UseVisualStyleBackColor = true;
            btnGold.Click += btnGold_Click;
            // 
            // btnOdds
            // 
            btnOdds.Location = new Point(242, 183);
            btnOdds.Name = "btnOdds";
            btnOdds.Size = new Size(58, 23);
            btnOdds.TabIndex = 1;
            btnOdds.Text = "Forge";
            btnOdds.UseVisualStyleBackColor = true;
            btnOdds.Click += btnOdds_Click;
            // 
            // btnBoth
            // 
            btnBoth.Location = new Point(124, 183);
            btnBoth.Name = "btnBoth";
            btnBoth.Size = new Size(58, 23);
            btnBoth.TabIndex = 2;
            btnBoth.Text = "Both";
            btnBoth.UseVisualStyleBackColor = true;
            btnBoth.Click += btnBoth_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(288, 102);
            label1.TabIndex = 3;
            label1.Text = "Would you like gold, to forge and increase your odds or both?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmABigSwordOpt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(312, 246);
            Controls.Add(label1);
            Controls.Add(btnBoth);
            Controls.Add(btnOdds);
            Controls.Add(btnGold);
            Name = "frmABigSwordOpt";
            Text = "ABigSwordOpt";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGold;
        private Button btnOdds;
        private Button btnBoth;
        private Label label1;
    }
}