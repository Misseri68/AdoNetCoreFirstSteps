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
    public partial class Form01PrimerAdo : Form
    {

        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        string connectionString;

        public Form01PrimerAdo()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa; Trust Server Certificate = True";

            this.cn = new SqlConnection();
            this.cn.ConnectionString = this.connectionString;
            this.cn.StateChange += Cn_StateChange;
            this.com = new SqlCommand();
        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.lblMensaje.Text = "La conexion está pasando de" +
                e.OriginalState + " a " + e.CurrentState;
        }

     
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (this.cn.State == ConnectionState.Closed) {
                this.cn.Open();
            }
            this.lblMensaje.BackColor = Color.LightGreen;
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.lblMensaje.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "select * from EMP";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.reader = this.com.ExecuteReader();


            for (int i = 0; i < this.reader.FieldCount; i++){
                string columna = this.reader.GetName(i);
                string tipoDato = this.reader.GetDataTypeName(i);
                this.lstColumnas.Items.Add(columna);
                this.lstTiposDato.Items.Add(tipoDato);
            }

            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstApellidos.Items.Add(apellido);
            }

            this.reader.Close();
           

        }

        private void lstApellidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
