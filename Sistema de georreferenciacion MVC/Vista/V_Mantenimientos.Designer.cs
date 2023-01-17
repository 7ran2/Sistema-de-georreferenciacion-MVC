namespace Vista
{
    partial class V_Mantenimientos
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
            this.cbxSeguimiento = new System.Windows.Forms.ComboBox();
            this.cbxTrayectoriaGeorreferenciacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAsignacionTrabajo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxSeguimiento
            // 
            this.cbxSeguimiento.FormattingEnabled = true;
            this.cbxSeguimiento.Location = new System.Drawing.Point(579, 122);
            this.cbxSeguimiento.Name = "cbxSeguimiento";
            this.cbxSeguimiento.Size = new System.Drawing.Size(246, 24);
            this.cbxSeguimiento.TabIndex = 0;
            // 
            // cbxTrayectoriaGeorreferenciacion
            // 
            this.cbxTrayectoriaGeorreferenciacion.FormattingEnabled = true;
            this.cbxTrayectoriaGeorreferenciacion.Location = new System.Drawing.Point(579, 178);
            this.cbxTrayectoriaGeorreferenciacion.Name = "cbxTrayectoriaGeorreferenciacion";
            this.cbxTrayectoriaGeorreferenciacion.Size = new System.Drawing.Size(246, 24);
            this.cbxTrayectoriaGeorreferenciacion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seguimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trayectoria y georreferenciacion";
            // 
            // txtAsignacionTrabajo
            // 
            this.txtAsignacionTrabajo.Location = new System.Drawing.Point(579, 238);
            this.txtAsignacionTrabajo.Multiline = true;
            this.txtAsignacionTrabajo.Name = "txtAsignacionTrabajo";
            this.txtAsignacionTrabajo.Size = new System.Drawing.Size(246, 76);
            this.txtAsignacionTrabajo.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(579, 345);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(246, 76);
            this.txtDescripcion.TabIndex = 5;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpInicio.Location = new System.Drawing.Point(579, 462);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(106, 22);
            this.dtpInicio.TabIndex = 6;
            this.dtpInicio.Value = new System.DateTime(2023, 1, 2, 15, 15, 28, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Asignacion de Trabajo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha y Hora de Inicio";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFinal.Location = new System.Drawing.Point(579, 531);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(109, 22);
            this.dtpFinal.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(579, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha y Hora de Finalizacion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(521, 453);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(582, 585);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // V_Mantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 648);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtAsignacionTrabajo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTrayectoriaGeorreferenciacion);
            this.Controls.Add(this.cbxSeguimiento);
            this.Name = "V_Mantenimientos";
            this.Text = "V_Mantenimientos";
            this.Load += new System.EventHandler(this.V_Mantenimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSeguimiento;
        private System.Windows.Forms.ComboBox cbxTrayectoriaGeorreferenciacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAsignacionTrabajo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuardar;
    }
}