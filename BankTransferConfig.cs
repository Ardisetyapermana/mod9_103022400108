using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;

namespace Modul9_103022400108
{
    internal class BankTransferConfig
    {
        public Config config { get; set; }
        private string filePath = "bank_transfer_config.json";

        public BankTransferConfig()
        {
            try
            {
                ReadConfigFile();
            }
            catch (Exception)
            {
                SetDefault();
                WriteConfigFile();
            }
        }

        public void ReadConfigFile()
        {
            string hasilbaca = File.ReadAllText(filePath);
            config = JsonSerializer.Deserialize<Config>(hasilbaca);
        }

        public void SetDefault()
        {
            config = new Config
            {
                lang = "en",
                transfer = new Transfer
                {
                    threshold = 25000000,
                    low_fee = 6500,
                    high_fee = 15000,
                    confirmation = new Confirmation
                    {
                        en = "yes",
                        id = "ya"
                    }
                },
                methods = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" },
                confirmation = new Confirmation
                {
                    en = "yes",
                    id = "ya"
                }
            };
        }

        public void WriteConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(config, options);
            File.WriteAllText(filePath, jsonString);
        }
    }
       
}
