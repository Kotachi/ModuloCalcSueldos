namespace ModuloCalcSueldos
{
    partial class Eliminar_Empleado
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
            this.txtElimXCodEmpleado = new System.Windows.Forms.TextBox();
            this.txtElimXRutEmpleado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbElimXCod = new System.Windows.Forms.Label();
            this.lbElimXRut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtElimXCodEmpleado
            // 
            this.txtElimXCodEmpleado.Location = new System.Drawing.Point(51, 63);
            this.txtElimXCodEmpleado.Name = "txtElimXCodEmpleado";
            this.txtElimXCodEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtElimXCodEmpleado.TabIndex = 0;
            // 
            // txtElimXRutEmpleado
            // 
            this.txtElimXRutEmpleado.Location = new System.Drawing.Point(222, 63);
            this.txtElimXRutEmpleado.Name = "txtElimXRutEmpleado";
            this.txtElimXRutEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtElimXRutEmpleado.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbElimXCod
            // 
            this.lbElimXCod.AutoSize = true;
            this.lbElimXCod.Location = new System.Drawing.Point(48, 47);
            this.lbElimXCod.Name = "lbElimXCod";
            this.lbElimXCod.Size = new System.Drawing.Size(89, 13);
            this.lbElimXCod.TabIndex = 4;
            this.lbElimXCod.Text = "Codigo empleado";
            // 
            // lbElimXRut
            // 
            this.lbElimXRut.AutoSize = true;
            this.lbElimXRut.Location = new System.Drawing.Point(219, 47);
            this.lbElimXRut.Name = "lbElimXRut";
            this.lbElimXRut.Size = new System.Drawing.Size(73, 13);
            this.lbElimXRut.TabIndex = 5;
            this.lbElimXRut.Text = "Rut empleado";
            // 
            // Eliminar_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 372);
            this.Controls.Add(this.lbElimXRut);
            this.Controls.Add(this.lbElimXCod);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtElimXRutEmpleado);
            this.Controls.Add(this.txtElimXCodEmpleado);
            this.Name = "Eliminar_Empleado";
            this.Text = "Eliminar_Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtElimXCodEmpleado;
        private System.Windows.Forms.TextBox txtElimXRutEmpleado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbElimXCod;
        private System.Windows.Forms.Label lbElimXRut;
    }
}