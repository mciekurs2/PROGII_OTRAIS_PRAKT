namespace PROGII_OTRAIS_PRAKT
{
    partial class Autorizacija
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
            this.lietotajvardsLabel = new System.Windows.Forms.Label();
            this.paroleLabel = new System.Windows.Forms.Label();
            this.lietotajvardsBox = new System.Windows.Forms.TextBox();
            this.paroleBox = new System.Windows.Forms.TextBox();
            this.IenaktButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lietotajvardsLabel
            // 
            this.lietotajvardsLabel.AutoSize = true;
            this.lietotajvardsLabel.Location = new System.Drawing.Point(84, 43);
            this.lietotajvardsLabel.Name = "lietotajvardsLabel";
            this.lietotajvardsLabel.Size = new System.Drawing.Size(67, 13);
            this.lietotajvardsLabel.TabIndex = 0;
            this.lietotajvardsLabel.Text = "Lietotājvārds";
            // 
            // paroleLabel
            // 
            this.paroleLabel.AutoSize = true;
            this.paroleLabel.Location = new System.Drawing.Point(84, 84);
            this.paroleLabel.Name = "paroleLabel";
            this.paroleLabel.Size = new System.Drawing.Size(37, 13);
            this.paroleLabel.TabIndex = 1;
            this.paroleLabel.Text = "Parole";
            // 
            // lietotajvardsBox
            // 
            this.lietotajvardsBox.Location = new System.Drawing.Point(157, 40);
            this.lietotajvardsBox.Name = "lietotajvardsBox";
            this.lietotajvardsBox.Size = new System.Drawing.Size(100, 20);
            this.lietotajvardsBox.TabIndex = 2;
            // 
            // paroleBox
            // 
            this.paroleBox.Location = new System.Drawing.Point(157, 81);
            this.paroleBox.Name = "paroleBox";
            this.paroleBox.Size = new System.Drawing.Size(100, 20);
            this.paroleBox.TabIndex = 3;
            // 
            // IenaktButton
            // 
            this.IenaktButton.Location = new System.Drawing.Point(182, 119);
            this.IenaktButton.Name = "IenaktButton";
            this.IenaktButton.Size = new System.Drawing.Size(75, 23);
            this.IenaktButton.TabIndex = 4;
            this.IenaktButton.Text = "Ienākt";
            this.IenaktButton.UseVisualStyleBackColor = true;
            this.IenaktButton.Click += new System.EventHandler(this.IenaktButton_Click);
            // 
            // Autorizacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 154);
            this.Controls.Add(this.IenaktButton);
            this.Controls.Add(this.paroleBox);
            this.Controls.Add(this.lietotajvardsBox);
            this.Controls.Add(this.paroleLabel);
            this.Controls.Add(this.lietotajvardsLabel);
            this.Name = "Autorizacija";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lietotajvardsLabel;
        private System.Windows.Forms.Label paroleLabel;
        private System.Windows.Forms.TextBox lietotajvardsBox;
        private System.Windows.Forms.TextBox paroleBox;
        private System.Windows.Forms.Button IenaktButton;
    }
}

