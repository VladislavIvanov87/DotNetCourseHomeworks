namespace Countries
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Web;

    public class Operations
    {
        public const string FilePath = @"C:\Users\Vlado\Desktop\SIPartTwo\Countries.txt";

        public static List<CountryInfo> ReadFromDataBase()
        {
            var listOfCountries = new List<CountryInfo>();
            using (var reader = new StreamReader(Operations.FilePath))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var currentCountry = line.Split('|');
                    var country = new CountryInfo(
                        currentCountry[0].Trim(),
                        currentCountry[1].Trim(),
                        (currentCountry[2].Trim()));
                    listOfCountries.Add(country);
                    line = reader.ReadLine();
                }
            }
            return listOfCountries;
        }

        public static bool AddCountry(CountryInfo countryToAdd)
        {
            try
            {
                using (var writer = new StreamWriter(Operations.FilePath, true))
                {
                    writer.WriteLine(countryToAdd);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}