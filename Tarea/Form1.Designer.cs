namespace Tarea
{
    partial class Form1
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
            this.ckbEmail = new System.Windows.Forms.CheckBox();
            this.ptbSelecionFoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbSMS = new System.Windows.Forms.CheckBox();
            this.grbRolUsuario = new System.Windows.Forms.GroupBox();
            this.rbUsuarioRegular = new System.Windows.Forms.RadioButton();
            this.rbAdministracion = new System.Windows.Forms.RadioButton();
            this.dtpFecahIngreso = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudNivelExperiencia = new System.Windows.Forms.NumericUpDown();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstPreferenciasNotificacion = new System.Windows.Forms.ListBox();
            this.ckLOpcionesAvanzadas = new System.Windows.Forms.CheckedListBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargarConfiguracion = new System.Windows.Forms.Button();
            this.lblResumen = new System.Windows.Forms.Label();
            this.btnSelecionFoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSelecionFoto)).BeginInit();
            this.grbRolUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNivelExperiencia)).BeginInit();
            this.SuspendLayout();
            // 
            // ckbEmail
            // 
            this.ckbEmail.AutoSize = true;
            this.ckbEmail.Location = new System.Drawing.Point(61, 308);
            this.ckbEmail.Name = "ckbEmail";
            this.ckbEmail.Size = new System.Drawing.Size(51, 17);
            this.ckbEmail.TabIndex = 1;
            this.ckbEmail.Text = "Email";
            this.ckbEmail.UseVisualStyleBackColor = true;
            // 
            // ptbSelecionFoto
            // 
            this.ptbSelecionFoto.Location = new System.Drawing.Point(51, 60);
            this.ptbSelecionFoto.Name = "ptbSelecionFoto";
            this.ptbSelecionFoto.Size = new System.Drawing.Size(173, 147);
            this.ptbSelecionFoto.TabIndex = 2;
            this.ptbSelecionFoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nivel de Experiencia (año)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de Ingreso ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Preferencia de Cominicacion ";
            // 
            // ckbSMS
            // 
            this.ckbSMS.AutoSize = true;
            this.ckbSMS.Location = new System.Drawing.Point(154, 308);
            this.ckbSMS.Name = "ckbSMS";
            this.ckbSMS.Size = new System.Drawing.Size(49, 17);
            this.ckbSMS.TabIndex = 6;
            this.ckbSMS.Text = "SMS";
            this.ckbSMS.UseVisualStyleBackColor = true;
            // 
            // grbRolUsuario
            // 
            this.grbRolUsuario.Controls.Add(this.rbUsuarioRegular);
            this.grbRolUsuario.Controls.Add(this.rbAdministracion);
            this.grbRolUsuario.Location = new System.Drawing.Point(51, 366);
            this.grbRolUsuario.Name = "grbRolUsuario";
            this.grbRolUsuario.Size = new System.Drawing.Size(200, 100);
            this.grbRolUsuario.TabIndex = 7;
            this.grbRolUsuario.TabStop = false;
            this.grbRolUsuario.Text = "Rol de Usuario";
            // 
            // rbUsuarioRegular
            // 
            this.rbUsuarioRegular.AutoSize = true;
            this.rbUsuarioRegular.Location = new System.Drawing.Point(26, 68);
            this.rbUsuarioRegular.Name = "rbUsuarioRegular";
            this.rbUsuarioRegular.Size = new System.Drawing.Size(104, 17);
            this.rbUsuarioRegular.TabIndex = 1;
            this.rbUsuarioRegular.TabStop = true;
            this.rbUsuarioRegular.Text = "Usuario Regular ";
            this.rbUsuarioRegular.UseVisualStyleBackColor = true;
            // 
            // rbAdministracion
            // 
            this.rbAdministracion.AutoSize = true;
            this.rbAdministracion.Location = new System.Drawing.Point(26, 29);
            this.rbAdministracion.Name = "rbAdministracion";
            this.rbAdministracion.Size = new System.Drawing.Size(93, 17);
            this.rbAdministracion.TabIndex = 0;
            this.rbAdministracion.TabStop = true;
            this.rbAdministracion.Text = "Administracion";
            this.rbAdministracion.UseVisualStyleBackColor = true;
            // 
            // dtpFecahIngreso
            // 
            this.dtpFecahIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecahIngreso.Location = new System.Drawing.Point(398, 131);
            this.dtpFecahIngreso.Name = "dtpFecahIngreso";
            this.dtpFecahIngreso.Size = new System.Drawing.Size(122, 20);
            this.dtpFecahIngreso.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(679, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Opciones Avanzadas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Departamento";
            // 
            // nudNivelExperiencia
            // 
            this.nudNivelExperiencia.Location = new System.Drawing.Point(398, 275);
            this.nudNivelExperiencia.Name = "nudNivelExperiencia";
            this.nudNivelExperiencia.Size = new System.Drawing.Size(120, 20);
            this.nudNivelExperiencia.TabIndex = 11;
            this.nudNivelExperiencia.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Items.AddRange(new object[] {
            "Tecnologia",
            "Ventas ",
            "Marketing",
            "Recursos Humanos"});
            this.cmbDepartamento.Location = new System.Drawing.Point(405, 391);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartamento.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(670, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Preferencias de Notificacion";
            // 
            // lstPreferenciasNotificacion
            // 
            this.lstPreferenciasNotificacion.FormattingEnabled = true;
            this.lstPreferenciasNotificacion.Items.AddRange(new object[] {
            "Actualizacion de Sistemas",
            "Alertas de seguridad",
            "Boletin Informatico"});
            this.lstPreferenciasNotificacion.Location = new System.Drawing.Point(673, 112);
            this.lstPreferenciasNotificacion.Name = "lstPreferenciasNotificacion";
            this.lstPreferenciasNotificacion.Size = new System.Drawing.Size(173, 69);
            this.lstPreferenciasNotificacion.TabIndex = 14;
            // 
            // ckLOpcionesAvanzadas
            // 
            this.ckLOpcionesAvanzadas.FormattingEnabled = true;
            this.ckLOpcionesAvanzadas.Items.AddRange(new object[] {
            "Modo AQvanzado",
            "Respaldo Automatico",
            "Notificaciones en Tiempo Real"});
            this.ckLOpcionesAvanzadas.Location = new System.Drawing.Point(673, 261);
            this.ckLOpcionesAvanzadas.Name = "ckLOpcionesAvanzadas";
            this.ckLOpcionesAvanzadas.Size = new System.Drawing.Size(205, 64);
            this.ckLOpcionesAvanzadas.TabIndex = 15;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(347, 485);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(141, 23);
            this.btnConfirmar.TabIndex = 16;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.Confirmar);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(545, 485);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 23);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.Guardar);
            // 
            // btnCargarConfiguracion
            // 
            this.btnCargarConfiguracion.Location = new System.Drawing.Point(739, 485);
            this.btnCargarConfiguracion.Name = "btnCargarConfiguracion";
            this.btnCargarConfiguracion.Size = new System.Drawing.Size(141, 23);
            this.btnCargarConfiguracion.TabIndex = 18;
            this.btnCargarConfiguracion.Text = "Cargar Configuracion";
            this.btnCargarConfiguracion.UseVisualStyleBackColor = true;
            this.btnCargarConfiguracion.Click += new System.EventHandler(this.CargarConfiguracion);
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Location = new System.Drawing.Point(51, 494);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(55, 13);
            this.lblResumen.TabIndex = 19;
            this.lblResumen.Text = "Resumen:";
            // 
            // btnSelecionFoto
            // 
            this.btnSelecionFoto.Location = new System.Drawing.Point(51, 22);
            this.btnSelecionFoto.Name = "btnSelecionFoto";
            this.btnSelecionFoto.Size = new System.Drawing.Size(173, 23);
            this.btnSelecionFoto.TabIndex = 20;
            this.btnSelecionFoto.Text = "Selecione una Foto de Perfil";
            this.btnSelecionFoto.UseVisualStyleBackColor = true;
            this.btnSelecionFoto.Click += new System.EventHandler(this.SelecioneFotoDePerfil);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 529);
            this.Controls.Add(this.btnSelecionFoto);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.btnCargarConfiguracion);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.ckLOpcionesAvanzadas);
            this.Controls.Add(this.lstPreferenciasNotificacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.nudNivelExperiencia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFecahIngreso);
            this.Controls.Add(this.grbRolUsuario);
            this.Controls.Add(this.ckbSMS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbSelecionFoto);
            this.Controls.Add(this.ckbEmail);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbSelecionFoto)).EndInit();
            this.grbRolUsuario.ResumeLayout(false);
            this.grbRolUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNivelExperiencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbEmail;
        private System.Windows.Forms.PictureBox ptbSelecionFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbSMS;
        private System.Windows.Forms.GroupBox grbRolUsuario;
        private System.Windows.Forms.RadioButton rbUsuarioRegular;
        private System.Windows.Forms.RadioButton rbAdministracion;
        private System.Windows.Forms.DateTimePicker dtpFecahIngreso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudNivelExperiencia;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstPreferenciasNotificacion;
        private System.Windows.Forms.CheckedListBox ckLOpcionesAvanzadas;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargarConfiguracion;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Button btnSelecionFoto;
    }
}

