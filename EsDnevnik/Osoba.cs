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

namespace EsDnevnik
{
    public partial class Osoba : Form
    {
        int broj_sloga = 0;
        DataTable tabela;

        public Osoba()
        {
            InitializeComponent();
        }

        private void TxtPopulate()
        {
            if (tabela.Rows.Count == 0)
            {
                textBox_id.Text = "";
                textBox_ime.Text = "";
                textBox_prezime.Text = "";
                textBox_adresa.Text = "";
                textBox_jmbg.Text = "";
                textBox_email.Text = "";
                textBox_pass.Text = "";
                textBox_uloga.Text = "";
            }
            else
            {
                textBox_id.Text = tabela.Rows[broj_sloga][0].ToString();
                textBox_ime.Text = tabela.Rows[broj_sloga][1].ToString();
                textBox_prezime.Text = tabela.Rows[broj_sloga][2].ToString();
                textBox_adresa.Text = tabela.Rows[broj_sloga][3].ToString();
                textBox_jmbg.Text = tabela.Rows[broj_sloga][4].ToString();
                textBox_email.Text = tabela.Rows[broj_sloga][5].ToString();
                textBox_pass.Text = tabela.Rows[broj_sloga][6].ToString();
                textBox_uloga.Text = tabela.Rows[broj_sloga][7].ToString();
                if (broj_sloga == tabela.Rows.Count - 1)
                {
                    button_sledeci.Enabled = false;
                    button_poslednji.Enabled = false;
                }
                else
                {
                    button_sledeci.Enabled = true;
                    button_poslednji.Enabled = true;
                }
                if (broj_sloga == 0)
                {
                    button_prosli.Enabled = false;
                    button_prvi.Enabled = false;
                }
                else
                {
                    button_prosli.Enabled = true;
                    button_prvi.Enabled = true;
                }

            }
        }

        private void Osoba_Load(object sender, EventArgs e)
        {
            tabela = new DataTable();
            SqlConnection veza = Connect.connect();
            SqlDataAdapter citac = new SqlDataAdapter("SELECT * FROM osoba", veza);
            citac.Fill(tabela);
            TxtPopulate();
            label_poruka.Visible = false;
        }

        private void button_prvi_Click(object sender, EventArgs e)
        {
            broj_sloga = 0;
            TxtPopulate();
            label_poruka.Visible = false;
        }

        private void button_prosli_Click(object sender, EventArgs e)
        {
            broj_sloga--;
            TxtPopulate();
            label_poruka.Visible = false;
        }

        private void button_sledeci_Click(object sender, EventArgs e)
        {
            broj_sloga++;
            TxtPopulate();
            label_poruka.Visible = false;
        }

        private void button_poslednji_Click(object sender, EventArgs e)
        {
            broj_sloga = tabela.Rows.Count - 1;
            TxtPopulate();
            label_poruka.Visible = false;
        }

        private void button_izmeni_Click(object sender, EventArgs e)
        {
            string naredba = "UPDATE osoba SET ";
            naredba = naredba + "ime = '" + textBox_ime.Text + "', ";
            naredba = naredba + "prezime = '" + textBox_prezime.Text + "', ";
            naredba = naredba + "adresa = '" + textBox_adresa.Text + "', ";
            naredba = naredba + "jmbg = '" + textBox_jmbg.Text + "', ";
            naredba = naredba + "email = '" + textBox_email.Text + "', ";
            naredba = naredba + "pass = '" + textBox_pass.Text + "', ";
            naredba = naredba + "uloga = " + textBox_uloga.Text + " ";
            naredba = naredba + "WHERE id = " + textBox_id.Text;
            SqlConnection veza = Connect.connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception GRESKA)
            {
                MessageBox.Show(GRESKA.Message);
            }
            SqlDataAdapter citac = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela = new DataTable();
            citac.Fill(tabela);
            TxtPopulate();
            label_poruka.Visible = true;
        }

        private void button_obrisi_Click(object sender, EventArgs e)
        {
            string naredba = "DELETE FROM osoba WHERE id=" + textBox_id.Text;
            SqlConnection veza = Connect.connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            if (broj_sloga == tabela.Rows.Count - 1) broj_sloga--;
            if (broj_sloga < 0) broj_sloga = 0;
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter citac = new SqlDataAdapter("SELECT * FROM osoba", veza);
            citac.Fill(tabela);
            TxtPopulate();
            label_poruka.Visible = true;
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            string naredba = "INSERT INTO osoba VALUES('";
            naredba = naredba + textBox_ime.Text + "', '";
            naredba = naredba + textBox_prezime.Text + "', '";
            naredba = naredba + textBox_adresa.Text + "', '";
            naredba = naredba + textBox_jmbg.Text + "', '";
            naredba = naredba + textBox_email.Text + "', '";
            naredba = naredba + textBox_pass.Text + "', ";
            naredba = naredba + textBox_uloga.Text + ")";
            SqlConnection veza = Connect.connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception GRESKA)
            {
                MessageBox.Show(GRESKA.Message);
            }
            SqlDataAdapter citac = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela = new DataTable();
            citac.Fill(tabela);
            TxtPopulate();
            label_poruka.Visible = true;
        }
    }
}
