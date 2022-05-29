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
        //Connecting to the Database
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");

        /*All the private variables that will be used to store the values pulled from the User input are created here*/
        string _loginID;
        string _role;
        string _username;
        string _password;

        //local variables used within the class
        public List<string> currentExistingIDs = new List<string>();
        public DataSet currentUserDetails = new DataSet();
        public string userAddedFilter;

        //Sets all the private variables to null ready to store values
        public UserLoginDetails()
        {
            _loginID = "";
            _role = "";
            _username = "";
            _password = "";
        }

        //Assigns the values of the private variables to local strings.
        public UserLoginDetails(string loginID, string role, string username, string password)
        {
            _loginID = loginID;
            _role = role;
            _username = username;
            _password = password;
        }

        /*These get and set functions are assigned the private variables containing the values from the form
        ready to use via public strings created below.*/
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

        //This function gets all the data stored within the LogInDetails table in the database for the system to use and display
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

        //Gets data from the database using a specfic input entered by the user
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


        //Once the user has inputted new data to save this function will assign it to the database variables and send it to the database to save
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

        //Gets all the changes that the user wishes to make and sends it to the database in a query that will complete the change
        public bool EditUser()
        {
            sqlConnection.Open();
            string query = "UPDATE LogInDetails SET Role = '" + role + "', Username = '" + username + "', Password = '" + password + "' where LogInID = '" + loginID + "'";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }

        //Gets all the current Login ID used in the LogInDetails Table in the database
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

        //Gets the LogInDetails that the user requests from the database
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

        //Gets the LogInDetails the user wishes to delete and sends it to the database to complete the request
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

