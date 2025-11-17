namespace FormsDesktop.Control
{
    partial class ColorsUserControl
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
            buttonEditar = new Button();
            labelEdad = new Label();
            labelEd = new Label();
            labelNombre = new Label();
            panelDataGame = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = SystemColors.ActiveCaption;
            buttonEditar.FlatAppearance.BorderSize = 0;
            buttonEditar.FlatStyle = FlatStyle.Flat;
            buttonEditar.Font = new Font("Segoe UI", 20F);
            buttonEditar.Location = new Point(423, 27);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(60, 63);
            buttonEditar.TabIndex = 9;
            buttonEditar.Text = "✏️";
            buttonEditar.UseVisualStyleBackColor = false;
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Font = new Font("Segoe UI", 12F);
            labelEdad.Location = new Point(97, 78);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(42, 28);
            labelEdad.TabIndex = 7;
            labelEdad.Text = "olis";
            // 
            // labelEd
            // 
            labelEd.AutoSize = true;
            labelEd.Font = new Font("Segoe UI", 12F);
            labelEd.Location = new Point(31, 78);
            labelEd.Name = "labelEd";
            labelEd.Size = new Size(60, 28);
            labelEd.TabIndex = 8;
            labelEd.Text = "Edad:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.FlatStyle = FlatStyle.Flat;
            labelNombre.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelNombre.Location = new Point(31, 27);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(104, 41);
            labelNombre.TabIndex = 6;
            labelNombre.Text = "label1";
            // 
            // panelDataGame
            // 
            panelDataGame.AutoScroll = true;
            panelDataGame.Location = new Point(21, 128);
            panelDataGame.Name = "panelDataGame";
            panelDataGame.Size = new Size(462, 461);
            panelDataGame.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem, eliminarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RenderMode = ToolStripRenderMode.System;
            contextMenuStrip1.Size = new Size(133, 52);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(132, 24);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(132, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // ColorsUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            Controls.Add(buttonEditar);
            Controls.Add(labelEdad);
            Controls.Add(labelEd);
            Controls.Add(labelNombre);
            Controls.Add(panelDataGame);
            Margin = new Padding(70, 40, 20, 20);
            Name = "ColorsUserControl";
            Size = new Size(504, 617);
            Load += ColorsUserControl_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEditar;
        private Label labelEdad;
        private Label labelEd;
        private Label labelNombre;
        private Panel panelDataGame;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
    }
}
