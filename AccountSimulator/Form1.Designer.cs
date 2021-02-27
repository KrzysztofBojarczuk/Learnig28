
namespace AccountSimulator
{
    partial class Form1
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
            this.balanceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.withdrawTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // balanceLabel
            // 
            this.balanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceLabel.Location = new System.Drawing.Point(403, 68);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(100, 23);
            this.balanceLabel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saldo";
            // 
            // withdrawTextBox
            // 
            this.withdrawTextBox.Location = new System.Drawing.Point(432, 199);
            this.withdrawTextBox.Name = "withdrawTextBox";
            this.withdrawTextBox.Size = new System.Drawing.Size(100, 20);
            this.withdrawTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kwota";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(432, 255);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(75, 23);
            this.withdrawButton.TabIndex = 4;
            this.withdrawButton.Text = "Wypłata";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(293, 388);
            this.exitButton.Name = "exitButton";
            this.exitButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Zakończ";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(194, 255);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 6;
            this.depositButton.Text = "Wpłata";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // depositTextBox
            // 
            this.depositTextBox.Location = new System.Drawing.Point(168, 205);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(100, 20);
            this.depositTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kwota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Wpłata na konto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.depositTextBox);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.withdrawTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.balanceLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox withdrawTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox depositTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

