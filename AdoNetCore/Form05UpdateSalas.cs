using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace AdoNetCore
{
    public partial class Form05UpdateSalas : Form

    {

        string connectionString;
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader reader;

        public Form05UpdateSalas()
        {
            InitializeComponent();

            this.connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.cmd = new SqlCommand();
            CargarLista();
        }

        private void CargarLista()
        {
            string query = "select * from SALA";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Connection = this.cn;
            cn.Open();
            reader = cmd.ExecuteReader();
            this.lstSalas.Items.Clear();
            while (reader.Read())
            {
                string nombre = reader["NOMBRE"].ToString();
                string idsala = reader["SALA_COD"].ToString();
                lstSalas.Items.Add(idsala + "\t" + nombre);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE SALA SET NOMBRE = @NOMBRE WHERE SALA_COD = @CODIGO";
            string nombreSala = this.txtSala.Text;
            int codigoSala = int.Parse(this.lstSalas.SelectedItem.ToString().Substring(0,1));
            SqlParameter pam = new SqlParameter("@CODIGO",codigoSala);
            SqlParameter pamNombre = new SqlParameter("@NOMBRE", nombreSala);
            this.cmd.Parameters.Add(pam);
            this.cmd.Parameters.Add(pamNombre);
            this.cmd.Connection = this.cn;
            this.cmd.CommandType = CommandType.Text;
            this.cmd.CommandText = query;
            this.cn.Open();
            int numAfetados = this.cmd.ExecuteNonQuery();
            this.cn.Close();
            CargarLista();
            this.txtSala.Text = "Elija sala";
        }

        private void lstSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtSala.Text = this.lstSalas.SelectedItem.ToString().Replace("\t", "").Substring(1);
        }
    }
}
