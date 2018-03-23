namespace ModuloCalcSueldos
{
    partial class Agregar_Empleado
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
            this.txtAgregarNombres = new System.Windows.Forms.TextBox();
            this.txtAgregarApellidos = new System.Windows.Forms.TextBox();
            this.txtAgregarRut = new System.Windows.Forms.TextBox();
            this.lbAgregarNombres = new System.Windows.Forms.Label();
            this.lbAgregarApellidos = new System.Windows.Forms.Label();
            this.lbAgregarRut = new System.Windows.Forms.Label();
            this.lbAgregarFechaNacimiento = new System.Windows.Forms.Label();
            this.lbAgregarCargo = new System.Windows.Forms.Label();
            this.lbAgregarPrevision = new System.Windows.Forms.Label();
            this.lbAgregarAfp = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbSeleccCargo = new System.Windows.Forms.ComboBox();
            this.cbSeleccPrevision = new System.Windows.Forms.ComboBox();
            this.cbSeleccAfp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtAgregarNombres
            // 
            this.txtAgregarNombres.Location = new System.Drawing.Point(84, 86);
            this.txtAgregarNombres.MaxLength = 100;
            this.txtAgregarNombres.Name = "txtAgregarNombres";
            this.txtAgregarNombres.Size = new System.Drawing.Size(100, 20);
            this.txtAgregarNombres.TabIndex = 0;
            // 
            // txtAgregarApellidos
            // 
            this.txtAgregarApellidos.Location = new System.Drawing.Point(217, 86);
            this.txtAgregarApellidos.MaxLength = 100;
            this.txtAgregarApellidos.Name = "txtAgregarApellidos";
            this.txtAgregarApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtAgregarApellidos.TabIndex = 1;
            // 
            // txtAgregarRut
            // 
            this.txtAgregarRut.Location = new System.Drawing.Point(352, 86);
            this.txtAgregarRut.MaxLength = 12;
            this.txtAgregarRut.Name = "txtAgregarRut";
            this.txtAgregarRut.Size = new System.Drawing.Size(100, 20);
            this.txtAgregarRut.TabIndex = 2;
            // 
            // lbAgregarNombres
            // 
            this.lbAgregarNombres.AutoSize = true;
            this.lbAgregarNombres.Location = new System.Drawing.Point(81, 70);
            this.lbAgregarNombres.Name = "lbAgregarNombres";
            this.lbAgregarNombres.Size = new System.Drawing.Size(49, 13);
            this.lbAgregarNombres.TabIndex = 3;
            this.lbAgregarNombres.Text = "Nombres";
            // 
            // lbAgregarApellidos
            // 
            this.lbAgregarApellidos.AutoSize = true;
            this.lbAgregarApellidos.Location = new System.Drawing.Point(214, 70);
            this.lbAgregarApellidos.Name = "lbAgregarApellidos";
            this.lbAgregarApellidos.Size = new System.Drawing.Size(49, 13);
            this.lbAgregarApellidos.TabIndex = 4;
            this.lbAgregarApellidos.Text = "Apellidos";
            // 
            // lbAgregarRut
            // 
            this.lbAgregarRut.AutoSize = true;
            this.lbAgregarRut.Location = new System.Drawing.Point(349, 70);
            this.lbAgregarRut.Name = "lbAgregarRut";
            this.lbAgregarRut.Size = new System.Drawing.Size(24, 13);
            this.lbAgregarRut.TabIndex = 5;
            this.lbAgregarRut.Text = "Rut";
            // 
            // lbAgregarFechaNacimiento
            // 
            this.lbAgregarFechaNacimiento.AutoSize = true;
            this.lbAgregarFechaNacimiento.Location = new System.Drawing.Point(81, 184);
            this.lbAgregarFechaNacimiento.Name = "lbAgregarFechaNacimiento";
            this.lbAgregarFechaNacimiento.Size = new System.Drawing.Size(106, 13);
            this.lbAgregarFechaNacimiento.TabIndex = 6;
            this.lbAgregarFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // lbAgregarCargo
            // 
            this.lbAgregarCargo.AutoSize = true;
            this.lbAgregarCargo.Location = new System.Drawing.Point(349, 184);
            this.lbAgregarCargo.Name = "lbAgregarCargo";
            this.lbAgregarCargo.Size = new System.Drawing.Size(38, 13);
            this.lbAgregarCargo.TabIndex = 7;
            this.lbAgregarCargo.Text = "Cargo ";
            this.lbAgregarCargo.Click += new System.EventHandler(this.lbAgregarCargo_Click);
            // 
            // lbAgregarPrevision
            // 
            this.lbAgregarPrevision.AutoSize = true;
            this.lbAgregarPrevision.Location = new System.Drawing.Point(81, 293);
            this.lbAgregarPrevision.Name = "lbAgregarPrevision";
            this.lbAgregarPrevision.Size = new System.Drawing.Size(80, 13);
            this.lbAgregarPrevision.TabIndex = 8;
            this.lbAgregarPrevision.Text = "Prevision social";
            // 
            // lbAgregarAfp
            // 
            this.lbAgregarAfp.AutoSize = true;
            this.lbAgregarAfp.Location = new System.Drawing.Point(349, 293);
            this.lbAgregarAfp.Name = "lbAgregarAfp";
            this.lbAgregarAfp.Size = new System.Drawing.Size(23, 13);
            this.lbAgregarAfp.TabIndex = 9;
            this.lbAgregarAfp.Text = "Afp";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 200);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // cbSeleccCargo
            // 
            this.cbSeleccCargo.FormattingEnabled = true;
            this.cbSeleccCargo.Items.AddRange(new object[] {
            "Cuprum",
            "Capital",
            "Modelo",
            "Habitat",
            "Plan vital"});
            this.cbSeleccCargo.Location = new System.Drawing.Point(352, 200);
            this.cbSeleccCargo.Name = "cbSeleccCargo";
            this.cbSeleccCargo.Size = new System.Drawing.Size(121, 21);
            this.cbSeleccCargo.TabIndex = 11;
            // 
            // cbSeleccPrevision
            // 
            this.cbSeleccPrevision.FormattingEnabled = true;
            this.cbSeleccPrevision.Location = new System.Drawing.Point(84, 309);
            this.cbSeleccPrevision.Name = "cbSeleccPrevision";
            this.cbSeleccPrevision.Size = new System.Drawing.Size(121, 21);
            this.cbSeleccPrevision.TabIndex = 12;
            // 
            // cbSeleccAfp
            // 
            this.cbSeleccAfp.FormattingEnabled = true;
            this.cbSeleccAfp.Location = new System.Drawing.Point(352, 309);
            this.cbSeleccAfp.Name = "cbSeleccAfp";
            this.cbSeleccAfp.Size = new System.Drawing.Size(121, 21);
            this.cbSeleccAfp.TabIndex = 13;
            // 
            // Agregar_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 459);
            this.Controls.Add(this.cbSeleccAfp);
            this.Controls.Add(this.cbSeleccPrevision);
            this.Controls.Add(this.cbSeleccCargo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbAgregarAfp);
            this.Controls.Add(this.lbAgregarPrevision);
            this.Controls.Add(this.lbAgregarCargo);
            this.Controls.Add(this.lbAgregarFechaNacimiento);
            this.Controls.Add(this.lbAgregarRut);
            this.Controls.Add(this.lbAgregarApellidos);
            this.Controls.Add(this.lbAgregarNombres);
            this.Controls.Add(this.txtAgregarRut);
            this.Controls.Add(this.txtAgregarApellidos);
            this.Controls.Add(this.txtAgregarNombres);
            this.Name = "Agregar_Empleado";
            this.Text = "Agregar_Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAgregarNombres;
        private System.Windows.Forms.TextBox txtAgregarApellidos;
        private System.Windows.Forms.TextBox txtAgregarRut;
        private System.Windows.Forms.Label lbAgregarNombres;
        private System.Windows.Forms.Label lbAgregarApellidos;
        private System.Windows.Forms.Label lbAgregarRut;
        private System.Windows.Forms.Label lbAgregarFechaNacimiento;
        private System.Windows.Forms.Label lbAgregarCargo;
        private System.Windows.Forms.Label lbAgregarPrevision;
        private System.Windows.Forms.Label lbAgregarAfp;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbSeleccCargo;
        private System.Windows.Forms.ComboBox cbSeleccPrevision;
        private System.Windows.Forms.ComboBox cbSeleccAfp;
    }
}