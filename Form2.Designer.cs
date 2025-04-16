namespace g
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            menuStrip1 = new MenuStrip();
            вфаToolStripMenuItem = new ToolStripMenuItem();
            ааToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            экспортToolStripMenuItem = new ToolStripMenuItem();
            импортToolStripMenuItem1 = new ToolStripMenuItem();
            guna2CircleButton4 = new Guna.UI2.WinForms.Guna2CircleButton();
            menuStrip2 = new MenuStrip();
            toolStripMenuItem2 = new ToolStripMenuItem();
            занятияToolStripMenuItem = new ToolStripMenuItem();
            преподователиToolStripMenuItem = new ToolStripMenuItem();
            группыToolStripMenuItem = new ToolStripMenuItem();
            специальностиToolStripMenuItem = new ToolStripMenuItem();
            дисциплиныToolStripMenuItem = new ToolStripMenuItem();
            toolTip1 = new ToolTip(components);
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(64, 64, 64);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 402);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(557, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.ForeColor = SystemColors.ButtonFace;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(84, 17);
            toolStripStatusLabel1.Text = "Пользователь";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.ForeColor = SystemColors.ButtonFace;
            toolStripStatusLabel2.Margin = new Padding(400, 3, 0, 2);
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.RightToLeft = RightToLeft.No;
            toolStripStatusLabel2.Size = new Size(79, 17);
            toolStripStatusLabel2.Text = "Дата и время";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(238, 41);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 46;
            label3.Text = "Год";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(339, 41);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 47;
            label2.Text = "Дисциплина";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(23, 42);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 45;
            label1.Text = "Преподователь";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(227, 59);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(77, 23);
            comboBox3.TabIndex = 43;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(326, 59);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 23);
            comboBox2.TabIndex = 44;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.HighlightText;
            comboBox1.ForeColor = Color.Black;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 59);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(185, 23);
            comboBox1.TabIndex = 42;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // guna2DataGridView1
            // 
            guna2DataGridView1.AllowUserToAddRows = false;
            guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.BackgroundColor = Color.DimGray;
            guna2DataGridView1.BorderStyle = BorderStyle.Fixed3D;
            guna2DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 34;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Gray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.SelectionBackColor = Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = Color.Silver;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(64, 64, 64);
            guna2DataGridView1.Location = new Point(11, 130);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.Size = new Size(535, 246);
            guna2DataGridView1.TabIndex = 41;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.DimGray;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(64, 64, 64);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 34;
            guna2DataGridView1.ThemeStyle.ReadOnly = true;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.ForeColor = SystemColors.Control;
            guna2HtmlLabel3.Location = new Point(270, 382);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(84, 17);
            guna2HtmlLabel3.TabIndex = 38;
            guna2HtmlLabel3.Text = "Практических:";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.ForeColor = SystemColors.Control;
            guna2HtmlLabel4.Location = new Point(11, 382);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(124, 17);
            guna2HtmlLabel4.TabIndex = 39;
            guna2HtmlLabel4.Text = "Всего по дисциплине:";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.ForeColor = SystemColors.Control;
            guna2HtmlLabel2.Location = new Point(176, 382);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(47, 17);
            guna2HtmlLabel2.TabIndex = 40;
            guna2HtmlLabel2.Text = "Лекций: ";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.FromArgb(64, 64, 64);
            guna2HtmlLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            guna2HtmlLabel1.ForeColor = SystemColors.Control;
            guna2HtmlLabel1.Location = new Point(66, 88);
            guna2HtmlLabel1.MaximumSize = new Size(393, 0);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(393, 36);
            guna2HtmlLabel1.TabIndex = 37;
            guna2HtmlLabel1.Text = "Календарно-тематический план по дисциплине ? преподователь ?";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(64, 64, 64);
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuStrip1.Items.AddRange(new ToolStripItem[] { вфаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 2);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(50, 38);
            menuStrip1.TabIndex = 48;
            menuStrip1.Text = "menuStrip1";
            toolTip1.SetToolTip(menuStrip1, "Администрирование\r\n");
            // 
            // вфаToolStripMenuItem
            // 
            вфаToolStripMenuItem.AutoToolTip = true;
            вфаToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            вфаToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            вфаToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            вфаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ааToolStripMenuItem, toolStripMenuItem1 });
            вфаToolStripMenuItem.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            вфаToolStripMenuItem.Image = (Image)resources.GetObject("вфаToolStripMenuItem.Image");
            вфаToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            вфаToolStripMenuItem.ImageTransparentColor = Color.FromArgb(64, 64, 64);
            вфаToolStripMenuItem.Name = "вфаToolStripMenuItem";
            вфаToolStripMenuItem.Size = new Size(42, 34);
            вфаToolStripMenuItem.Tag = "пп";
            вфаToolStripMenuItem.Text = "    ";
            вфаToolStripMenuItem.ToolTipText = "Администрирование  ";
            // 
            // ааToolStripMenuItem
            // 
            ааToolStripMenuItem.Name = "ааToolStripMenuItem";
            ааToolStripMenuItem.Size = new Size(229, 22);
            ааToolStripMenuItem.Text = "Управление пользователями";
            ааToolStripMenuItem.Click += ааToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { экспортToolStripMenuItem, импортToolStripMenuItem1 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(229, 22);
            toolStripMenuItem1.Text = "Резервное копирование";
            // 
            // экспортToolStripMenuItem
            // 
            экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            экспортToolStripMenuItem.Size = new Size(118, 22);
            экспортToolStripMenuItem.Text = "Экспорт";
            // 
            // импортToolStripMenuItem1
            // 
            импортToolStripMenuItem1.Name = "импортToolStripMenuItem1";
            импортToolStripMenuItem1.Size = new Size(118, 22);
            импортToolStripMenuItem1.Text = "Импорт";
            // 
            // guna2CircleButton4
            // 
            guna2CircleButton4.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton4.FillColor = Color.FromArgb(64, 64, 64);
            guna2CircleButton4.Font = new Font("Segoe UI", 9F);
            guna2CircleButton4.ForeColor = Color.White;
            guna2CircleButton4.Image = (Image)resources.GetObject("guna2CircleButton4.Image");
            guna2CircleButton4.ImageAlign = HorizontalAlignment.Right;
            guna2CircleButton4.ImageOffset = new Point(-5, 0);
            guna2CircleButton4.ImageSize = new Size(25, 25);
            guna2CircleButton4.Location = new Point(522, 2);
            guna2CircleButton4.Name = "guna2CircleButton4";
            guna2CircleButton4.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton4.Size = new Size(35, 35);
            guna2CircleButton4.TabIndex = 49;
            toolTip1.SetToolTip(guna2CircleButton4, "Выход");
            guna2CircleButton4.Click += guna2CircleButton4_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.FromArgb(64, 64, 64);
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            menuStrip2.Location = new Point(51, 2);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(52, 40);
            menuStrip2.TabIndex = 50;
            menuStrip2.Text = "menuStrip2";
            toolTip1.SetToolTip(menuStrip2, "Данные");
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { занятияToolStripMenuItem, преподователиToolStripMenuItem, группыToolStripMenuItem, специальностиToolStripMenuItem, дисциплиныToolStripMenuItem });
            toolStripMenuItem2.Image = (Image)resources.GetObject("toolStripMenuItem2.Image");
            toolStripMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(44, 36);
            toolStripMenuItem2.Text = "Данные";
            // 
            // занятияToolStripMenuItem
            // 
            занятияToolStripMenuItem.Name = "занятияToolStripMenuItem";
            занятияToolStripMenuItem.Size = new Size(160, 22);
            занятияToolStripMenuItem.Text = "Занятия";
            занятияToolStripMenuItem.Click += занятияToolStripMenuItem_Click;
            // 
            // преподователиToolStripMenuItem
            // 
            преподователиToolStripMenuItem.Name = "преподователиToolStripMenuItem";
            преподователиToolStripMenuItem.Size = new Size(160, 22);
            преподователиToolStripMenuItem.Text = "Преподователи";
            преподователиToolStripMenuItem.Click += преподователиToolStripMenuItem_Click;
            // 
            // группыToolStripMenuItem
            // 
            группыToolStripMenuItem.Name = "группыToolStripMenuItem";
            группыToolStripMenuItem.Size = new Size(160, 22);
            группыToolStripMenuItem.Text = "Группы";
            группыToolStripMenuItem.Click += группыToolStripMenuItem_Click;
            // 
            // специальностиToolStripMenuItem
            // 
            специальностиToolStripMenuItem.Name = "специальностиToolStripMenuItem";
            специальностиToolStripMenuItem.Size = new Size(160, 22);
            специальностиToolStripMenuItem.Text = "Специальности";
            специальностиToolStripMenuItem.Click += специальностиToolStripMenuItem_Click;
            // 
            // дисциплиныToolStripMenuItem
            // 
            дисциплиныToolStripMenuItem.Name = "дисциплиныToolStripMenuItem";
            дисциплиныToolStripMenuItem.Size = new Size(160, 22);
            дисциплиныToolStripMenuItem.Text = "Дисциплины";
            дисциплиныToolStripMenuItem.Click += дисциплиныToolStripMenuItem_Click;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.FromArgb(64, 64, 64);
            guna2CircleButton1.FocusedColor = Color.FromArgb(64, 64, 64);
            guna2CircleButton1.Font = new Font("Segoe UI", 9F);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Image = (Image)resources.GetObject("guna2CircleButton1.Image");
            guna2CircleButton1.ImageAlign = HorizontalAlignment.Right;
            guna2CircleButton1.ImageOffset = new Point(-10, 0);
            guna2CircleButton1.ImageSize = new Size(35, 35);
            guna2CircleButton1.Location = new Point(115, 2);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(35, 35);
            guna2CircleButton1.TabIndex = 52;
            guna2CircleButton1.Click += guna2CircleButton1_Click_1;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(557, 424);
            ControlBox = false;
            Controls.Add(guna2CircleButton1);
            Controls.Add(guna2CircleButton4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(guna2DataGridView1);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            ForeColor = Color.FromArgb(224, 224, 224);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главное окно";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem вфаToolStripMenuItem;
        private ToolStripMenuItem ааToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem экспортToolStripMenuItem;
        private ToolStripMenuItem импортToolStripMenuItem1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton4;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem занятияToolStripMenuItem;
        private ToolStripMenuItem преподователиToolStripMenuItem;
        private ToolStripMenuItem группыToolStripMenuItem;
        private ToolStripMenuItem специальностиToolStripMenuItem;
        private ToolStripMenuItem дисциплиныToolStripMenuItem;
        private ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.Timer timer1;
    }
}