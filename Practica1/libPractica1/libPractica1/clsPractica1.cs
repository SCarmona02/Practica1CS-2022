using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPractica1
{
    public class clsPractica1
    {
        #region "Atributos"

        private float fltA, fltB, fltC, fltArea;
        private string strError;

        #endregion

        #region "Constructor"

        public clsPractica1()
        {
            fltA = 0;
            fltB = 0;
            fltC = 0;
            fltArea = 0;
            strError = string.Empty;
        }

        #endregion

        #region "Propiedades"
        //Valores de Entrada
        public float ladoA
        {
            set { fltA = value; }
        }

        public float ladoB
        {
            set { fltB = value; }
        }

        public float ladoC
        {
            set { fltC = value; }
        }

        //Valores de Salida
        public float Area
        {
            get { return fltArea; }
        }

        public string Error
        {
            get { return strError; }
        }

        #endregion

        #region "Métodos Privados"

        private bool Validar()
        {
            if (fltA <= 0)
            {
                strError = "Valor del lado A, no es válido";
                return false;
            }

            if (fltB <= 0)
            {
                strError = "Valor del lado B, no es válido";
                return false;
            }

            if (fltC <= 0)
            {
                strError = "Valor del lado C, no es válido";
                return false;
            }

            if ((fltA + fltB <= fltC) || (fltB + fltC <= fltA) || (fltA + fltC <= fltB))
            {
                strError = "No es posible crear un triángulo con los datos ingresados";
                return false;
            }

            return true;
        }

        #endregion

        #region "Métodos Públicos"

        public bool hallarArea()
        {
            float fltP = 0;

            if (!Validar())
            {
                return false;
            }

            fltP = (fltA + fltB + fltC) / 2f;
            //Poniendo 'f' al final de un entero se convierte en float

            fltArea = Convert.ToSingle(Math.Sqrt(fltP * (fltP - fltA) * (fltP - fltB) * (fltP - fltC)));
            //El Convert permite cambiar el tipo de dato, no existe el toFloat para flotantes, usamos el toSingle
            //El Math nos entrega funciones numericas a implementar, por ejemplo el sqrt que permite sacar la raiz cuadrada

            return true;
        }

        #endregion

    }
}
