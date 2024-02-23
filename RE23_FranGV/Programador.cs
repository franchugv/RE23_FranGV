using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE23_FranGV
{
    public class Programador
    {

        // CONSTANTES

        protected const string DEFAULT_CONSTRUCTOR = "Desconocido";

        // SALARIO

        private const int SAL_MAX = 10000;
        private const int SAL_MÌN = 1000;

        // MIEMBROS

        protected string _nombre;
        protected string _apellidos;
        protected float _salario;
        

        // CONSTRUCTORES

        // PROPIEDADES

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                ConvertirMayuscula(value);
                _nombre = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return _apellidos;
            }
            set
            {
                ConvertirMayuscula(value);
                _apellidos = value;
            }
        }

        public virtual float Salario
        {
            get
            {
                return _salario;
            }
            set
            {
                _salario = value;
            }
        }

        // MÉTODOS

        private static string ConvertirMayuscula(string cadena)
        {
            // proceso

            cadena = cadena.ToUpper();

            return cadena;
        } 

        private static void ValidarCadena(string cadena)
        {
            
            // Validar cadena vacía
            if (string.IsNullOrEmpty(cadena)) throw new CadenaVaciaException("Cadena vacía");

            if (cadena.All(char.IsLetter)) throw new Exception();
        }
    }


    // EXCEPCIONES PERSOLALIZADAS

    public class CadenaVaciaException : Exception
    {
        public CadenaVaciaException() :base("Cadena vacía")
        {

        }
        public CadenaVaciaException(string mensaje) : base(mensaje)
        {

        }
    }

}
