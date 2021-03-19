using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Data.SqlClient;
public class SceneEvents : MonoBehaviour
{
    SqlConnection connection;
    SqlCommand command = new SqlCommand();
    string cmd;
    public Text username;
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void ExitBtn()
    {
        Application.Quit();
    }
    public void SaveToDB()
    {
        // First use a SqlClient connection
        string conn = @"Data source=LAPTOP-MDHTC0G8\SQLEXPRESS;";
        conn += "Initial Catalog=players;Integrated Security=True";
        connection = new SqlConnection(conn);
        connection.OpenAsync();
        Debug.Log(string.Format("State: {0}", connection.State));

        Debug.Log(string.Format("ConnectionString: {0}", connection.ConnectionString));
        connection.Close();
    }
}
