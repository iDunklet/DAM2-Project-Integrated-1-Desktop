namespace FormsDesktop
{
    partial class ImportScreen
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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(118, 195, 255);
            button1.Font = new Font("Segoe UI", 30F);
            button1.Location = new Point(437, 298);
            button1.Name = "button1";
            button1.Size = new Size(368, 116);
            button1.TabIndex = 0;
            button1.Text = "Import   JSON";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ImportScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 104, 156);
            ClientSize = new Size(1184, 761);
            Controls.Add(button1);
            Name = "ImportScreen";
            Text = "ImportScreen";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}