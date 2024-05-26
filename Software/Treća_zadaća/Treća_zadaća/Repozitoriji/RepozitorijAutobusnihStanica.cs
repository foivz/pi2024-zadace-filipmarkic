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
        public static AutobusnaStanica DohvatiAutobusnuStanicu(int id) //pretrazivanje po lokaciji
        {
            AutobusnaStanica autobusnaStanica = null;
            string sql = $"SELECT * FROM AutobusneStanice WHERE Lokacija = {id}";
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
            string sql = $"INSERT INTO AutobusneStanice (ID, Naziv, Lokacija) VALUES ({autobusnaStanica.ID}, '{autobusnaStanica.Naziv}', '{autobusnaStanica.Lokacija}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void AzurirajAutobusnuStanicu(int id, string naziv, string lokacija) //azuriranje po ID-u
        {
            string sql = $"UPDATE AutobusneStanice SET Naziv = '{naziv}', Lokacija = '{lokacija}' WHERE ID = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void ObrisiAutobusnuStanicu(string lokacija)//brisanje po lokaciji
        {
            string sql = $"DELETE FROM AutobusneStanice WHERE Lokacija = '{lokacija}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }



    }
}
