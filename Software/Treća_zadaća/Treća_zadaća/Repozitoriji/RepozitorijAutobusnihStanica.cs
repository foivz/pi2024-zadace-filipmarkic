using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using Treća_zadaća.Modeli;


namespace Treća_zadaća.Repozitoriji
{
    public class RepozitorijAutobusnihStanica
    {
       

        public RepozitorijAutobusnihStanica()
        {
            
        }
        
        private static AutobusnaStanica CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID"].ToString());
            string naziv = reader["Naziv"].ToString();
            string lokacija = reader["Lokacija"].ToString();

            var autobusnaStanica = new AutobusnaStanica(id, naziv, lokacija)
            {
                ID = id,
                Naziv = naziv.Trim(),
                Lokacija = lokacija.Trim(),
            };

            return autobusnaStanica;
        }

        //beskorisna metoda?? za dohvat pojedine stanice
        public static AutobusnaStanica DohvatiAutobusnuStanicu(string lokacija) //pretrazivanje po lokaciji
        {
            AutobusnaStanica autobusnaStanica = null;
            string sql = $"SELECT * FROM AutobusneStanice WHERE Lokacija = '{lokacija}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                autobusnaStanica = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return autobusnaStanica;
        }

        public static List<AutobusnaStanica> DohvatiAutobusneStanice() //ispis svih autobusnih stanica
        {
            List<AutobusnaStanica> autobusneStanice = new List<AutobusnaStanica>();
            string sqlQuery = "SELECT * FROM AutobusneStanice";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sqlQuery);
            while (reader.Read())
            {
                AutobusnaStanica autobusnaStanica = CreateObject(reader);
                autobusneStanice.Add(autobusnaStanica);
            }
            reader.Close();
            DB.CloseConnection();
            return autobusneStanice;
            
        }

        public static void DodajAutobusnuStanicu(AutobusnaStanica autobusnaStanica) //dodavanje nove autobusne stanice potrebno doraditi
        {
            //dodati provjeru je li ID vec postoji, ako postoji ne dodavati - ID je autoincrement ili ga generirati ili javiti upozorenje
            string sql = $"INSERT INTO AutobusneStanice (ID, Naziv, Lokacija) VALUES ({autobusnaStanica.ID}, '{autobusnaStanica.Naziv}', '{autobusnaStanica.Lokacija}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void AzurirajAutobusnuStanicu(AutobusnaStanica autobusnaStanica) //azuriranje po ID-u, potrebno doraditi
        {
            //dodati provjeru je li ID postoji, tj postoji li stanica koja se zeli azurirati
            string sql = $"UPDATE AutobusneStanice SET Naziv = '{autobusnaStanica.Naziv}', Lokacija = '{autobusnaStanica.Lokacija}' WHERE ID = {autobusnaStanica.ID}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void ObrisiAutobusnuStanicu(string lokacija)//brisanje po lokaciji, dodati provjeru je li Id postoji
        {
            string sql = $"DELETE FROM AutobusneStanice WHERE Lokacija = '{lokacija}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }



    }
}
