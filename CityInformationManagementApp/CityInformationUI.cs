using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityInformationManagementApp
{
    public partial class CityInformationUI : Form
    {
        public CityInformationUI()
        {
            InitializeComponent();
        }

        public string connectionString =
            ConfigurationManager.ConnectionStrings["CityInformationConString"].ConnectionString;
        City aCity = new City();
        public bool isUpdateMode = false;
        public int cityID;
        public void saveButton_Click(object sender, EventArgs e)
        {
            aCity.cityName = cityNameTextBox.Text;
            aCity.about = aboutCityTextBox.Text;
            aCity.country = countryTextBox.Text;

            if (isUpdateMode)
            {
                SqlConnection connection = new SqlConnection(connectionString);


                //2. write query 

                string query = "UPDATE tbl_City SET About ='" + aCity.about + "', Country ='" + aCity.country + "' WHERE ID = '" + aCity.ID + "'";
                //*******

                // 3. execute query 

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                connection.Close();



                //4. see result

                if (rowAffected > 0)
                {
                    MessageBox.Show("Updated Successfully!");

                    saveButton.Text = "Save";
                    cityID = 0;
                    isUpdateMode = false;
                    cityNameTextBox.Enabled = true;
                    ShowAllCityInformation();

                }
                else
                {
                    MessageBox.Show("Update Failed!");
                }
            }
            else
            {
                if (IsCityNameExist(aCity.cityName) || (aCity.cityName.Length < 4))
                {
                    MessageBox.Show("City Name Already Exist Or city name less than 4 Characters.");
                    return;
                }
                SqlConnection connection = new SqlConnection(connectionString);

                string query = "INSERT INTO tbl_City VALUES('" + aCity.cityName + "','" + aCity.about + "','" + aCity.country + "')";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowAffected > 0)
                {
                    MessageBox.Show("Insertion Successfull");
                    ShowAllCityInformation();
                }
                else
                {
                    MessageBox.Show("Insertion Successfull");
                }
            }
            
        }

        public bool IsCityNameExist(string cityName)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM tbl_City WHERE CityName ='"+cityName+"'";

            SqlCommand command = new SqlCommand(query, connection);
            bool isCityNameExist = false;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                isCityNameExist = true;
                break;
            }
            reader.Close();
            connection.Close();

            return isCityNameExist;
        }


        public void ShowAllCityInformation()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM tbl_City";

            SqlCommand command = new SqlCommand(query, connection);
            List<City> cityList = new List<City>();
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                City city = new City();
                city.ID = int.Parse(reader["ID"].ToString());
                city.cityName = reader["CityName"].ToString();
                city.about = reader["About"].ToString();
                city.country = reader["Country"].ToString();

                cityList.Add(city);
            }
            reader.Close();
            connection.Close();

            LoadCitiesListView(cityList);
        }

        public void LoadCitiesListView(List<City> cities)
        {
            cityListView.Items.Clear();
            foreach (var city in cities)
            {
                ListViewItem item = new ListViewItem(city.ID.ToString());
                item.SubItems.Add(city.cityName);
                item.SubItems.Add(city.about);
                item.SubItems.Add(city.country);

                cityListView.Items.Add(item);
            }
        }

        private void cityListView_DoubleClick(object sender, EventArgs e)
        {


            //// 1. Select selected Student

            ListViewItem item = cityListView.SelectedItems[0];
            //ListViewItem item = studentListView.SelectedItems[0];
            int id = int.Parse(item.Text.ToString());
            //int id = int.Parse(item.Text.ToString());
            City city = GetCityByID(id);
            //Student student = GetStudentByID(id);
            if (city != null)
            {
                isUpdateMode = true;
                saveButton.Text = "Update";
                cityNameTextBox.Enabled = false;
                cityID = city.ID;

                cityNameTextBox.Text = city.cityName;
                aboutCityTextBox.Text = city.about;
                countryTextBox.Text = city.country;
            }
        }

        private void CityInformationUI_Load(object sender, EventArgs e)
        {
            ShowAllCityInformation();
        }

        public City GetCityByID(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            //2. write query 

            string query = "SELECT * FROM tbl_City WHERE ID ='" + id + "'";


            // 3. execute query 

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<City> cityList = new List<City>();

            while (reader.Read())
            {

                City city = new City();
                city.ID = int.Parse(reader["ID"].ToString());
                city.cityName = reader["CityName"].ToString();
                city.about = reader["About"].ToString();
                city.country = reader["Country"].ToString();

                cityList.Add(city);

            }
            reader.Close();
            connection.Close();

            return cityList.FirstOrDefault();

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            String query;
            SqlConnection connection = new SqlConnection(connectionString);
            string Name = searchTextBox.Text;
            if (searchByCityRadioButton.Checked)
            {
                query = "SELECT * FROM tbl_City WHERE CityName LIKE %'" + Name+ "'%";
            }
            else
            {
                query = "SELECT * FROM tbl_City WHERE Country LIKE %'" + Name + "'%";
            }

            SqlCommand command = new SqlCommand(query, connection);
            List<City> cityList = new List<City>();
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                City city = new City();
                city.ID = int.Parse(reader["ID"].ToString());
                city.cityName = reader["CityName"].ToString();
                city.about = reader["About"].ToString();
                city.country = reader["Country"].ToString();

                cityList.Add(city);
            }
            reader.Close();
            connection.Close();

            LoadCitiesListView(cityList);
        }
    }
}
