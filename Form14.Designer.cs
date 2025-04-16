namespace g
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            guna2CircleButton4 = new Guna.UI2.WinForms.Guna2CircleButton();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(224, 93);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 0;
            label1.Text = "Разработчик Даниленко И.А";
            // 
            // guna2CircleButton4
            // 
            guna2CircleButton4.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton4.FillColor = Color.Gray;
            guna2CircleButton4.Font = new Font("Segoe UI", 9F);
            guna2CircleButton4.ForeColor = Color.White;
            guna2CircleButton4.Image = (Image)resources.GetObject("guna2CircleButton4.Image");
            guna2CircleButton4.ImageAlign = HorizontalAlignment.Right;
            guna2CircleButton4.ImageOffset = new Point(-5, 0);
            guna2CircleButton4.ImageSize = new Size(25, 25);
            guna2CircleButton4.Location = new Point(362, 3);
            guna2CircleButton4.Name = "guna2CircleButton4";
            guna2CircleButton4.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton4.Size = new Size(35, 35);
            guna2CircleButton4.TabIndex = 50;
            guna2CircleButton4.Click += guna2CircleButton4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(307, 30);
            label2.TabIndex = 51;
            label2.Text = "Программа создана для облегчения и автоматизации \r\nучета занятий преподователя ";
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(400, 115);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(guna2CircleButton4);
            Controls.Add(label1);
            Name = "Form14";
            Text = "Информация о программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton4;
        private Label label2;
    }
}