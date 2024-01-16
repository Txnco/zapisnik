namespace RadnoVrijeme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sveFirme = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            sviZaposlenici = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            odabirDana = new DateTimePicker();
            butdodajZaposlenika = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            butIspisManjeOd40sati = new Button();
            butUpisDolazakOdlazak = new Button();
            butDodajFirmu = new Button();
            textIdFirme = new Label();
            textIdZaposlenika = new Label();
            label11 = new Label();
            butSpremanjeDolaska = new Button();
            upisDolazakV = new DateTimePicker();
            upisOdlaskaV = new DateTimePicker();
            butKasnjenjeZapos = new Button();
            kasneLabel = new Label();
            butRanijeOdlaze = new Button();
            ranijeOdlaze = new Label();
            labelRadnoVrijeme = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            textNazivFirme = new TextBox();
            datePocetak1 = new DateTimePicker();
            datePocetak2 = new DateTimePicker();
            dateKraj2 = new DateTimePicker();
            dateKraj1 = new DateTimePicker();
            SuspendLayout();
            // 
            // sveFirme
            // 
            sveFirme.FormattingEnabled = true;
            sveFirme.Location = new Point(23, 153);
            sveFirme.Name = "sveFirme";
            sveFirme.Size = new Size(121, 23);
            sveFirme.TabIndex = 2;
            sveFirme.SelectedIndexChanged += sveFirme_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 135);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 3;
            label1.Text = "Izaberi firmu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 195);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 5;
            label2.Text = "ID firme";
            // 
            // sviZaposlenici
            // 
            sviZaposlenici.FormattingEnabled = true;
            sviZaposlenici.Location = new Point(167, 153);
            sviZaposlenici.Name = "sviZaposlenici";
            sviZaposlenici.Size = new Size(121, 23);
            sviZaposlenici.TabIndex = 6;
            sviZaposlenici.SelectedIndexChanged += sviZaposlenici_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 135);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 7;
            label3.Text = "Izaberi zaposlenika";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(81, 285);
            label4.Name = "label4";
            label4.Size = new Size(168, 32);
            label4.TabIndex = 8;
            label4.Text = "Radno vrijeme";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(116, 317);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 9;
            label5.Text = "Dolazak / Odlazak";
            // 
            // odabirDana
            // 
            odabirDana.Location = new Point(66, 347);
            odabirDana.Name = "odabirDana";
            odabirDana.Size = new Size(200, 23);
            odabirDana.TabIndex = 12;
            // 
            // butdodajZaposlenika
            // 
            butdodajZaposlenika.Location = new Point(167, 105);
            butdodajZaposlenika.Name = "butdodajZaposlenika";
            butdodajZaposlenika.Size = new Size(121, 23);
            butdodajZaposlenika.TabIndex = 13;
            butdodajZaposlenika.Text = "Dodaj zaposlenika";
            butdodajZaposlenika.UseVisualStyleBackColor = true;
            butdodajZaposlenika.Click += butdodajZaposlenika_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 388);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 15;
            label6.Text = "Dolazak";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(182, 388);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 16;
            label7.Text = "Odlazak";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(167, 195);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 18;
            label8.Text = "ID zaposlenika";
            // 
            // butIspisManjeOd40sati
            // 
            butIspisManjeOd40sati.Location = new Point(379, 105);
            butIspisManjeOd40sati.Name = "butIspisManjeOd40sati";
            butIspisManjeOd40sati.Size = new Size(198, 23);
            butIspisManjeOd40sati.TabIndex = 19;
            butIspisManjeOd40sati.Text = "Manje od 40 radnih sati u tjednu";
            butIspisManjeOd40sati.UseVisualStyleBackColor = true;
            butIspisManjeOd40sati.Click += butIspisManjeOd40sati_Click;
            // 
            // butUpisDolazakOdlazak
            // 
            butUpisDolazakOdlazak.Location = new Point(181, 446);
            butUpisDolazakOdlazak.Name = "butUpisDolazakOdlazak";
            butUpisDolazakOdlazak.Size = new Size(121, 23);
            butUpisDolazakOdlazak.TabIndex = 20;
            butUpisDolazakOdlazak.Text = "Upisi vrijeme";
            butUpisDolazakOdlazak.UseVisualStyleBackColor = true;
            butUpisDolazakOdlazak.Click += butUpisDolazakOdlazak_Click;
            // 
            // butDodajFirmu
            // 
            butDodajFirmu.Location = new Point(23, 105);
            butDodajFirmu.Name = "butDodajFirmu";
            butDodajFirmu.Size = new Size(121, 23);
            butDodajFirmu.TabIndex = 21;
            butDodajFirmu.Text = "Dodaj Firmu";
            butDodajFirmu.UseVisualStyleBackColor = true;
            butDodajFirmu.Click += butDodajFirmu_Click_1;
            // 
            // textIdFirme
            // 
            textIdFirme.AutoSize = true;
            textIdFirme.Location = new Point(23, 221);
            textIdFirme.Name = "textIdFirme";
            textIdFirme.Size = new Size(18, 15);
            textIdFirme.TabIndex = 26;
            textIdFirme.Text = "ID";
            // 
            // textIdZaposlenika
            // 
            textIdZaposlenika.AutoSize = true;
            textIdZaposlenika.Location = new Point(167, 221);
            textIdZaposlenika.Name = "textIdZaposlenika";
            textIdZaposlenika.Size = new Size(18, 15);
            textIdZaposlenika.TabIndex = 27;
            textIdZaposlenika.Text = "ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(379, 131);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 28;
            label11.Text = "label11";
            // 
            // butSpremanjeDolaska
            // 
            butSpremanjeDolaska.Location = new Point(23, 446);
            butSpremanjeDolaska.Name = "butSpremanjeDolaska";
            butSpremanjeDolaska.Size = new Size(123, 23);
            butSpremanjeDolaska.TabIndex = 29;
            butSpremanjeDolaska.Text = "Upisi dolazak";
            butSpremanjeDolaska.UseVisualStyleBackColor = true;
            butSpremanjeDolaska.Click += butSpremanjeDolaska_Click;
            // 
            // upisDolazakV
            // 
            upisDolazakV.Location = new Point(23, 408);
            upisDolazakV.Name = "upisDolazakV";
            upisDolazakV.Size = new Size(122, 23);
            upisDolazakV.TabIndex = 30;
            // 
            // upisOdlaskaV
            // 
            upisOdlaskaV.Location = new Point(181, 406);
            upisOdlaskaV.Name = "upisOdlaskaV";
            upisOdlaskaV.Size = new Size(122, 23);
            upisOdlaskaV.TabIndex = 31;
            // 
            // butKasnjenjeZapos
            // 
            butKasnjenjeZapos.Location = new Point(379, 295);
            butKasnjenjeZapos.Name = "butKasnjenjeZapos";
            butKasnjenjeZapos.Size = new Size(118, 23);
            butKasnjenjeZapos.TabIndex = 32;
            butKasnjenjeZapos.Text = "Kasne na posao";
            butKasnjenjeZapos.UseVisualStyleBackColor = true;
            butKasnjenjeZapos.Click += butKasnjenjeZapos_Click;
            // 
            // kasneLabel
            // 
            kasneLabel.AutoSize = true;
            kasneLabel.Location = new Point(379, 321);
            kasneLabel.Name = "kasneLabel";
            kasneLabel.Size = new Size(44, 15);
            kasneLabel.TabIndex = 33;
            kasneLabel.Text = "label13";
            // 
            // butRanijeOdlaze
            // 
            butRanijeOdlaze.Location = new Point(564, 295);
            butRanijeOdlaze.Name = "butRanijeOdlaze";
            butRanijeOdlaze.Size = new Size(118, 23);
            butRanijeOdlaze.TabIndex = 34;
            butRanijeOdlaze.Text = "Odlaze ranije";
            butRanijeOdlaze.UseVisualStyleBackColor = true;
            butRanijeOdlaze.Click += butRanijeOdlaze_Click;
            // 
            // ranijeOdlaze
            // 
            ranijeOdlaze.AutoSize = true;
            ranijeOdlaze.Location = new Point(564, 321);
            ranijeOdlaze.Name = "ranijeOdlaze";
            ranijeOdlaze.Size = new Size(44, 15);
            ranijeOdlaze.TabIndex = 35;
            ranijeOdlaze.Text = "label14";
            // 
            // labelRadnoVrijeme
            // 
            labelRadnoVrijeme.AutoSize = true;
            labelRadnoVrijeme.Location = new Point(21, 250);
            labelRadnoVrijeme.Name = "labelRadnoVrijeme";
            labelRadnoVrijeme.Size = new Size(83, 15);
            labelRadnoVrijeme.TabIndex = 36;
            labelRadnoVrijeme.Text = "Radno vrijeme";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(317, 13);
            label12.Name = "label12";
            label12.Size = new Size(117, 15);
            label12.TabIndex = 46;
            label12.Text = "Kraj radnog vremena";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(167, 10);
            label13.Name = "label13";
            label13.Size = new Size(139, 15);
            label13.TabIndex = 45;
            label13.Text = "Početak radnog vremena";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(23, 39);
            label14.Name = "label14";
            label14.Size = new Size(67, 15);
            label14.TabIndex = 44;
            label14.Text = "Naziv firme";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(21, 10);
            label15.Name = "label15";
            label15.Size = new Size(123, 30);
            label15.TabIndex = 42;
            label15.Text = "Dodaj firmu";
            // 
            // textNazivFirme
            // 
            textNazivFirme.Location = new Point(23, 57);
            textNazivFirme.Name = "textNazivFirme";
            textNazivFirme.Size = new Size(121, 23);
            textNazivFirme.TabIndex = 37;
            // 
            // datePocetak1
            // 
            datePocetak1.Location = new Point(167, 28);
            datePocetak1.Name = "datePocetak1";
            datePocetak1.Size = new Size(121, 23);
            datePocetak1.TabIndex = 47;
            // 
            // datePocetak2
            // 
            datePocetak2.Location = new Point(167, 57);
            datePocetak2.Name = "datePocetak2";
            datePocetak2.Size = new Size(121, 23);
            datePocetak2.TabIndex = 48;
            // 
            // dateKraj2
            // 
            dateKraj2.Location = new Point(317, 57);
            dateKraj2.Name = "dateKraj2";
            dateKraj2.Size = new Size(121, 23);
            dateKraj2.TabIndex = 50;
            // 
            // dateKraj1
            // 
            dateKraj1.Location = new Point(317, 28);
            dateKraj1.Name = "dateKraj1";
            dateKraj1.Size = new Size(121, 23);
            dateKraj1.TabIndex = 49;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 486);
            Controls.Add(dateKraj2);
            Controls.Add(dateKraj1);
            Controls.Add(datePocetak2);
            Controls.Add(datePocetak1);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(textNazivFirme);
            Controls.Add(labelRadnoVrijeme);
            Controls.Add(ranijeOdlaze);
            Controls.Add(butRanijeOdlaze);
            Controls.Add(kasneLabel);
            Controls.Add(butKasnjenjeZapos);
            Controls.Add(upisOdlaskaV);
            Controls.Add(upisDolazakV);
            Controls.Add(butSpremanjeDolaska);
            Controls.Add(label11);
            Controls.Add(textIdZaposlenika);
            Controls.Add(textIdFirme);
            Controls.Add(butDodajFirmu);
            Controls.Add(butUpisDolazakOdlazak);
            Controls.Add(butIspisManjeOd40sati);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(butdodajZaposlenika);
            Controls.Add(odabirDana);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(sviZaposlenici);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sveFirme);
            Name = "Form1";
            Text = "Zapisnik";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox sveFirme;
        private Label label1;
        private Label label2;
        private ComboBox sviZaposlenici;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker odabirDana;
        private Button butdodajZaposlenika;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button butIspisManjeOd40sati;
        private Button butUpisDolazakOdlazak;
        private Button butDodajFirmu;
        private Label textIdFirme;
        private Label textIdZaposlenika;
        private Label label11;
        private Button butSpremanjeDolaska;
        private DateTimePicker upisDolazakV;
        private DateTimePicker upisOdlaskaV;
        private Button butKasnjenjeZapos;
        private Label kasneLabel;
        private Button butRanijeOdlaze;
        private Label ranijeOdlaze;
        private Label labelRadnoVrijeme;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox textNazivFirme;
        private DateTimePicker datePocetak1;
        private DateTimePicker datePocetak2;
        private DateTimePicker dateKraj2;
        private DateTimePicker dateKraj1;
    }
}
