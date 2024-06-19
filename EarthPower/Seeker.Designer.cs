namespace EarthPower
{
    partial class Seeker
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SearchButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ExitButton = new Button();
            BronButton = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(264, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "666666";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 30);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 2;
            label1.Text = "Минимум";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 30);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 3;
            label2.Text = "Максимум";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 9);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 4;
            label3.Text = "Стоимость";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(446, 53);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 5;
            SearchButton.Text = "Искать";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ControlDark;
            flowLayoutPanel1.Location = new Point(12, 98);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(783, 440);
            flowLayoutPanel1.TabIndex = 6;
            flowLayoutPanel1.ControlAdded += flowLayoutPanel1_ControlAdded;
            flowLayoutPanel1.ControlRemoved += flowLayoutPanel1_ControlRemoved;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(867, 5);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // BronButton
            // 
            BronButton.Location = new Point(813, 98);
            BronButton.Name = "BronButton";
            BronButton.Size = new Size(134, 440);
            BronButton.TabIndex = 8;
            BronButton.Text = "Забронировать";
            BronButton.UseVisualStyleBackColor = true;
            BronButton.Click += BronButton_Click;
            // 
            // Seeker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 585);
            Controls.Add(BronButton);
            Controls.Add(ExitButton);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(SearchButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Seeker";
            Text = "Seeker";
            Load += Seeker_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button SearchButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button ExitButton;
        private Button BronButton;
    }
}