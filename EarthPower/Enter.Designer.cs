namespace EarthPower
{
    partial class Enter
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
            EnterButton = new Button();
            RegisterButton = new Button();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // EnterButton
            // 
            EnterButton.Location = new Point(39, 297);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(51, 29);
            EnterButton.TabIndex = 0;
            EnterButton.Text = "Вход";
            EnterButton.UseVisualStyleBackColor = true;
            EnterButton.Click += EnterButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(96, 297);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(108, 29);
            RegisterButton.TabIndex = 1;
            RegisterButton.Text = "Регистрация";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(39, 57);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(165, 27);
            LoginTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(39, 174);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(165, 27);
            PasswordTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 34);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 4;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 151);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 5;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 355);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // Enter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(RegisterButton);
            Controls.Add(EnterButton);
            Name = "Enter";
            Text = "Form1";
            Load += Enter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EnterButton;
        private Button RegisterButton;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}