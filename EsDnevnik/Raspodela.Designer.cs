
namespace EsDnevnik
{
    partial class Raspodela
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_id = new System.Windows.Forms.Label();
            this.label_nastavnik = new System.Windows.Forms.Label();
            this.label_godina = new System.Windows.Forms.Label();
            this.label_predmet = new System.Windows.Forms.Label();
            this.label_odeljenje = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.comboBox_nastavnik = new System.Windows.Forms.ComboBox();
            this.comboBox_godina = new System.Windows.Forms.ComboBox();
            this.comboBox_predmet = new System.Windows.Forms.ComboBox();
            this.comboBox_odeljenje = new System.Windows.Forms.ComboBox();
            this.button_prvi = new System.Windows.Forms.Button();
            this.button_prosli = new System.Windows.Forms.Button();
            this.button_sledeci = new System.Windows.Forms.Button();
            this.button_poslednji = new System.Windows.Forms.Button();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.button_obrisi = new System.Windows.Forms.Button();
            this.button_izmeni = new System.Windows.Forms.Button();
            this.label_poruka = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(20, 20);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 13);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID";
            // 
            // label_nastavnik
            // 
            this.label_nastavnik.AutoSize = true;
            this.label_nastavnik.Location = new System.Drawing.Point(20, 50);
            this.label_nastavnik.Name = "label_nastavnik";
            this.label_nastavnik.Size = new System.Drawing.Size(68, 13);
            this.label_nastavnik.TabIndex = 1;
            this.label_nastavnik.Text = "NASTAVNIK";
            // 
            // label_godina
            // 
            this.label_godina.AutoSize = true;
            this.label_godina.Location = new System.Drawing.Point(20, 80);
            this.label_godina.Name = "label_godina";
            this.label_godina.Size = new System.Drawing.Size(49, 13);
            this.label_godina.TabIndex = 2;
            this.label_godina.Text = "GODINA";
            // 
            // label_predmet
            // 
            this.label_predmet.AutoSize = true;
            this.label_predmet.Location = new System.Drawing.Point(20, 110);
            this.label_predmet.Name = "label_predmet";
            this.label_predmet.Size = new System.Drawing.Size(60, 13);
            this.label_predmet.TabIndex = 3;
            this.label_predmet.Text = "PREDMET";
            // 
            // label_odeljenje
            // 
            this.label_odeljenje.AutoSize = true;
            this.label_odeljenje.Location = new System.Drawing.Point(20, 140);
            this.label_odeljenje.Name = "label_odeljenje";
            this.label_odeljenje.Size = new System.Drawing.Size(68, 13);
            this.label_odeljenje.TabIndex = 4;
            this.label_odeljenje.Text = "ODELJENJE";
            // 
            // textBox_id
            // 
            this.textBox_id.Enabled = false;
            this.textBox_id.Location = new System.Drawing.Point(100, 20);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(120, 20);
            this.textBox_id.TabIndex = 5;
            // 
            // comboBox_nastavnik
            // 
            this.comboBox_nastavnik.FormattingEnabled = true;
            this.comboBox_nastavnik.Location = new System.Drawing.Point(100, 50);
            this.comboBox_nastavnik.Name = "comboBox_nastavnik";
            this.comboBox_nastavnik.Size = new System.Drawing.Size(120, 21);
            this.comboBox_nastavnik.TabIndex = 6;
            // 
            // comboBox_godina
            // 
            this.comboBox_godina.FormattingEnabled = true;
            this.comboBox_godina.Location = new System.Drawing.Point(100, 80);
            this.comboBox_godina.Name = "comboBox_godina";
            this.comboBox_godina.Size = new System.Drawing.Size(120, 21);
            this.comboBox_godina.TabIndex = 7;
            // 
            // comboBox_predmet
            // 
            this.comboBox_predmet.FormattingEnabled = true;
            this.comboBox_predmet.Location = new System.Drawing.Point(100, 110);
            this.comboBox_predmet.Name = "comboBox_predmet";
            this.comboBox_predmet.Size = new System.Drawing.Size(120, 21);
            this.comboBox_predmet.TabIndex = 8;
            // 
            // comboBox_odeljenje
            // 
            this.comboBox_odeljenje.FormattingEnabled = true;
            this.comboBox_odeljenje.Location = new System.Drawing.Point(100, 140);
            this.comboBox_odeljenje.Name = "comboBox_odeljenje";
            this.comboBox_odeljenje.Size = new System.Drawing.Size(120, 21);
            this.comboBox_odeljenje.TabIndex = 9;
            // 
            // button_prvi
            // 
            this.button_prvi.Location = new System.Drawing.Point(20, 180);
            this.button_prvi.Name = "button_prvi";
            this.button_prvi.Size = new System.Drawing.Size(50, 50);
            this.button_prvi.TabIndex = 17;
            this.button_prvi.Text = "<<";
            this.button_prvi.UseVisualStyleBackColor = true;
            this.button_prvi.Click += new System.EventHandler(this.button_prvi_Click);
            // 
            // button_prosli
            // 
            this.button_prosli.Location = new System.Drawing.Point(80, 180);
            this.button_prosli.Name = "button_prosli";
            this.button_prosli.Size = new System.Drawing.Size(50, 50);
            this.button_prosli.TabIndex = 18;
            this.button_prosli.Text = "<";
            this.button_prosli.UseVisualStyleBackColor = true;
            this.button_prosli.Click += new System.EventHandler(this.button_prosli_Click);
            // 
            // button_sledeci
            // 
            this.button_sledeci.Location = new System.Drawing.Point(205, 180);
            this.button_sledeci.Name = "button_sledeci";
            this.button_sledeci.Size = new System.Drawing.Size(50, 50);
            this.button_sledeci.TabIndex = 19;
            this.button_sledeci.Text = ">";
            this.button_sledeci.UseVisualStyleBackColor = true;
            this.button_sledeci.Click += new System.EventHandler(this.button_sledeci_Click);
            // 
            // button_poslednji
            // 
            this.button_poslednji.Location = new System.Drawing.Point(265, 180);
            this.button_poslednji.Name = "button_poslednji";
            this.button_poslednji.Size = new System.Drawing.Size(50, 50);
            this.button_poslednji.TabIndex = 20;
            this.button_poslednji.Text = ">>";
            this.button_poslednji.UseVisualStyleBackColor = true;
            this.button_poslednji.Click += new System.EventHandler(this.button_poslednji_Click);
            // 
            // button_dodaj
            // 
            this.button_dodaj.Location = new System.Drawing.Point(240, 100);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(75, 36);
            this.button_dodaj.TabIndex = 25;
            this.button_dodaj.Text = "DODAJ";
            this.button_dodaj.UseVisualStyleBackColor = true;
            this.button_dodaj.Click += new System.EventHandler(this.button_dodaj_Click);
            // 
            // button_obrisi
            // 
            this.button_obrisi.Location = new System.Drawing.Point(240, 60);
            this.button_obrisi.Name = "button_obrisi";
            this.button_obrisi.Size = new System.Drawing.Size(75, 36);
            this.button_obrisi.TabIndex = 24;
            this.button_obrisi.Text = "OBRISI";
            this.button_obrisi.UseVisualStyleBackColor = true;
            this.button_obrisi.Click += new System.EventHandler(this.button_obrisi_Click);
            // 
            // button_izmeni
            // 
            this.button_izmeni.Location = new System.Drawing.Point(240, 20);
            this.button_izmeni.Name = "button_izmeni";
            this.button_izmeni.Size = new System.Drawing.Size(75, 36);
            this.button_izmeni.TabIndex = 23;
            this.button_izmeni.Text = "IZMENI";
            this.button_izmeni.UseVisualStyleBackColor = true;
            this.button_izmeni.Click += new System.EventHandler(this.button_izmeni_Click);
            // 
            // label_poruka
            // 
            this.label_poruka.AutoSize = true;
            this.label_poruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_poruka.Location = new System.Drawing.Point(240, 146);
            this.label_poruka.Name = "label_poruka";
            this.label_poruka.Size = new System.Drawing.Size(77, 20);
            this.label_poruka.TabIndex = 26;
            this.label_poruka.Text = "Uspesno.";
            // 
            // Raspodela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 241);
            this.Controls.Add(this.label_poruka);
            this.Controls.Add(this.button_dodaj);
            this.Controls.Add(this.button_obrisi);
            this.Controls.Add(this.button_izmeni);
            this.Controls.Add(this.button_poslednji);
            this.Controls.Add(this.button_sledeci);
            this.Controls.Add(this.button_prosli);
            this.Controls.Add(this.button_prvi);
            this.Controls.Add(this.comboBox_odeljenje);
            this.Controls.Add(this.comboBox_predmet);
            this.Controls.Add(this.comboBox_godina);
            this.Controls.Add(this.comboBox_nastavnik);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_odeljenje);
            this.Controls.Add(this.label_predmet);
            this.Controls.Add(this.label_godina);
            this.Controls.Add(this.label_nastavnik);
            this.Controls.Add(this.label_id);
            this.Name = "Raspodela";
            this.Text = "Raspodela";
            this.Load += new System.EventHandler(this.Raspodela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_nastavnik;
        private System.Windows.Forms.Label label_godina;
        private System.Windows.Forms.Label label_predmet;
        private System.Windows.Forms.Label label_odeljenje;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.ComboBox comboBox_nastavnik;
        private System.Windows.Forms.ComboBox comboBox_godina;
        private System.Windows.Forms.ComboBox comboBox_predmet;
        private System.Windows.Forms.ComboBox comboBox_odeljenje;
        private System.Windows.Forms.Button button_prvi;
        private System.Windows.Forms.Button button_prosli;
        private System.Windows.Forms.Button button_sledeci;
        private System.Windows.Forms.Button button_poslednji;
        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.Button button_obrisi;
        private System.Windows.Forms.Button button_izmeni;
        private System.Windows.Forms.Label label_poruka;
    }
}