using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Buisness
{
    public class clsCountry
    {

        public int ID { set; get; }
        public string Country_code { set; get; }
        public string Country_enName { set; get; }
        public string Country_arName { set; get; }
        public string Country_enNationality { set; get; }
        public string Country_arNationality { set; get; }
   
        public clsCountry()

        {
            this.ID = -1;
            this.Country_code = "";
            this.Country_enName = "";
            this.Country_arName = "";
            this.Country_enNationality = "";
            this.Country_arNationality = "";

        }

        private clsCountry(int ID, string country_code, string country_enName, string country_arName, string country_enNationality, string country_arNationality )

        {
            this.ID = ID;
            this.Country_code = country_code;
            this.Country_enName = country_enName;
            this.Country_arName = country_arName;
            this.Country_enNationality = country_enNationality;
            this.Country_arNationality = country_arNationality;
        }

        public static clsCountry Find(int ID)
        {
            string country_code = "", country_enName="",country_arName="",country_enNationality="",country_arNationality="";

            if (clsCountryData.GetCountryInfoByID(ID, ref country_code ,ref country_enName , ref country_arName,ref country_enNationality, ref country_arNationality ) )

                return new clsCountry(  ID,  country_code,  country_enName,  country_arName,  country_enNationality,  country_arNationality );
            else
                return null;

        }

        public static clsCountry Find(string country_enName )
        {

            int ID = -1;
            string country_code = "", country_arName = "", country_enNationality = "", country_arNationality = "";


            if (clsCountryData.GetCountryInfoByName( country_enName, ref ID, ref country_code, ref country_arName, ref country_enNationality, ref country_arNationality ) )

                return new clsCountry( ID, country_code, country_enName, country_arName, country_enNationality, country_arNationality );
            else
                return null;

        }

        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();

        }

    }
}
