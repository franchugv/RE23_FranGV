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
        protected const float DEFAULT_CONSTRUCTOR_NUM = 1000;


        // SALARIO

        private const int SAL_MAX = 10000;
        private const int SAL_MIN = 1000;

        // MIEMBROS

        protected string _nombre;
        protected string _apellidos;
        protected float _salario;
        

        // CONSTRUCTORES

        public Programador()
        {
            _nombre = DEFAULT_CONSTRUCTOR;
            _apellidos = DEFAULT_CONSTRUCTOR;
            _salario = DEFAULT_CONSTRUCTOR_NUM;
        }

        public Programador(string name, string secondname) : this ()
        {
            Nombre = name;
            Apellidos = secondname;
        }

        public Programador(float sal, string name, string secondname) : this(name, secondname) 
        {

            Salario = sal;
        }

        // PROPIEDADES

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {


                _nombre = ConvertirMayuscula(value);

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
                _apellidos = ConvertirMayuscula(value);

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
                // VALIDACIÓN
                ValidarMaximos(value, SAL_MAX, SAL_MIN);
                // ESCRITURA
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

        protected static void ValidarMaximos(float num, float MAX, float MIN)
        {
            if (num > MAX) throw new Exception("Valor mayor al rango de valores establecido.");
            if (num < MIN) throw new Exception("Valor menor al rango de valores establecido.");
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
