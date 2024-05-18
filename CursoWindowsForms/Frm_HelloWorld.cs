using System;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_HelloWorld : Form
    {
        public Frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ModificaLabel_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Label modificada";
        }

        private void txt_ConteudoLabel_TextChanged(object sender, EventArgs e)
        {
            lbl_Titulo.Text = txt_ConteudoLabel.Text;
        }
    }
}
