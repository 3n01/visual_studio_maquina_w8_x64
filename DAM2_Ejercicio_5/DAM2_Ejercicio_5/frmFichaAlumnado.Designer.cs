namespace DAM2_Ejercicio_5
{
    partial class frmFichaAlumnado
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInscribir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnElegirCarpeta = new System.Windows.Forms.Button();
            this.labArchivoAlumnado = new System.Windows.Forms.Label();
            this.labAnio = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.tbxArchivoAlumnado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInscribir
            // 
            this.btnInscribir.Location = new System.Drawing.Point(66, 181);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(133, 34);
            this.btnInscribir.TabIndex = 0;
            this.btnInscribir.Text = "Inscripción";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(242, 181);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(133, 34);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consulta";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(432, 181);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(133, 34);
            this.btnFinalizar.TabIndex = 2;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnElegirCarpeta
            // 
            this.btnElegirCarpeta.Location = new System.Drawing.Point(919, 33);
            this.btnElegirCarpeta.Name = "btnElegirCarpeta";
            this.btnElegirCarpeta.Size = new System.Drawing.Size(111, 34);
            this.btnElegirCarpeta.TabIndex = 3;
            this.btnElegirCarpeta.Text = "Carpeta";
            this.btnElegirCarpeta.UseVisualStyleBackColor = true;
            this.btnElegirCarpeta.Click += new System.EventHandler(this.btnElegirCarpeta_Click);
            // 
            // labArchivoAlumnado
            // 
            this.labArchivoAlumnado.AutoSize = true;
            this.labArchivoAlumnado.Location = new System.Drawing.Point(62, 8);
            this.labArchivoAlumnado.Name = "labArchivoAlumnado";
            this.labArchivoAlumnado.Size = new System.Drawing.Size(126, 18);
            this.labArchivoAlumnado.TabIndex = 4;
            this.labArchivoAlumnado.Text = "Archivo alumnado";
            // 
            // labAnio
            // 
            this.labAnio.AutoSize = true;
            this.labAnio.Location = new System.Drawing.Point(70, 106);
            this.labAnio.Name = "labAnio";
            this.labAnio.Size = new System.Drawing.Size(111, 18);
            this.labAnio.TabIndex = 5;
            this.labAnio.Text = "Año académico";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBorrar.Location = new System.Drawing.Point(432, 100);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(133, 34);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar fichero";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(255, 106);
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(120, 24);
            this.nudAnio.TabIndex = 7;
            this.nudAnio.ValueChanged += new System.EventHandler(this.nudAnio_ValueChanged);
            // 
            // tbxArchivoAlumnado
            // 
            this.tbxArchivoAlumnado.Location = new System.Drawing.Point(66, 41);
            this.tbxArchivoAlumnado.Name = "tbxArchivoAlumnado";
            this.tbxArchivoAlumnado.Size = new System.Drawing.Size(835, 24);
            this.tbxArchivoAlumnado.TabIndex = 8;
            // 
            // frmFichaAlumnado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 253);
            this.ControlBox = false;
            this.Controls.Add(this.tbxArchivoAlumnado);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.labAnio);
            this.Controls.Add(this.labArchivoAlumnado);
            this.Controls.Add(this.btnElegirCarpeta);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnInscribir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFichaAlumnado";
            this.Text = "Ficha del alumnado";
            this.Load += new System.EventHandler(this.frmFichaAlumnado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnElegirCarpeta;
        private System.Windows.Forms.Label labArchivoAlumnado;
        private System.Windows.Forms.Label labAnio;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.TextBox tbxArchivoAlumnado;
    }
}

