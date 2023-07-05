using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace _3_project
{
    internal class Class1
    {
        static string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project2";
        static MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
        

        public Class1() { }

        public bool insert(string nom,string kengaytma,double hajm,string text,string adres)
        {
            String query = "Insert into data(Nomi,Kengaytmasi,Hajmi,Data_Text,Data_image) Values ('" + nom + "','" + kengaytma + "'," + hajm + ",'" + text + "','" + adres + "')";
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            command.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while(reader.Read())
                    {

                    }
                }
                else
                MessageBox.Show("Successfull");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query error"+ex.Message);
            }
            return true;
        }

        public bool delete (int id)
        {
            String query = "Delete from data where id="+id;
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            command.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                    }
                }
                else
                    MessageBox.Show("Successfull");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query error" + ex.Message);
            }
            return true;
        }

        public bool update(int id,string nom, string kengaytma, double hajm, string text, string adres)
        {
            String query = "Update data set Nomi='"+nom+"',Kengaytmasi='"+kengaytma+"',Hajmi="+hajm+",Data_Text='"+text+"',Data_image='"+adres+"' where id="+id;
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            command.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                    }
                }
                else
                    MessageBox.Show("Successfull");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query error" + ex.Message);
            }
            return true;
        }


    }
}
