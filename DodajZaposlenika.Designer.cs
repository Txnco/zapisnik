namespace RadnoVrijeme
{
    partial class DodajZaposlenika
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
            label1 = new Label();
            butdodajZaposlenikacs2 = new Button();
            textImeZaposlenika = new TextBox();
            textPrezimeZaposlenika = new TextBox();
            odabirFirmeZaposleniku = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 18);
            label1.Name = "label1";
            label1.Size = new Size(235, 37);
            label1.TabIndex = 0;
            label1.Text = "Dodaj zaposlenika";
            // 
            // butdodajZaposlenikacs2
            // 
            butdodajZaposlenikacs2.Location = new Point(75, 237);
            butdodajZaposlenikacs2.Name = "butdodajZaposlenikacs2";
            butdodajZaposlenikacs2.Size = new Size(179, 23);
            butdodajZaposlenikacs2.TabIndex = 1;
            butdodajZaposlenikacs2.Text = "Dodaj zaposlenika";
            butdodajZaposlenikacs2.UseVisualStyleBackColor = true;
            // 
            // textImeZaposlenika
            // 
            textImeZaposlenika.Location = new Point(113, 79);
            textImeZaposlenika.Name = "textImeZaposlenika";
            textImeZaposlenika.Size = new Size(100, 23);
            textImeZaposlenika.TabIndex = 2;
            // 
            // textPrezimeZaposlenika
            // 
            textPrezimeZaposlenika.Location = new Point(113, 127);
            textPrezimeZaposlenika.Name = "textPrezimeZaposlenika";
            textPrezimeZaposlenika.Size = new Size(100, 23);
            textPrezimeZaposlenika.TabIndex = 3;
            // 
            // odabirFirmeZaposleniku
            // 
            odabirFirmeZaposleniku.FormattingEnabled = true;
            odabirFirmeZaposleniku.Location = new Point(75, 182);
            odabirFirmeZaposleniku.Name = "odabirFirmeZaposleniku";
            odabirFirmeZaposleniku.Size = new Size(179, 23);
            odabirFirmeZaposleniku.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 61);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 5;
            label2.Text = "Ime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 111);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Prezime";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 161);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 7;
            label4.Text = "Odaberi firmu";
            // 
            // DodajZaposlenika
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 285);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(odabirFirmeZaposleniku);
            Controls.Add(textPrezimeZaposlenika);
            Controls.Add(textImeZaposlenika);
            Controls.Add(butdodajZaposlenikacs2);
            Controls.Add(label1);
            Name = "DodajZaposlenika";
            Text = "DodajZaposlenika";
            Load += DodajZaposlenika_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button butdodajZaposlenikacs2;
        private TextBox textImeZaposlenika;
        private TextBox textPrezimeZaposlenika;
        private ComboBox odabirFirmeZaposleniku;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}