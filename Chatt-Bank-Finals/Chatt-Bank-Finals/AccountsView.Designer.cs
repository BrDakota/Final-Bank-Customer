namespace Chatt_Bank_Finals
{
    partial class AccountsView
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
            AccViewRad = new RadioButton();
            AccCreateRad = new RadioButton();
            DepWitBtn = new Button();
            SubBtn = new Button();
            AccNoBox = new TextBox();
            AccViewBox = new TextBox();
            label1 = new Label();
            CreatePanel = new Panel();
            IntDepBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            chk = new RadioButton();
            sav = new RadioButton();
            mma = new RadioButton();
            CreatePanel.SuspendLayout();
            SuspendLayout();
            // 
            // AccViewRad
            // 
            AccViewRad.AutoSize = true;
            AccViewRad.Location = new Point(146, 291);
            AccViewRad.Name = "AccViewRad";
            AccViewRad.Size = new Size(144, 29);
            AccViewRad.TabIndex = 0;
            AccViewRad.TabStop = true;
            AccViewRad.Text = "View Account";
            AccViewRad.UseVisualStyleBackColor = true;
            AccViewRad.CheckedChanged += AccViewRad_CheckedChanged;
            // 
            // AccCreateRad
            // 
            AccCreateRad.AutoSize = true;
            AccCreateRad.Location = new Point(471, 291);
            AccCreateRad.Name = "AccCreateRad";
            AccCreateRad.Size = new Size(157, 29);
            AccCreateRad.TabIndex = 1;
            AccCreateRad.TabStop = true;
            AccCreateRad.Text = "Create Account";
            AccCreateRad.UseVisualStyleBackColor = true;
            // 
            // DepWitBtn
            // 
            DepWitBtn.Location = new Point(297, 404);
            DepWitBtn.Name = "DepWitBtn";
            DepWitBtn.Size = new Size(173, 34);
            DepWitBtn.TabIndex = 2;
            DepWitBtn.Text = "Deposit/ Withdraw";
            DepWitBtn.UseVisualStyleBackColor = true;
            DepWitBtn.Click += DepWitBtn_Click;
            // 
            // SubBtn
            // 
            SubBtn.Location = new Point(297, 347);
            SubBtn.Name = "SubBtn";
            SubBtn.Size = new Size(173, 34);
            SubBtn.TabIndex = 3;
            SubBtn.Text = "Submit";
            SubBtn.UseVisualStyleBackColor = true;
            SubBtn.Click += SubBtn_Click;
            // 
            // AccNoBox
            // 
            AccNoBox.Location = new Point(229, 124);
            AccNoBox.Name = "AccNoBox";
            AccNoBox.Size = new Size(150, 31);
            AccNoBox.TabIndex = 4;
            // 
            // AccViewBox
            // 
            AccViewBox.Location = new Point(450, 35);
            AccViewBox.Multiline = true;
            AccViewBox.Name = "AccViewBox";
            AccViewBox.ReadOnly = true;
            AccViewBox.ScrollBars = ScrollBars.Vertical;
            AccViewBox.Size = new Size(237, 207);
            AccViewBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 130);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(151, 25);
            label1.TabIndex = 6;
            label1.Text = "Account Number:";
            // 
            // CreatePanel
            // 
            CreatePanel.Controls.Add(IntDepBox);
            CreatePanel.Controls.Add(label3);
            CreatePanel.Controls.Add(label2);
            CreatePanel.Controls.Add(chk);
            CreatePanel.Controls.Add(sav);
            CreatePanel.Controls.Add(mma);
            CreatePanel.Location = new Point(2, 5);
            CreatePanel.Name = "CreatePanel";
            CreatePanel.Size = new Size(796, 280);
            CreatePanel.TabIndex = 7;
            CreatePanel.Visible = false;
            // 
            // IntDepBox
            // 
            IntDepBox.Location = new Point(292, 195);
            IntDepBox.Name = "IntDepBox";
            IntDepBox.Size = new Size(150, 31);
            IntDepBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 198);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 4;
            label3.Text = "Intial Deposit: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 67);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 3;
            label2.Text = "Account Type:";
            // 
            // chk
            // 
            chk.AutoSize = true;
            chk.Location = new Point(301, 100);
            chk.Name = "chk";
            chk.Size = new Size(71, 29);
            chk.TabIndex = 2;
            chk.TabStop = true;
            chk.Text = "CHK";
            chk.UseVisualStyleBackColor = true;
            // 
            // sav
            // 
            sav.AutoSize = true;
            sav.Location = new Point(301, 65);
            sav.Name = "sav";
            sav.Size = new Size(69, 29);
            sav.TabIndex = 1;
            sav.TabStop = true;
            sav.Text = "SAV";
            sav.UseVisualStyleBackColor = true;
            // 
            // mma
            // 
            mma.AutoSize = true;
            mma.Location = new Point(301, 30);
            mma.Name = "mma";
            mma.Size = new Size(81, 29);
            mma.TabIndex = 0;
            mma.TabStop = true;
            mma.Text = "MMA";
            mma.UseVisualStyleBackColor = true;
            // 
            // AccountsView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreatePanel);
            Controls.Add(label1);
            Controls.Add(AccViewBox);
            Controls.Add(AccNoBox);
            Controls.Add(SubBtn);
            Controls.Add(DepWitBtn);
            Controls.Add(AccCreateRad);
            Controls.Add(AccViewRad);
            Name = "AccountsView";
            Text = "AccountsView";
            CreatePanel.ResumeLayout(false);
            CreatePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton AccViewRad;
        private RadioButton AccCreateRad;
        private Button DepWitBtn;
        private Button SubBtn;
        private TextBox AccNoBox;
        private TextBox AccViewBox;
        private Label label1;
        private Panel CreatePanel;
        private TextBox IntDepBox;
        private Label label3;
        private Label label2;
        private RadioButton chk;
        private RadioButton sav;
        private RadioButton mma;
    }
}