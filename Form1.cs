using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plannning_ligue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitaliseComboBox();
        }

        public void InitaliseComboBox()
        {
            Type.Items.Add("Initiation");
            Type.Items.Add("Loisir");
            Type.Items.Add("Compétition");

            for(int i=0;i<24;i++)
            {
                HeureD.Items.Add(i);
                HeureF.Items.Add(i);
            }

            for(int i=0;i<60;i=i+15)
            {
                MinuteD.Items.Add(i);
                MinuteF.Items.Add(i);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(HeureD.SelectedItem.ToString());
            string  jour=JourDebut.Value.DayOfWeek.ToString();
            Seance s = new Seance();
            s.ajout(jour, JourDebut.Value, JourFin.Value,HeureD.SelectedItem.ToString(), MinuteD.SelectedItem.ToString(), HeureF.SelectedItem.ToString(), MinuteF.SelectedItem.ToString(), Type.SelectedItem.ToString(), Description.Text);
            MessageBox.Show("Toute vos séances ont bien été enregistré");
            InitaliseComboBox();
        }

    }
}
