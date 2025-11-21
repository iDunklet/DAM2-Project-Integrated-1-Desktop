namespace FormsDesktop
{
    partial class LeadingPage
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panelDivisor1 = new Panel();
            panelDivisor2 = new Panel();
            panelSuperior = new FlowLayoutPanel();
            flowLayoutPanelHeader = new FlowLayoutPanel();
            comboBoxOrdenar = new ComboBox();
            comboBoxTipoJuegos = new ComboBox();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Location = new Point(282, 833);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(400, 60);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(227, 234, 255);
            button1.Image = Properties.Resources.icon_buton_lapiz_1_;
            button1.Location = new Point(3, 4);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(74, 87);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(227, 234, 255);
            button2.BackgroundImage = Properties.Resources.borrar;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(83, 4);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(74, 87);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(227, 234, 255);
            button3.Image = Properties.Resources.icon_buton_importar_1_;
            button3.Location = new Point(163, 4);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(74, 87);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panelDivisor1
            // 
            panelDivisor1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelDivisor1.BackColor = Color.White;
            panelDivisor1.Location = new Point(14, 820);
            panelDivisor1.Margin = new Padding(3, 4, 3, 4);
            panelDivisor1.Name = "panelDivisor1";
            panelDivisor1.Size = new Size(1329, 13);
            panelDivisor1.TabIndex = 1;
            // 
            // panelDivisor2
            // 
            panelDivisor2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelDivisor2.BackColor = Color.White;
            panelDivisor2.Location = new Point(14, 960);
            panelDivisor2.Margin = new Padding(3, 4, 3, 4);
            panelDivisor2.Name = "panelDivisor2";
            panelDivisor2.Size = new Size(1329, 13);
            panelDivisor2.TabIndex = 2;
            // 
            // panelSuperior
            // 
            panelSuperior.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSuperior.AutoScroll = true;
            panelSuperior.BackColor = Color.FromArgb(36, 104, 156);
            panelSuperior.Location = new Point(12, 95);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1331, 706);
            panelSuperior.TabIndex = 3;
            // 
            // flowLayoutPanelHeader
            // 
            flowLayoutPanelHeader.BackColor = Color.FromArgb(72, 94, 196);
            flowLayoutPanelHeader.Controls.Add(comboBoxOrdenar);
            flowLayoutPanelHeader.Controls.Add(comboBoxTipoJuegos);
            flowLayoutPanelHeader.Dock = DockStyle.Top;
            flowLayoutPanelHeader.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelHeader.Location = new Point(0, 0);
            flowLayoutPanelHeader.Name = "flowLayoutPanelHeader";
            flowLayoutPanelHeader.Padding = new Padding(10);
            flowLayoutPanelHeader.Size = new Size(1353, 50);
            flowLayoutPanelHeader.TabIndex = 4;
            flowLayoutPanelHeader.WrapContents = false;
            // 
            // comboBoxOrdenar
            // 
            comboBoxOrdenar.FlatStyle = FlatStyle.Popup;
            comboBoxOrdenar.FormattingEnabled = true;
            comboBoxOrdenar.Items.AddRange(new object[] { "Edad (as)", "Edad (des)", "Nombre (as)", "Nombre (des)", "Puntos (as)", "Puntos (des)" });
            comboBoxOrdenar.Location = new Point(1179, 13);
            comboBoxOrdenar.Name = "comboBoxOrdenar";
            comboBoxOrdenar.Size = new Size(151, 28);
            comboBoxOrdenar.TabIndex = 3;
            comboBoxOrdenar.Text = "Ordenar por...";
            comboBoxOrdenar.SelectedIndexChanged += comboBoxOrdenar_SelectedIndexChanged;
            // 
            // comboBoxTipoJuegos
            // 
            comboBoxTipoJuegos.AllowDrop = true;
            comboBoxTipoJuegos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoJuegos.FlatStyle = FlatStyle.Popup;
            comboBoxTipoJuegos.FormattingEnabled = true;
            comboBoxTipoJuegos.Items.AddRange(new object[] { "Gatito Cuentgotas", "Colorful Shapes" });
            comboBoxTipoJuegos.Location = new Point(988, 13);
            comboBoxTipoJuegos.Name = "comboBoxTipoJuegos";
            comboBoxTipoJuegos.Size = new Size(185, 28);
            comboBoxTipoJuegos.TabIndex = 2;
            comboBoxTipoJuegos.Tag = "";
            comboBoxTipoJuegos.SelectedIndexChanged += comboBoxTipoJuegos_SelectedIndexChanged;
            // 
            // LeadingPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 104, 156);
            ClientSize = new Size(1353, 1015);
            Controls.Add(panelSuperior);
            Controls.Add(flowLayoutPanelHeader);
            Controls.Add(panelDivisor2);
            Controls.Add(panelDivisor1);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LeadingPage";
            Text = "LeadingPage";
            WindowState = FormWindowState.Maximized;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panelDivisor1;
        private Panel panelDivisor2;
        private FlowLayoutPanel panelSuperior;
        private FlowLayoutPanel flowLayoutPanelHeader;
        private Button button5;
        private ComboBox comboBoxTipoJuegos;
        private ComboBox comboBoxOrdenar;
    }
}