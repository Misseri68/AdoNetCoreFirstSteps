using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNetCore.Models;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace AdoNetCore.Repositories
{
    public class RepositoryDepartamentos
    {

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader reader;

        public RepositoryDepartamentos() {

            string connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.cmd = new SqlCommand();
            this.cmd.Connection = this.cn;

        }

        public async Task<List<Departamento>> GetDepartamentosAsync()
        {
            string query = "select * from DEPT";
            this.cmd.CommandType = System.Data.CommandType.Text;
            this.cmd.CommandText = query;
            await this.cn.OpenAsync();
            this.reader = await this.cmd.ExecuteReaderAsync();
            List<Departamento> departamentos = new List<Departamento>();
            while (await this.reader.ReadAsync())
            {
                int id = int.Parse(this.reader["DEPT_NO"].ToString());
                string nombre = this.reader["DNOMBRE"].ToString();
                string localidad = this.reader["LOC"].ToString();
                Departamento dept = new Departamento();
                dept.IdDepartamento = id;
                dept.Nombre = nombre;
                dept.Localidad = localidad;
                departamentos.Add(dept);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }

        public async Task InsertDepartamentoAsync(int id, string nombre, string localidad)
        {
            string sql = "insert into DEPT values (@id, @nombre, @localidad)";
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
            cmd.Parameters.Add(new SqlParameter("@localidad", localidad));
            this.cmd.CommandType = System.Data.CommandType.Text;
            this.cmd.CommandText = sql;
            await this.cn.OpenAsync();
            await this.cmd.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.cmd.Parameters.Clear();
        }

        public async Task UpdateDepartamentoAsync(int id, string nombre, string localidad)
        {
            string sql = "update DEPT set DNOMBRE = @nombre, LOC = @localidad, where DEPT_NO = @id";
            this.cmd.Parameters.AddWithValue("@id", id);
            this.cmd.Parameters.AddWithValue("@nombre", nombre);
            this.cmd.Parameters.AddWithValue("@localidad", localidad);
            this.cmd.CommandType = System.Data.CommandType.Text;
            this.cmd.CommandText = sql;
            await this.cn.OpenAsync();
            await this.cmd.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.cmd.Parameters.Clear();
        }

        public async Task DeleteDepartamentoAsync(int id)
        {
            string sql = "delete from DEPT where DEPT_NO = @id";
            this.cmd.Parameters.AddWithValue("@id", id);
            this.cmd.CommandText = sql;
            this.cmd.CommandType= System.Data.CommandType.Text;
            await this.cn.OpenAsync();
            await this.cmd.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.cmd.Parameters.Clear();
        }
    }
}
