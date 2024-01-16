namespace RadnoVrijeme
{
    partial class DodajFirmu
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
            textNazivFirme = new TextBox();
            textPocetakRadnogVremena = new TextBox();
            textKrajRadnogVremena = new TextBox();
            label1 = new Label();
            dodajFirmucs2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textPocetakRadnogVremena2 = new TextBox();
            textKrajRadnogVremena2 = new TextBox();
            SuspendLayout();
            // 
            // textNazivFirme
            // 
            textNazivFirme.Location = new Point(110, 109);
            textNazivFirme.Name = "textNazivFirme";
            textNazivFirme.Size = new Size(100, 23);
            textNazivFirme.TabIndex = 0;
            // 
            // textPocetakRadnogVremena
            // 
            textPocetakRadnogVremena.Location = new Point(26, 167);
            textPocetakRadnogVremena.Name = "textPocetakRadnogVremena";
            textPocetakRadnogVremena.Size = new Size(100, 23);
            textPocetakRadnogVremena.TabIndex = 1;
            // 
            // textKrajRadnogVremena
            // 
            textKrajRadnogVremena.Location = new Point(187, 167);
            textKrajRadnogVremena.Name = "textKrajRadnogVremena";
            textKrajRadnogVremena.Size = new Size(100, 23);
            textKrajRadnogVremena.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 35);
            label1.Name = "label1";
            label1.Size = new Size(158, 37);
            label1.TabIndex = 3;
            label1.Text = "Dodaj firmu";
            // 
            // dodajFirmucs2
            // 
            dodajFirmucs2.Location = new Point(110, 250);
            dodajFirmucs2.Name = "dodajFirmucs2";
            dodajFirmucs2.Size = new Size(100, 23);
            dodajFirmucs2.TabIndex = 4;
            dodajFirmucs2.Text = "Dodaj firmu";
            dodajFirmucs2.UseVisualStyleBackColor = true;
            dodajFirmucs2.Click += dodajFirmucs2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 91);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 5;
            label2.Text = "Naziv firme";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 149);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 6;
            label3.Text = "Početak radnog vremena";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(187, 149);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 7;
            label4.Text = "Kraj radnog vremena";
            // 
            // textPocetakRadnogVremena2
            // 
            textPocetakRadnogVremena2.Location = new Point(26, 196);
            textPocetakRadnogVremena2.Name = "textPocetakRadnogVremena2";
            textPocetakRadnogVremena2.Size = new Size(100, 23);
            textPocetakRadnogVremena2.TabIndex = 1;
            // 
            // textKrajRadnogVremena2
            // 
            textKrajRadnogVremena2.Location = new Point(187, 196);
            textKrajRadnogVremena2.Name = "textKrajRadnogVremena2";
            textKrajRadnogVremena2.Size = new Size(100, 23);
            textKrajRadnogVremena2.TabIndex = 2;
            // 
            // DodajFirmu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 326);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dodajFirmucs2);
            Controls.Add(label1);
            Controls.Add(textKrajRadnogVremena2);
            Controls.Add(textKrajRadnogVremena);
            Controls.Add(textPocetakRadnogVremena2);
            Controls.Add(textPocetakRadnogVremena);
            Controls.Add(textNazivFirme);
            Name = "DodajFirmu";
            Text = "DodajFirmu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNazivFirme;
        private TextBox textPocetakRadnogVremena;
        private TextBox textKrajRadnogVremena;
        private Label label1;
        private Button dodajFirmucs2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textPocetakRadnogVremena2;
        private TextBox textKrajRadnogVremena2;
    }
}