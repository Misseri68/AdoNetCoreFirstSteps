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
    public partial class Form10UpdateEmpleadosOficios : Form
    {

        RepositoryUpdateEmpleado rep;

        public Form10UpdateEmpleadosOficios()
        {
            InitializeComponent();
            this.rep = new RepositoryUpdateEmpleado();
            CargarOficios();
        }

        private async void CargarOficios()
        {
            this.lstOficios.Items.Clear();
            List<string> oficios = new List<string>();
            oficios = await this.rep.GetOficios();
            foreach (string oficio in oficios)
            {
                this.lstOficios.Items.Add(oficio);
            }
        }


        private async 

        Task
CargarEmpleados(string oficio)
        {
            this.lstEmpleados.Items.Clear();
            List<string> empleados = new List<string>();
            empleados = await this.rep.GetEmpleadosOficio(oficio);
            foreach (string emp in empleados)
            {
                this.lstEmpleados.Items.Add(emp);
            }

        }

        private async 
        Task
CargarLabels(string oficio) {
            List<int> list = await this.rep.getDatosSalario(oficio);
            this.lblMaximoSalario.Text = list[0].ToString();
            this.lblMediaSalarial.Text = list[1].ToString();
            this.lblSumaSalarial.Text = list[2].ToString();
            
        }

        private async void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string oficioSeleccionado = this.lstOficios.SelectedItem.ToString();
            await CargarEmpleados(oficioSeleccionado);
            await CargarLabels(oficioSeleccionado);

        }

        private async void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string empleado = this.lstEmpleados.SelectedItem.ToString();
            int salario = await this.rep.getSalarioEmpleado(empleado);
            this.txtIncremento.Text = salario.ToString();
        }

        private async void btnIncrementar_Click(object sender, EventArgs e)
        {
            string empleado = this.lstEmpleados.SelectedItem.ToString();
            int incremento = int.Parse(this.txtIncremento.Text);
            await this.rep.UpdateIncrementoSalario(empleado, incremento);
            int salario = await this.rep.getSalarioEmpleado(empleado);
            this.txtIncremento.Text = salario.ToString();
        }

        private async void btnNombreOficio_Click(object sender, EventArgs e)
        {
            string oficio = this.lstOficios.SelectedItem.ToString();
            string nuevoNombre = this.txtOficio.Text;
            await this.rep.UpdateNombreOficio(oficio, nuevoNombre);
            this.CargarOficios();


        }
    }
}
