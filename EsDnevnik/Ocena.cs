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
    public partial class Ocena : Form
    {
        DataTable dt_Ocena;
        public Ocena()
        {
            InitializeComponent();
        }

        private void Ocena_Load(object sender, EventArgs e)
        {
            cb_GodinaPopulate();
            cb_Predmet.Enabled = false;
            cb_Odeljenje.Enabled = false;
            cb_Ucenik.Enabled = false;
            cb_Ocena.Items.Add(1);
            cb_Ocena.Items.Add(2);
            cb_Ocena.Items.Add(3);
            cb_Ocena.Items.Add(4);
            cb_Ocena.Items.Add(5);
            // cb_Ocena.Enabled = false;
            cb_ProfesorPopulate();
            cb_Profesor.SelectedValue = -1;
        }

        private void cb_GodinaPopulate()
        {
            SqlConnection veza = Connect.connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM skolska_godina", veza);
            DataTable dt_Godina = new DataTable();
            adapter.Fill(dt_Godina);
            cb_Godina.DataSource =dt_Godina;
            cb_Godina.ValueMember = "id";
            cb_Godina.DisplayMember = "naziv";
            cb_Godina.SelectedValue = 2;
        }

        private void cb_Godina_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_Godina.IsHandleCreated && cb_Godina.Focused)
            {
                cb_ProfesorPopulate();
                cb_Profesor.SelectedValue = -1;
                cb_Profesor.Enabled = true;

                cb_Predmet.SelectedIndex = -1;
                cb_Predmet.Enabled = false;

                cb_Odeljenje.SelectedValue = -1;
                cb_Odeljenje.Enabled = false;

                cb_Ucenik.SelectedValue = -1;
                cb_Ucenik.Enabled = false;

                cb_Odeljenje.SelectedValue = -1;
                cb_Odeljenje.Enabled = false;

                cb_Ocena.SelectedValue = -1;
                cb_Ocena.Enabled = false;

                dt_Ocena = new DataTable();
                Grid_Ocena.DataSource = dt_Ocena;
            }
        }

        private void cb_ProfesorPopulate()
        {
            StringBuilder naredba = new StringBuilder("SELECT DISTINCT osoba.id AS id, ime + ' ' + prezime AS naziv FROM osoba");
            naredba.Append(" JOIN raspodela ON osoba.id = raspodela.nastavnik_id");
            naredba.Append(" WHERE godina_id = " + cb_Godina.SelectedValue.ToString());
            //txt_Provera.Text = naredba.ToString();
            SqlConnection veza = Connect.connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_Profesor = new DataTable();
            adapter.Fill(dt_Profesor);
            cb_Profesor.DataSource = dt_Profesor;
            cb_Profesor.ValueMember = "id";
            cb_Profesor.DisplayMember = "naziv";
        }

        private void cb_Profesor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_Profesor.IsHandleCreated && cb_Profesor.Focused)
            {
                cb_PredmetPopulate();
                cb_Predmet.SelectedIndex = -1;
                cb_Predmet.Enabled = true;

                cb_Odeljenje.SelectedValue = -1;
                cb_Odeljenje.Enabled = false;

                cb_Ucenik.SelectedValue = -1;
                cb_Ucenik.Enabled = false;

                cb_Ocena.SelectedValue = -1;
                cb_Ocena.Enabled = false;

                dt_Ocena = new DataTable();
                Grid_Ocena.DataSource = dt_Ocena;
            }
        }

        private void cb_PredmetPopulate()
        {
            StringBuilder naredba = new StringBuilder("SELECT DISTINCT predmet.id AS id, naziv FROM predmet");
            naredba.Append(" JOIN raspodela ON predmet.id = raspodela.predmet_id");
            naredba.Append(" WHERE godina_id = " + cb_Godina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + cb_Profesor.SelectedValue.ToString());
            //txt_Provera.Text = naredba.ToString();
            SqlConnection veza = Connect.connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_Predmet = new DataTable();
            adapter.Fill(dt_Predmet);
            cb_Predmet.DataSource = dt_Predmet;
            cb_Predmet.ValueMember = "id";
            cb_Predmet.DisplayMember = "naziv";
        }

        private void cb_Predmet_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_Predmet.IsHandleCreated && cb_Predmet.Focused)
            {
                cb_OdeljenjePopulate();
                cb_Odeljenje.SelectedIndex = -1;
                cb_Odeljenje.Enabled = true;

                cb_Ucenik.SelectedValue = -1;
                cb_Ucenik.Enabled = false;

                cb_Ocena.SelectedValue = -1;
                cb_Ocena.Enabled = false;

                dt_Ocena = new DataTable();
                Grid_Ocena.DataSource = dt_Ocena;
            }
        }

        private void cb_OdeljenjePopulate()
        {
            StringBuilder naredba = new StringBuilder("SELECT DISTINCT odeljenje.id AS id, STR(razred) + '-' + indeks AS naziv FROM odeljenje");
            naredba.Append(" JOIN raspodela ON odeljenje.id = raspodela.odeljenje_id");
            naredba.Append(" WHERE raspodela.godina_id = " + cb_Godina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + cb_Profesor.SelectedValue.ToString());
            naredba.Append(" AND predmet_id = " + cb_Predmet.SelectedValue.ToString());
            //txt_Provera.Text = naredba.ToString();
            SqlConnection veza = Connect.connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_Odeljenje = new DataTable();
            adapter.Fill(dt_Odeljenje);
            cb_Odeljenje.DataSource = dt_Odeljenje;
            cb_Odeljenje.ValueMember = "id";
            cb_Odeljenje.DisplayMember = "naziv";
        }

        private void cb_Odeljenje_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_Odeljenje.IsHandleCreated && cb_Odeljenje.Focused)
            {
                cb_UcenikPopulate();
                cb_Ucenik.Enabled = true;

                cb_Ocena.Enabled = true;

                GridPopulate();
                UcenikOcenaIdSet(0);
            }
        }

        private void cb_UcenikPopulate()
        {
            StringBuilder naredba = new StringBuilder("SELECT osoba.id AS id, ime + ' ' + prezime AS naziv FROM osoba");
            naredba.Append(" JOIN upisnica ON osoba.id = upisnica.osoba_id");
            naredba.Append(" WHERE upisnica.odeljenje_id = " + cb_Odeljenje.SelectedValue.ToString());
            //txt_Provera.Text = naredba.ToString();
            SqlConnection veza = Connect.connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_Ucenik = new DataTable();
            adapter.Fill(dt_Ucenik);
            cb_Ucenik.DataSource = dt_Ucenik;
            cb_Ucenik.ValueMember = "id";
            cb_Ucenik.DisplayMember = "naziv";
        }

        private void GridPopulate()
        {
            StringBuilder naredba = new StringBuilder("SELECT ocena.id AS id, ime + ' ' + prezime AS naziv, ucenik_id, ocena, datum FROM osoba");
            naredba.Append(" JOIN ocena ON osoba.id = ocena.ucenik_id");
            naredba.Append(" JOIN raspodela ON ocena.raspodela_id = raspodela.id");
            naredba.Append(" WHERE raspodela_id = ");
            naredba.Append(" (SELECT id FROM raspodela");
            naredba.Append(" WHERE godina_id = " + cb_Godina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + cb_Profesor.SelectedValue.ToString());
            naredba.Append(" AND predmet_id = " + cb_Predmet.SelectedValue.ToString());
            naredba.Append(" AND odeljenje_id = " + cb_Odeljenje.SelectedValue.ToString() + ")");
            //txt_Provera.Text = naredba.ToString();
            SqlConnection veza = Connect.connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            dt_Ocena = new DataTable();
            adapter.Fill(dt_Ocena);
            Grid_Ocena.DataSource = dt_Ocena;
            Grid_Ocena.AllowUserToAddRows = false;
            Grid_Ocena.Columns["ucenik_id"].Visible = false;
        }

        private void Grid_Ocena_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                UcenikOcenaIdSet(e.RowIndex);
            }
        }

        private void UcenikOcenaIdSet(int index)
        {
            cb_Ucenik.SelectedValue = dt_Ocena.Rows[index]["ucenik_id"];
            cb_Ocena.SelectedItem = dt_Ocena.Rows[index]["ocena"];
            txt_ID.Text = dt_Ocena.Rows[index]["id"].ToString();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("SELECT id FROM raspodela");
            naredba.Append(" WHERE godina_id = " + cb_Godina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + cb_Profesor.SelectedValue.ToString());
            naredba.Append(" AND predmet_id = " + cb_Predmet.SelectedValue.ToString());
            naredba.Append(" AND odeljenje_id = " + cb_Odeljenje.SelectedValue.ToString());
            SqlConnection veza = Connect.connect();
            SqlCommand Komanda = new SqlCommand(naredba.ToString(), veza);
            int id_raspodele = 0;
            try
            {
                veza.Open();
                id_raspodele = (int) Komanda.ExecuteScalar();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            if (id_raspodele > 0)
            {
                naredba = new StringBuilder("INSERT INTO ocena (datum, raspodela_id, ucenik_id, ocena) VALUES('");
                DateTime Datum = datum.Value;
                naredba.Append(Datum.ToString("yyyy-MM-dd") + "', '");
                naredba.Append(id_raspodele + "', '");
                naredba.Append(cb_Ucenik.SelectedValue.ToString() + "', '");
                naredba.Append(cb_Ocena.SelectedItem.ToString() + "')");
                Komanda = new SqlCommand(naredba.ToString(), veza);
                try
                {
                    veza.Open();
                    Komanda.ExecuteNonQuery();
                    veza.Close();
                }
                catch (Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                }
            }
            GridPopulate();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txt_ID.Text) > 0)
            {
                DateTime Datum = datum.Value;
                StringBuilder naredba = new StringBuilder("UPDATE ocena SET ");
                naredba.Append(" ucenik_id = '" + cb_Ucenik.SelectedValue.ToString() + "',");
                naredba.Append(" ocena = '" + cb_Ocena.SelectedItem.ToString() + "',");
                naredba.Append(" datum = '" + Datum.ToString("yyyy-MM-dd") + "'");
                naredba.Append(" WHERE id = " + txt_ID.Text);
                SqlConnection veza = Connect.connect();
                SqlCommand Komanda = new SqlCommand(naredba.ToString(), veza);
                try
                {
                    veza.Open();
                    Komanda.ExecuteNonQuery();
                    veza.Close();
                    GridPopulate();
                }
                catch (Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_ID.Text) > 0)
            {
                string naredba = "DELETE FROM ocena WHERE id = " + txt_ID.Text;
                SqlConnection veza = Connect.connect();
                SqlCommand Komanda = new SqlCommand(naredba, veza);
                try
                {
                    veza.Open();
                    Komanda.ExecuteNonQuery();
                    veza.Close();
                    GridPopulate();
                    UcenikOcenaIdSet(0);
                }
                catch (Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                }
            }
        }
    }
}
