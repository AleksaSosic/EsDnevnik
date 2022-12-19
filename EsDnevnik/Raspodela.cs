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
    public partial class Raspodela : Form
    {
        int broj_sloga = 0;
        DataTable tabela;

        public Raspodela()
        {
            InitializeComponent();
        }

        private void TxtPopulate()
        {
            if (tabela.Rows.Count == 0)
            {
                textBox_id.Text = "";
                comboBox_nastavnik.SelectedValue = 0;
                comboBox_godina.SelectedValue = 0;
                comboBox_predmet.SelectedValue = 0;
                comboBox_odeljenje.SelectedValue = 0;
            }
            else
            {
                textBox_id.Text = tabela.Rows[broj_sloga][0].ToString();
                comboBox_nastavnik.SelectedValue = (int) tabela.Rows[broj_sloga][1];
                comboBox_godina.SelectedValue = (int) tabela.Rows[broj_sloga][2];
                comboBox_predmet.SelectedValue = (int) tabela.Rows[broj_sloga][3];
                comboBox_odeljenje.SelectedValue = (int) tabela.Rows[broj_sloga][4];
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

        private void Raspodela_Load(object sender, EventArgs e)
        {
            tabela = new DataTable();
            SqlConnection veza = Connect.connect();

            DataTable nastavnik = new DataTable();
            string upit = "";
            upit = "SELECT DISTINCT nastavnik_id id, ime + ' ' + prezime punoime FROM osoba ";
            upit = upit + "JOIN raspodela ON osoba.id = raspodela.nastavnik_id";
            SqlDataAdapter nastavnik_citac = new SqlDataAdapter(upit, veza);
            nastavnik_citac.Fill(nastavnik);
            comboBox_nastavnik.DataSource = nastavnik;
            comboBox_nastavnik.ValueMember = "id";
            comboBox_nastavnik.DisplayMember = "punoime";

            DataTable godina = new DataTable();
            upit = "SELECT * FROM skolska_godina";
            SqlDataAdapter godina_citac = new SqlDataAdapter(upit, veza);
            godina_citac.Fill(godina);
            comboBox_godina.DataSource = godina;
            comboBox_godina.ValueMember = "id";
            comboBox_godina.DisplayMember = "naziv";

            DataTable predmet = new DataTable();
            upit = "SELECT naziv + ' ' + convert(nvarchar, razred) punoime, id FROM predmet";
            SqlDataAdapter predmet_citac = new SqlDataAdapter(upit, veza);
            predmet_citac.Fill(predmet);
            comboBox_predmet.DataSource = predmet;
            comboBox_predmet.ValueMember = "id";
            comboBox_predmet.DisplayMember = "punoime";

            DataTable odeljenje = new DataTable();
            upit = "SELECT id, convert(nvarchar, razred) + '/' +  convert(nvarchar, indeks) punoime FROM odeljenje";
            SqlDataAdapter odeljenje_citac = new SqlDataAdapter(upit, veza);
            odeljenje_citac.Fill(odeljenje);
            comboBox_odeljenje.DataSource = odeljenje;
            comboBox_odeljenje.ValueMember = "id";
            comboBox_odeljenje.DisplayMember = "punoime";

            SqlDataAdapter citac = new SqlDataAdapter("SELECT * FROM raspodela", veza);
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
            string naredba = "UPDATE raspodela SET ";
            naredba = naredba + "nastavnik_id = '" + comboBox_nastavnik.SelectedValue + "', ";
            naredba = naredba + "godina_id = '" + comboBox_godina.SelectedValue + "', ";
            naredba = naredba + "predmet_id = '" + comboBox_predmet.SelectedValue + "', ";
            naredba = naredba + "odeljenje_id = '" + comboBox_odeljenje.SelectedValue + "' ";
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
            SqlDataAdapter citac = new SqlDataAdapter("SELECT * FROM raspodela", veza);
            tabela = new DataTable();
            citac.Fill(tabela);
            TxtPopulate();
            label_poruka.Visible = true;
        }

        private void button_obrisi_Click(object sender, EventArgs e)
        {
            string naredba = "DELETE FROM raspodela WHERE id=" + textBox_id.Text;
            SqlConnection veza = Connect.connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            if (broj_sloga == tabela.Rows.Count - 1) broj_sloga--;
            if (broj_sloga < 0) broj_sloga = 0;
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter citac = new SqlDataAdapter("SELECT * FROM raspodela", veza);
            citac.Fill(tabela);
            TxtPopulate();
            label_poruka.Visible = true;
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            string naredba = "INSERT INTO raspodela VALUES('";
            naredba = naredba + comboBox_nastavnik.SelectedValue + "', '";
            naredba = naredba + comboBox_godina.SelectedValue + "', '";
            naredba = naredba + comboBox_predmet.SelectedValue + "', '";
            naredba = naredba + comboBox_odeljenje.SelectedValue + "')";
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
            SqlDataAdapter citac = new SqlDataAdapter("SELECT * FROM raspodela", veza);
            tabela = new DataTable();
            citac.Fill(tabela);
            TxtPopulate();
            label_poruka.Visible = true;
        }
    }
}
