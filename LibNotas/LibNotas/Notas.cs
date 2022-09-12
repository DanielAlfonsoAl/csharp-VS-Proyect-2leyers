using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibNotas
{
    public class Notas
    {
        #region Atributos
        private double Nota1;
        private double Nota2;
        private double Nota3;
        private double Nota4;
        private double Promedio;
        private String Error;

        #endregion

        #region propiedades 
        public double SetNota1
        {
            set { Nota1 = value; }
        }

        public double SetNota2
        {
            set { Nota2 = value; }
        }

        public double SetNota3
        {
            set { Nota3 = value; }
        }

        public double SetNota4
        {
            set { Nota4 = value; }
        }

        public double GetPromedio
        {
            get { return Promedio; }
        }

        public String GetError
        {
            get { return Error; }
        }
        #endregion
        #region Metodos Publicos

        public Notas()
        {
            Nota1 = 0;
            Nota2 = 0;
            Nota3 = 0;
            Nota4 = 0;
            Promedio = 0;
            Error = "";
        }

        public bool Calcular_Prom()
        {
            if (!Validar())
            {
                return false;
            }
            try
            {
                Promedio = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
                return true;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
            }
        }
        #endregion


        #region metodos Privados

        private bool Validar()
        {
            if(Nota1 < 0 || Nota2 < 0|| Nota3 < 0 || Nota4 < 0)
            {   
                Error = "Ingrese una nota entre 0 y 5";
                return false;        
            }
            else if (Nota1 >= 5.1 || Nota2 >= 5.1 || Nota3 >= 5.1 || Nota4 >= 5.1)
            {
                Error = "Ingrese una nota menor a 5";
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion

    }
}
