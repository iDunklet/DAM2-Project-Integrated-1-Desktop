namespace FormsDesktop.Control
{
    partial class ColorsGameDataControl
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
            labelAciertos = new Label();
            labelAc = new Label();
            labelErrores = new Label();
            labelErr = new Label();
            labelDificultad = new Label();
            labelDif = new Label();
            labelTiempo = new Label();
            labelTiem = new Label();
            labelRondas = new Label();
            labelRon = new Label();
            SuspendLayout();
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelFecha.Location = new Point(16, 23);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(82, 35);
            labelFecha.TabIndex = 1;
            labelFecha.Text = "Fecha";
            // 
            // labelAciertos
            // 
            labelAciertos.AutoSize = true;
            labelAciertos.Font = new Font("Segoe UI", 12F);
            labelAciertos.Location = new Point(333, 135);
            labelAciertos.Name = "labelAciertos";
            labelAciertos.Size = new Size(39, 28);
            labelAciertos.TabIndex = 16;
            labelAciertos.Text = "ola";
            // 
            // labelAc
            // 
            labelAc.AutoSize = true;
            labelAc.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelAc.Location = new Point(242, 135);
            labelAc.Name = "labelAc";
            labelAc.Size = new Size(96, 28);
            labelAc.TabIndex = 15;
            labelAc.Text = "Aciertos:";
            labelAc.Click += labelPun_Click;
            // 
            // labelErrores
            // 
            labelErrores.AutoSize = true;
            labelErrores.Font = new Font("Segoe UI", 12F);
            labelErrores.Location = new Point(325, 77);
            labelErrores.Name = "labelErrores";
            labelErrores.Size = new Size(39, 28);
            labelErrores.TabIndex = 14;
            labelErrores.Text = "ola";
            // 
            // labelErr
            // 
            labelErr.AutoSize = true;
            labelErr.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelErr.Location = new Point(242, 77);
            labelErr.Name = "labelErr";
            labelErr.Size = new Size(84, 28);
            labelErr.TabIndex = 13;
            labelErr.Text = "Errores:";
            // 
            // labelDificultad
            // 
            labelDificultad.AutoSize = true;
            labelDificultad.Font = new Font("Segoe UI", 12F);
            labelDificultad.Location = new Point(122, 135);
            labelDificultad.Name = "labelDificultad";
            labelDificultad.Size = new Size(39, 28);
            labelDificultad.TabIndex = 12;
            labelDificultad.Text = "ola";
            // 
            // labelDif
            // 
            labelDif.AutoSize = true;
            labelDif.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelDif.Location = new Point(16, 135);
            labelDif.Name = "labelDif";
            labelDif.Size = new Size(111, 28);
            labelDif.TabIndex = 11;
            labelDif.Text = "Dificultad:";
            // 
            // labelTiempo
            // 
            labelTiempo.AutoSize = true;
            labelTiempo.Font = new Font("Segoe UI", 12F);
            labelTiempo.Location = new Point(104, 77);
            labelTiempo.Name = "labelTiempo";
            labelTiempo.Size = new Size(39, 28);
            labelTiempo.TabIndex = 10;
            labelTiempo.Text = "ola";
            // 
            // labelTiem
            // 
            labelTiem.AutoSize = true;
            labelTiem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTiem.Location = new Point(16, 77);
            labelTiem.Name = "labelTiem";
            labelTiem.Size = new Size(88, 28);
            labelTiem.TabIndex = 9;
            labelTiem.Text = "Tiempo:";
            // 
            // labelRondas
            // 
            labelRondas.AutoSize = true;
            labelRondas.Font = new Font("Segoe UI", 12F);
            labelRondas.Location = new Point(216, 192);
            labelRondas.Name = "labelRondas";
            labelRondas.Size = new Size(39, 28);
            labelRondas.TabIndex = 18;
            labelRondas.Text = "ola";
            // 
            // labelRon
            // 
            labelRon.AutoSize = true;
            labelRon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelRon.Location = new Point(134, 192);
            labelRon.Name = "labelRon";
            labelRon.Size = new Size(86, 28);
            labelRon.TabIndex = 17;
            labelRon.Text = "Rondas:";
            // 
            // ColorsGameDataControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            Controls.Add(labelRondas);
            Controls.Add(labelRon);
            Controls.Add(labelAciertos);
            Controls.Add(labelAc);
            Controls.Add(labelErrores);
            Controls.Add(labelErr);
            Controls.Add(labelDificultad);
            Controls.Add(labelDif);
            Controls.Add(labelTiempo);
            Controls.Add(labelTiem);
            Controls.Add(labelFecha);
            Name = "ColorsGameDataControl";
            Size = new Size(420, 241);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFecha;
        private Label labelAciertos;
        private Label labelAc;
        private Label labelErrores;
        private Label labelErr;
        private Label labelDificultad;
        private Label labelDif;
        private Label labelTiempo;
        private Label labelTiem;
        private Label labelRondas;
        private Label labelRon;
    }
}
