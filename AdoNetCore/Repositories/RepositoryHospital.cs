using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNetCore.Models;
using Microsoft.Data.SqlClient;

namespace AdoNetCore.Repositories
{
    public class RepositoryHospital
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryHospital() {
            string connectionString = @"Data Source=LOCALHOST\DESARROLLO;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            cn = new SqlConnection(connectionString);
            com = new SqlCommand();
            com.Connection = cn;
        }
        

        public async Task<List<Hospital>> GetHospitalesAsync()
        {
            List<Hospital> hospitales = new List<Hospital>();
            string query = "SELECT * FROM HOSPITAL;";
            this.com.CommandText = query;
            this.com.CommandType = System.Data.CommandType.Text;
            await this.cn.OpenAsync();
            this.reader = await com.ExecuteReaderAsync();
            while (await reader.ReadAsync()) {
                Hospital hospital = new Hospital();
                hospital.Id = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                hospital.Nombre = this.reader["NOMBRE"].ToString();
                hospital.Direccion = this.reader["DIRECCION"].ToString();
                
                hospitales.Add(hospital);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return hospitales;
        }

        public async Task CreateHospitalAsync(int id, string nombre, string direccion) {
            string query = "INSERT INTO HOSPITAL (HOSPITAL_COD, NOMBRE, DIRECCION) VALUES(@id, @nombre, @direccion)";
            this.com.CommandText = query;
            this.com.Parameters.AddWithValue("@id", id);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@direccion", direccion);
            this.com.CommandType = System.Data.CommandType.Text;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task UpdateHospitalAsync(int id, string nombre, string direccion) {
            string query = "UPDATE HOSPITAL SET NOMBRE = @nombre , DIRECCION = @direccion WHERE HOSPITAL_COD = @id";
            this.com.Parameters.AddWithValue("@id", id);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@direccion", direccion);
            this.com.CommandType= System.Data.CommandType.Text;
            this.com.CommandText= query;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task DeleteHospitalAsync(int id) {
            string query = "DELETE FROM HOSPITAL WHERE HOSPITAL_COD = @id";
            this.com.Parameters.AddWithValue("@id", id);
            this.com.CommandText = query;
            this.com.CommandType = System.Data.CommandType.Text;
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();


        }
    }
}
