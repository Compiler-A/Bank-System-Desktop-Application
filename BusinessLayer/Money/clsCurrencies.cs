using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class clsCurrencies
    {
        public string Country { get; }
        public string Code { get;  }
        public string Name { get; }
        public double Rate { get; set; }


        public clsCurrencies(string country, string code, string name, double rate)
        {
            Country = country;
            Code = code;
            Name = name;
            Rate = rate;
        }

        static public int GetTotalCurrencies()
        {
            return clsDataCurrencies.GetTotalCurrencies();
        }

        static public DataTable GetAllCurrencies()
        {
            return clsDataCurrencies.GetAllCurrencies();
        }

        static public bool ExistCurrencyByCode(string Code)
        {
            return clsDataCurrencies.ExistCurrencyByCode(Code);
        }

        static public bool UpdateCurrencyByCode(string Code, double newRate)
        {
            return clsDataCurrencies.UpdateRateByCode(newRate, Code);
        }

        static public clsCurrencies FindCurrencyByCountryName(string countryName)
        {
            string Name = "", Code = "";
            double Rate = 0;
            if (clsDataCurrencies.FindCurrencybyCountryName(countryName, ref Code, ref Name, ref Rate))
            {
                return new clsCurrencies(countryName, Code, Name, Rate);
            }
            return new clsCurrencies("", Code, Name, Rate);
        }
        static public clsCurrencies FindCurrencyByCode(string Code)
        {
            string Name = "", CountryName = "";
            double Rate = 0;
            if (clsDataCurrencies.FindCurrencybyCode(Code, ref CountryName, ref Name, ref Rate))
            {
                return new clsCurrencies(CountryName, Code, Name, Rate);
            }
            return new clsCurrencies(CountryName, "", Name, Rate);
        }

        double ConvertToUSD(double Amount)
        {
            return (double)(Amount / Rate);
        }

        public double ConvertToOtherCurrency(double Amount, clsCurrencies Currency2)
        {
            double AmountInUSD = ConvertToUSD(Amount);

            if (Currency2.Code == "USD")
            {
                return AmountInUSD;
            }

            return (double)(AmountInUSD * Currency2.Rate);

        }
    }
}
