namespace EarthPower
{
    partial class Register
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
            EmailTextBox = new TextBox();
            FNFTextBox = new TextBox();
            NumberTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            RegisterButton = new Button();
            button2 = new Button();
            ErrorLabel = new Label();
            SuspendLayout();
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(49, 97);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(125, 27);
            EmailTextBox.TabIndex = 0;
            // 
            // FNFTextBox
            // 
            FNFTextBox.Location = new Point(453, 97);
            FNFTextBox.Name = "FNFTextBox";
            FNFTextBox.Size = new Size(125, 27);
            FNFTextBox.TabIndex = 1;
            // 
            // NumberTextBox
            // 
            NumberTextBox.Location = new Point(453, 225);
            NumberTextBox.Name = "NumberTextBox";
            NumberTextBox.Size = new Size(125, 27);
            NumberTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(49, 225);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(125, 27);
            PasswordTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 74);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 4;
            label1.Text = "Э.Почта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(453, 74);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 5;
            label2.Text = "ФИО";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 202);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 6;
            label3.Text = "Пароль";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(453, 202);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 8;
            label5.Text = "Номер Телефона";
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(238, 304);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(161, 29);
            RegisterButton.TabIndex = 9;
            RegisterButton.Text = "Зарегистрироваться";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(614, 12);
            button2.Name = "button2";
            button2.Size = new Size(28, 29);
            button2.TabIndex = 10;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Location = new Point(283, 202);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 20);
            ErrorLabel.TabIndex = 11;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 450);
            Controls.Add(ErrorLabel);
            Controls.Add(button2);
            Controls.Add(RegisterButton);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTextBox);
            Controls.Add(NumberTextBox);
            Controls.Add(FNFTextBox);
            Controls.Add(EmailTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EmailTextBox;
        private TextBox FNFTextBox;
        private TextBox NumberTextBox;
        private TextBox PasswordTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button RegisterButton;
        private Button button2;
        private Label ErrorLabel;
    }
}