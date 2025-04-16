using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul8_103022300066
{


    class BankTransferConfig
    {
        public config konfig;

        public string filePath = @"C:\\Users\\user\\Documents\\BankTransferConfig.json";

        public string transaksi { get; set; }
        public int saldo { get; set; }
        public int admin { get; set; }
        public int transfer { get; set; }
        public string bank { get; set; }
        public confirmation bahasa { get; set; }

        public void ReadConfigFile()
        {
            String configJsonData = File.ReadAllText(filePath);
            konfig = JsonSerializer.Deserialize<config>(configJsonData);
        }
    }

    class config
    {
        public string transaksi { get; set; }
        public int saldo { get; set; }
        public int admin { get; set; }
        public int transfer { get; set; }
        public string bank { get; set; }
        public confirmation bahasa { get; set; }
        public config(string transaksi, int saldo, int admin, int transfer, string bank, confirmation bahasa)
        {
            this.transaksi = transaksi;
            this.saldo = saldo;
            this.admin = admin;
            this.transfer = transfer;
            this.bank = bank;
            this.bahasa = bahasa;
        }
    }
    class confirmation
    {
        public string en { get; set; }
        public string id { get; set; }

        public confirmation(string en, string id)
        {
            this.en = en;
            this.id = id;
        }
        class transfer
        {
            public string threshold { get; set; }
            public string low_fee { get; set; }
            public string high_fee { get; set; }

            public transfer(string threshold, string low_fee, string high_fee)
            {
                this.threshold = threshold;
                this.low_fee = low_fee;
                this.high_fee = high_fee;
            }

            class transaksi
            {
                public string transfer { get; set; }
                public string saldo { get; set; }
                public string admin { get; set; }
                public string bank { get; set; }
                public transaksi(string transfer, string saldo, string admin, string bank)
                {
                    this.transfer = transfer;
                    this.saldo = saldo;
                    this.admin = admin;
                    this.bank = bank;
                }

                if(config.saldo < threshold){
                    Console.WriteLine("Saldo anda kurang dari " + threshold);
                }
                else if(config.saldo > threshold && config.saldo<low_fee){
                    Console.WriteLine("Biaya admin anda adalah " + low_fee);
                }
                else if(config.saldo > low_fee && config.saldo<high_fee){
                    Console.WriteLine("Biaya admin anda adalah " + high_fee);
                }
                else{
                    Console.WriteLine("Biaya admin anda adalah " + high_fee);
            }
        }

    }
}