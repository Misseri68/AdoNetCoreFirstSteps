using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetCore.Models;
using AdoNetCore.Repositories;

namespace AdoNetCore
{
    public partial class Form08CrudDepartamentos : Form
    {
        RepositoryDepartamentos rep;
        public Form08CrudDepartamentos()
        {
            InitializeComponent();
            this.rep = new RepositoryDepartamentos();
            LoadDepartamentos();
        }

        private async void LoadDepartamentos()
        {
            List<Departamento> departamentos = await this.rep.GetDepartamentosAsync();
            this.lstDepartamentos.Items.Clear();
            foreach (Departamento dept in departamentos)
            {
                this.lstDepartamentos.Items.Add(dept.IdDepartamento + " - " + dept.Nombre + " - " + dept.Localidad);
            }
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            await this.rep.InsertDepartamentoAsync(id, nombre, localidad);
            this.LoadDepartamentos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            await this.rep.UpdateDepartamentoAsync(id, nombre, localidad);
            this.LoadDepartamentos();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            await this.rep.DeleteDepartamentoAsync(id);
            this.lstDepartamentos.Items.Clear();
            this.LoadDepartamentos();
        }
    }
}
