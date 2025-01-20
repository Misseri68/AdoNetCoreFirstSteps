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

#region PROCEDIMIENTOS ALMACENADOS

/*
 
CREATE PROCEDURE SP_ALL_DEPARTAMENTOS
as
	select * from DEPT
go;


CREATE PROCEDURE SP_INSERT_DEPARTAMENTO
(@numero int, @nombre nvarchar(30), @localidad nvarchar(30))
as
	insert into DEPT (DEPT_NO, DNOMBRE, LOC)
	values (@numero, @nombre, @localidad);
go


ALTER PROCEDURE SP_INSERT_DEPARTAMENTO
(@numero int, @nombre nvarchar(30), @localidad nvarchar(30))
as
	if(@localidad = 'TERUEL')
	begin
		print 'TERUEL NO EXISTE'
	end

	else

	begin
		insert into DEPT (DEPT_NO, DNOMBRE, LOC)
	values (@numero, @nombre, @localidad);
	end
	
go

 
 */






#endregion

namespace AdoNetCore
{
    public partial class Form12MensajeServidor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form12MensajeServidor()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = cn;

            this.cn.InfoMessage += Cn_InfoMessage;
            
            LoadDepartamentos();

        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.lblMensaje.Text = e.Message;
        }

        public async Task LoadDepartamentos()
        {
            string sp = "SP_ALL_DEPARTAMENTOS";
            this.lstDepartamentos.Items.Clear();
            await this.cn.OpenAsync();
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sp;
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync())
            {
                this.lstDepartamentos.Items.Add(this.reader["DNOMBRE"].ToString());
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            this.lblMensaje.Text = "";
            int numDep = int.Parse(this.txtNum.Text);
            string dnombre = this.txtNombre.Text;
            string loc = this.txtLocalidad.Text;

            string sp = "SP_INSERT_DEPARTAMENTO";
            this.com.Parameters.AddWithValue("@numero", numDep);
            this.com.Parameters.AddWithValue("@nombre", dnombre);
            this.com.Parameters.AddWithValue("@localidad", loc);
            this.com.CommandText = sp;
            this.com.CommandType = CommandType.StoredProcedure;
            await this.cn.OpenAsync();
            int nrowsaffected = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            await this.LoadDepartamentos();
            MessageBox.Show(nrowsaffected + " afectados ");

        }

     

       
    }
}
