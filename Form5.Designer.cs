namespace g
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            guna2CircleButton5 = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 21);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Название дисциплины";
            textBox1.Size = new Size(144, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(69, 23);
            textBox2.TabIndex = 1;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 109);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(69, 23);
            textBox3.TabIndex = 2;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(22, 3);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 3;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(0, 47);
            label2.Name = "label2";
            label2.Size = new Size(176, 15);
            label2.TabIndex = 4;
            label2.Text = "Кол-во часов на практ занятия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(0, 91);
            label3.Name = "label3";
            label3.Size = new Size(140, 15);
            label3.TabIndex = 5;
            label3.Text = "Кол-во часов на лекции";
            // 
            // guna2CircleButton5
            // 
            guna2CircleButton5.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton5.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton5.FillColor = Color.Gray;
            guna2CircleButton5.Font = new Font("Segoe UI", 9F);
            guna2CircleButton5.ForeColor = Color.White;
            guna2CircleButton5.Image = (Image)resources.GetObject("guna2CircleButton5.Image");
            guna2CircleButton5.ImageAlign = HorizontalAlignment.Right;
            guna2CircleButton5.ImageOffset = new Point(-7, 0);
            guna2CircleButton5.ImageSize = new Size(31, 31);
            guna2CircleButton5.Location = new Point(141, 138);
            guna2CircleButton5.Name = "guna2CircleButton5";
            guna2CircleButton5.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton5.Size = new Size(35, 35);
            guna2CircleButton5.TabIndex = 26;
            guna2CircleButton5.Click += guna2CircleButton5_Click;
            // 
            // guna2CircleButton3
            // 
            guna2CircleButton3.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton3.FillColor = Color.Gray;
            guna2CircleButton3.Font = new Font("Segoe UI", 9F);
            guna2CircleButton3.ForeColor = Color.White;
            guna2CircleButton3.Image = (Image)resources.GetObject("guna2CircleButton3.Image");
            guna2CircleButton3.ImageAlign = HorizontalAlignment.Right;
            guna2CircleButton3.ImageOffset = new Point(-5, 0);
            guna2CircleButton3.ImageSize = new Size(29, 29);
            guna2CircleButton3.Location = new Point(0, 138);
            guna2CircleButton3.Name = "guna2CircleButton3";
            guna2CircleButton3.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton3.Size = new Size(35, 35);
            guna2CircleButton3.TabIndex = 25;
            guna2CircleButton3.Click += guna2CircleButton3_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(180, 177);
            ControlBox = false;
            Controls.Add(guna2CircleButton5);
            Controls.Add(guna2CircleButton3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form5";
            Text = "Добавление дисциплины";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton5;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
        public TextBox textBox1;
        public TextBox textBox2;
        public TextBox textBox3;
    }
}