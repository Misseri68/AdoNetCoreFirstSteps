using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AdoNetCore.Repositories
{
    public class RepositoryEmpleadosDepartamentos

    {

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader reader;
        String connectionString;

        public RepositoryEmpleadosDepartamentos()
        {
            this.connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.cmd = new SqlCommand();
        }

        public async Task<List<string>> CargarDepartamentosAsync(){
            List<string> departamentos = new List<string>();
            string query = "SELECT DNOMBRE FROM DEPT";
            this.cmd.CommandType= System.Data.CommandType.Text;
            this.cmd.CommandText= query;
            this.cmd.Connection = cn;
            await this.cn.OpenAsync();
            this.reader = await this.cmd.ExecuteReaderAsync();

            while (await this.reader.ReadAsync()) {
                departamentos.Add(this.reader["DNOMBRE"].ToString());
            }
            await this.cn.CloseAsync();
            await this.reader.CloseAsync();
            return departamentos;
        }

        public async Task<List<string>> CargarEmpleadosDepartamentoAsync(string nombreDepartamento) {


            int idDepartamento = await  FindDepartmentIdByName(nombreDepartamento);
            List<string> empleados = new List<string>();
            string query = "SELECT APELLIDO FROM EMP E INNER JOIN DEPT D ON D.DEPT_NO = E.DEPT_NO " +
                "WHERE D.DEPT_NO = @idDept ";
            SqlParameter pam = new SqlParameter("@idDept", idDepartamento);
            this.cmd.Parameters.Add(pam);
            this.cmd.Connection = this.cn;
            this.cmd.CommandType = System.Data.CommandType.Text;
            this.cmd.CommandText = query;
            await this.cn.OpenAsync();
            this.reader = await cmd.ExecuteReaderAsync();

            while (await this.reader.ReadAsync())
            {
                empleados.Add(this.reader["APELLIDO"].ToString());
            }
            await this.cn.CloseAsync();
            await this.reader.CloseAsync();
            this.cmd.Parameters.Clear();
            return empleados;
        }

        public async Task BorrarEmpleado(string apellidoEmpleado) {
            string query = "DELETE FROM EMP WHERE apellido = @apellido";
            SqlParameter pam = new SqlParameter("@apellido", apellidoEmpleado);
            this.cmd.Parameters.Add(pam);
            this.cmd.Connection = this.cn;
            this.cmd.CommandText = query;
            this.cmd.CommandType = System.Data.CommandType.Text;
            await this.cn.OpenAsync();
            await this.cmd.ExecuteNonQueryAsync();
            this.cmd.Parameters.Clear();
            await this.cn.CloseAsync();
        }

        public async Task<int> FindDepartmentIdByName(string dnombre)
        {
            string query = "SELECT DEPT_NO FROM DEPT WHERE DNOMBRE = @DNOMBRE ";
            SqlParameter pam = new SqlParameter("@DNOMBRE", dnombre);
            this.cmd.Parameters.Add(pam);
            this.cmd.Connection = this.cn;
            this.cmd.CommandText = query;
            this.cmd.CommandType = System.Data.CommandType.Text;
            await this.cn.OpenAsync();
            this.reader = await this.cmd.ExecuteReaderAsync();
            await this.reader.ReadAsync();
            int id = int.Parse(this.reader["DEPT_NO"].ToString());
            this.cmd.Parameters.Clear();
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return id;

        }
    }
}
