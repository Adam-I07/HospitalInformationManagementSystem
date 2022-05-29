using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HospitalInformationManagementSystem
{
    class PatientPersonalDetails
    {
        //Connecting to the Database
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-AG0H67T\SQLEXPRESS;Initial Catalog=HIMSDatabase;Integrated Security=True");

        /*All the private variables that will be used to store the values pulled from the User input are created here*/
        string _patientID;
        string _nhsNumber;
        string _firstName;
        string _middleName;
        string _lastName;
        string _age;
        string _gender;
        string _dateOfBirth;
        string _countryOfBirth;
        string _email;
        string _phoneNumber;
        string _homeNumber;
        string _address;
        string _city;
        string _postcode;
        string _bloodType;

        //local variables used within the class
        public List<string> currentExistingIDs = new List<string>();
        public DataSet currentPatientDetails = new DataSet();
        public string userFirstNameSearch;

        //Sets all the private variables to null ready to store values
        public PatientPersonalDetails()
        {
            _patientID = "";
            _nhsNumber = "";
            _firstName = "";
            _middleName = "";
            _lastName = "";
            _age = "";
            _gender = "";
            _dateOfBirth = "";
            _countryOfBirth = "";
            _email = "";
            _phoneNumber = "";
            _homeNumber = "";
            _address = "";
            _city = "";
            _postcode = "";
            _bloodType = "";
        }

        //Assigns the values of the private variables to local strings.
        public PatientPersonalDetails(string patientID, string nhsNumber, string firstName, string middleName, string lastName, string age, string gender, string dateOfBirth, string countryOfBirth, string email, string phoneNumber, string homeNumber, string address, string city, string postcode, string bloodType)
        {
            _patientID = patientID;
            _nhsNumber = nhsNumber;
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
            _age = age;
            _gender = gender;
            _dateOfBirth = dateOfBirth;
            _countryOfBirth = countryOfBirth;
            _email = email;
            _phoneNumber = phoneNumber;
            _homeNumber = homeNumber;
            _address = address;
            _city = city;
            _postcode = postcode;
            _bloodType = bloodType;
        }

        /*These get and set functions are assigned the private variables containing the values from the form
        ready to use via public strings created below.*/
        public string patientID
        {
            get
            {
                return _patientID;
            }
            set
            {
                _patientID = value;
            }
        }

        public string nhsNumber
        {
            get
            {
                return _nhsNumber;
            }
            set
            {
                _nhsNumber = value;
            }
        }
        public string firstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string middleName
        {
            get
            {
                return _middleName;
            }
            set
            {
                _middleName = value;
            }
        }
        public string lastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public string gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }
        public string dateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                _dateOfBirth = value;
            }
        }
        public string countryOfBirth
        {
            get
            {
                return _countryOfBirth;
            }
            set
            {
                _countryOfBirth = value;
            }
        }
        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public string phoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }
        }
        public string homeNumber
        {
            get
            {
                return _homeNumber;
            }
            set
            {
                _homeNumber = value;
            }
        }
        public string address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        public string city
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        public string postcode
        {
            get
            {
                return _postcode;
            }
            set
            {
                _postcode = value;
            }
        }
        public string bloodType
        {
            get
            {
                return _bloodType;
            }
            set
            {
                _bloodType = value;
            }
        }

        //This function gets all the data stored within the PateintPersonalInformation table in the database for the system to use and display
        public bool LoadCurrentDetails()
        {
            currentPatientDetails.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "select * from PatientPersonalInformation";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(currentPatientDetails);
            sqlConnection.Close();
            return true;
        }

        //Gets data from the database using a specfic input entered by the user
        public bool FilterPatientDetails()
        {
            currentPatientDetails.Clear();
            sqlConnection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select * from PatientPersonalInformation where [FirstName] = '" + userFirstNameSearch + "'";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(currentPatientDetails);
            sqlConnection.Close();
            return true;
        }

        //Gets all the current Patient ID used in the LogInDetails Table in the database
        public bool GetAllCurrentPatientIDs()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select PatientID from PatientPersonalInformation";
            command.Connection.Open();
            SqlDataReader sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                currentExistingIDs.Add(sqlDataReader.GetValue(0).ToString());
            }

            sqlConnection.Close();
            return true;
        }

        //Once the user has inputted new data to save this function will assign it to the database variables and send it to the database to save
        public string AddPatient()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "insert into PatientPersonalInformation(PatientID,NHSNumber,FirstName,MiddleName,LastName,Age,Gender,DateOfBirth,CountryOfBirth,Email,PhoneNumber,HomeNumber,Address,City,Postcode,BloodType) values ('" + patientID + "', '" + nhsNumber + "','" + firstName + "','" + middleName + "','" + lastName + "','" + age + "','" + gender + "','" + dateOfBirth + "','" + countryOfBirth + "','" + email + "','" + phoneNumber + "','" + homeNumber + "','" + address + "','" + city + "', '" + postcode + "','" + bloodType + "')";

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            sqlConnection.Close();
            return "Successful";
        }

        //Gets the PatientPersonalInformation that the user requests from the database
        public bool GetPatientDetails()
        {

            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "select * from PatientPersonalInformation where PatientID = " + patientID + "";

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            nhsNumber = dataSet.Tables[0].Rows[0][1].ToString();
            firstName = dataSet.Tables[0].Rows[0][2].ToString();
            middleName = dataSet.Tables[0].Rows[0][3].ToString();
            lastName = dataSet.Tables[0].Rows[0][4].ToString();
            age = dataSet.Tables[0].Rows[0][5].ToString();
            gender = dataSet.Tables[0].Rows[0][6].ToString();
            dateOfBirth = dataSet.Tables[0].Rows[0][7].ToString();
            countryOfBirth = dataSet.Tables[0].Rows[0][8].ToString();
            email = dataSet.Tables[0].Rows[0][9].ToString();
            phoneNumber = dataSet.Tables[0].Rows[0][10].ToString();
            homeNumber = dataSet.Tables[0].Rows[0][11].ToString();
            address = dataSet.Tables[0].Rows[0][12].ToString();
            city = dataSet.Tables[0].Rows[0][13].ToString();
            postcode = dataSet.Tables[0].Rows[0][14].ToString();
            bloodType = dataSet.Tables[0].Rows[0][15].ToString();
            sqlConnection.Close();
            return true;
        }

        //Gets all the changes that the user wishes to make and sends it to the database in a query that will complete the change
        public bool EditPatient()
        {
            sqlConnection.Open();
            string query = "UPDATE PatientPersonalInformation SET NHSNumber = '" + nhsNumber + "', FirstName = '" + firstName + "', MiddleName = '" + middleName + "', LastName = '" + lastName + "', Age = '" + age + "', Gender = '" + gender + "', DateOfBirth = '" + dateOfBirth + "', CountryOfBirth = '" + countryOfBirth + "', Email = '" + email + "', PhoneNumber = '" + phoneNumber + "', HomeNumber = '" + homeNumber + "', Address = '" + address + "', City = '" + city + "', Postcode = '" + postcode + "', BloodType = '" + bloodType + "' where PatientID = '" + patientID + "'";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }

        //Gets the Patient ID of Patient the user wishes to delete and sends it to the database to complete the request
        public string DeleteExistingPatient()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;

            command.CommandText = "delete from PatientPersonalInformation where PatientID = '" + patientID + "'";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            sda.Fill(dataSet);
            sqlConnection.Close();
            return "Success";
        }
    }
}
