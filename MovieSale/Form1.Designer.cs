namespace MovieSale
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tcktPrice = new TextBox();
            btnDisplay = new Button();
            tcktQuantity = new TextBox();
            label4 = new Label();
            label2 = new Label();
            lstOut = new ListBox();
            btnClear = new Button();
            btnQuit = new Button();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 107);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 0;
            label1.Text = "Ticket Price (Each) -";
            // 
            // tcktPrice
            // 
            tcktPrice.Location = new Point(63, 143);
            tcktPrice.Name = "tcktPrice";
            tcktPrice.Size = new Size(588, 31);
            tcktPrice.TabIndex = 1;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = SystemColors.ControlLight;
            btnDisplay.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDisplay.Location = new Point(63, 412);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(174, 94);
            btnDisplay.TabIndex = 2;
            btnDisplay.Text = "&Display Total Ticket Price";
            btnDisplay.UseVisualStyleBackColor = false;
            // 
            // tcktQuantity
            // 
            tcktQuantity.Location = new Point(63, 226);
            tcktQuantity.Name = "tcktQuantity";
            tcktQuantity.Size = new Size(588, 31);
            tcktQuantity.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(270, 41);
            label4.Name = "label4";
            label4.Size = new Size(173, 38);
            label4.TabIndex = 6;
            label4.Text = "Movie Sales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 190);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 7;
            label2.Text = "Ticket Quantity -";
            // 
            // lstOut
            // 
            lstOut.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 45;
            lstOut.Location = new Point(63, 287);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(588, 94);
            lstOut.TabIndex = 8;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlLight;
            btnClear.Location = new Point(269, 412);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(174, 94);
            btnClear.TabIndex = 9;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = SystemColors.ControlLight;
            btnQuit.Location = new Point(477, 412);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(174, 94);
            btnQuit.TabIndex = 10;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 515);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 11;
            label3.Text = "ALT+D";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(327, 515);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 12;
            label5.Text = "ALT+C";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(539, 515);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 13;
            label6.Text = "ALT+Q";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 557);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(lstOut);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(tcktQuantity);
            Controls.Add(btnDisplay);
            Controls.Add(tcktPrice);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Movie Sales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tcktPrice;
        private Button btnDisplay;
        private TextBox tcktQuantity;
        private Label label4;
        private Label label2;
        private ListBox lstOut;
        private Button btnClear;
        private Button btnQuit;
        private Label label3;
        private Label label5;
        private Label label6;
    }
}
