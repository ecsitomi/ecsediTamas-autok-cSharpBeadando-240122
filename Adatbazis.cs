using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using MySql.Data.MySqlClient;

namespace loginForm
{
    internal class Adatbazis
    {
        MySqlCommand command = null;
        MySqlConnection connection = null;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "autok";
            builder.CharacterSet = "utf8";
            connection = new MySqlConnection(builder.ConnectionString);
            try
            {
                nyit();
                command = connection.CreateCommand();
                zar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            
        }

        private void zar()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        private void nyit()
        {
            if (connection.State!=System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public List<Auto> selectAuto() //Adatok lekérése az adatbázisból
        {
            List<Auto> autok = new List<Auto>(); //a lekért adatokat ide mentjuk

            //ez a select utasítás
            command.CommandText = "SELECT * FROM auto";
            nyit();

            using (MySqlDataReader reader = command.ExecuteReader()) //Ez olvassa be és fordítja le az adatbázisból kapott infókat
            {
                while (reader.Read()) //alább a lefordítás
                {
                    string rendszam = reader.GetString("rendszam");
                    string marka = reader.GetString("marka");
                    string modell = reader.GetString("modell");
                    int gyartasiEv = reader.GetInt32("gyartasiev");
                    DateTime forgalmiErvenyesseg = reader.GetDateTime("forgalmiErvenyesseg");
                    int vetelAr = reader.GetInt32("vetelar");
                    int kmAllas = reader.GetInt32("kmallas");
                    int hengerurtartalom = reader.GetInt32("hengerűrtartalom");
                    int tomeg = reader.GetInt32("tomeg");
                    int teljesitmeny = reader.GetInt32("teljesitmeny");

                    Auto auto = new Auto(rendszam, marka, modell, gyartasiEv, forgalmiErvenyesseg, vetelAr, kmAllas, hengerurtartalom, tomeg, teljesitmeny);
                    autok.Add(auto); //mentem a fenti listában
                }
            }
            zar();
            return autok;
        }

        public void insertAuto(Auto auto) //auto feltöltése a listához
        {
            command.CommandText = "INSERT INTO `auto` (`rendszam`, `marka`, `modell`, `gyartasiev`, `forgalmiErvenyesseg`, `vetelar`, `kmallas`, `hengerűrtartalom`, `tomeg`, `teljesitmeny`) " +
                          "VALUES (@rendszam, @marka, @modell, @gyartasiEv, @forgalmiErvenyesseg, @vetelAr, @kmAllas, @hengerurtartalom, @tomeg, @teljesitmeny)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@rendszam", auto.Rendszam);
            command.Parameters.AddWithValue("@marka", auto.Marka);
            command.Parameters.AddWithValue("@modell", auto.Modell);
            command.Parameters.AddWithValue("@gyartasiEv", auto.GyartasiEv);
            command.Parameters.AddWithValue("@forgalmiErvenyesseg", auto.ForgalmiErvenyesseg.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@vetelAr", auto.VetelAr);
            command.Parameters.AddWithValue("@kmAllas", auto.KmAllas);
            command.Parameters.AddWithValue("@hengerurtartalom", auto.Hengerurtartalom);
            command.Parameters.AddWithValue("@tomeg", auto.Tomeg);
            command.Parameters.AddWithValue("@teljesitmeny", auto.Teljesitmeny);

            nyit();
            command.ExecuteNonQuery();
            zar();
        }

        public void updateAuto(Auto auto) //auto módosítása
        {
            command.CommandText = "UPDATE auto SET marka = @marka, modell = @modell, gyartasiev = @gyartasiEv, forgalmiErvenyesseg = @forgalmiErvenyesseg, " +
                      "vetelar = @vetelAr, kmallas = @kmAllas, hengerűrtartalom = @hengerurtartalom, tomeg = @tomeg, teljesitmeny = @teljesitmeny " +
                      "WHERE rendszam = @rendszam";
            //FONTOS - A RENDSZÁM NEM MÓDOSÍTHATÓ
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@marka", auto.Marka);
            command.Parameters.AddWithValue("@modell", auto.Modell);
            command.Parameters.AddWithValue("@gyartasiEv", auto.GyartasiEv);
            command.Parameters.AddWithValue("@forgalmiErvenyesseg", auto.ForgalmiErvenyesseg.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@vetelAr", auto.VetelAr);
            command.Parameters.AddWithValue("@kmAllas", auto.KmAllas);
            command.Parameters.AddWithValue("@hengerurtartalom", auto.Hengerurtartalom);
            command.Parameters.AddWithValue("@tomeg", auto.Tomeg);
            command.Parameters.AddWithValue("@teljesitmeny", auto.Teljesitmeny);
            command.Parameters.AddWithValue("@rendszam", auto.Rendszam);

            nyit();
            command.ExecuteNonQuery();
            zar();
        }
        public void deleteAuto(Auto auto) // auto törlése
        {
            command.CommandText = "DELETE FROM `auto` WHERE `rendszam` = @rendszam";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@rendszam", auto.Rendszam);
            nyit();
            command.ExecuteNonQuery(); 
            zar();
        }
    }
}
