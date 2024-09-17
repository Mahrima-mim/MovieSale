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
            tktPrice = new TextBox();
            btnDisplay = new Button();
            tktQuantity = new TextBox();
            label4 = new Label();
            label2 = new Label();
            lstOut = new ListBox();
            btnClear = new Button();
            btnQuit = new Button();
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
            // tktPrice
            // 
            tktPrice.Location = new Point(63, 143);
            tktPrice.Name = "tktPrice";
            tktPrice.Size = new Size(588, 31);
            tktPrice.TabIndex = 1;
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
            // tktQuantity
            // 
            tktQuantity.Location = new Point(63, 226);
            tktQuantity.Name = "tktQuantity";
            tktQuantity.Size = new Size(588, 31);
            tktQuantity.TabIndex = 4;
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
            btnClear.Click += btnClear_Click;
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
            btnQuit.Click += btnQuit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 535);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(lstOut);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(tktQuantity);
            Controls.Add(btnDisplay);
            Controls.Add(tktPrice);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Movie Sales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tktPrice;
        private Button btnDisplay;
        private TextBox tktQuantity;
        private Label label4;
        private Label label2;
        private ListBox lstOut;
        private Button btnClear;
        private Button btnQuit;
    }
}
