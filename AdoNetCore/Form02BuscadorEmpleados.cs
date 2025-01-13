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
    public partial class Form02BuscadorEmpleados : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader reader;
        string ConnectionString;
        public Form02BuscadorEmpleados()
        {
            this.ConnectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(this.ConnectionString);
            this.cmd = new SqlCommand();

            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.lstEmpleados.Items.Clear();
            string salario = this.txtSalario.Text;
            string query = "select * from EMP where salario >= " + salario;
            try
            {
                this.cmd.Connection = this.cn;
                this.cmd.CommandText = query;
                this.cmd.CommandType = CommandType.Text;

                this.cn.Open();
                this.reader = cmd.ExecuteReader();

                while (this.reader.Read()) {
                    string apellido = this.reader["APELLIDO"].ToString();
                    string salarios = this.reader["SALARIO"].ToString();

                    string empleado = apellido + " ; " + salarios;

                    this.lstEmpleados.Items.Add(empleado);
                }
                this.reader.Close();
                cn.Close();
            }
            catch (Exception ex) {
                if (cn.State == ConnectionState.Open) 
                {
                    cn.Close();
                }
                if (!reader.IsClosed) 
                {
                    reader.Close();
                }
            }
        }
    }
}
