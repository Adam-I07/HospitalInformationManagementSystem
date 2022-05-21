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
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");
        string _requestID;
        string _userID;
        string _requestDate;
        string _requestStatus;
        string _request;
        string _requestResponse;
        public DataSet currentRequests = new DataSet();
        public string userSelectedFilter;

        public Requests()
        {
            _requestID = "";
            _userID = "";
            _requestDate = "";
            _requestStatus = "";
            _request = "";
            _requestResponse = "";
        }

        public Requests(string requestID, string userID, string requestDate, string requestStatus, string request, string requestResponse)
        {
            _requestID = requestID;
            _userID = userID;
            _requestDate = requestDate;
            _requestStatus = requestStatus;
            _request = request;
            _requestResponse = requestResponse;
        }
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
    }
}
