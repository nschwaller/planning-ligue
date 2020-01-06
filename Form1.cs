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
            MessageBox.Show(JourDebut.Value.DayOfWeek.ToString());
            MessageBox.Show(JourDebut.Value.ToString("yyyy/MM/dd"));

        }
    }
}
