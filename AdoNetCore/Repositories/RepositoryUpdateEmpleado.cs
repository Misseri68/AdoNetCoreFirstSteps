using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AdoNetCore.Repositories
{
    public class RepositoryUpdateEmpleado
    {

        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public RepositoryUpdateEmpleado() 
        {
            string connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetOficios()
        {
            List<string> listOficios = new List<string>();
            string query = "SELECT DISTINCT OFICIO FROM EMP;";
            await this.cn.OpenAsync();
            this.com.CommandText = query;
            this.com.CommandType = System.Data.CommandType.Text;
            this.reader = await this.com.ExecuteReaderAsync();

            while (await this.reader.ReadAsync()) {
                listOficios.Add(this.reader["OFICIO"].ToString());
            }
            await this.cn.CloseAsync();
            await this.reader.CloseAsync();
            return listOficios;
        }

        public async Task<List<string>> GetEmpleadosOficio(string oficio) {
            List<string> listEmpleados = new List<string>();
            string query = "SELECT APELLIDO FROM EMP WHERE OFICIO = @oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandText= query;
            this.com.CommandType = System.Data.CommandType.Text;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            while (await this.reader.ReadAsync()) {
                listEmpleados.Add(this.reader["APELLIDO"].ToString());
            }
            this.com.Parameters.Clear();
            await this.cn.CloseAsync();
            await this.reader.CloseAsync();
            return listEmpleados;
        }

        public async Task UpdateIncrementoSalario(string apellido, int incremento) {
            string query = "UPDATE EMP SET SALARIO = SALARIO + @incremento WHERE APELLIDO = @apellido ";
            this.com.Parameters.AddWithValue("@incremento", incremento);
            this.com.Parameters.AddWithValue("@apellido", apellido);
            this.com.CommandText= query;
            this.com.CommandType= System.Data.CommandType.Text;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task UpdateNombreOficio(string oficio, string nuevoNombre)
        {
            string query = "UPDATE EMP SET OFICIO = @nuevo  WHERE OFICIO = @viejo";
            this.com.Parameters.AddWithValue("@nuevo", nuevoNombre);
            this.com.Parameters.AddWithValue("@viejo", oficio);
            this.com.CommandText= query;
            this.com.CommandType = System.Data.CommandType.Text;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();  
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task<int> getSalarioEmpleado(string apellido)
        {
            string query = "SELECT SALARIO FROM EMP WHERE APELLIDO = @apellido";
            this.com.Parameters.AddWithValue("@apellido", apellido);
            this.com.CommandText = query;
            this.com.CommandType = System.Data.CommandType.Text;
            await this.cn.OpenAsync();
            this.reader = await com.ExecuteReaderAsync();
            await this.reader.ReadAsync();
            int salario = int.Parse(this.reader["SALARIO"].ToString());
            await this.cn.CloseAsync();
            await this.reader.CloseAsync();
            this.com.Parameters.Clear();

            return salario;
        }

        public async Task<List<int>> getDatosSalario(string oficio)
        {
            string query = "SELECT " +
                "MAX(SALARIO) as MAX," +
                "AVG(SALARIO) as AVG, " +
                "SUM(SALARIO) as SUM FROM " +
                "EMP WHERE OFICIO = @oficio";

            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandText = query;
            this.com.CommandType = System.Data.CommandType.Text;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            await this.reader.ReadAsync();
            int max = int.Parse(this.reader["MAX"].ToString());
            int avg = int.Parse(this.reader["AVG"].ToString());
            int sum = int.Parse(this.reader["SUM"].ToString());
            await this.cn.CloseAsync();
            await this.reader.CloseAsync();
            this.com.Parameters.Clear();
            List<int> list = new List<int>();
            list.Add(max);
            list.Add(avg);
            list.Add(sum);
            return list;

        }

    }
}
