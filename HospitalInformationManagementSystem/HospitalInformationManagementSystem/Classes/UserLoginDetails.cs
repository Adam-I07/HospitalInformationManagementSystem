using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalInformationManagementSystem
{
    class UserLoginDetails
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
        string _loginID;
        string _role;
        string _username;
        string _password;
        public List<string> currentExistingIDs = new List<string>();
        public DataSet currentUserDetails = new DataSet();
        public string userAddedFilter;

        public UserLoginDetails()
        {
            _loginID = "";
            _role = "";
            _username = "";
            _password = "";
        }

        public UserLoginDetails(string loginID, string role, string username, string password)
        {
            _loginID = loginID;
            _role = role;
            _username = username;
            _password = password;
        }

        public string loginID
        {
            get
            {
                return _loginID;
            }
            set
            {
                _loginID = value;
            }
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

        public bool LoadCurrentDetails()
        {
            currentUserDetails.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "select * from LogInDetails";
            SqlDataAdapter sda = new SqlDataAdapter(command);

            sda.Fill(currentUserDetails);
            sqlConnection.Close();
            return true;
        }

        public bool FilterUserDetails()
        {
            currentUserDetails.Clear();
            sqlConnection.Open();
            string query = "select * from LogInDetails where Role = '" + userAddedFilter + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            sqlDataAdapter.Fill(currentUserDetails);
            sqlConnection.Close();
            return true;
        }
        public string AddUser()
        {
            try
            {

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "insert into LogInDetails (LogInID,Role,Username,Password) values ('" + _loginID + "', '" + _role + "','" + _username + "','" + _password + "')";

                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                sda.Fill(dataSet);
                sqlConnection.Close();
                return "Successful";
            }
            catch
            {
                return "unsuccessful";
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public bool EditUser()
        {
            sqlConnection.Open();
            string query = "UPDATE LogInDetails SET Role = '" + role + "', Username = '" + username + "', Password = '" + password + "' where LogInID = '" + loginID + "'";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }

        public bool GetAllCurrentUserIDs()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select LogInID from LogInDetails";
            command.Connection.Open();
            SqlDataReader sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                currentExistingIDs.Add(sqlDataReader.GetValue(0).ToString());
            }

            sqlConnection.Close();
            return true;
        }


        public bool GetUserDetails()
        {

            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select * from LogInDetails where LogInID = '" + _loginID + "'";

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            role = dataSet.Tables[0].Rows[0][1].ToString();
            username = dataSet.Tables[0].Rows[0][2].ToString();
            password = dataSet.Tables[0].Rows[0][3].ToString();

            sqlConnection.Close();
            return true;
        }

        public string DeleteExistingUser()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "delete from LogInDetails where LogInID = '" + _loginID + "'";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            sqlConnection.Close();
            return "Success";
        }
    }
}

