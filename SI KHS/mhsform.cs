using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SI_KHS
{
    public partial class mhsform : Form
    {
        private List<string>[] list;
        private string query;
        DBConnection dbConnection;
        int count;
        string max;
        int sks;
        int plus;
        double[] array;
        double divide;
        double ip;
        public mhsform(string log){
            dbConnection = new DBConnection();
            InitializeComponent();
            label1.Text = log;
            sethome();
            fillcombokhs();
            fillcombokls();
        }
        public string id { get; set; }
        public void sethome()
        {
            query = "SELECT * FROM mahasiswa where nrp='"+label1.Text+"'";
            list = dbConnection.SelectMahasiswa(query);
            for (int i = 0; i < list[0].Count; i++)
            {
                label2.Text = list[1][i];
                label3.Text = list[4][i];
            }
            
        }

        private void listtabelkhs()
        {
            query = "SELECT matakuliah.namamk,laporan.semesterambil,laporan.nilai FROM laporan,kelas,matakuliah where laporan.nrp='" + label1.Text + "' AND laporan.idkls=kelas.idkls AND kelas.id_mk=matakuliah.id_mk";
            list = dbConnection.Selectkhs(query);
            listkhs.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = listkhs.Rows.Add();
                listkhs.Rows[number].Cells[0].Value = list[0][i];
                listkhs.Rows[number].Cells[1].Value = list[1][i];
                listkhs.Rows[number].Cells[2].Value = list[2][i];
            }
        }

        private void listtabelkhs1(string sem)
        {
            query = "SELECT matakuliah.namamk,laporan.semesterambil,laporan.nilai FROM laporan,kelas,matakuliah where laporan.nrp='" + label1.Text + "' AND laporan.idkls=kelas.idkls AND kelas.id_mk=matakuliah.id_mk AND laporan.semesterambil='"+sem+"'";
            list = dbConnection.Selectkhs(query);
            listkhs.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = listkhs.Rows.Add();
                listkhs.Rows[number].Cells[0].Value = list[0][i];
                listkhs.Rows[number].Cells[1].Value = list[1][i];
                listkhs.Rows[number].Cells[2].Value = list[2][i];
            }
        }
        void fillcombokhs()
        {
            query = "SELECT * FROM mahasiswa where nrp='"+label1.Text+"'";
            list = dbConnection.SelectMahasiswa(query);
            combosem.Items.Clear();
            combosem.Items.Add("All");
            for (int i = 0; i < list[0].Count; i++)
            {
                for (int count = 1; count <= Convert.ToInt64(list[2][i]);count++)
                {
                    combosem.Items.Add(count);
                }
            }
        }

        private void combosem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combosem.Text == "All")
            {
                listtabelkhs();
            }
            else
            {
                listtabelkhs1(combosem.Text);
                divide = 0;
                query = "Select laporan.nrp,laporan.nilai,matakuliah.sks,laporan.semesterambil From Laporan,kelas,matakuliah Where laporan.semesterambil='"+combosem.Text+"' AND laporan.nrp='"+label1.Text+"' AND laporan.idkls=kelas.idkls AND kelas.id_mk=matakuliah.id_mk";
                list = dbConnection.Selectip(query);
                array = new double[list[0].Count];
                for (int i = 0; i < list[0].Count; i++)
                {
                    if (list[1][i] == "A") {
                        array[i] = 4 * Convert.ToDouble(list[2][i]);
                    }
                    else if (list[1][i] == "AB")
                    {
                        array[i] = 3.5 * Convert.ToDouble (list[2][i]);
                    }
                    else if (list[1][i] == "B")
                    {
                        array[i] = 3 * Convert.ToDouble(list[2][i]);
                    }
                    else if (list[1][i] == "BC")
                    {
                        array[i] = 2.5 * Convert.ToDouble(list[2][i]);
                    }
                    else if (list[1][i] == "C")
                    {
                        array[i] = 2 * Convert.ToDouble(list[2][i]);
                    }
                    else if (list[1][i] == "D")
                    {
                        array[i] = 1 * Convert.ToDouble(list[2][i]);
                    }
                    else if (list[1][i] == "E")
                    {
                        array[i] = 0;
                    }
                    else
                    {
                        array[i] = 0;
                    }
                    divide = divide + Convert.ToDouble(list[2][i]);
                }
                ip=array.Sum()/divide;
                label7.Text = (ip).ToString();
            }
        }

        void fillcombokls()
        {
            query = "SELECT * FROM matakuliah";
            list = dbConnection.SelectMatkul(query);
            combokls.Items.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                combokls.Items.Add(list[1][i]);
            }
        }
        private void combokls_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM kelas where id_mk=(Select id_mk from matakuliah where namamk='"+combokls.Text+"')";
            list = dbConnection.SelectKelas(query);
            comboidkls.Items.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                comboidkls.Items.Add(list[0][i]);
            }
        }
        private void comboidkls_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM kelas where idkls='"+comboidkls.Text + "'";
            list = dbConnection.SelectKelas(query);
            for (int i = 0; i < list[0].Count; i++)
            {
                jumlahmhslabel.Text=list[5][i];
            }
            query = "SELECT * FROM dosen where nip=(Select nip from kelas where idkls='" + comboidkls.Text + "')";
            list = dbConnection.SelectDosen(query);
            for (int i = 0; i < list[0].Count; i++)
            {
                Namadsnlabel.Text = list[1][i];
            }      
        }

        private void ambilbutton_Click(object sender, EventArgs e)
        {
            query = "SELECT * from laporan where idkls='"+comboidkls.Text+"'";
            list=dbConnection.selectlaporan(query);
                count = list[0].Count;
            query="SELECT * from kelas where idkls='"+comboidkls.Text+"'";
            list=dbConnection.SelectKelas(query);
            for (int i = 0; i < list[0].Count; i++)
            {
                max = list[5][i];
            }

            if (Convert.ToInt32(count) == Convert.ToInt32(max)){
                MessageBox.Show("Kelas Penuh");
            }
            else
            {
                query = "INSERT INTO laporan(nrp,idkls,semesterambil) Values ('" + label1.Text + "','" + comboidkls.Text + "',(SELECT semester FROM mahasiswa where nrp='" + label1.Text + "'))";
                dbConnection.Insert(query);

                query = "SELECT * from mahasiswa where nrp='" + label1.Text + "'";
                list = dbConnection.SelectMahasiswa(query);
                for (int i = 0; i < list[0].Count; i++)
                {
                    sks = Convert.ToInt32(list[3][i]);
                }

                query = "SELECT * from matakuliah where id_mk=(SELECT id_mk FROM kelas where idkls='" + comboidkls.Text + "')";
                list = dbConnection.SelectMatkul(query);
                for (int i = 0; i < list[0].Count; i++)
                {
                    plus = Convert.ToInt32(list[2][i]);
                }

                sks = sks + plus;

                query = "UPDATE mahasiswa set SKS='" + sks + "' where nrp='"+label1.Text+"'";
                dbConnection.Update(query);

                MessageBox.Show("Kelas sudah terambil");
            }
        }

        private void KHS_Click(object sender, EventArgs e)
        {

        }

    }
}
