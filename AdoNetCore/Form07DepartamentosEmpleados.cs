using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetCore.Repositories;

namespace AdoNetCore
{
    public partial class Form07DepartamentosEmpleados : Form
    {
        RepositoryEmpleadosDepartamentos rep;
        public Form07DepartamentosEmpleados()
        {
            InitializeComponent();
            this.rep = new RepositoryEmpleadosDepartamentos();
            CargarDepartamentos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public async void CargarEmpleados()
        {
            List<string> empleados = new List<string>();
            if (this.lstDepartamentos.SelectedItems.Count > 0)
            {
                string nombreDep = this.lstDepartamentos.SelectedItem.ToString();
                empleados = await rep.CargarEmpleadosDepartamentoAsync(nombreDep);
                foreach (string emp in empleados)
                {
                    this.lstEmpleados.Items.Add(emp);
                }

            }
        }

        public async void CargarDepartamentos()
        {
            List<string> departamentos = await this.rep.CargarDepartamentosAsync();
            this.lstDepartamentos.Items.Clear();
            foreach (string dep in departamentos)
            {
                this.lstDepartamentos.Items.Add(dep);
            }

        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            string apellido = this.lstEmpleados.SelectedItem.ToString();
            await this.rep.BorrarEmpleado(apellido);
            this.lstEmpleados.Items.Clear();
            CargarEmpleados();

        }

        private void LstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lstEmpleados.Items.Clear();
            CargarEmpleados();
        }
    }
}
