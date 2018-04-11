namespace PROGII_OTRAIS_PRAKT
{
    partial class JaunaRecepte
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.izveidotButton = new System.Windows.Forms.Button();
            this.sastavdalasBox = new System.Windows.Forms.TextBox();
            this.pagatavosanaBox = new System.Windows.Forms.RichTextBox();
            this.bildesIzveleButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nosaukumsBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagatavošana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sastāvdaļas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bildes Izvēle";
            // 
            // izveidotButton
            // 
            this.izveidotButton.Location = new System.Drawing.Point(255, 287);
            this.izveidotButton.Name = "izveidotButton";
            this.izveidotButton.Size = new System.Drawing.Size(69, 31);
            this.izveidotButton.TabIndex = 2;
            this.izveidotButton.Text = "Izveidot";
            this.izveidotButton.UseVisualStyleBackColor = true;
            this.izveidotButton.Click += new System.EventHandler(this.IzveidotButton_Click);
            // 
            // sastavdalasBox
            // 
            this.sastavdalasBox.Location = new System.Drawing.Point(121, 195);
            this.sastavdalasBox.Name = "sastavdalasBox";
            this.sastavdalasBox.Size = new System.Drawing.Size(203, 20);
            this.sastavdalasBox.TabIndex = 3;
            // 
            // pagatavosanaBox
            // 
            this.pagatavosanaBox.Location = new System.Drawing.Point(121, 56);
            this.pagatavosanaBox.Name = "pagatavosanaBox";
            this.pagatavosanaBox.Size = new System.Drawing.Size(203, 113);
            this.pagatavosanaBox.TabIndex = 4;
            this.pagatavosanaBox.Text = "";
            // 
            // bildesIzveleButton
            // 
            this.bildesIzveleButton.Location = new System.Drawing.Point(121, 246);
            this.bildesIzveleButton.Name = "bildesIzveleButton";
            this.bildesIzveleButton.Size = new System.Drawing.Size(203, 23);
            this.bildesIzveleButton.TabIndex = 5;
            this.bildesIzveleButton.Text = "Izvēlēties bildi";
            this.bildesIzveleButton.UseVisualStyleBackColor = true;
            this.bildesIzveleButton.Click += new System.EventHandler(this.bildesIzveleButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nosaukums";
            // 
            // nosaukumsBox
            // 
            this.nosaukumsBox.Location = new System.Drawing.Point(121, 20);
            this.nosaukumsBox.Name = "nosaukumsBox";
            this.nosaukumsBox.Size = new System.Drawing.Size(203, 20);
            this.nosaukumsBox.TabIndex = 7;
            // 
            // JaunaRecepte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 364);
            this.Controls.Add(this.nosaukumsBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bildesIzveleButton);
            this.Controls.Add(this.pagatavosanaBox);
            this.Controls.Add(this.sastavdalasBox);
            this.Controls.Add(this.izveidotButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JaunaRecepte";
            this.Text = "JaunaRecepte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button izveidotButton;
        private System.Windows.Forms.TextBox sastavdalasBox;
        private System.Windows.Forms.RichTextBox pagatavosanaBox;
        private System.Windows.Forms.Button bildesIzveleButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nosaukumsBox;
    }
}