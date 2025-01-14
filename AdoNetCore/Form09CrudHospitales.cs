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
    public partial class Form09CrudHospitales : Form
    {
        RepositoryHospital rep;

        public Form09CrudHospitales()
        {
            InitializeComponent();
            this.rep = new RepositoryHospital();
            CargarHospitales();

        }


        private async void CargarHospitales() { 
            List<Hospital> hospitales = await this.rep.GetHospitalesAsync();
            foreach (Hospital hospi in hospitales){
                this.lstHospitales.Items.Add(
                    hospi.Id + " - " + hospi.Nombre + " - " + hospi.Direccion
                    );
            }
        }

        private async void BtnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtLocalidad.Text;
            await this.rep.CreateHospitalAsync(id, nombre, direccion);
            this.lstHospitales.Items.Clear();
            CargarHospitales();
        }

        private async void BtnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtLocalidad.Text;
            await this.rep.UpdateHospitalAsync(id, nombre, direccion);
            this.lstHospitales.Items.Clear();
            CargarHospitales();

        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            await this.rep.DeleteHospitalAsync(id);
            this.lstHospitales.Items.Clear();
            CargarHospitales();
        }
    }
}
