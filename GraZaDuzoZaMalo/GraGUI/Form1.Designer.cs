namespace GraGUI
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.nowaGra = new System.Windows.Forms.Button();
            this.groupboxLosuj = new System.Windows.Forms.GroupBox();
            this.buttonLosowanie = new System.Windows.Forms.Button();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.labeldo = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.labelod = new System.Windows.Forms.Label();
            this.groupboxSprawdz = new System.Windows.Forms.GroupBox();
            this.labelRuch = new System.Windows.Forms.Label();
            this.LiczbaRuchow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Liczba = new System.Windows.Forms.Label();
            this.buttonsprawdzenie = new System.Windows.Forms.Button();
            this.textBoxliczba = new System.Windows.Forms.TextBox();
            this.labelwprowadz = new System.Windows.Forms.Label();
            this.messageboxPoddanie = new System.Windows.Forms.Button();
            this.groupboxLosuj.SuspendLayout();
            this.groupboxSprawdz.SuspendLayout();
            this.SuspendLayout();
            // 
            // nowaGra
            // 
            this.nowaGra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nowaGra.Location = new System.Drawing.Point(16, 13);
            this.nowaGra.Margin = new System.Windows.Forms.Padding(4);
            this.nowaGra.Name = "nowaGra";
            this.nowaGra.Size = new System.Drawing.Size(151, 39);
            this.nowaGra.TabIndex = 0;
            this.nowaGra.Text = "Nowa gra";
            this.nowaGra.UseVisualStyleBackColor = true;
            this.nowaGra.Click += new System.EventHandler(this.NowaGra_Click);
            // 
            // groupboxLosuj
            // 
            this.groupboxLosuj.Controls.Add(this.buttonLosowanie);
            this.groupboxLosuj.Controls.Add(this.textBoxMax);
            this.groupboxLosuj.Controls.Add(this.labeldo);
            this.groupboxLosuj.Controls.Add(this.textBoxMin);
            this.groupboxLosuj.Controls.Add(this.labelod);
            this.groupboxLosuj.Location = new System.Drawing.Point(17, 79);
            this.groupboxLosuj.Margin = new System.Windows.Forms.Padding(4);
            this.groupboxLosuj.Name = "groupboxLosuj";
            this.groupboxLosuj.Padding = new System.Windows.Forms.Padding(4);
            this.groupboxLosuj.Size = new System.Drawing.Size(485, 176);
            this.groupboxLosuj.TabIndex = 1;
            this.groupboxLosuj.TabStop = false;
            this.groupboxLosuj.Text = "Losowanie";
            this.groupboxLosuj.Visible = false;
            this.groupboxLosuj.Enter += new System.EventHandler(this.GroupboxLosuj_Enter);
            // 
            // buttonLosowanie
            // 
            this.buttonLosowanie.Location = new System.Drawing.Point(377, 66);
            this.buttonLosowanie.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLosowanie.Name = "buttonLosowanie";
            this.buttonLosowanie.Size = new System.Drawing.Size(100, 28);
            this.buttonLosowanie.TabIndex = 4;
            this.buttonLosowanie.Text = "Wylosuj";
            this.buttonLosowanie.UseVisualStyleBackColor = true;
            this.buttonLosowanie.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(96, 103);
            this.textBoxMax.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(132, 22);
            this.textBoxMax.TabIndex = 3;
            // 
            // labeldo
            // 
            this.labeldo.AutoSize = true;
            this.labeldo.Location = new System.Drawing.Point(11, 106);
            this.labeldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeldo.Name = "labeldo";
            this.labeldo.Size = new System.Drawing.Size(76, 17);
            this.labeldo.TabIndex = 2;
            this.labeldo.Text = "Zakres do:";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(96, 46);
            this.textBoxMin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(132, 22);
            this.textBoxMin.TabIndex = 1;
            // 
            // labelod
            // 
            this.labelod.AutoSize = true;
            this.labelod.Location = new System.Drawing.Point(11, 49);
            this.labelod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelod.Name = "labelod";
            this.labelod.Size = new System.Drawing.Size(76, 17);
            this.labelod.TabIndex = 0;
            this.labelod.Text = "Zakres od:";
            this.labelod.Click += new System.EventHandler(this.labelod_Click);
            // 
            // groupboxSprawdz
            // 
            this.groupboxSprawdz.Controls.Add(this.labelRuch);
            this.groupboxSprawdz.Controls.Add(this.LiczbaRuchow);
            this.groupboxSprawdz.Controls.Add(this.label2);
            this.groupboxSprawdz.Controls.Add(this.Liczba);
            this.groupboxSprawdz.Controls.Add(this.buttonsprawdzenie);
            this.groupboxSprawdz.Controls.Add(this.textBoxliczba);
            this.groupboxSprawdz.Controls.Add(this.labelwprowadz);
            this.groupboxSprawdz.Location = new System.Drawing.Point(16, 282);
            this.groupboxSprawdz.Margin = new System.Windows.Forms.Padding(4);
            this.groupboxSprawdz.Name = "groupboxSprawdz";
            this.groupboxSprawdz.Padding = new System.Windows.Forms.Padding(4);
            this.groupboxSprawdz.Size = new System.Drawing.Size(486, 259);
            this.groupboxSprawdz.TabIndex = 2;
            this.groupboxSprawdz.TabStop = false;
            this.groupboxSprawdz.Text = "Liczba wylosowana. Odgadnij ją!";
            this.groupboxSprawdz.Visible = false;
            this.groupboxSprawdz.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // labelRuch
            // 
            this.labelRuch.AutoSize = true;
            this.labelRuch.Location = new System.Drawing.Point(13, 134);
            this.labelRuch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRuch.Name = "labelRuch";
            this.labelRuch.Size = new System.Drawing.Size(102, 17);
            this.labelRuch.TabIndex = 6;
            this.labelRuch.Text = "Liczba ruchów:";
            this.labelRuch.Click += new System.EventHandler(this.LabelRuch_Click);
            // 
            // LiczbaRuchow
            // 
            this.LiczbaRuchow.AutoSize = true;
            this.LiczbaRuchow.Location = new System.Drawing.Point(139, 134);
            this.LiczbaRuchow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LiczbaRuchow.Name = "LiczbaRuchow";
            this.LiczbaRuchow.Size = new System.Drawing.Size(0, 17);
            this.LiczbaRuchow.TabIndex = 5;
            this.LiczbaRuchow.Visible = false;
            this.LiczbaRuchow.Click += new System.EventHandler(this.LiczbaRuchow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Szukana liczba:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Liczba
            // 
            this.Liczba.AutoSize = true;
            this.Liczba.Location = new System.Drawing.Point(139, 103);
            this.Liczba.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Liczba.Name = "Liczba";
            this.Liczba.Size = new System.Drawing.Size(0, 17);
            this.Liczba.TabIndex = 3;
            this.Liczba.Visible = false;
            this.Liczba.Click += new System.EventHandler(this.Liczba_Click);
            // 
            // buttonsprawdzenie
            // 
            this.buttonsprawdzenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonsprawdzenie.Location = new System.Drawing.Point(369, 60);
            this.buttonsprawdzenie.Margin = new System.Windows.Forms.Padding(4);
            this.buttonsprawdzenie.Name = "buttonsprawdzenie";
            this.buttonsprawdzenie.Size = new System.Drawing.Size(109, 48);
            this.buttonsprawdzenie.TabIndex = 2;
            this.buttonsprawdzenie.Text = "Sprawdź";
            this.buttonsprawdzenie.UseVisualStyleBackColor = true;
            this.buttonsprawdzenie.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // textBoxliczba
            // 
            this.textBoxliczba.Location = new System.Drawing.Point(138, 60);
            this.textBoxliczba.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxliczba.Name = "textBoxliczba";
            this.textBoxliczba.Size = new System.Drawing.Size(125, 22);
            this.textBoxliczba.TabIndex = 1;
            // 
            // labelwprowadz
            // 
            this.labelwprowadz.AutoSize = true;
            this.labelwprowadz.Location = new System.Drawing.Point(12, 60);
            this.labelwprowadz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelwprowadz.Name = "labelwprowadz";
            this.labelwprowadz.Size = new System.Drawing.Size(118, 17);
            this.labelwprowadz.TabIndex = 0;
            this.labelwprowadz.Text = "Wprowadź liczbę:";
            // 
            // messageboxPoddanie
            // 
            this.messageboxPoddanie.Location = new System.Drawing.Point(351, 13);
            this.messageboxPoddanie.Margin = new System.Windows.Forms.Padding(4);
            this.messageboxPoddanie.Name = "messageboxPoddanie";
            this.messageboxPoddanie.Size = new System.Drawing.Size(151, 39);
            this.messageboxPoddanie.TabIndex = 3;
            this.messageboxPoddanie.Text = "Przerwij";
            this.messageboxPoddanie.UseVisualStyleBackColor = true;
            this.messageboxPoddanie.Visible = false;
            this.messageboxPoddanie.Click += new System.EventHandler(this.PoddanieGry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(515, 554);
            this.Controls.Add(this.messageboxPoddanie);
            this.Controls.Add(this.groupboxSprawdz);
            this.Controls.Add(this.groupboxLosuj);
            this.Controls.Add(this.nowaGra);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Za Dużo Za Mało";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupboxLosuj.ResumeLayout(false);
            this.groupboxLosuj.PerformLayout();
            this.groupboxSprawdz.ResumeLayout(false);
            this.groupboxSprawdz.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nowaGra;
        private System.Windows.Forms.GroupBox groupboxLosuj;
        private System.Windows.Forms.Label labelod;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label labeldo;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Button buttonLosowanie;
        private System.Windows.Forms.GroupBox groupboxSprawdz;
        private System.Windows.Forms.TextBox textBoxliczba;
        private System.Windows.Forms.Label labelwprowadz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Liczba;
        private System.Windows.Forms.Button messageboxPoddanie;
        private System.Windows.Forms.Label labelRuch;
        private System.Windows.Forms.Label LiczbaRuchow;
        private System.Windows.Forms.Button buttonsprawdzenie;
    }
}

