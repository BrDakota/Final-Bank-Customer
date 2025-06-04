namespace Chatt_Bank_Finals
{
    partial class Login
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
            Log_IdBox = new TextBox();
            Log_PassBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            LoginBtn = new Button();
            SuspendLayout();
            // 
            // Log_IdBox
            // 
            Log_IdBox.Location = new Point(325, 150);
            Log_IdBox.Name = "Log_IdBox";
            Log_IdBox.Size = new Size(150, 31);
            Log_IdBox.TabIndex = 0;
            // 
            // Log_PassBox
            // 
            Log_PassBox.Location = new Point(325, 210);
            Log_PassBox.Name = "Log_PassBox";
            Log_PassBox.Size = new Size(150, 31);
            Log_PassBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 156);
            label1.Name = "label1";
            label1.Size = new Size(37, 25);
            label1.TabIndex = 2;
            label1.Text = "Id: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 216);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 3;
            label2.Text = "Password: ";
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(325, 317);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(112, 34);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Log_PassBox);
            Controls.Add(Log_IdBox);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Log_IdBox;
        private TextBox Log_PassBox;
        private Label label1;
        private Label label2;
        private Button LoginBtn;
    }
}