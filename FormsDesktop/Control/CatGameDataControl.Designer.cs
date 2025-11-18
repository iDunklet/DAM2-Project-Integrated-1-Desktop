namespace FormsDesktop.Control
{
    partial class CatGameDataControl
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
            labelFecha = new Label();
            labelTiem = new Label();
            labelTiempo = new Label();
            labelDificultad = new Label();
            labelDif = new Label();
            labelErrores = new Label();
            labelErr = new Label();
            labelPuntos = new Label();
            labelPun = new Label();
            SuspendLayout();
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelFecha.Location = new Point(16, 23);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(82, 35);
            labelFecha.TabIndex = 0;
            labelFecha.Text = "Fecha";
            // 
            // labelTiem
            // 
            labelTiem.AutoSize = true;
            labelTiem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTiem.Location = new Point(16, 77);
            labelTiem.Name = "labelTiem";
            labelTiem.Size = new Size(88, 28);
            labelTiem.TabIndex = 1;
            labelTiem.Text = "Tiempo:";
            labelTiem.Click += label1_Click;
            // 
            // labelTiempo
            // 
            labelTiempo.AutoSize = true;
            labelTiempo.Font = new Font("Segoe UI", 12F);
            labelTiempo.Location = new Point(104, 77);
            labelTiempo.Name = "labelTiempo";
            labelTiempo.Size = new Size(39, 28);
            labelTiempo.TabIndex = 2;
            labelTiempo.Text = "ola";
            labelTiempo.Click += labelTiempo_Click;
            // 
            // labelDificultad
            // 
            labelDificultad.AutoSize = true;
            labelDificultad.Font = new Font("Segoe UI", 12F);
            labelDificultad.Location = new Point(122, 135);
            labelDificultad.Name = "labelDificultad";
            labelDificultad.Size = new Size(39, 28);
            labelDificultad.TabIndex = 4;
            labelDificultad.Text = "ola";
            labelDificultad.Click += labelDificultad_Click;
            // 
            // labelDif
            // 
            labelDif.AutoSize = true;
            labelDif.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelDif.Location = new Point(16, 135);
            labelDif.Name = "labelDif";
            labelDif.Size = new Size(111, 28);
            labelDif.TabIndex = 3;
            labelDif.Text = "Dificultad:";
            // 
            // labelErrores
            // 
            labelErrores.AutoSize = true;
            labelErrores.Font = new Font("Segoe UI", 12F);
            labelErrores.Location = new Point(325, 77);
            labelErrores.Name = "labelErrores";
            labelErrores.Size = new Size(39, 28);
            labelErrores.TabIndex = 6;
            labelErrores.Text = "ola";
            // 
            // labelErr
            // 
            labelErr.AutoSize = true;
            labelErr.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelErr.Location = new Point(242, 77);
            labelErr.Name = "labelErr";
            labelErr.Size = new Size(84, 28);
            labelErr.TabIndex = 5;
            labelErr.Text = "Errores:";
            // 
            // labelPuntos
            // 
            labelPuntos.AutoSize = true;
            labelPuntos.Font = new Font("Segoe UI", 12F);
            labelPuntos.Location = new Point(324, 135);
            labelPuntos.Name = "labelPuntos";
            labelPuntos.Size = new Size(39, 28);
            labelPuntos.TabIndex = 8;
            labelPuntos.Text = "ola";
            // 
            // labelPun
            // 
            labelPun.AutoSize = true;
            labelPun.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelPun.Location = new Point(242, 135);
            labelPun.Name = "labelPun";
            labelPun.Size = new Size(82, 28);
            labelPun.TabIndex = 7;
            labelPun.Text = "Puntos:";
            // 
            // CatGameDataControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(labelPuntos);
            Controls.Add(labelPun);
            Controls.Add(labelErrores);
            Controls.Add(labelErr);
            Controls.Add(labelDificultad);
            Controls.Add(labelDif);
            Controls.Add(labelTiempo);
            Controls.Add(labelTiem);
            Controls.Add(labelFecha);
            Name = "CatGameDataControl";
            Size = new Size(416, 189);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFecha;
        private Label labelTiem;
        private Label labelTiempo;
        private Label labelDificultad;
        private Label labelDif;
        private Label labelErrores;
        private Label labelErr;
        private Label labelPuntos;
        private Label labelPun;
    }
}
