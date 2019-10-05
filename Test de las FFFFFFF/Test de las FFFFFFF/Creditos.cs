using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_de_las_FFFFFFF
{
    public partial class Creditos : Form
    {
        private OpenFileDialog ofd;
        public Creditos() 
        {
            InitializeComponent();
            ofd = new OpenFileDialog();
            ofd.Filter = "Archivo de Audio (*.wav)|*.wav";
        }
        //LOS CREDITOS VAN AQUI, AGREGA ALGO SI LO REQUIERES
        private void BtnExit_Click(object sender, EventArgs e)
        { //BOTON PARA SALIR, NO REQUIERE MODIFICACIONES
            Application.Exit();
        }
        #region labels2
        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void Creditos_Load(object sender, EventArgs e) //BORRAR SI NO FUNCIONA
        {
            
        }

       

        #region labels
        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
