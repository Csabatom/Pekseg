namespace NyírőCsaba_Pékség
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_PeksegUjTermek = new System.Windows.Forms.Button();
            this.LB_PeksegAdatokOldal = new System.Windows.Forms.ListBox();
            this.LB_PeksegTermekei = new System.Windows.Forms.ListBox();
            this.BTN_PeksegHozzaadas = new System.Windows.Forms.Button();
            this.TXTBOX_PeksegNev = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_UjPekaru = new System.Windows.Forms.Button();
            this.BTN_PekaruTorles = new System.Windows.Forms.Button();
            this.LB_Pekaruk = new System.Windows.Forms.ListBox();
            this.CB_Laktozmentes = new System.Windows.Forms.CheckBox();
            this.BTN_PekaruHozzaadas = new System.Windows.Forms.Button();
            this.TXTBOX_PekaruAr = new System.Windows.Forms.TextBox();
            this.TXTBOX_PekaruNev = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LBL_LegdragabbTermek = new System.Windows.Forms.Label();
            this.LBL_LaktozmentesTermekek = new System.Windows.Forms.Label();
            this.LBL_LegolcsobbTermek = new System.Windows.Forms.Label();
            this.LBL_AtlagAr = new System.Windows.Forms.Label();
            this.LBL_PekaruDarab = new System.Windows.Forms.Label();
            this.LBL_AlapitasDatum = new System.Windows.Forms.Label();
            this.LBL_PeksegNev = new System.Windows.Forms.Label();
            this.LB_PeksegekStatisztikakOldal = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adatok";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_PeksegUjTermek);
            this.groupBox2.Controls.Add(this.LB_PeksegAdatokOldal);
            this.groupBox2.Controls.Add(this.LB_PeksegTermekei);
            this.groupBox2.Controls.Add(this.BTN_PeksegHozzaadas);
            this.groupBox2.Controls.Add(this.TXTBOX_PeksegNev);
            this.groupBox2.Location = new System.Drawing.Point(9, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 236);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pékségek";
            // 
            // BTN_PeksegUjTermek
            // 
            this.BTN_PeksegUjTermek.Enabled = false;
            this.BTN_PeksegUjTermek.Location = new System.Drawing.Point(624, 186);
            this.BTN_PeksegUjTermek.Name = "BTN_PeksegUjTermek";
            this.BTN_PeksegUjTermek.Size = new System.Drawing.Size(75, 23);
            this.BTN_PeksegUjTermek.TabIndex = 6;
            this.BTN_PeksegUjTermek.Text = "+";
            this.BTN_PeksegUjTermek.UseVisualStyleBackColor = true;
            this.BTN_PeksegUjTermek.Click += new System.EventHandler(this.BTN_PeksegUjTermek_Click);
            // 
            // LB_PeksegAdatokOldal
            // 
            this.LB_PeksegAdatokOldal.FormattingEnabled = true;
            this.LB_PeksegAdatokOldal.ItemHeight = 16;
            this.LB_PeksegAdatokOldal.Location = new System.Drawing.Point(333, 21);
            this.LB_PeksegAdatokOldal.Name = "LB_PeksegAdatokOldal";
            this.LB_PeksegAdatokOldal.Size = new System.Drawing.Size(215, 212);
            this.LB_PeksegAdatokOldal.TabIndex = 5;
            this.LB_PeksegAdatokOldal.SelectedIndexChanged += new System.EventHandler(this.LB_PeksegAdatokOldal_SelectedIndexChanged);
            // 
            // LB_PeksegTermekei
            // 
            this.LB_PeksegTermekei.FormattingEnabled = true;
            this.LB_PeksegTermekei.ItemHeight = 16;
            this.LB_PeksegTermekei.Location = new System.Drawing.Point(554, 21);
            this.LB_PeksegTermekei.Name = "LB_PeksegTermekei";
            this.LB_PeksegTermekei.Size = new System.Drawing.Size(215, 132);
            this.LB_PeksegTermekei.TabIndex = 4;
            // 
            // BTN_PeksegHozzaadas
            // 
            this.BTN_PeksegHozzaadas.Location = new System.Drawing.Point(5, 50);
            this.BTN_PeksegHozzaadas.Name = "BTN_PeksegHozzaadas";
            this.BTN_PeksegHozzaadas.Size = new System.Drawing.Size(98, 23);
            this.BTN_PeksegHozzaadas.TabIndex = 3;
            this.BTN_PeksegHozzaadas.Text = "Hozzáadás";
            this.BTN_PeksegHozzaadas.UseVisualStyleBackColor = true;
            this.BTN_PeksegHozzaadas.Click += new System.EventHandler(this.BTN_PeksegHozzaadas_Click);
            // 
            // TXTBOX_PeksegNev
            // 
            this.TXTBOX_PeksegNev.ForeColor = System.Drawing.Color.Silver;
            this.TXTBOX_PeksegNev.Location = new System.Drawing.Point(5, 21);
            this.TXTBOX_PeksegNev.Name = "TXTBOX_PeksegNev";
            this.TXTBOX_PeksegNev.Size = new System.Drawing.Size(144, 22);
            this.TXTBOX_PeksegNev.TabIndex = 2;
            this.TXTBOX_PeksegNev.Text = "Pékség neve";
            this.TXTBOX_PeksegNev.Enter += new System.EventHandler(this.TXTBOX_PeksegNev_FocusEnter);
            this.TXTBOX_PeksegNev.Leave += new System.EventHandler(this.TXTBOX_PeksegNev_FocusLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_UjPekaru);
            this.groupBox1.Controls.Add(this.BTN_PekaruTorles);
            this.groupBox1.Controls.Add(this.LB_Pekaruk);
            this.groupBox1.Controls.Add(this.CB_Laktozmentes);
            this.groupBox1.Controls.Add(this.BTN_PekaruHozzaadas);
            this.groupBox1.Controls.Add(this.TXTBOX_PekaruAr);
            this.groupBox1.Controls.Add(this.TXTBOX_PekaruNev);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pékáruk";
            // 
            // BTN_UjPekaru
            // 
            this.BTN_UjPekaru.Location = new System.Drawing.Point(185, 13);
            this.BTN_UjPekaru.Name = "BTN_UjPekaru";
            this.BTN_UjPekaru.Size = new System.Drawing.Size(99, 64);
            this.BTN_UjPekaru.TabIndex = 6;
            this.BTN_UjPekaru.Text = "Új pékáru";
            this.BTN_UjPekaru.UseVisualStyleBackColor = true;
            this.BTN_UjPekaru.Click += new System.EventHandler(this.BTN_UjPekaru_Click);
            // 
            // BTN_PekaruTorles
            // 
            this.BTN_PekaruTorles.Location = new System.Drawing.Point(185, 83);
            this.BTN_PekaruTorles.Name = "BTN_PekaruTorles";
            this.BTN_PekaruTorles.Size = new System.Drawing.Size(99, 78);
            this.BTN_PekaruTorles.TabIndex = 5;
            this.BTN_PekaruTorles.Text = "Törlés";
            this.BTN_PekaruTorles.UseVisualStyleBackColor = true;
            this.BTN_PekaruTorles.Click += new System.EventHandler(this.BTN_PekaruTorles_Click);
            // 
            // LB_Pekaruk
            // 
            this.LB_Pekaruk.FormattingEnabled = true;
            this.LB_Pekaruk.ItemHeight = 16;
            this.LB_Pekaruk.Location = new System.Drawing.Point(290, 13);
            this.LB_Pekaruk.Name = "LB_Pekaruk";
            this.LB_Pekaruk.Size = new System.Drawing.Size(481, 148);
            this.LB_Pekaruk.TabIndex = 4;
            this.LB_Pekaruk.SelectedIndexChanged += new System.EventHandler(this.LB_Pekaruk_SelectedIndexChanged);
            // 
            // CB_Laktozmentes
            // 
            this.CB_Laktozmentes.AutoSize = true;
            this.CB_Laktozmentes.Location = new System.Drawing.Point(7, 79);
            this.CB_Laktozmentes.Name = "CB_Laktozmentes";
            this.CB_Laktozmentes.Size = new System.Drawing.Size(118, 21);
            this.CB_Laktozmentes.TabIndex = 3;
            this.CB_Laktozmentes.Text = "Laktózmentes";
            this.CB_Laktozmentes.UseVisualStyleBackColor = true;
            // 
            // BTN_PekaruHozzaadas
            // 
            this.BTN_PekaruHozzaadas.Location = new System.Drawing.Point(7, 112);
            this.BTN_PekaruHozzaadas.Name = "BTN_PekaruHozzaadas";
            this.BTN_PekaruHozzaadas.Size = new System.Drawing.Size(98, 23);
            this.BTN_PekaruHozzaadas.TabIndex = 2;
            this.BTN_PekaruHozzaadas.Text = "Hozzáadás";
            this.BTN_PekaruHozzaadas.UseVisualStyleBackColor = true;
            this.BTN_PekaruHozzaadas.Click += new System.EventHandler(this.BTN_PekaruHozzaadas_Click);
            // 
            // TXTBOX_PekaruAr
            // 
            this.TXTBOX_PekaruAr.ForeColor = System.Drawing.Color.Silver;
            this.TXTBOX_PekaruAr.Location = new System.Drawing.Point(7, 50);
            this.TXTBOX_PekaruAr.Name = "TXTBOX_PekaruAr";
            this.TXTBOX_PekaruAr.Size = new System.Drawing.Size(144, 22);
            this.TXTBOX_PekaruAr.TabIndex = 1;
            this.TXTBOX_PekaruAr.Text = "Pékáru ára (Ft/db)";
            this.TXTBOX_PekaruAr.TextChanged += new System.EventHandler(this.TXTBOX_PekaruAr_TextChanged);
            this.TXTBOX_PekaruAr.Enter += new System.EventHandler(this.TXTBOX_PekaruAr_FocusEnter);
            this.TXTBOX_PekaruAr.Leave += new System.EventHandler(this.TXTBOX_PekaruAr_FocusLeave);
            // 
            // TXTBOX_PekaruNev
            // 
            this.TXTBOX_PekaruNev.ForeColor = System.Drawing.Color.Silver;
            this.TXTBOX_PekaruNev.Location = new System.Drawing.Point(7, 22);
            this.TXTBOX_PekaruNev.Name = "TXTBOX_PekaruNev";
            this.TXTBOX_PekaruNev.Size = new System.Drawing.Size(144, 22);
            this.TXTBOX_PekaruNev.TabIndex = 0;
            this.TXTBOX_PekaruNev.Text = "Pékáru neve";
            this.TXTBOX_PekaruNev.Enter += new System.EventHandler(this.TXTBOX_PekaruNev_FocusEnter);
            this.TXTBOX_PekaruNev.Leave += new System.EventHandler(this.TXTBOX_PekaruNev_FocusLeave);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LBL_LegdragabbTermek);
            this.tabPage2.Controls.Add(this.LBL_LaktozmentesTermekek);
            this.tabPage2.Controls.Add(this.LBL_LegolcsobbTermek);
            this.tabPage2.Controls.Add(this.LBL_AtlagAr);
            this.tabPage2.Controls.Add(this.LBL_PekaruDarab);
            this.tabPage2.Controls.Add(this.LBL_AlapitasDatum);
            this.tabPage2.Controls.Add(this.LBL_PeksegNev);
            this.tabPage2.Controls.Add(this.LB_PeksegekStatisztikakOldal);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Statisztikák";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LBL_LegdragabbTermek
            // 
            this.LBL_LegdragabbTermek.AutoSize = true;
            this.LBL_LegdragabbTermek.Location = new System.Drawing.Point(263, 110);
            this.LBL_LegdragabbTermek.Name = "LBL_LegdragabbTermek";
            this.LBL_LegdragabbTermek.Size = new System.Drawing.Size(140, 17);
            this.LBL_LegdragabbTermek.TabIndex = 7;
            this.LBL_LegdragabbTermek.Text = "Legdrágább termék: ";
            // 
            // LBL_LaktozmentesTermekek
            // 
            this.LBL_LaktozmentesTermekek.AutoSize = true;
            this.LBL_LaktozmentesTermekek.Location = new System.Drawing.Point(263, 127);
            this.LBL_LaktozmentesTermekek.Name = "LBL_LaktozmentesTermekek";
            this.LBL_LaktozmentesTermekek.Size = new System.Drawing.Size(166, 17);
            this.LBL_LaktozmentesTermekek.TabIndex = 6;
            this.LBL_LaktozmentesTermekek.Text = "Laktózmentes termékek: ";
            // 
            // LBL_LegolcsobbTermek
            // 
            this.LBL_LegolcsobbTermek.AutoSize = true;
            this.LBL_LegolcsobbTermek.Location = new System.Drawing.Point(263, 93);
            this.LBL_LegolcsobbTermek.Name = "LBL_LegolcsobbTermek";
            this.LBL_LegolcsobbTermek.Size = new System.Drawing.Size(136, 17);
            this.LBL_LegolcsobbTermek.TabIndex = 5;
            this.LBL_LegolcsobbTermek.Text = "Legolcsóbb termék: ";
            // 
            // LBL_AtlagAr
            // 
            this.LBL_AtlagAr.AutoSize = true;
            this.LBL_AtlagAr.Location = new System.Drawing.Point(263, 76);
            this.LBL_AtlagAr.Name = "LBL_AtlagAr";
            this.LBL_AtlagAr.Size = new System.Drawing.Size(80, 17);
            this.LBL_AtlagAr.TabIndex = 4;
            this.LBL_AtlagAr.Text = "Átlagos ár: ";
            // 
            // LBL_PekaruDarab
            // 
            this.LBL_PekaruDarab.AutoSize = true;
            this.LBL_PekaruDarab.Location = new System.Drawing.Point(263, 59);
            this.LBL_PekaruDarab.Name = "LBL_PekaruDarab";
            this.LBL_PekaruDarab.Size = new System.Drawing.Size(68, 17);
            this.LBL_PekaruDarab.TabIndex = 3;
            this.LBL_PekaruDarab.Text = "Pékáruk: ";
            // 
            // LBL_AlapitasDatum
            // 
            this.LBL_AlapitasDatum.AutoSize = true;
            this.LBL_AlapitasDatum.Location = new System.Drawing.Point(263, 24);
            this.LBL_AlapitasDatum.Name = "LBL_AlapitasDatum";
            this.LBL_AlapitasDatum.Size = new System.Drawing.Size(66, 17);
            this.LBL_AlapitasDatum.TabIndex = 2;
            this.LBL_AlapitasDatum.Text = "Alapítva: ";
            // 
            // LBL_PeksegNev
            // 
            this.LBL_PeksegNev.AutoSize = true;
            this.LBL_PeksegNev.Location = new System.Drawing.Point(263, 7);
            this.LBL_PeksegNev.Name = "LBL_PeksegNev";
            this.LBL_PeksegNev.Size = new System.Drawing.Size(90, 17);
            this.LBL_PeksegNev.TabIndex = 1;
            this.LBL_PeksegNev.Text = "Pékség neve";
            // 
            // LB_PeksegekStatisztikakOldal
            // 
            this.LB_PeksegekStatisztikakOldal.FormattingEnabled = true;
            this.LB_PeksegekStatisztikakOldal.ItemHeight = 16;
            this.LB_PeksegekStatisztikakOldal.Location = new System.Drawing.Point(8, 6);
            this.LB_PeksegekStatisztikakOldal.Name = "LB_PeksegekStatisztikakOldal";
            this.LB_PeksegekStatisztikakOldal.Size = new System.Drawing.Size(248, 244);
            this.LB_PeksegekStatisztikakOldal.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_PeksegUjTermek;
        private System.Windows.Forms.ListBox LB_PeksegAdatokOldal;
        private System.Windows.Forms.ListBox LB_PeksegTermekei;
        private System.Windows.Forms.Button BTN_PeksegHozzaadas;
        private System.Windows.Forms.TextBox TXTBOX_PeksegNev;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LB_Pekaruk;
        private System.Windows.Forms.CheckBox CB_Laktozmentes;
        private System.Windows.Forms.Button BTN_PekaruHozzaadas;
        private System.Windows.Forms.TextBox TXTBOX_PekaruAr;
        private System.Windows.Forms.TextBox TXTBOX_PekaruNev;
        private System.Windows.Forms.Label LBL_LegdragabbTermek;
        private System.Windows.Forms.Label LBL_LaktozmentesTermekek;
        private System.Windows.Forms.Label LBL_LegolcsobbTermek;
        private System.Windows.Forms.Label LBL_AtlagAr;
        private System.Windows.Forms.Label LBL_PekaruDarab;
        private System.Windows.Forms.Label LBL_AlapitasDatum;
        private System.Windows.Forms.Label LBL_PeksegNev;
        private System.Windows.Forms.ListBox LB_PeksegekStatisztikakOldal;
        private System.Windows.Forms.Button BTN_PekaruTorles;
        private System.Windows.Forms.Button BTN_UjPekaru;
        private System.Windows.Forms.Timer timer1;
    }
}

