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
    public partial class Form06UpdateSalasClases : Form
    {

        RepositorySalas repo;
        public Form06UpdateSalasClases()
        {
            InitializeComponent();
            this.repo = new RepositorySalas();
            LoadSalas();

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string newName = this.txtSala.Text;
            string oldName = this.lstSalas.SelectedItem.ToString();
            await this.repo.UpdateNombreSalaAsync(oldName, newName);
            this.LoadSalas();
        }

        private async void LoadSalas()
        {
            List<string> salas = await this.repo.GetNombreSalaAsync();
            this.lstSalas.Items.Clear();
            foreach (string sala in salas)
            {
                {
                    this.lstSalas.Items.Add(sala);
                }
            }
        }
    }
}
