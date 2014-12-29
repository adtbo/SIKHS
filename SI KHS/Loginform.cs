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
    public partial class Login : Form
    {
        private List<string>[] list;
        private string password;
        DBConnection dbConnection;
        public string datanrp;
        public Login()
        {
            InitializeComponent();
            dbConnection = new DBConnection();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if(this.previl.Text == "Admin"){

                if (this.loginidbox.Text == "admin")
                {
                    if (this.loginpassbox.Text == "admin")
                    {
                        System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(Threadadmin));
                        t.Start();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Your Username / Password Incorrect");
                }
            }
            else if(previl.Text == "Dosen")
            {
                string query = "Select * from dosen where nip='"+this.loginidbox.Text+"'";
                list = dbConnection.SelectDosen(query);

                for (int i = 0; i < list[0].Count; i++)
                {
                    password = list[2][i];
                }
                if (this.loginpassbox.Text == password)
                {
                    dsnform ida = new dsnform(loginidbox.Text);
                    ida.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Your Username / Password Incorrect");
            }
            else if (this.previl.Text == "Mahasiswa")
            {
                string query = "Select * from mahasiswa where nrp='" + this.loginidbox.Text + "'";
                string id = this.loginidbox.Text;
                list = dbConnection.SelectMahasiswa(query);
                for (int i = 0; i < list[0].Count; i++)
                {
                    password = list[5][i];
                }
                if (this.loginpassbox.Text == password)
                {
                    mhsform ida = new mhsform(this.loginidbox.Text);
                    ida.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Your Username / Password Incorrect");
            }
        }

        public static void Threadadmin()
        {
            Application.Run(new Adminform());
        }        
    }
}
