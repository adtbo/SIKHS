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
    public partial class Adminform : Form
    {
        private string query;
        private List<string>[] list;
        DBConnection dbConnection;
        public Adminform()
        {
            dbConnection = new DBConnection();
            InitializeComponent();
            fillcombomk();
            listtabelkelas();
            listtabeldosen();
            listtabelmatkul();
            listtabelmahasiswa();
            fillcombodosen();
        }

        private void listtabelkelas()
        {
            query = "SELECT * FROM kelas";
            list = dbConnection.SelectKelas(query);
            listkelas.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = listkelas.Rows.Add();
                listkelas.Rows[number].Cells[0].Value = list[0][i];
                listkelas.Rows[number].Cells[1].Value = list[1][i];
                listkelas.Rows[number].Cells[2].Value = list[2][i];
                listkelas.Rows[number].Cells[3].Value = list[3][i];
                listkelas.Rows[number].Cells[4].Value = list[4][i];
                listkelas.Rows[number].Cells[5].Value = list[5][i];
            }
        }

        private void listtabeldosen()
        {
            query = "SELECT * FROM dosen";
            list = dbConnection.SelectDosen(query);
            listdosen.Rows.Clear();
            listdosen1.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = listdosen.Rows.Add();
                listdosen.Rows[number].Cells[0].Value = list[0][i];
                listdosen.Rows[number].Cells[1].Value = list[1][i];
                

                number = listdosen1.Rows.Add();
                listdosen1.Rows[number].Cells[0].Value = list[0][i];
                listdosen1.Rows[number].Cells[1].Value = list[1][i];
                listdosen1.Rows[number].Cells[2].Value = list[2][i];
            }
        }

        private void listtabelmatkul()
        {
            query = "SELECT * FROM matakuliah";
            list = dbConnection.SelectMatkul(query);
            listmatakuliah.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = listmatakuliah.Rows.Add();
                listmatakuliah.Rows[number].Cells[0].Value = list[0][i];
                listmatakuliah.Rows[number].Cells[1].Value = list[1][i];
                listmatakuliah.Rows[number].Cells[2].Value = list[2][i];
            }
        }

        private void listtabelmahasiswa()
        {
            query = "SELECT * FROM mahasiswa";
            list = dbConnection.SelectMahasiswa(query);
            listmahasiswa.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = listmahasiswa.Rows.Add();
                listmahasiswa.Rows[number].Cells[0].Value = list[0][i];
                listmahasiswa.Rows[number].Cells[1].Value = list[1][i];
                listmahasiswa.Rows[number].Cells[2].Value = list[2][i];
                listmahasiswa.Rows[number].Cells[3].Value = list[3][i];
                listmahasiswa.Rows[number].Cells[4].Value = list[4][i];
                listmahasiswa.Rows[number].Cells[5].Value = list[5][i];
            }
        }




        //==============TAB KELAS=================

        void fillcombomk()
        {
            query = "SELECT * FROM matakuliah";
            list = dbConnection.SelectMatkul(query);
            comboidmk.Items.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                comboidmk.Items.Add(list[1][i]);
            }
        }

        void fillcombodosen()
        {
            query = "SELECT * FROM dosen";
            list = dbConnection.SelectDosen(query);
            comboNIP.Items.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                comboNIP.Items.Add(list[1][i]);
            }
        }

        
        private void listkelasbutton_Click(object sender, EventArgs e)
        {
            listtabelkelas();
            listtabeldosen();
            fillcombodosen();
            fillcombomk();
        }
       

        private void UpdateKelasbutton_Click(object sender, EventArgs e)
        {
            query = "UPDATE kelas SET namakls='" + this.namakelastext.Text + "', id_mk='" + this.id_mktext.Text + "', nip='" + this.niptext.Text + "', tahun='" + this.tahuntext.Text + "', peserta='" + this.pesertatext.Text + "' WHERE idkls='" + this.idklstext.Text + "'";
            dbConnection.Update(query);
            listtabelkelas();
        }

        private void HapusKelas_Click(object sender, EventArgs e)
        {
            query = "DELETE FROM kelas WHERE idkls='" + this.idklstext.Text + "'";
            dbConnection.Delete(query);
            listtabelkelas();
        }

        private void tambahkelasbutton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO kelas (idkls,namakls,id_mk,nip,tahun,peserta) VALUES ('" + idklsaddtext.Text + "', '" + namaklsaddtext.Text + "',(SELECT id_mk from matakuliah where namamk='" + comboidmk.Text + "'),(SELECT nip from dosen where namadsn='" + comboNIP.Text + "'), '" + tahunaddtext.Text + "','" + pesertaaddtext.Text + "')";
            dbConnection.Insert(query);
            listtabelkelas();
        }
        private void listkelas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.listkelas.Rows[e.RowIndex];
                idklstext.Text = row.Cells["idkls"].Value.ToString();
                namakelastext.Text = row.Cells["namakls"].Value.ToString();
                id_mktext.Text = row.Cells["idmk"].Value.ToString();
                niptext.Text = row.Cells["nipdsnkls"].Value.ToString();
                tahuntext.Text = row.Cells["tahun"].Value.ToString();
                pesertatext.Text = row.Cells["peserta"].Value.ToString();
            }
        }
        //============================================================================================
        //==================================TAB DOSEN==============================================
        private void button1_Click(object sender, EventArgs e)
        {
            listtabeldosen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            query = "Update dosen Set namadsn='" + namadsnbox.Text + "', passworddsn='" + passworddosenbox.Text + "' where nip='"+nipbox.Text+"'";
            dbConnection.Update(query);
            listtabeldosen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            query = "DELETE from dosen where nip='" + nipbox.Text + "'";
            dbConnection.Delete(query);
            listtabeldosen();
        }

        private void tambahdsnbutton_Click(object sender, EventArgs e)
        {
            query = "INSERT into dosen (nip,namadsn,passworddsn) Values ('" + nipaddbox.Text + "','" + namadsnaddbox.Text + "','" + passworddsnaddbox.Text + "')";
            dbConnection.Insert(query);
            listtabeldosen();
        }
        private void listdosen1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.listdosen1.Rows[e.RowIndex];
                nipbox.Text = row.Cells["nip"].Value.ToString();
                namadsnbox.Text = row.Cells["namadsn"].Value.ToString();
                passworddosenbox.Text = row.Cells["passworddsn"].Value.ToString();
            }
        }
        //====================================TAB MATKUL=============================

        private void button4_Click(object sender, EventArgs e)
        {
            listtabelmatkul();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            query = "Update matakuliah Set namamk='" + namamkbox.Text + "', sks='" + sksmkbox.Text + "' where id_mk='" + idmkbox.Text + "'";
            dbConnection.Update(query);
            listtabelmatkul();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            query = "DELETE from matakuliah where id_mk='" + idmkbox.Text + "'";
            dbConnection.Delete(query);
            listtabelmatkul();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            query = "INSERT into matakuliah (id_mk,namamk,sks) Values ('" + idmkaddbox.Text + "','" + namamkaddbox.Text + "','" + sksaddbox.Text + "')";
            dbConnection.Insert(query);
            listtabelmatkul();
        }
        private void listmatakuliah_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.listmatakuliah.Rows[e.RowIndex];
                idmkbox.Text = row.Cells["id_mk"].Value.ToString();
                namamkbox.Text = row.Cells["namamk"].Value.ToString();
                sksmkbox.Text = row.Cells["sksmk"].Value.ToString();
            }
        }
       
        //=============================TAB MAHASISWA===================================
        private void button8_Click(object sender, EventArgs e)
        {
            listtabelmahasiswa();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            query = "update mahasiswa set namamhs='" + namamhsbox.Text + "', semester='" + semesterbox.Text + "', sks='" + skstbox.Text + "', ipk='" + ipk.Text + "', passwordmhs='" + passwordmhsbox.Text + "' where nrp='"+nrpbox.Text+"'";
            dbConnection.Update(query);
            listtabelmahasiswa();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            query = "DELETE from mahasiswa where nrp='" + nrpbox.Text + "'";
            dbConnection.Delete(query);
            listtabelmahasiswa();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            query = "INSERT into mahasiswa (nrp,namamhs,semester,sks,ipk,passwordmhs) values ('"+nrpaddbox.Text+"','"+namamhsaddbox.Text+"','"+semesteraddbox.Text+"','"+skstaddbox.Text+"','"+ipkaddbox+"','"+passwordaddbox.Text+"')";
            dbConnection.Insert(query);
            listtabelmahasiswa();
        }

        private void listmahasiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.listmahasiswa.Rows[e.RowIndex];
                nrpbox.Text = row.Cells["nrp"].Value.ToString();
                namamhsbox.Text = row.Cells["namamhs"].Value.ToString();
                semesterbox.Text = row.Cells["semester"].Value.ToString();
                skstbox.Text = row.Cells["sks"].Value.ToString();
                ipk.Text = row.Cells["ip"].Value.ToString();
                passwordmhsbox.Text = row.Cells["passwordmhs"].Value.ToString();
            }
        }

        
    }
}
