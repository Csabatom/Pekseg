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
    public partial class PeksegUjPekaru : Form
    {
        public Pekaru pekaru;
        public ComboBox COMBO_Pekaruk = new ComboBox();

        public PeksegUjPekaru()
        {
            InitializeComponent();
        }

        private void BTN_PekaruHozzaadas_Click(object sender, EventArgs e)
        {
            pekaru = (Pekaru)COMBO_Pekaruk.SelectedItem;
            if(pekaru != null)
            {
                this.Close();
            } else
            {
                MessageBox.Show("Nincs kiválasztva pékáru!");
            }
        }

        private void COMBO_Pekaruk_SelectedIndexChanged(object sender, EventArgs e)
        {
            COMBO_Pekaruk.ForeColor = Color.Black;
        }



        public void addComboBox()
        {
            COMBO_Pekaruk.Location = new Point(12, 12);
            COMBO_Pekaruk.Size = new Size(160, 24);
            COMBO_Pekaruk.Name = "COMBO_Pekaruk";
            COMBO_Pekaruk.Text = "Válassz pékárut!";
            COMBO_Pekaruk.ForeColor = Color.Silver;
            COMBO_Pekaruk.SelectedIndexChanged += COMBO_Pekaruk_SelectedIndexChanged;
            COMBO_Pekaruk.GotFocus += COMBO_Pekaruk_GotFocus;
            COMBO_Pekaruk.LostFocus += COMBO_Pekaruk_LostFocus;
            this.Controls.Add(COMBO_Pekaruk);
        }

        private void COMBO_Pekaruk_LostFocus(object sender, EventArgs e)
        {
            if (COMBO_Pekaruk.SelectedIndex == -1)
            {
                COMBO_Pekaruk.Text = "Válassz pékárut!";
                COMBO_Pekaruk.ForeColor = Color.Silver;
            }
        }

        private void COMBO_Pekaruk_GotFocus(object sender, EventArgs e)
        {
            if(COMBO_Pekaruk.ForeColor == Color.Silver)
            {
                COMBO_Pekaruk.Text = "";
                COMBO_Pekaruk.ForeColor = Color.Black;
            }
        }
    }
}
