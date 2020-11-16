using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using JubicApiChallenge_Core.Models;
using MySql.Data;

namespace JubicApiChallenge_Core
{
    public class LicenseContext
    {
        public string ConnectionString { get; set; }

        public LicenseContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<License> GetAllLicenses()
        {
            List<License> list = new List<License>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM LicenseInfo", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new License()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Name = reader["name"].ToString(),
                            QueriedAt = DateTime.Now.ToString(),
                            ExpiresAt = reader["expiresAt"].ToString()
                        });
                    }
                }
            }
            return list;
        }
    }
}