namespace Rougelette
{
    partial class frmCharacterSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCharacterSelect));
            picChar1 = new PictureBox();
            lblCharDesc1 = new Label();
            btnChar1Select = new Button();
            ((System.ComponentModel.ISupportInitialize)picChar1).BeginInit();
            SuspendLayout();
            // 
            // picChar1
            // 
            picChar1.Image = (Image)resources.GetObject("picChar1.Image");
            picChar1.Location = new Point(343, 113);
            picChar1.Name = "picChar1";
            picChar1.Size = new Size(135, 77);
            picChar1.SizeMode = PictureBoxSizeMode.StretchImage;
            picChar1.TabIndex = 3;
            picChar1.TabStop = false;
            // 
            // lblCharDesc1
            // 
            lblCharDesc1.ForeColor = SystemColors.ButtonHighlight;
            lblCharDesc1.Location = new Point(343, 207);
            lblCharDesc1.Name = "lblCharDesc1";
            lblCharDesc1.Size = new Size(135, 50);
            lblCharDesc1.TabIndex = 1;
            lblCharDesc1.Text = "Sample Char Desc";
            // 
            // btnChar1Select
            // 
            btnChar1Select.Location = new Point(343, 260);
            btnChar1Select.Name = "btnChar1Select";
            btnChar1Select.Size = new Size(135, 26);
            btnChar1Select.TabIndex = 2;
            btnChar1Select.Text = "Slect This Character";
            btnChar1Select.UseVisualStyleBackColor = true;
            // 
            // frmCharacterSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChar1Select);
            Controls.Add(lblCharDesc1);
            Controls.Add(picChar1);
            Name = "frmCharacterSelect";
            Text = "CharacterSelect";
            ((System.ComponentModel.ISupportInitialize)picChar1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picChar1;
        private Label lblCharDesc1;
        private Button btnChar1Select;
    }
}