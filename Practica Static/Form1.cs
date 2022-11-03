using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace Practica_Static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Empleado empleado1 = new Empleado() { Id=1, Name="Juan", LastName="Jill"};
            Empleado empleado2 = new Empleado() { Id=2, Name="Sol", LastName="Luna"};

            Empleado.Comision = 10;

            MessageBox.Show(Empleado.Comision.ToString());

            Empleado empleado3 = new Empleado() { Id = 3, Name = "Abril", LastName = "Black" };
            Empleado empleado4 = new Empleado() { Id = 4, Name = "Jorge", LastName = "Lanka" };

            Empleado.Comision = 99;

            MessageBox.Show(Empleado.Comision.ToString());

        }
    }
}
