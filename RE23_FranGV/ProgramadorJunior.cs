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

        private const float DEFAULT_BONUS = 100;

        private const float MAX_BONUS = 1000;

        // MIEMBROS

        private float _bonus;

        // CONSTRUCTORES

        public ProgramadorJunior() : base()
        {
            _bonus = DEFAULT_BONUS;
        }

        public ProgramadorJunior(string name, string secondname, float sal) : this()
        {
            Nombre = name;
            Apellidos = secondname;
            Salario = sal;
        }
        public ProgramadorJunior(string name, string secondname, float bonus, float sal) : this(name, secondname, sal)
        {
            Bonus = bonus;
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
                Programador.ValidarMaximos(value, MAX_BONUS, 0);
                _bonus = value;
            }
        }

        // MÉTODOS

        private float CalcularSalario()
        {
            // return Salario * 1.10f;
            return base.Salario * 1.10f;

        }
    }
}
