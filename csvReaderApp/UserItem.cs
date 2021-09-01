using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace csvReaderApp
{
    public class UserItem
    {
        public int Id { get; set; }
        public string Region { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public static List<UserItem> LoadFile(string path)
        {
            List<UserItem> items = new List<UserItem>();

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ","
            };

            using (var reader = new StreamReader(path))
            {
                using (var csv = new CsvReader(reader, config))
                {
                    csv.Read();
                    csv.ReadHeader();
                    while (csv.Read())
                    {
                        var userItem = new UserItem
                        {
                            Id = Convert.ToInt32(csv.GetField("Id")),
                            Region = csv.GetField("Region"),
                            FirstName = csv.GetField("FirstName"),
                            LastName = csv.GetField("LastName"),
                            Phone = csv.GetField("Phone")
                        };

                        items.Add(userItem);
                    }                    
                }
            }

            return items;
        }

        public override string ToString()
        {
            return $"{Id}. Region: {Region} | {FirstName} {LastName} | phone: {Phone} .";
        }
    }
}
