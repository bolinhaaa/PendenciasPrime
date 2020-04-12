using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimePendencias
{
    public partial class homePendencias : Form
    {
        public homePendencias()
        {
            InitializeComponent();
        }

        private void picWebSite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.primecirurgica.com.br/");
        }

        private void picFace_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/primecirurgica");
        }
    }
}
