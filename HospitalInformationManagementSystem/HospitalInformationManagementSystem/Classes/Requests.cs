using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalInformationManagementSystem
{
    class Requests
    {
        //Connecting to the Database
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");

        /*All the private variables that will be used to store the values pulled from the User input are created here*/
        string _requestID;
        string _userID;
        string _requestDate;
        string _requestStatus;
        string _request;
        string _requestResponse;

        //local variables used within the class
        public DataSet currentRequests = new DataSet();
        public string userSelectedFilter;
        public List<String> currentExistingRequestIDs = new List<string>();
        public DataTable currentExistingLoginIDs = new DataTable();


        //Sets all the private variables to null ready to store values
        public Requests()
        {
            _requestID = "";
            _userID = "";
            _requestDate = "";
            _requestStatus = "";
            _request = "";
            _requestResponse = "";
        }

        //Assigns the values of the private variables to local strings.
        public Requests(string requestID, string userID, string requestDate, string requestStatus, string request, string requestResponse)
        {
            _requestID = requestID;
            _userID = userID;
            _requestDate = requestDate;
            _requestStatus = requestStatus;
            _request = request;
            _requestResponse = requestResponse;
        }

        /*These get and set functions are assigned the private variables containing the values from the form
        ready to use via public strings created below.*/
        public string requestID
        {
            get
            {
                return _requestID;
            }
            set
            {
                _requestID = value;
            }
        }
        public string userID
        {
            get
            {
                return _userID;
            }
            set
            {
                _userID = value;
            }
        }
        public string requestDate
        {
            get
            {
                return _requestDate;
            }
            set
            {
                _requestDate = value;
            }
        }
        public string requestStatus
        {
            get
            {
                return _requestStatus;
            }
            set
            {
                _requestStatus = value;
            }
        }
        public string request
        {
            get
            {
                return _request;
            }
            set
            {
                _request = value;
            }
        }
        public string requestResponse
        {
            get
            {
                return _requestResponse;
            }
            set
            {
                _requestResponse = value;
            }
        }

        //This function gets all the data stored within the Requests table in the database for the system to use and display
        public bool LoadCurrentRequests()
        {
            currentRequests.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "select * from Requests";
            SqlDataAdapter sda = new SqlDataAdapter(command);

            sda.Fill(currentRequests);
            sqlConnection.Close();
            return true;
        }

        //Gets data from the database using a specfic input entered by the user
        public bool FilterIlnessInformation()
        {
            currentRequests.Clear();
            sqlConnection.Open();
            string query = "select * from Requests where RequestStatus = '" + userSelectedFilter + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            sqlDataAdapter.Fill(currentRequests);
            sqlConnection.Close();
            return true;
        }

        //Gets all the current Request ID used in the Requests Table in the database
        public bool GetAllCurrentRequestID()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select RequestID from Requests";
            command.Connection.Open();
            SqlDataReader sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                currentExistingRequestIDs.Add(sqlDataReader.GetValue(0).ToString());
            }

            sqlConnection.Close();
            return true;
        }

        //Once the user has inputted new data to save this function will assign it to the database variables and send it to the database to save
        public bool SubmitRequest()
        {
            string date = DateTime.UtcNow.ToString("dd-MM-yyyy");
            string requestStatus = "Pending";
            string requestResponse = "Pending";

            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "insert into Requests(RequestID,UserID,RequestDate,RequestStatus,Request,RequestResponse) values ('" + requestID + "', '" + userID + "','" + date + "','" + requestStatus + "','" + request + "','" + requestResponse + "')";

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            sqlConnection.Close();
            return true;
        }

        //Gets all the current Login ID used in the LogInDetails Table in the database
        public bool GetAllCurrentLoginIDs()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select LogInID from LogInDetails";
            command.Connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(currentExistingLoginIDs);
            sqlConnection.Close();
            return true;
        }

        //Gets the Request that the user wants from the database
        public bool GetRequest()
        {

            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select * from Requests where RequestID = " + requestID + "";

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            userID = dataSet.Tables[0].Rows[0][1].ToString();
            requestDate = dataSet.Tables[0].Rows[0][2].ToString();
            requestStatus = dataSet.Tables[0].Rows[0][3].ToString();
            request = dataSet.Tables[0].Rows[0][4].ToString();
            requestResponse = dataSet.Tables[0].Rows[0][5].ToString();

            sqlConnection.Close();
            return true;
        }

        //Gets the response the user enters and sends it to the database to save
        public bool RespondToRequest()
        {
            sqlConnection.Open();
            string query = "UPDATE Requests SET UserID = '" + userID + "', RequestDate = '" + requestDate + "', RequestStatus = '" + requestStatus + "', Request = '" + request + "', RequestResponse = '" + requestResponse + "' where RequestID = '" + requestID + "'";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }

        //Gets the Request the user wishes to delete and sends it to the database to delete
        public string DeleteRequest()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "delete from Requests where RequestID = '" + requestID + "'";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            sqlConnection.Close();
            return "Success";
        }
    }
}
