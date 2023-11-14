using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entity;
using System.Data;

namespace Capa_Datos
{
    public class D_Agenda
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);

        public List<E_Agenda>AgendaList(string firstName, string lastName)
        {
            SqlDataReader getRows;
            SqlCommand cmd = new SqlCommand("SP_GETAGENDA2", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@LastName", lastName);
            getRows = cmd.ExecuteReader();

            List<E_Agenda>Lists = new List<E_Agenda>();

            while(getRows.Read())
            {
                Lists.Add(new E_Agenda
                {
                    ID = getRows.GetInt32(0),
                    FirstName = getRows.GetString(1),
                    LastName = getRows.GetString(2),
                    Address = getRows.GetString(3),
                    DateOfBirth = getRows.GetDateTime(4),
                    MobilePhone= getRows.GetString(5),
                });
            }

            conexion.Close();
            getRows.Close();
            return Lists;

        }

        public void InsertAgenda(E_Agenda agenda)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAGENDA2", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@FirstName", agenda.FirstName);
            cmd.Parameters.AddWithValue("@LastName", agenda.LastName);
            cmd.Parameters.AddWithValue("@Address", agenda.Address);
            cmd.Parameters.AddWithValue("@DateOfBirth", agenda.DateOfBirth);
            cmd.Parameters.AddWithValue("@MobilePhone", agenda.MobilePhone);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void UpdateAgenda(E_Agenda agenda)
        {
            SqlCommand cmd = new SqlCommand("SP_UPDATEAGENDA2", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID", agenda.ID);
            cmd.Parameters.AddWithValue("@FirstName", agenda.FirstName);
            cmd.Parameters.AddWithValue("@LastName", agenda.LastName);
            cmd.Parameters.AddWithValue("@Address", agenda.Address);
            cmd.Parameters.AddWithValue("@DateOfBirth", agenda.DateOfBirth);
            cmd.Parameters.AddWithValue("@MobilePhone", agenda.MobilePhone);

            
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void DeleteAgenda(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_DELETEAGENDA2", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID", id);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

    }
}
