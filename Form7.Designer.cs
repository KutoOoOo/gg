namespace g
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            guna2CircleButton5 = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Название специальности";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(23, 53);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 2;
            label2.Text = "Квалификация";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 71);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Квалификация";
            textBox2.Size = new Size(205, 23);
            textBox2.TabIndex = 3;
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
            guna2CircleButton5.Location = new Point(194, 100);
            guna2CircleButton5.Name = "guna2CircleButton5";
            guna2CircleButton5.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton5.Size = new Size(35, 35);
            guna2CircleButton5.TabIndex = 28;
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
            guna2CircleButton3.Location = new Point(0, 100);
            guna2CircleButton3.Name = "guna2CircleButton3";
            guna2CircleButton3.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton3.Size = new Size(35, 35);
            guna2CircleButton3.TabIndex = 27;
            guna2CircleButton3.Click += guna2CircleButton3_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(230, 136);
            ControlBox = false;
            Controls.Add(guna2CircleButton5);
            Controls.Add(guna2CircleButton3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form7";
            Text = "Добавление специальности";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton5;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
        public TextBox textBox1;
        public TextBox textBox2;
    }
}