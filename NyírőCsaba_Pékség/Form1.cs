using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyírőCsaba_Pékség
{
    public partial class Form1 : Form
    {
        public static List<Pekseg> peksegek = new List<Pekseg>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_PekaruHozzaadas_Click(object sender, EventArgs e)
        {
            try
            {
                Pekaru pekaru = new Pekaru(TXTBOX_PekaruNev.Text, int.Parse(TXTBOX_PekaruAr.Text), CB_Laktozmentes.Checked);
                if (BTN_PekaruHozzaadas.Text == "Hozzáadás")
                {
                    LB_Pekaruk.Items.Add(pekaru);
                } else
                {
                    int index = LB_Pekaruk.SelectedIndex;
                    foreach(var pekseg in peksegek)
                    {
                        if(pekseg.Pekaruk.Contains(LB_Pekaruk.Items[index]))
                        {
                            pekseg.Pekaruk.Insert(pekseg.Pekaruk.IndexOf((Pekaru)LB_Pekaruk.Items[index]), pekaru);
                            pekseg.Pekaruk.Remove((Pekaru)LB_Pekaruk.Items[index]);
                        }
                    }
                    LB_Pekaruk.Items.RemoveAt(index);
                    LB_Pekaruk.Items.Insert(index, pekaru);
                }
                TXTBOX_PekaruNev.Text = "Pékáru neve";
                TXTBOX_PekaruNev.ForeColor = Color.Silver;
                TXTBOX_PekaruAr.Text = "Pékáru ára (Ft/db)";
                TXTBOX_PekaruAr.ForeColor = Color.Silver;
                CB_Laktozmentes.Checked = false;
            } catch (Exception err)
            {
                MessageBox.Show("Nem vehető fel a pékáru!\n\nHibakód: " + err);
            }
        }

        private void TXTBOX_PekaruNev_FocusEnter(object sender, EventArgs e)
        {
            if (TXTBOX_PekaruNev.Text == "Pékáru neve" && TXTBOX_PekaruNev.ForeColor == Color.Silver)
            {
                TXTBOX_PekaruNev.Text = "";
                TXTBOX_PekaruNev.ForeColor = Color.Black;
            }
        }

        private void TXTBOX_PekaruNev_FocusLeave(object sender, EventArgs e)
        {
            if (TXTBOX_PekaruNev.Text == "")
            {
                TXTBOX_PekaruNev.Text = "Pékáru neve";
                TXTBOX_PekaruNev.ForeColor = Color.Silver;
            }
        }

        private void TXTBOX_PekaruAr_FocusEnter(object sender, EventArgs e)
        {
            if (TXTBOX_PekaruAr.Text == "Pékáru ára (Ft/db)" && TXTBOX_PekaruAr.ForeColor == Color.Silver)
            {
                TXTBOX_PekaruAr.Text = "";
                TXTBOX_PekaruAr.ForeColor = Color.Black;
            }
        }

        private void TXTBOX_PekaruAr_FocusLeave(object sender, EventArgs e)
        {
            if (TXTBOX_PekaruAr.Text == "")
            {
                TXTBOX_PekaruAr.Text = "Pékáru ára (Ft/db)";
                TXTBOX_PekaruAr.ForeColor = Color.Silver;
            }
        }

        private void LB_Pekaruk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LB_Pekaruk.SelectedIndex != -1)
            {
                Pekaru pekaru = (Pekaru)LB_Pekaruk.SelectedItem;
                TXTBOX_PekaruNev.Text = pekaru.Nev;
                TXTBOX_PekaruAr.Text = pekaru.Ar.ToString();
                CB_Laktozmentes.Checked = pekaru.Laktozmentes;
                TXTBOX_PekaruNev.ForeColor = Color.Black;
                TXTBOX_PekaruAr.ForeColor = Color.Black;

                BTN_PekaruHozzaadas.Text = "Módosítás";
            } else
            {
                TXTBOX_PekaruNev.Text = "Pékáru neve";
                TXTBOX_PekaruNev.ForeColor = Color.Silver;
                TXTBOX_PekaruAr.Text = "Pékáru ára (Ft/db)";
                TXTBOX_PekaruAr.ForeColor = Color.Silver;
                CB_Laktozmentes.Checked = false;

                BTN_PekaruHozzaadas.Text = "Hozzáadás";
            }
        }

        private void BTN_PekaruTorles_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(var pekseg in peksegek)
                {
                    if(pekseg.Pekaruk.Contains(LB_Pekaruk.Items[LB_Pekaruk.SelectedIndex]))
                    {
                        pekseg.Pekaruk.Remove((Pekaru)LB_Pekaruk.Items[LB_Pekaruk.SelectedIndex]);
                    }
                }
                LB_Pekaruk.Items.RemoveAt(LB_Pekaruk.SelectedIndex);
            } catch (Exception err)
            {
                MessageBox.Show("Nincs kiválasztva pékáru!\n\nHibakód: " + err);
            }
        }

        private void BTN_UjPekaru_Click(object sender, EventArgs e)
        {
            TXTBOX_PekaruNev.Text = "Pékáru neve";
            TXTBOX_PekaruNev.ForeColor = Color.Silver;
            TXTBOX_PekaruAr.Text = "Pékáru ára (Ft/db)";
            TXTBOX_PekaruAr.ForeColor = Color.Silver;
            CB_Laktozmentes.Checked = false;

            BTN_PekaruHozzaadas.Text = "Hozzáadás";
        }

        private void BTN_PeksegUjTermek_Click(object sender, EventArgs e)
        {
            PeksegUjPekaru ujPekaruForm = new PeksegUjPekaru(LB_PeksegAdatokOldal.SelectedIndex);
            foreach(var pekaru in LB_Pekaruk.Items)
            {
                if(!peksegek[LB_PeksegAdatokOldal.SelectedIndex].Pekaruk.Contains(pekaru))
                {
                    ujPekaruForm.COMBO_Pekaruk.Items.Add((Pekaru)pekaru);
                }
            }
            if(ujPekaruForm.COMBO_Pekaruk.Items.Count > 0)
            {
                ujPekaruForm.addComboBox();
                ujPekaruForm.Show();
            } else
            {
                MessageBox.Show("A pékség minden pékárut tartalmaz!");
            }
        }

        private void TXTBOX_PekaruAr_TextChanged(object sender, EventArgs e)
        {
            if(TXTBOX_PekaruAr.Focused)
            {
                int kurzorPozicio = TXTBOX_PekaruAr.SelectionStart;
                TXTBOX_PekaruAr.Text = new string(TXTBOX_PekaruAr.Text.Where(c => char.IsDigit(c)).ToArray());
                TXTBOX_PekaruAr.SelectionStart = kurzorPozicio;
            }
        }

        private void BTN_PeksegHozzaadas_Click(object sender, EventArgs e)
        {
            if(TXTBOX_PeksegNev.ForeColor != Color.Silver)
            {
                Pekseg pekseg = new Pekseg(TXTBOX_PeksegNev.Text, DateTime.Now);
                peksegek.Add(pekseg);
                LB_PeksegAdatokOldal.Items.Add(pekseg);
                TXTBOX_PeksegNev.Text = "Pékség neve";
                TXTBOX_PeksegNev.ForeColor = Color.Silver;
            } else
            {
                MessageBox.Show("Adja meg a pékség nevét!");
            }
        }

        private void TXTBOX_PeksegNev_FocusEnter(object sender, EventArgs e)
        {
            if (TXTBOX_PeksegNev.Text == "Pékség neve" && TXTBOX_PeksegNev.ForeColor == Color.Silver)
            {
                TXTBOX_PeksegNev.Text = "";
                TXTBOX_PeksegNev.ForeColor = Color.Black;
            }
        }

        private void TXTBOX_PeksegNev_FocusLeave(object sender, EventArgs e)
        {
            if (TXTBOX_PeksegNev.Text == "")
            {
                TXTBOX_PeksegNev.Text = "Pékség neve";
                TXTBOX_PeksegNev.ForeColor = Color.Silver;
            }
        }

        private void LB_PeksegAdatokOldal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LB_PeksegAdatokOldal.SelectedIndex == -1)
            {
                BTN_PeksegUjTermek.Enabled = false;
            } else
            {
                BTN_PeksegUjTermek.Enabled = true;
            }
            LB_PeksegTermekei.Items.Clear();
            if(LB_PeksegAdatokOldal.SelectedIndex != -1 && peksegek[LB_PeksegAdatokOldal.SelectedIndex].Pekaruk != null)
            {
                foreach (var peksegPekaru in peksegek[LB_PeksegAdatokOldal.SelectedIndex].Pekaruk)
                {
                    LB_PeksegTermekei.Items.Add(peksegPekaru);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                LB_PeksegTermekei.Items.Clear();
                if (peksegek[LB_PeksegAdatokOldal.SelectedIndex].Pekaruk.Count > LB_PeksegTermekei.Items.Count)
                {
                    foreach (var peksegPekaru in peksegek[LB_PeksegAdatokOldal.SelectedIndex].Pekaruk)
                    {
                        LB_PeksegTermekei.Items.Add(peksegPekaru);
                    }
                }
            } catch (Exception err) { }

            if(TXTBOX_PekaruNev.ForeColor == Color.Silver && TXTBOX_PekaruAr.ForeColor == Color.Silver && CB_Laktozmentes.Checked == false)
            {
                LB_Pekaruk.SelectedIndex = -1;
                BTN_PekaruHozzaadas.Text = "Hozzáadás";
            }
        }
    }
}
