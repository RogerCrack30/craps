using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class btnTirar : Form
    {

        Random dado = new Random();
        Boolean jugada = false;

        



        public btnTirar()
        {
            InitializeComponent();
        }

        private void btnTirar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           

            int tira1 = dado.Next(1,7);
            int tira2 = dado.Next(1,7);

        }
    }
}
