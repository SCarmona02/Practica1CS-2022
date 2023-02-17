using System;

using System.Windows.Forms;

//Librerias propias
using libPractica1;

namespace appPractica1
{
    public partial class frmHallarArea : Form
    {
        public frmHallarArea() //Constructor del form
        {
            InitializeComponent();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtLadoA.Clear();
            this.txtLadoB.Text = string.Empty;
            this.txtLadoC.Text = string.Empty;
            this.gpbArea.Visible = false;
            this.txtLadoA.Focus();
        }

        private void btnHallarArea_Click(object sender, EventArgs e)
        {
            float fltA, fltB, fltC;

            //Captura de datos
            fltA = Convert.ToSingle(this.txtLadoA.Text);
            fltB = Convert.ToSingle(this.txtLadoB.Text);
            fltC = Convert.ToSingle(this.txtLadoC.Text);

            if( fltA <= 0 || fltB <= 0 || fltB <= 0)
            {
                MessageBox.Show("Error, existe al menos un lado no válido");
                this.txtLadoA.Focus();
                return;
            }

            //Crear el objeto
            clsPractica1 obj = new clsPractica1(); //Instancia de clase, creacion de clase

            //Envio de datos
            obj.ladoA = fltA;
            obj.ladoB = fltB;
            obj.ladoC = fltC;

            //Invocación del método y Tratamiento del error
            if (!obj.hallarArea())
            {
                MessageBox.Show(obj.Error);
                return;
            }
            //this.lblArea.Text = Convert.ToString(obj.Area);
            this.lblArea.Text = obj.Area.ToString();
            this.gpbArea.Visible = true;
        }
    }
}
