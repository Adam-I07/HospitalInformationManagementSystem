using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HospitalInformationManagementSystem
{
    class Login
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
        string _role;
        string _username;
        string _password;
        public bool userDetailsCorrect;

        public Login()
        {
            _role = "";
            _username = "";
            _password = "";
        }

        public Login(string role, string username, string password)
        {
            _role = role;
            _username = username;
            _password = password;
        }
        public string role
        {
            get
            {
                return _role;
            }
            set
            {
                _role = value;
            }
        }
        public string username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }
        public string password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public bool CheckLoginCredentials()
        {
            string query = "SELECT * FROM LogInDetails WHERE Role = '" + role + "' AND Username = '" + username + "' AND Password = '" + password + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                userDetailsCorrect = true;
            }
            else
            {
                userDetailsCorrect = false;
            }
            sqlConnection.Close();
            return true;
        }
    }
}
