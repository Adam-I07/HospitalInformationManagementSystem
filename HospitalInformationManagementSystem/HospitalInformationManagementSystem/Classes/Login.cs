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
        //Connecting to the Database
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
        /*All the private variables that will be used to store the values pulled from the User input are created here*/
        string _role;
        string _username;
        string _password;

        //local variables used within the class
        public bool userDetailsCorrect;

        //Sets all the private variables to null ready to store values
        public Login()
        {
            _role = "";
            _username = "";
            _password = "";
        }

        //Assigns the values of the private variables to local strings.
        public Login(string role, string username, string password)
        {
            _role = role;
            _username = username;
            _password = password;
        }

        /*These get and set functions are assigned the private variables containing the values from the form
        ready to use via public strings created below.*/
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

        //Gets the login details inputted and sends them to the database to be checked if they exist or not
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
