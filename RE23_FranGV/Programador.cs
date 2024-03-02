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

        // CARACTERES

        protected const int DEFAULT_CARACTER_SIZE = 50;

        // SALARIO

        private const int SAL_MAX = 10000;
        private const int SAL_MIN = 1000;

        // MIEMBROS

        protected string _nombre;
        protected string _apellidos;
        protected float _salario;


        // CONSTRUCTORES
        #region Constructores
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

        public Programador(string name, string secondname, float sal) : this(name, secondname) 
        {
            Salario = sal;
        }
        #endregion

        // PROPIEDADES

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {

                ValidarCadena(value);
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
                ValidarCadena(value);
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
            if (string.IsNullOrEmpty(cadena)) throw new CadenaVaciaException();

            if (!cadena.All(char.IsLetter)) throw new NoLetterException();

            if (cadena.Length > DEFAULT_CARACTER_SIZE) throw new CaracterMaxException();


        }

        protected static void ValidarMaximos(float num, float MAX, float MIN)
        {
            if (num > MAX) throw new MaxException("Valor mayor al rango de valores establecido.");
            if (num < MIN) throw new MinException("Valor menor al rango de valores establecido.");
        }

    }

    #region Excepciones Personalizadas
    // EXCEPCIONES PERSOLALIZADAS

    public class CadenaVaciaException : Exception
    {
        public CadenaVaciaException() :base("Cadena vacía")
        {}
        public CadenaVaciaException(string mensaje) : base(mensaje)
        {}
    }

    public class MaxException : Exception
    {
        public MaxException() :base("Supera el rango maximo de valores establecido")
        {}
        public MaxException(string mensaje) : base(mensaje)
        {}
    }
    public class MinException : Exception
    {
        public MinException() : base("Es infeerior al rango mínimo de valores establecido")
        {}
        public MinException(string mensaje) : base(mensaje)
        {}
    }

    public class NoLetterException : Exception
    {
        public NoLetterException() : base("Error: No es letra")
        {}
        public NoLetterException(string mensaje) : base(mensaje)
        {}
    }

    public class CaracterMaxException : Exception
    {
        public CaracterMaxException() : base("Supera el rango de caracteres definido")
        {}
        public CaracterMaxException(string mensaje) : base(mensaje)
        {}
    }
    #endregion

}
