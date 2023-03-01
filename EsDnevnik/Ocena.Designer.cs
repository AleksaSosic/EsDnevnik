
namespace EsDnevnik
{
    partial class Ocena
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
            this.cb_Godina = new System.Windows.Forms.ComboBox();
            this.cb_Profesor = new System.Windows.Forms.ComboBox();
            this.cb_Predmet = new System.Windows.Forms.ComboBox();
            this.cb_Odeljenje = new System.Windows.Forms.ComboBox();
            this.cb_Ucenik = new System.Windows.Forms.ComboBox();
            this.cb_Ocena = new System.Windows.Forms.ComboBox();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.Grid_Ocena = new System.Windows.Forms.DataGridView();
            this.lbl_Godina = new System.Windows.Forms.Label();
            this.lbl_Profesor = new System.Windows.Forms.Label();
            this.lbl_Predmet = new System.Windows.Forms.Label();
            this.lbl_Odeljenje = new System.Windows.Forms.Label();
            this.lbl_Ucenik = new System.Windows.Forms.Label();
            this.lbl_Ocena = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Datum = new System.Windows.Forms.Label();
            this.txt_Provera = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Ocena)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Godina
            // 
            this.cb_Godina.FormattingEnabled = true;
            this.cb_Godina.Location = new System.Drawing.Point(58, 46);
            this.cb_Godina.Name = "cb_Godina";
            this.cb_Godina.Size = new System.Drawing.Size(121, 21);
            this.cb_Godina.TabIndex = 0;
            this.cb_Godina.SelectedValueChanged += new System.EventHandler(this.cb_Godina_SelectedValueChanged);
            // 
            // cb_Profesor
            // 
            this.cb_Profesor.FormattingEnabled = true;
            this.cb_Profesor.Location = new System.Drawing.Point(185, 46);
            this.cb_Profesor.Name = "cb_Profesor";
            this.cb_Profesor.Size = new System.Drawing.Size(121, 21);
            this.cb_Profesor.TabIndex = 1;
            this.cb_Profesor.SelectedValueChanged += new System.EventHandler(this.cb_Profesor_SelectedValueChanged);
            // 
            // cb_Predmet
            // 
            this.cb_Predmet.FormattingEnabled = true;
            this.cb_Predmet.Location = new System.Drawing.Point(312, 46);
            this.cb_Predmet.Name = "cb_Predmet";
            this.cb_Predmet.Size = new System.Drawing.Size(121, 21);
            this.cb_Predmet.TabIndex = 2;
            this.cb_Predmet.SelectedValueChanged += new System.EventHandler(this.cb_Predmet_SelectedValueChanged);
            // 
            // cb_Odeljenje
            // 
            this.cb_Odeljenje.FormattingEnabled = true;
            this.cb_Odeljenje.Location = new System.Drawing.Point(439, 46);
            this.cb_Odeljenje.Name = "cb_Odeljenje";
            this.cb_Odeljenje.Size = new System.Drawing.Size(121, 21);
            this.cb_Odeljenje.TabIndex = 3;
            this.cb_Odeljenje.SelectedValueChanged += new System.EventHandler(this.cb_Odeljenje_SelectedValueChanged);
            // 
            // cb_Ucenik
            // 
            this.cb_Ucenik.FormattingEnabled = true;
            this.cb_Ucenik.Location = new System.Drawing.Point(58, 114);
            this.cb_Ucenik.Name = "cb_Ucenik";
            this.cb_Ucenik.Size = new System.Drawing.Size(121, 21);
            this.cb_Ucenik.TabIndex = 4;
            // 
            // cb_Ocena
            // 
            this.cb_Ocena.FormattingEnabled = true;
            this.cb_Ocena.Location = new System.Drawing.Point(185, 114);
            this.cb_Ocena.Name = "cb_Ocena";
            this.cb_Ocena.Size = new System.Drawing.Size(121, 21);
            this.cb_Ocena.TabIndex = 5;
            // 
            // datum
            // 
            this.datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datum.Location = new System.Drawing.Point(439, 113);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(121, 20);
            this.datum.TabIndex = 6;
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(312, 113);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(121, 20);
            this.txt_ID.TabIndex = 7;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(582, 46);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 8;
            this.btn_Insert.Text = "Dodaj";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(582, 78);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 9;
            this.btn_Update.Text = "Promeni";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(582, 109);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Izbrisi";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Grid_Ocena
            // 
            this.Grid_Ocena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Ocena.Location = new System.Drawing.Point(58, 201);
            this.Grid_Ocena.Name = "Grid_Ocena";
            this.Grid_Ocena.Size = new System.Drawing.Size(599, 235);
            this.Grid_Ocena.TabIndex = 11;
            this.Grid_Ocena.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Ocena_CellClick);
            // 
            // lbl_Godina
            // 
            this.lbl_Godina.AutoSize = true;
            this.lbl_Godina.Location = new System.Drawing.Point(58, 27);
            this.lbl_Godina.Name = "lbl_Godina";
            this.lbl_Godina.Size = new System.Drawing.Size(41, 13);
            this.lbl_Godina.TabIndex = 12;
            this.lbl_Godina.Text = "Godina";
            // 
            // lbl_Profesor
            // 
            this.lbl_Profesor.AutoSize = true;
            this.lbl_Profesor.Location = new System.Drawing.Point(182, 27);
            this.lbl_Profesor.Name = "lbl_Profesor";
            this.lbl_Profesor.Size = new System.Drawing.Size(46, 13);
            this.lbl_Profesor.TabIndex = 13;
            this.lbl_Profesor.Text = "Profesor";
            // 
            // lbl_Predmet
            // 
            this.lbl_Predmet.AutoSize = true;
            this.lbl_Predmet.Location = new System.Drawing.Point(309, 27);
            this.lbl_Predmet.Name = "lbl_Predmet";
            this.lbl_Predmet.Size = new System.Drawing.Size(46, 13);
            this.lbl_Predmet.TabIndex = 14;
            this.lbl_Predmet.Text = "Predmet";
            // 
            // lbl_Odeljenje
            // 
            this.lbl_Odeljenje.AutoSize = true;
            this.lbl_Odeljenje.Location = new System.Drawing.Point(436, 27);
            this.lbl_Odeljenje.Name = "lbl_Odeljenje";
            this.lbl_Odeljenje.Size = new System.Drawing.Size(51, 13);
            this.lbl_Odeljenje.TabIndex = 15;
            this.lbl_Odeljenje.Text = "Odeljenje";
            // 
            // lbl_Ucenik
            // 
            this.lbl_Ucenik.AutoSize = true;
            this.lbl_Ucenik.Location = new System.Drawing.Point(58, 96);
            this.lbl_Ucenik.Name = "lbl_Ucenik";
            this.lbl_Ucenik.Size = new System.Drawing.Size(41, 13);
            this.lbl_Ucenik.TabIndex = 16;
            this.lbl_Ucenik.Text = "Ucenik";
            // 
            // lbl_Ocena
            // 
            this.lbl_Ocena.AutoSize = true;
            this.lbl_Ocena.Location = new System.Drawing.Point(182, 96);
            this.lbl_Ocena.Name = "lbl_Ocena";
            this.lbl_Ocena.Size = new System.Drawing.Size(39, 13);
            this.lbl_Ocena.TabIndex = 17;
            this.lbl_Ocena.Text = "Ocena";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(309, 96);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(56, 13);
            this.lbl_ID.TabIndex = 18;
            this.lbl_ID.Text = "ID_Ocene";
            // 
            // lbl_Datum
            // 
            this.lbl_Datum.AutoSize = true;
            this.lbl_Datum.Location = new System.Drawing.Point(436, 96);
            this.lbl_Datum.Name = "lbl_Datum";
            this.lbl_Datum.Size = new System.Drawing.Size(38, 13);
            this.lbl_Datum.TabIndex = 19;
            this.lbl_Datum.Text = "Datum";
            // 
            // txt_Provera
            // 
            this.txt_Provera.Location = new System.Drawing.Point(58, 165);
            this.txt_Provera.Name = "txt_Provera";
            this.txt_Provera.Size = new System.Drawing.Size(599, 20);
            this.txt_Provera.TabIndex = 20;
            // 
            // Ocena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 465);
            this.Controls.Add(this.txt_Provera);
            this.Controls.Add(this.lbl_Datum);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_Ocena);
            this.Controls.Add(this.lbl_Ucenik);
            this.Controls.Add(this.lbl_Odeljenje);
            this.Controls.Add(this.lbl_Predmet);
            this.Controls.Add(this.lbl_Profesor);
            this.Controls.Add(this.lbl_Godina);
            this.Controls.Add(this.Grid_Ocena);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.cb_Ocena);
            this.Controls.Add(this.cb_Ucenik);
            this.Controls.Add(this.cb_Odeljenje);
            this.Controls.Add(this.cb_Predmet);
            this.Controls.Add(this.cb_Profesor);
            this.Controls.Add(this.cb_Godina);
            this.Name = "Ocena";
            this.Text = "Ocena";
            this.Load += new System.EventHandler(this.Ocena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Ocena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Godina;
        private System.Windows.Forms.ComboBox cb_Profesor;
        private System.Windows.Forms.ComboBox cb_Predmet;
        private System.Windows.Forms.ComboBox cb_Odeljenje;
        private System.Windows.Forms.ComboBox cb_Ucenik;
        private System.Windows.Forms.ComboBox cb_Ocena;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView Grid_Ocena;
        private System.Windows.Forms.Label lbl_Godina;
        private System.Windows.Forms.Label lbl_Profesor;
        private System.Windows.Forms.Label lbl_Predmet;
        private System.Windows.Forms.Label lbl_Odeljenje;
        private System.Windows.Forms.Label lbl_Ucenik;
        private System.Windows.Forms.Label lbl_Ocena;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Datum;
        private System.Windows.Forms.TextBox txt_Provera;
    }
}