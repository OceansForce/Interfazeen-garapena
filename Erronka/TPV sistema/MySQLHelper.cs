using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows;

public class MySQLHelper
{
    public string connectionString;

    public MySQLHelper()
    {
        connectionString = "server=localhost;database=IG_DB;user=root;password=2829;";
        //connectionString = "server=localhost;database=IG_DB;user=root;password=123;";
    }

    // Ejecutar consulta SELECT
    public DataTable ExecuteQuery(string query)
    {
        DataTable dataTable = new DataTable();

        using (MySqlConnection connection = new MySqlConnection(connectionString))
        using (MySqlCommand command = new MySqlCommand(query, connection))
        {
            connection.Open();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                dataTable.Load(reader);
            }
        }

        return dataTable;
    }

    // Ejecutar consulta INSERT, UPDATE, DELETE
    public int ExecuteNonQuery(string query, MySqlParameter[] parameters = null)
    {
        int rowsAffected = 0;

        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show($"Error MySQL: {ex.Message}\nCódigo: {ex.Number}", "Error de Base de Datos");
            return -1; // Retornar un valor que indique error
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}", "Error General");
            return -1;
        }

        return rowsAffected;
    }


}