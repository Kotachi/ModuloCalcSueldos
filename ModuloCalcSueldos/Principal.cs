using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloCalcSueldos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Empleado agr_Emp = new Agregar_Empleado();
            agr_Emp.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //revisar
            Entrada entrada = new Entrada();
            entrada.Show();
            this.Close();
            entrada.Close();
        }
    }
}
