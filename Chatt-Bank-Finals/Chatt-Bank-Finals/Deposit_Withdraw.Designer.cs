namespace Chatt_Bank_Finals
{
    partial class Deposit_Withdraw
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
            label1 = new Label();
            label2 = new Label();
            deposit = new RadioButton();
            withdraw = new RadioButton();
            subBtn = new Button();
            backBtn = new Button();
            acctNoBox = new TextBox();
            amountBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 165);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 0;
            label1.Text = "Account Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 218);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 1;
            label2.Text = "Amount: ";
            // 
            // deposit
            // 
            deposit.AutoSize = true;
            deposit.Location = new Point(299, 47);
            deposit.Name = "deposit";
            deposit.Size = new Size(99, 29);
            deposit.TabIndex = 2;
            deposit.TabStop = true;
            deposit.Text = "Deposit";
            deposit.UseVisualStyleBackColor = true;
            // 
            // withdraw
            // 
            withdraw.AutoSize = true;
            withdraw.Location = new Point(299, 82);
            withdraw.Name = "withdraw";
            withdraw.Size = new Size(113, 29);
            withdraw.TabIndex = 3;
            withdraw.TabStop = true;
            withdraw.Text = "Withdraw";
            withdraw.UseVisualStyleBackColor = true;
            // 
            // subBtn
            // 
            subBtn.Location = new Point(316, 312);
            subBtn.Name = "subBtn";
            subBtn.Size = new Size(112, 34);
            subBtn.TabIndex = 4;
            subBtn.Text = "Submit";
            subBtn.UseVisualStyleBackColor = true;
            subBtn.Click += subBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(316, 365);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(112, 34);
            backBtn.TabIndex = 5;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // acctNoBox
            // 
            acctNoBox.Location = new Point(316, 159);
            acctNoBox.Name = "acctNoBox";
            acctNoBox.Size = new Size(210, 31);
            acctNoBox.TabIndex = 6;
            // 
            // amountBox
            // 
            amountBox.Location = new Point(316, 212);
            amountBox.Name = "amountBox";
            amountBox.Size = new Size(210, 31);
            amountBox.TabIndex = 7;
            // 
            // Deposit_Withdraw
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(amountBox);
            Controls.Add(acctNoBox);
            Controls.Add(backBtn);
            Controls.Add(subBtn);
            Controls.Add(withdraw);
            Controls.Add(deposit);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Deposit_Withdraw";
            Text = "Deposit_Withdraw";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton deposit;
        private RadioButton withdraw;
        private Button subBtn;
        private Button backBtn;
        private TextBox acctNoBox;
        private TextBox amountBox;
    }
}