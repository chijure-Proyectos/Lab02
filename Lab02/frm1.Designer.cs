namespace Lab02
{
    partial class frm1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpECivil = new System.Windows.Forms.GroupBox();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.txtAñoServicios = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSueldoNeto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTP = new System.Windows.Forms.Button();
            this.txtTP = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.rndSoltero = new System.Windows.Forms.RadioButton();
            this.rndCasado = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNConyugue = new System.Windows.Forms.TextBox();
            this.txtNHijos = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpECivil.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DELCROSA SAC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTP);
            this.groupBox1.Controls.Add(this.btnTP);
            this.groupBox1.Controls.Add(this.txtSueldoNeto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAñoServicios);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.grpDatos);
            this.groupBox1.Controls.Add(this.grpECivil);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 262);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(57, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(57, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(231, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(57, 72);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Edad:";
            // 
            // grpECivil
            // 
            this.grpECivil.Controls.Add(this.rndCasado);
            this.grpECivil.Controls.Add(this.rndSoltero);
            this.grpECivil.Location = new System.Drawing.Point(10, 102);
            this.grpECivil.Name = "grpECivil";
            this.grpECivil.Size = new System.Drawing.Size(98, 75);
            this.grpECivil.TabIndex = 6;
            this.grpECivil.TabStop = false;
            this.grpECivil.Text = "Estado Civil";
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtNHijos);
            this.grpDatos.Controls.Add(this.txtNConyugue);
            this.grpDatos.Controls.Add(this.label8);
            this.grpDatos.Controls.Add(this.label7);
            this.grpDatos.Location = new System.Drawing.Point(114, 102);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(282, 75);
            this.grpDatos.TabIndex = 7;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // txtAñoServicios
            // 
            this.txtAñoServicios.Location = new System.Drawing.Point(103, 191);
            this.txtAñoServicios.Name = "txtAñoServicios";
            this.txtAñoServicios.Size = new System.Drawing.Size(100, 20);
            this.txtAñoServicios.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Años de Servicios:";
            // 
            // txtSueldoNeto
            // 
            this.txtSueldoNeto.Location = new System.Drawing.Point(289, 191);
            this.txtSueldoNeto.Name = "txtSueldoNeto";
            this.txtSueldoNeto.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoNeto.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sueldo Neto:";
            // 
            // btnTP
            // 
            this.btnTP.Location = new System.Drawing.Point(10, 222);
            this.btnTP.Name = "btnTP";
            this.btnTP.Size = new System.Drawing.Size(98, 23);
            this.btnTP.TabIndex = 12;
            this.btnTP.Text = "Total a Pagar";
            this.btnTP.UseVisualStyleBackColor = true;
            // 
            // txtTP
            // 
            this.txtTP.Location = new System.Drawing.Point(127, 224);
            this.txtTP.Name = "txtTP";
            this.txtTP.Size = new System.Drawing.Size(100, 20);
            this.txtTP.TabIndex = 13;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(435, 56);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(436, 83);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // rndSoltero
            // 
            this.rndSoltero.AutoSize = true;
            this.rndSoltero.Location = new System.Drawing.Point(20, 20);
            this.rndSoltero.Name = "rndSoltero";
            this.rndSoltero.Size = new System.Drawing.Size(58, 17);
            this.rndSoltero.TabIndex = 0;
            this.rndSoltero.TabStop = true;
            this.rndSoltero.Text = "Soltero";
            this.rndSoltero.UseVisualStyleBackColor = true;
            // 
            // rndCasado
            // 
            this.rndCasado.AutoSize = true;
            this.rndCasado.Location = new System.Drawing.Point(20, 44);
            this.rndCasado.Name = "rndCasado";
            this.rndCasado.Size = new System.Drawing.Size(61, 17);
            this.rndCasado.TabIndex = 1;
            this.rndCasado.TabStop = true;
            this.rndCasado.Text = "Casado";
            this.rndCasado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombre Conyugue:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Número de Hijos:";
            // 
            // txtNConyugue
            // 
            this.txtNConyugue.Location = new System.Drawing.Point(105, 12);
            this.txtNConyugue.Name = "txtNConyugue";
            this.txtNConyugue.Size = new System.Drawing.Size(164, 20);
            this.txtNConyugue.TabIndex = 2;
            // 
            // txtNHijos
            // 
            this.txtNHijos.Location = new System.Drawing.Point(105, 44);
            this.txtNHijos.Name = "txtNHijos";
            this.txtNHijos.Size = new System.Drawing.Size(51, 20);
            this.txtNHijos.TabIndex = 3;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(522, 315);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm1";
            this.Text = "Registro de Ingresos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpECivil.ResumeLayout(false);
            this.grpECivil.PerformLayout();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTP;
        private System.Windows.Forms.Button btnTP;
        private System.Windows.Forms.TextBox txtSueldoNeto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAñoServicios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.GroupBox grpECivil;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RadioButton rndCasado;
        private System.Windows.Forms.RadioButton rndSoltero;
        private System.Windows.Forms.TextBox txtNHijos;
        private System.Windows.Forms.TextBox txtNConyugue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

