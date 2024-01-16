using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using static RadnoVrijeme.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace RadnoVrijeme
{
    public partial class Form1 : Form
    {

    
        private List<Firma> firme;
        private List<Zaposlenik> zaposlenici;
        Label label12 = new Label();

        public class Firma
        {
            private static int pocetniID = 0;
            public int idFirme { get; set; }
            public string nazivFirme { get; }
            public TimeSpan pocetakRadnogVremena { get; }
            public TimeSpan pocetakRadnogVremena2 { get; }
            public TimeSpan krajRadnogVremena { get; }
            public TimeSpan krajRadnogVremena2 { get; }
            public List<Zaposlenik> zaposlenici { get; }

            public Firma(string _nazivFirme, TimeSpan _pocetakRadnogVremena, TimeSpan _pocetakRadnogVremena2, TimeSpan _krajRadnogVremena, TimeSpan _krajRadnogVremena2)
            {
                this.idFirme = pocetniID++;
                this.nazivFirme = _nazivFirme;
                this.pocetakRadnogVremena = _pocetakRadnogVremena;
                this.pocetakRadnogVremena2 = _pocetakRadnogVremena2;
                this.krajRadnogVremena = _krajRadnogVremena;
                this.krajRadnogVremena2 = _krajRadnogVremena2;

                this.zaposlenici = new List<Zaposlenik>();
            }

            public void DodajZaposlenika(Zaposlenik zaposlenik)
            {
                zaposlenici.Add(zaposlenik);
            }


            public string GetNaziv()
            {
                return this.nazivFirme;
            }

            public int GetID()
            {
                return this.idFirme;
            }

            public string DohvatiZaposlenikeTekst()
            {
                string tekst = $"";
                foreach (var zaposlenik in zaposlenici)
                {
                    tekst += $"{zaposlenik.ime},{zaposlenik.prezime},{zaposlenik.idZaposlenika}, {zaposlenik.firma}\n";
                }
                return tekst;
            }

            public List<KeyValuePair<Zaposlenik, TimeSpan>> VratiZaposlenikeManjeOd40sati()
            {
                List<KeyValuePair<Zaposlenik, TimeSpan>> zaposleniciManjeOd40sati = new List<KeyValuePair<Zaposlenik, TimeSpan>>();

                foreach (Zaposlenik zaposlenik in zaposlenici)
                {
                    if (zaposlenik.UkupnoRadnihSatiZaTrenutniTjedan().TotalHours < 40)
                    {
                        zaposleniciManjeOd40sati.Add(new KeyValuePair<Zaposlenik, TimeSpan>(zaposlenik, zaposlenik.UkupnoRadnihSatiZaTrenutniTjedan()));
                    }
                }
                return zaposleniciManjeOd40sati;
            }

           
            public Dictionary<Zaposlenik, string> VratiZaposlenikeKasnjenje()
            {
                Dictionary<Zaposlenik, string> zaposleniciKasnjenje = new Dictionary<Zaposlenik, string>();

                foreach (Zaposlenik zaposlenik in zaposlenici)
                {
                    string kasni = "";
                    foreach (Evidencija evidencija in zaposlenik.EvidencijaRanogVremena)
                    {
                       
                        if (evidencija.dolazak > pocetakRadnogVremena2)
                        {
                            kasni="kasni";
                            zaposleniciKasnjenje.TryAdd(zaposlenik, kasni);
                        }

                    }

                }
                return zaposleniciKasnjenje;
            }

            
            public Dictionary<Zaposlenik, string> VratiZaposlenikeRanijeOdlazak()
            {
                Dictionary<Zaposlenik, string> zaposleniciRanijeOdlazak = new Dictionary<Zaposlenik, string>();

                foreach (Zaposlenik zaposlenik in zaposlenici)
                {
                    string ranijeOdlazi = "";
                    foreach (Evidencija evidencija in zaposlenik.EvidencijaRanogVremena)
                    {
                        
                        if (evidencija.odlazak < krajRadnogVremena)
                        {
                            ranijeOdlazi = "ranije odlazi";
                            zaposleniciRanijeOdlazak.TryAdd(zaposlenik, ranijeOdlazi);
                        }

                    }

                }
                return zaposleniciRanijeOdlazak;
            }


        }


        public class Zaposlenik
        {
            private static int pocetniID = 1;
            public int idZaposlenika { get; set; }
            public string ime { get; }
            public string prezime { get; }

            public int firma { get; set; }

            public List<Evidencija> EvidencijaRanogVremena { get; set; } = new List<Evidencija>();

            public List<Dolazak> Dolasci { get; set; } = new List<Dolazak>();

            public Zaposlenik(string _ime, string _prezime, int _firma)
            {
                this.idZaposlenika = pocetniID++;
                this.ime = _ime;
                this.prezime = _prezime;
                this.firma = _firma;
            }

            public void EvidencijaDolaskaOdlaska(DateTime datum, TimeSpan dolazak, TimeSpan odlazak)
            {
                EvidencijaRanogVremena.Add(new Evidencija(datum, dolazak, odlazak));
            }

            public void spremanjeDolaska(DateTime _dolazak, DateTime _datum, int _idZaposlenikaV)
            {
                Dolasci.Add(new Dolazak(_dolazak, _datum, _idZaposlenikaV));
            }

            public TimeSpan UkupnoRadnihSatiZaTrenutniTjedan()
            {
                DateTime datum = DateTime.Now;
                int brojDana = datum.DayOfWeek - DayOfWeek.Monday;
                DateTime pocetakTjedna = datum.AddDays(-brojDana);
                DateTime krajTjedna = pocetakTjedna.AddDays(7);

                TimeSpan sati = TimeSpan.Zero;
                foreach (Evidencija evidencija in EvidencijaRanogVremena)
                {
                    if (evidencija.datum >= pocetakTjedna && evidencija.datum < krajTjedna)
                    {
                        sati += evidencija.odlazak - evidencija.dolazak;
                    }
                }
                return sati;

            }

        }

        public class Dolazak
        {
            public int idZaposlenika { get; set; }
            public DateTime datum { get; set; }
            public DateTime dolazak { get; set; }

            public Dolazak(DateTime _dolazak, DateTime datum, int idZaposlenika)
            {
                this.dolazak = _dolazak;
                this.datum = datum;
                this.idZaposlenika = idZaposlenika;
            }
        }

        public class Evidencija
        {
            public DateTime datum { get; set; }
            public TimeSpan dolazak { get; set; }
            public TimeSpan odlazak { get; set; }

            public Evidencija(DateTime _datum, TimeSpan _dolazak, TimeSpan _odlazak)
            {
                this.datum = _datum;
                this.dolazak = _dolazak;
                this.odlazak = _odlazak;
            }
        }


        public Form1()
        {
            InitializeComponent();

            firme = new List<Firma> {
                new Firma("Firma 1", new TimeSpan(7,0,0), new TimeSpan(8,0,0), new TimeSpan(15,0,0), new TimeSpan(16,0,0)),
                new Firma("Firma 2", new TimeSpan(7,0,0), new TimeSpan(8,0,0), new TimeSpan(15,0,0), new TimeSpan(16,0,0)),
                new Firma("Firma 3", new TimeSpan(7,0,0), new TimeSpan(8,0,0), new TimeSpan(15,0,0), new TimeSpan(16,0,0)),
            };


            zaposlenici = new List<Zaposlenik>
            {
                new Zaposlenik("Ana ", "Petrović",firme[0].idFirme),
                new Zaposlenik("Marko ", "Jovanović", firme[0].idFirme),
                new Zaposlenik("Ivan ", "Kovačević", firme[0].idFirme),
                new Zaposlenik("Martina ", "Šarić",firme[1].idFirme),
                new Zaposlenik("Tomislav ", "Novak", firme[0].idFirme),
                new Zaposlenik("Mia ", "Kovač",firme[0].idFirme),
                new Zaposlenik("Mateo ", "Knežević",firme[1].idFirme),
                new Zaposlenik("Petra ", "Vuković",firme[1].idFirme),
                new Zaposlenik("Filip ", "Horvat",firme[1].idFirme),
                new Zaposlenik("Ivana ", "Kovač",firme[1].idFirme),
                new Zaposlenik("Lara ", "Pavić",firme[2].idFirme),
                new Zaposlenik("Ante ", "Jurić",firme[2].idFirme),
                new Zaposlenik("Ema ", "Kralj",firme[2].idFirme),
                new Zaposlenik("Domagoj ", "Matić",firme[2].idFirme),
                new Zaposlenik("Magdalena ", "Tomić",firme[2].idFirme),
            };

            foreach (Zaposlenik zapos in zaposlenici)
            {
                firme[zapos.firma].DodajZaposlenika(zapos);
            }


            foreach (Firma firmaAll in firme)
            {
                sveFirme.Items.Add(firmaAll.GetID() + "-" + firmaAll.GetNaziv());
            }

            var zaposlenik = zaposlenici.Find(z => z.idZaposlenika == 1);

            if (zaposlenik != null)
            {
                zaposlenik.EvidencijaDolaskaOdlaska(new DateTime(2024, 1, 15), new TimeSpan(9, 0, 0), new TimeSpan(13, 25, 0));
                zaposlenik.EvidencijaDolaskaOdlaska(new DateTime(2024, 1, 16), new TimeSpan(9, 0, 0), new TimeSpan(13, 25, 0));
                zaposlenik.EvidencijaDolaskaOdlaska(new DateTime(2024, 1, 17), new TimeSpan(9, 25, 0), new TimeSpan(13, 25, 0));
                zaposlenik.EvidencijaDolaskaOdlaska(new DateTime(2024, 1, 18), new TimeSpan(9, 0, 0), new TimeSpan(13, 25, 0));
                zaposlenik.EvidencijaDolaskaOdlaska(new DateTime(2024, 1, 19), new TimeSpan(9, 0, 0), new TimeSpan(13, 25, 0));
            }

            var zaposlenik2 = zaposlenici.Find(z => z.idZaposlenika == 2);

            if (zaposlenik2 != null)
            {
                zaposlenik2.EvidencijaDolaskaOdlaska(new DateTime(2024, 1, 15), new TimeSpan(7, 15, 0), new TimeSpan(13, 25, 0));
                zaposlenik2.EvidencijaDolaskaOdlaska(new DateTime(2024, 1, 16), new TimeSpan(7, 4, 0), new TimeSpan(14, 25, 0));
                zaposlenik2.EvidencijaDolaskaOdlaska(new DateTime(2024, 1, 17), new TimeSpan(7, 7, 0), new TimeSpan(15, 45, 0));
                zaposlenik2.EvidencijaDolaskaOdlaska(new DateTime(2024, 1, 18), new TimeSpan(9, 8, 0), new TimeSpan(15, 25, 0));
                zaposlenik2.EvidencijaDolaskaOdlaska(new DateTime(2024, 1, 19), new TimeSpan(7, 5, 0), new TimeSpan(15, 25, 0));
            }


            label11.Text = "";
            kasneLabel.Text = "";
            ranijeOdlaze.Text = "";

            butdodajZaposlenika.Enabled = false;
            sviZaposlenici.Enabled = false;
            butUpisDolazakOdlazak.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            upisDolazakV.Format = DateTimePickerFormat.Custom;
            upisDolazakV.CustomFormat = "HH:mm";
            upisDolazakV.ShowUpDown = true;
            upisDolazakV.Value = DateTime.Parse("07:00");

            upisOdlaskaV.Format = DateTimePickerFormat.Custom;
            upisOdlaskaV.CustomFormat = "HH:mm";
            upisOdlaskaV.ShowUpDown = true;
            upisOdlaskaV.Value = DateTime.Parse("15:00");

            dateKraj1.Format = DateTimePickerFormat.Custom;
            dateKraj1.CustomFormat = "HH:mm";
            dateKraj1.ShowUpDown = true;
            dateKraj1.Value = DateTime.Parse("15:00");

            dateKraj2.Format = DateTimePickerFormat.Custom;
            dateKraj2.CustomFormat = "HH:mm";
            dateKraj2.ShowUpDown = true;
            dateKraj2.Value = DateTime.Parse("17:00");

            datePocetak1.Format = DateTimePickerFormat.Custom;
            datePocetak1.CustomFormat = "HH:mm";
            datePocetak1.ShowUpDown = true;
            datePocetak1.Value = DateTime.Parse("7:00");

            datePocetak2.Format = DateTimePickerFormat.Custom;
            datePocetak2.CustomFormat = "HH:mm";
            datePocetak2.ShowUpDown = true;
            datePocetak2.Value = DateTime.Parse("8:00");
        }

        private void butdodajFirmu_Click(object sender, EventArgs e)
        {

        }

        private void butdodajZaposlenika_Click(object sender, EventArgs e)
        {

        }

        private void butSpremanjeDolaska_Click(object sender, EventArgs e)
        {
            try
            {

                int idZaposlenika = Int32.Parse(textIdZaposlenika.Text);
                var zaposlenik = zaposlenici.Find(z => z.idZaposlenika == idZaposlenika);

                DateTime dateTime = odabirDana.Value.Date;

                DateTime vrijemeDolaska = upisDolazakV.Value;
                zaposlenik.spremanjeDolaska(vrijemeDolaska, dateTime, idZaposlenika);

                butUpisDolazakOdlazak.Enabled = true;

            }
            catch (System.FormatException)
            {
                MessageBox.Show("Niste unijeli sve podatke!");
            }
        }

        private void butUpisDolazakOdlazak_Click(object sender, EventArgs e)
        {
            try
            {

                int idZaposlenika = Int32.Parse(textIdZaposlenika.Text);
                var zaposlenik = zaposlenici.Find(z => z.idZaposlenika == idZaposlenika);

                if (string.IsNullOrEmpty(textIdZaposlenika.Text))
                {
                    MessageBox.Show("Niste izabrali zaposlenika!");
                    return;
                }

                TimeSpan dolazak1 = TimeSpan.Zero;
                TimeSpan odlazak1 = TimeSpan.Zero;


                DateTime upisDolaska = upisDolazakV.Value;
                dolazak1 = upisDolaska.TimeOfDay;


                DateTime upisOdlaska = upisOdlaskaV.Value;
                odlazak1 = upisOdlaska.TimeOfDay;



                DateTime dateTime = odabirDana.Value.Date;

                foreach (Dolazak dolaz in zaposlenik.Dolasci)
                {
                    if (dolaz.idZaposlenika == zaposlenik.idZaposlenika)
                    {
                        dolaz.dolazak = DateTime.MinValue;

                    }
                }

                if (zaposlenik != null)
                {

                    zaposlenik.EvidencijaDolaskaOdlaska(dateTime, dolazak1, odlazak1);

                }
                else
                {
                    MessageBox.Show("Zaposlenik nije pronađen!");
                }


            }
            catch (System.FormatException)
            {
                MessageBox.Show("Niste unijeli sve podatke!");
            }



        }

        private void butDodajFirmu_Click_1(object sender, EventArgs e)
        {
            try
            {

            string naziv = textNazivFirme.Text;

                if (naziv == "")
                {
                    MessageBox.Show("Niste unijeli naziv firme!");
                }
                else if (naziv != "") { 

                        DateTime pocet1 = datePocetak1.Value;
                        TimeSpan dolazak = pocet1.TimeOfDay;
                        DateTime pocet2 = datePocetak2.Value;
                        TimeSpan dolazak2 = pocet2.TimeOfDay;

                        DateTime kraj1 = dateKraj1.Value;
                        TimeSpan odlazak = kraj1.TimeOfDay;
                        DateTime kraj2 = dateKraj2.Value;
                        TimeSpan odlazak2 = kraj2.TimeOfDay;

                        firme.Add(new Firma(naziv, dolazak, dolazak2, odlazak, odlazak2));

                        sveFirme.Items.Clear();
                        foreach (Firma firmaAll in firme)
                        {
                            sveFirme.Items.Add(firmaAll.GetID() + "-" + firmaAll.GetNaziv());
                        }
                }

            }
            catch (System.FormatException)
            {
                MessageBox.Show("Niste unijeli sve podatke!");
            }
        }

        private void sveFirme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sveFirme.SelectedIndex != -1)
            {
                if (textIdFirme.Text.Length > 0)
                {
                    sviZaposlenici.Enabled = true;
                }

                string odabranaFirma = sveFirme.SelectedItem.ToString();
                string[] parts = odabranaFirma.Split('-');
                int idFirme = Int32.Parse(parts[0]);
                textIdFirme.Text = idFirme.ToString();

                sviZaposlenici.Items.Clear();
                sviZaposlenici.Text = "";
                textIdZaposlenika.Text = "ID";
                labelRadnoVrijeme.Text = "";


                label11.Text = "";
                kasneLabel.Text = "";
                ranijeOdlaze.Text = "";

                foreach (Firma firmice in firme.Where(z => z.idFirme == idFirme)) {
                    labelRadnoVrijeme.Text = "Radno vrijeme:\nPocetak " + firmice.pocetakRadnogVremena + " - " + firmice.pocetakRadnogVremena2 + "  Kraj: " + firmice.krajRadnogVremena + " - " + firmice.krajRadnogVremena2;
                }


                foreach (Zaposlenik zapos in zaposlenici.Where(z => z.firma == idFirme))
                {
                    sviZaposlenici.Items.Add(zapos.idZaposlenika + "-" + zapos.ime);
                }

            }

        }

        private void sviZaposlenici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sviZaposlenici.SelectedIndex != -1)
            {
                butUpisDolazakOdlazak.Enabled = false;



                string odabraniZaposlenik = sviZaposlenici.SelectedItem.ToString();

                string[] parts = odabraniZaposlenik.Split('-');
                int idZaposlenika = int.Parse(parts[0].ToString());
                textIdZaposlenika.Text = idZaposlenika.ToString();

                var zaposlenik = zaposlenici.Find(z => z.idZaposlenika == idZaposlenika);

                DateTime dateTime = odabirDana.Value.Date;

                foreach (Dolazak dolaz in zaposlenik.Dolasci)
                {
                    if (dolaz.idZaposlenika == zaposlenik.idZaposlenika)
                    {
                        upisDolazakV.Value = dolaz.dolazak;

                        if (upisDolazakV.Value == dolaz.dolazak)
                        {
                            butUpisDolazakOdlazak.Enabled = true;
                        }
                        else butUpisDolazakOdlazak.Enabled = false;

                    }
                }



            }
        }

        private void butIspisManjeOd40sati_Click(object sender, EventArgs e)
        {
            try
            {

                label11.Text = "";
                string odabranaFirma = sveFirme.SelectedItem.ToString();
                string[] parts = odabranaFirma.Split('-');
                int idFirme = Int32.Parse(parts[0]);

                var firma = firme.Find(f => f.idFirme == idFirme);

                firma.VratiZaposlenikeManjeOd40sati();

                foreach (var zaposlenikSati in firma.VratiZaposlenikeManjeOd40sati())
                {
                    string tekst = $"{zaposlenikSati.Key.ime} \t \t \t {zaposlenikSati.Key.prezime} \t \t \t - {Math.Floor(zaposlenikSati.Value.TotalHours)} sati {zaposlenikSati.Value.Minutes} minuta";
                    label11.Text += tekst + "\n";
                }



            }
            catch (Exception)
            {
                MessageBox.Show("Niste odabrali firmu!");
            }
        }

        private void butKasnjenjeZapos_Click(object sender, EventArgs e)
        {
            try
            {
                kasneLabel.Text = "";
                string odabranaFirma = sveFirme.SelectedItem.ToString();
                string[] parts = odabranaFirma.Split('-');
                int idFirme = Int32.Parse(parts[0]);

                //ispisi zaposlenike koji kasne na posao preko funkcije VratiZaposlenikeKasnjenje
                foreach (var zaposlenikKasnjenje in firme[idFirme].VratiZaposlenikeKasnjenje())
                {
                    string tekst = $"{zaposlenikKasnjenje.Key.ime} \t \t \t {zaposlenikKasnjenje.Key.prezime} \t \t \t - {zaposlenikKasnjenje.Value} ";
                    kasneLabel.Text += tekst + "\n";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Niste odabrali firmu!");
            }
        }

        private void butRanijeOdlaze_Click(object sender, EventArgs e)
        {
            try
            {
                ranijeOdlaze.Text = "";
                string odabranaFirma = sveFirme.SelectedItem.ToString();
                string[] parts = odabranaFirma.Split('-');
                int idFirme = Int32.Parse(parts[0]);

                //ispisi zaposlenike koji odlaze ranije s posla preko funkcije VratiZaposlenikeRanijeOdlazak
                foreach (var zaposlenikRanijeOdlazak in firme[idFirme].VratiZaposlenikeRanijeOdlazak())
                {
                    string tekst = $"{zaposlenikRanijeOdlazak.Key.ime} \t \t \t {zaposlenikRanijeOdlazak.Key.prezime} \t \t \t - {zaposlenikRanijeOdlazak.Value}";
                    ranijeOdlaze.Text += tekst + "\n";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Niste odabrali firmu!");
            }
        }
    }
}