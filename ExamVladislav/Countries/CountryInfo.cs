namespace Countries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class CountryInfo
    {
        public string Country { get; set; }

        public string Capital { get; set; }

        public string PopulationInRange { get; set; }

        public CountryInfo(string country, string capital, string populationInRange)
        {
            this.Country = country;
            this.Capital = capital;
            this.PopulationInRange = populationInRange;
        }

        public override string ToString()
        {
            return string.Format("{0} | {1} | {2}", this.Country, this.Capital, this.PopulationInRange);
        }
    }
}