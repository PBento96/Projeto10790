using Loja10790.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Loja10790.Model
{
    internal class CountryData : DbContext
    {
        private readonly string _dbFilePath;

        public CountryData()
        {
            _dbFilePath = DataPath.DatabasePath; // Ensure DataPath.DatabasePath is correctly set in your application
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={_dbFilePath};Integrated Security=True");
        }

        public DbSet<CountryModel> t_countries { get; set; }

        public List<string> GetCountryShortNames()
        {
            try
            {
                var countries = t_countries.Select(c => c.short_name).ToList();

                return countries;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<string>();
            }
        }

        public class CountryInfo
        {
            public string Emoji { get; set; }
            public string ShortName { get; set; }
        }

        public List<CountryInfo> GetCountryNamesWithEmoji()
        {
            try
            {
                var countryInfoList = t_countries
                    .Select(c => new CountryInfo { Emoji = c.flag_emoji, ShortName = c.short_name })
                    .ToList();

                return countryInfoList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<CountryInfo>();
            }
        }

    }
}
