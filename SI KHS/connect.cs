using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SI_KHS
{
    class DBConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DBConnection()
        {
            Initialize();
        }

        private void Initialize()//MEMBUAT PROPERTI DARI KONEKSI DATABASE
        {
            server = "localhost";
            database = "netbaru";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        //=============================================================================================================

        public void Update(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void Delete(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void Insert(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public List<string>[] selectlaporan(string query)
        {
            List<string>[] list = new List<string>[1];
            list[0] = new List<string>();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["nrp"] + "");
                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }
        //=============KELAS===============
        public List<string>[] SelectKelas(string query)
        {
            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["idkls"] + "");
                    list[1].Add(dataReader["Namakls"] + "");
                    list[2].Add(dataReader["ID_mk"] + "");
                    list[3].Add(dataReader["nip"] + "");
                    list[4].Add(dataReader["Tahun"] + "");
                    list[5].Add(dataReader["Peserta"] + "");
                }

                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }
        }

        //==========================================================
        //===================MATAKULIAH=============================
        public List<string>[] SelectMatkul(string query)
        {
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["ID_mk"] + "");
                    list[1].Add(dataReader["Namamk"] + "");
                    list[2].Add(dataReader["SKS"] + "");
                }

                dataReader.Close();
                this.CloseConnection();
                return list;
            }

            else
            {
                return list;
            }
        }

        //=================================================================
        //=====================DOSEN=======================================
        public List<string>[] SelectDosen(string query)
        {
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["NIP"] + "");
                    list[1].Add(dataReader["Namadsn"] + "");
                    list[2].Add(dataReader["Passworddsn"] + "");
                }

                dataReader.Close();
                this.CloseConnection();
                return list;
            }

            else
            {
                return list;
            }
        }


        //=================================================================
        //======================MAHASISWA=================================
        public List<string>[] SelectMahasiswa(string query)
        {
            List<string>[] list = new List<string>[6];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["nrp"] + "");
                    list[1].Add(dataReader["Namamhs"] + "");
                    list[2].Add(dataReader["Semester"] + "");
                    list[3].Add(dataReader["SKS"] + "");
                    list[4].Add(dataReader["IPK"] + "");
                    list[5].Add(dataReader["Passwordmhs"] + "");
                }

                dataReader.Close();
                this.CloseConnection();
                return list;
            }

            else
            {
                return list;
            }
        }

        //===================================================================
        public List<string>[] Selectkhs(string query)
        {
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["namamk"] + "");
                    list[1].Add(dataReader["semesterambil"] + "");
                    list[2].Add(dataReader["nilai"] + "");
                }

                dataReader.Close();
                this.CloseConnection();
                return list;
            }

            else
            {
                return list;
            }
        }

        public List<string>[] Selectnilai(string query)
        {
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["nrp"] + "");
                    list[1].Add(dataReader["namamhs"] + "");
                    list[2].Add(dataReader["nilai"] + "");
                }

                dataReader.Close();
                this.CloseConnection();
                return list;
            }

            else
            {
                return list;
            }
        }
        public List<string>[] Selectip(string query)
        {
            List<string>[] list = new List<string>[4];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["nrp"] + "");
                    list[1].Add(dataReader["nilai"] + "");
                    list[2].Add(dataReader["sks"] + "");
                    list[3].Add(dataReader["semesterambil"] + "");
                }

                dataReader.Close();
                this.CloseConnection();
                return list;
            }

            else
            {
                return list;
            }
        }
    }
}//BERISI FUNGSI SELECT UNTUK MENGAMBIL DATA DARI DATABASE YANG AKAN DIMASUKKAN KE LIST
