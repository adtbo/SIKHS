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
    public partial class dsnform : Form
    {
        private List<string>[] list;
        private string query;
        DBConnection dbConnection;
        double[] array;
        double divide;
        double ip;
        public dsnform(string logg)
        {
            InitializeComponent();
            niplabel.Text = logg;
            dbConnection = new DBConnection();
            fillcombotahun();
            sethome();
        }
        public string id { get; set; }
        public void sethome()
        {
            query = "SELECT * FROM dosen where nip='" + niplabel.Text + "'";
            list = dbConnection.SelectDosen(query);
            for (int i = 0; i < list[0].Count; i++)
            {
                namalabel.Text = list[1][i];
            }
        }
        void fillcombotahun()
        {
            comtahun.Items.Clear();
            for (int i = 2012; i < 2016; i++)
            {
                comtahun.Items.Add(i);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM kelas where tahun='" + comtahun.Text + "' AND nip='" + niplabel.Text + "'";
            list = dbConnection.SelectKelas(query);
            kelascom.Items.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                kelascom.Items.Add(list[0][i]);
            }
            /*query = "SELECT * FROM matakuliah where id_mk=(SELECT id_mk from kelas where nip='" + niplabel.Text + "' AND tahun = '"+comtahun.Text+"')";
            list = dbConnection.SelectMatkul(query);
            matakuliahcom.Items.Clear();
            for (int i = 0; i < list[1].Count; i++)
            {
                matakuliahcom.Items.Add(list[1][i]);
            }*/
        }
        
        void fillcombomk()
        {
            
        }

        private void matakuliahcom_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void kelascom_SelectedIndexChanged(object sender, EventArgs e)
        {
            listtabel();
        }

        private void listtabel()
        {
            query = "SELECT mahasiswa.nrp, mahasiswa.namamhs,laporan.nilai FROM matakuliah, mahasiswa,laporan,kelas,Dosen where mahasiswa.nrp=laporan.nrp AND kelas.idkls=laporan.idkls AND dosen.nip=kelas.nip AND matakuliah.id_mk=kelas.id_mk AND dosen.nip='"+niplabel.Text+"' AND kelas.idkls='"+kelascom.Text+"'";
            list = dbConnection.Selectnilai(query);
            tabelnilailist.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = tabelnilailist.Rows.Add();
                tabelnilailist.Rows[number].Cells[0].Value = list[0][i];
                tabelnilailist.Rows[number].Cells[1].Value = list[1][i];
                tabelnilailist.Rows[number].Cells[2].Value = list[2][i];
            }
        }

        private void tabelnilailist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.tabelnilailist.Rows[e.RowIndex];
                nrpmhslabel.Text = row.Cells["nrp"].Value.ToString();
                namamhslabel.Text = row.Cells["namamhs"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            query = "UPDATE laporan SET nilai = '"+nilaicom.Text+"' where nrp='"+nrpmhslabel.Text+"' AND idkls='"+kelascom.Text+"'";
            dbConnection.Update(query);
            listtabel();

            divide = 0;
            query = "Select laporan.nrp,laporan.nilai,matakuliah.sks,laporan.semesterambil From Laporan,kelas,matakuliah Where laporan.nrp='" + nrpmhslabel.Text + "' AND laporan.idkls=kelas.idkls AND kelas.id_mk=matakuliah.id_mk";
            list = dbConnection.Selectip(query);
            array = new double[list[0].Count];
            for (int i = 0; i < list[0].Count; i++)
            {
                if (list[1][i] == "A")
                {
                    array[i] = 4 * Convert.ToDouble(list[2][i]);
                }
                else if (list[1][i] == "AB")
                {
                    array[i] = 3.5 * Convert.ToDouble(list[2][i]);
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
            ip = array.Sum() / divide;

            query = "UPDATE mahasiswa SET IPK = '" + ip + "' where nrp='" + nrpmhslabel.Text + "'";
            dbConnection.Update(query);
        }

        
    }
}
