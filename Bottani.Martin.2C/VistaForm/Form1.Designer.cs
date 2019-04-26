namespace VistaForm
{
    partial class FormDT
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblExperiencia = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.numDNI = new System.Windows.Forms.NumericUpDown();
            this.numExperiencia = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExperiencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(33, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(34, 59);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(34, 87);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(36, 15);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(34, 113);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(28, 15);
            this.lblDni.TabIndex = 3;
            this.lblDni.Text = "DNI";
            // 
            // lblExperiencia
            // 
            this.lblExperiencia.AutoSize = true;
            this.lblExperiencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperiencia.Location = new System.Drawing.Point(33, 140);
            this.lblExperiencia.Name = "lblExperiencia";
            this.lblExperiencia.Size = new System.Drawing.Size(72, 15);
            this.lblExperiencia.TabIndex = 4;
            this.lblExperiencia.Text = "Experiencia";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(37, 182);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(106, 57);
            this.btnCrear.TabIndex = 5;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(167, 182);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(111, 57);
            this.btnValidar.TabIndex = 6;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(124, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(124, 60);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(124, 87);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(100, 20);
            this.numEdad.TabIndex = 9;
            // 
            // numDNI
            // 
            this.numDNI.Location = new System.Drawing.Point(124, 113);
            this.numDNI.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numDNI.Name = "numDNI";
            this.numDNI.Size = new System.Drawing.Size(100, 20);
            this.numDNI.TabIndex = 10;
            // 
            // numExperiencia
            // 
            this.numExperiencia.Location = new System.Drawing.Point(124, 139);
            this.numExperiencia.Name = "numExperiencia";
            this.numExperiencia.Size = new System.Drawing.Size(100, 20);
            this.numExperiencia.TabIndex = 11;
            // 
            // FormDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 276);
            this.Controls.Add(this.numExperiencia);
            this.Controls.Add(this.numDNI);
            this.Controls.Add(this.numEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblExperiencia);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDT";
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExperiencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblExperiencia;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.NumericUpDown numDNI;
        private System.Windows.Forms.NumericUpDown numExperiencia;
    }
}

