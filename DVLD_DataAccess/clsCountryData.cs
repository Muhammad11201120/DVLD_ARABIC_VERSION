using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsCountryData
    {
        public enum enGendor { Male = 0, Female = 1 };

        public static bool GetCountryInfoByID( int ID, ref string country_code , ref string country_enName , ref string country_arName, ref string country_enNationality, ref string country_arNationality)
            {
                bool isFound = false;

                SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

                string query = "SELECT * FROM Countries WHERE CountryID = @CountryID";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@CountryID", ID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {

                        // The record was found
                        isFound = true;

                        country_code = (string)reader[ "Country_code" ];
                        country_enName = (string)reader[ "Country_enName" ];
                        country_arName = (string)reader[ "Country_arName" ];
                        country_enNationality = (string)reader[ "Country_enNationality" ];
                        country_arNationality = (string)reader[ "Country_arNationality" ];

                    }
                    else
                    {
                        // The record was not found
                        isFound = false;
                    }

                    reader.Close();


                }
                catch (Exception ex)
                {
                    //Console.WriteLine("Error: " + ex.Message);
                    isFound = false;
                }
                finally
                {
                    connection.Close();
                }

                return isFound;
            }

        public static bool GetCountryInfoByName(string country_enName, ref int ID, ref string country_code, ref string country_arName, ref string country_enNationality, ref string country_arNationality )
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Countries WHERE Country_enName = @Country_enName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue( "@Country_enName", country_enName );

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    ID = (int)reader["CountryID"];
                    country_code = ( string ) reader[ "Country_code" ];
                    country_arName = ( string ) reader[ "Country_arName" ];
                    country_enNationality = ( string ) reader[ "Country_enNationality" ];
                    country_arNationality = ( string ) reader[ "Country_arNationality" ];

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static DataTable GetAllCountries()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Countries order by Country_arName";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

    }
}
