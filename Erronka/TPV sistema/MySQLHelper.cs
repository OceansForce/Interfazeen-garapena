using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows;

public class MySQLHelper
{
    public string connectionString;

    public MySQLHelper()
    {
        //connectionString = "server=localhost;database=IG_DB;user=root;password=2829;";
        connectionString = "server=localhost;database=IG_DB;user=root;password=123;";
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
            return ManejarErrorMySQL(ex);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error general: {ex.Message}", "Error");
            return -1;
        }

        return rowsAffected;
    }

    private int ManejarErrorMySQL(MySqlException ex)
    {
        string mensaje = "";

        switch (ex.Number)
        {
            case 1062: // Violación de PRIMARY KEY o UNIQUE KEY
                mensaje = "Errorea: Erabiltzaile edo Produktu izena existitzen da";

                break;

            case 1045: // Acceso denegado
                mensaje ="Sarbide-errorea: Erabiltzaile edo pasahitz okerrak.";
                break;

            case 1042: // No se puede conectar al servidor
                mensaje = "Konexio-errorea: Ezin da datu-basearen zerbitzarira konektatu.";
                break;

            default:
                mensaje = $"Error MySQL [{ex.Number}]: {ex.Message}";
                break;
        }

        MessageBox.Show(mensaje);

        return -ex.Number;
    }


}