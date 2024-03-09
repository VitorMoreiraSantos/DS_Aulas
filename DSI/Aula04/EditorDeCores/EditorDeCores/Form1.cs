using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorDeCores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TrackBarVermelho_Scroll(object sender, EventArgs e)
        {
            Painel.BackColor = Color.FromArgb(TrackBarVermelho.Value, TrackBarVerde.Value, TrackBarAzul.Value);
            label4.Text = TrackBarVermelho.ToString();
        }

        private void TrackBarVerde_Scroll(object sender, EventArgs e)
        {
            Painel.BackColor = Color.FromArgb(TrackBarVermelho.Value, TrackBarVerde.Value, TrackBarAzul.Value);
            label5.Text = TrackBarVerde.ToString();
        }

        private void TrackBarAzul_Scroll(object sender, EventArgs e)
        {
            Painel.BackColor = Color.FromArgb(TrackBarVermelho.Value, TrackBarVerde.Value, TrackBarAzul.Value);
            label6.Text = TrackBarAzul.ToString();
        }
    }
}
