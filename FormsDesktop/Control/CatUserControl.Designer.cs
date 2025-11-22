namespace FormsDesktop.Control
{
    partial class CatUserControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelDataGame = new Panel();
            labelNombre = new Label();
            labelEd = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            buttonEditar = new Button();
            labelEdad = new Label();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelDataGame
            // 
            panelDataGame.AutoScroll = true;
            panelDataGame.Location = new Point(17, 138);
            panelDataGame.Name = "panelDataGame";
            panelDataGame.Size = new Size(462, 461);
            panelDataGame.TabIndex = 0;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.FlatStyle = FlatStyle.Flat;
            labelNombre.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelNombre.Location = new Point(27, 37);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(104, 41);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "label1";
            // 
            // labelEd
            // 
            labelEd.AutoSize = true;
            labelEd.Font = new Font("Segoe UI", 12F);
            labelEd.Location = new Point(27, 88);
            labelEd.Name = "labelEd";
            labelEd.Size = new Size(60, 28);
            labelEd.TabIndex = 2;
            labelEd.Text = "Edad:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RenderMode = ToolStripRenderMode.System;
            contextMenuStrip1.Size = new Size(133, 28);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(132, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = SystemColors.Highlight;
            buttonEditar.FlatAppearance.BorderSize = 0;
            buttonEditar.FlatStyle = FlatStyle.Flat;
            buttonEditar.Font = new Font("Segoe UI", 20F);
            buttonEditar.Location = new Point(419, 37);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(60, 63);
            buttonEditar.TabIndex = 4;
            buttonEditar.Text = "✏️";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Font = new Font("Segoe UI", 12F);
            labelEdad.Location = new Point(93, 88);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(42, 28);
            labelEdad.TabIndex = 2;
            labelEdad.Text = "olis";
            // 
            // CatUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(buttonEditar);
            Controls.Add(labelEdad);
            Controls.Add(labelEd);
            Controls.Add(labelNombre);
            Controls.Add(panelDataGame);
            Margin = new Padding(70, 40, 20, 20);
            Name = "CatUserControl";
            Size = new Size(500, 612);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelDataGame;
        private Label labelNombre;
        private Label labelEd;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private Button buttonEditar;
        private Label labelEdad;
    }
}
