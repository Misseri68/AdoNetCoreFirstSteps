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

    #region STORED_PROCEDURES

    /*
     
    create procedure SP_EMPLEADOS_DEPT_OUT
	(@nombre nvarchar(50), @suma int OUT, @media int OUT, @personas int OUT)
	as
		declare @id int
		select @id = DEPT_NO from DEPT where DNOMBRE = @nombre 
		select * from EMP where DEPT_NO = @id

		select @suma = SUM(salario),
		 @media = AVG(salario), 
		 @personas = COUNT(EMP_NO) from EMP
		where DEPT_NO = @id
	go
     
     
     */


    #endregion
    public partial class Form13ParametrosSalida : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form13ParametrosSalida()
        {
            InitializeComponent();

            string connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = cn;

            LoadDepartamentos();
        }

        private async Task LoadDepartamentos()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.cmbDeps.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                this.cmbDeps.Items.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnMostrar_Click(object sender, EventArgs e)
        {
            string sp = "SP_EMPLEADOS_DEPT_OUT";
            string nombre = this.cmbDeps.SelectedItem.ToString();
            this.com.Parameters.AddWithValue("@nombre", nombre);
            SqlParameter pamSuma = new SqlParameter();
            pamSuma.ParameterName = "@suma";
            pamSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamSuma);
            SqlParameter pamMedia = new SqlParameter();
            pamMedia.ParameterName = "@media";
            pamMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamMedia);
            SqlParameter pamPersonas = new SqlParameter();
            pamPersonas.Direction = ParameterDirection.Output;
            pamPersonas.ParameterName = "@personas";
            this.com.Parameters.Add(pamPersonas);
            pamSuma.Value = 0;
            pamMedia.Value = 0;
            pamPersonas.Value = 0;
            this.com.CommandText = sp;
            this.com.CommandType = CommandType.StoredProcedure;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstEmpleados.Items.Clear();
            while(await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstEmpleados.Items.Add(apellido);
            }

            await this.reader.CloseAsync();


            this.txtSuma.Text = pamSuma.Value.ToString();
            this.txtMedia.Text = pamMedia.Value.ToString();
            this.txtPersonas.Text = pamPersonas.Value.ToString();

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

        }
    }
}
