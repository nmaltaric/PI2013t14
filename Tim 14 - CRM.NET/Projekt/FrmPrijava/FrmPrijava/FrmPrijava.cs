using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace FrmPrijava
{
    public partial class FrmPrijava : Form
    {
        public FrmPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            bool login = true;

            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\BazaPI.mdf;Integrated Security=True";

            string selectUpit = "SELECT * FROM Admin";
            //txtLozinka
            //txtKorisnickoIme

            if (txtKorisnickoIme.Text != "" && txtLozinka.Text != "")
            {
                sc.Open();
                using (var command = new SqlCommand(selectUpit, sc))
                {
                    
                   
                    
                    SqlDataReader usernameRdr = null;

                    usernameRdr = command.ExecuteReader();
                    while (usernameRdr.Read())
                    {
                        

                        if (txtKorisnickoIme.Text == usernameRdr["username"].ToString() && txtLozinka.Text == usernameRdr["lozinka"].ToString())
                        {
                            MessageBox.Show("Logiran kao admin: " + usernameRdr["ime"].ToString() + " " + usernameRdr["prezime"].ToString());

                            this.Hide();
                            FrmAdmin frmAdmin = new FrmAdmin();
                            frmAdmin.Show();
                            this.Show();
                        }

                        else
                        {
                            login = false;
                        }
                    }
                    sc.Close();
                }

                if (login == false)
                {
                    SqlConnection sc2 = new SqlConnection();
                    sc2.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\BazaPI.mdf;Integrated Security=True";

                    string selectUpit2 = "SELECT * FROM Korisnik";
                    //txtLozinka
                    //txtKorisnickoIme

                    if (txtKorisnickoIme.Text != "" && txtLozinka.Text != "")
                    {
                        sc2.Open();
                        using (var command2 = new SqlCommand(selectUpit2, sc2))
                        {

                         

                            SqlDataReader usernameRdr2 = null;

                            usernameRdr2 = command2.ExecuteReader();
                            while (usernameRdr2.Read())
                            {
                                //lista.Add();
                                //lista.Add();

                                if (txtKorisnickoIme.Text == usernameRdr2["username"].ToString() && txtLozinka.Text == usernameRdr2["lozinka"].ToString())
                                {
                                    MessageBox.Show("Logiran kao korisnik: " + usernameRdr2["ime"].ToString() + " " + usernameRdr2["prezime"].ToString());
                                    this.Hide();


                                    FrmKorisnik frmKorisnik = new FrmKorisnik();

                                    frmKorisnik.Show();

                                    this.Show();
                                }

                                else
                                {
                                    MessageBox.Show("Krivi podaci");
                                }

                            }

                            sc2.Close();

                        }

                        if (login == false)
                        {
                        }

                    }
                }

            }
      
            else
            {
                MessageBox.Show("Niste unijeli potrebne podatke!");
            }

            
        }
    }
}
