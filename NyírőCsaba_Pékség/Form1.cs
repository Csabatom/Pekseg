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
                CB_Laktozmentes.Checked = pekaru.laktozmentes;
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
            PeksegUjPekaru ujPekaruForm = new PeksegUjPekaru();
            foreach(var pekaru in LB_Pekaruk.Items)
            {
                ujPekaruForm.COMBO_Pekaruk.Items.Add((Pekaru)pekaru);
            }
            ujPekaruForm.addComboBox();
            ujPekaruForm.Show();
        }

        private void TXTBOX_PekaruAr_TextChanged(object sender, EventArgs e)
        {
            int kurzorPozicio = TXTBOX_PekaruAr.SelectionStart;
            TXTBOX_PekaruAr.Text = new string(TXTBOX_PekaruAr.Text.Where(c => char.IsDigit(c)).ToArray());
            TXTBOX_PekaruAr.SelectionStart = kurzorPozicio;
        }
    }
}
