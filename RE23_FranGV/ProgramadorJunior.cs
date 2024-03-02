using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE23_FranGV
{
    public class ProgramadorJunior : Programador
    {
        // CONSTANTES
        private const float MIN_BONUS = 0;

        private const float DEFAULT_BONUS = 100;

        private const float MAX_BONUS = 1000;

        // MIEMBROS

        private float _bonus;

        // CONSTRUCTORES

        public ProgramadorJunior() : base()
        {
            _bonus = DEFAULT_BONUS;
        }

        public ProgramadorJunior(string name, string secondname) : this()
        {
            Nombre = name;
            Apellidos = secondname;
        }
        public ProgramadorJunior(string name, string secondname, float sal, float bonus) : base(name, secondname)
        {
            Bonus = bonus;
            Salario = sal;
        }

        // PROPIEDADES

        public override float Salario
        {
            get
            {
                return CalcularSalario();
            }
            set
            {

                base.Salario = value;

            }
        }

        public float Bonus
        {
            get
            {
                return _bonus;
            }
            set
            {
                Programador.ValidarMaximos(value, MAX_BONUS, MIN_BONUS); // Coge el método de validación de la clase padre
                _bonus = value;
            }
        }

        // MÉTODOS

        private float CalcularSalario()
        {
            // return Salario * 1.10f;  Esto provoca un bucle
            return base.Salario * 1.10f;

        }

       
    }
}
