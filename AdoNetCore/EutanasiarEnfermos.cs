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
    public partial class EutanasiarEnfermos : Form
    {

        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        string ConnectionString;

        public EutanasiarEnfermos()
        {
            InitializeComponent();
            this.ConnectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(this.ConnectionString);
            this.com = new SqlCommand();
            cargarEnfermos();

        }

        private void cargarEnfermos() {
            
            string query = "select * from ENFERMO";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = query;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstTerminales.Items.Clear();
            while (this.reader.Read())
            {
                string inscripcion = this.reader["INSCRIPCION"].ToString();
                string apellidos = this.reader["APELLIDO"].ToString();
                this.lstTerminales.Items.Add(apellidos + " - " + inscripcion);     
             }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int inscripcion = int.Parse(this.txtInscripcion.Text);
            string query = "delete from ENFERMO where INSCRIPCION = @inscripcion";
            SqlParameter pam = new SqlParameter();
            pam.ParameterName = "@inscripcion";
            pam.Value = inscripcion;
            // pam.DbType = DbType.Int32 Esto es opcional para datos sencillos
            this.com.Parameters.Add(pam);
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText= query;
            this.cn.Open();
            int eliminados = this.com.ExecuteNonQuery();
            this.cn.Close();
            cargarEnfermos();
        }
    }
}
