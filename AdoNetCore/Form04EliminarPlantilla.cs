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
    public partial class Form04EliminarPlantilla : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        string ConnectionString;
        public Form04EliminarPlantilla()
        {
            InitializeComponent();

            this.ConnectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(this.ConnectionString);
            this.com = new SqlCommand();

            InitializeConnection();
        }

        private void InitializeConnection()
        {

            string query = "SELECT * FROM PLANTILLA";
            this.com.CommandText = query;
            this.com.CommandType = CommandType.Text;
            this.com.Connection = this.cn;
            this.cn.Open();

            this.lstEmpleados.Items.Clear();
            this.reader = com.ExecuteReader();

            while (this.reader.Read()) {
                string apellido = this.reader["APELLIDO"].ToString();
                string numeroEmp = this.reader["EMPLEADO_NO"].ToString();
                this.lstEmpleados.Items.Add(apellido + "---- ID:" +  numeroEmp);
            }

            this.reader.Close();
            this.cn.Close();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idEmp = int.Parse(this.txtID.Text);

            string query = "DELETE FROM PLANTILLA WHERE EMPLEADO_NO = " + idEmp;
            this.com.CommandText = query;
            this.com.CommandType = CommandType.Text;
            this.com.Connection = this.cn;
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.InitializeConnection();
        }
    }
}
