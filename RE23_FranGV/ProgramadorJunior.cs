using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RE23_FranGV
{
    public class ProgramadorJunior : Programador
    {




        // CONSTRUCTORES

        public ProgramadorJunior() : base()
        {
            _nombre = DEFAULT_CONSTRUCTOR;
            _apellidos = DEFAULT_CONSTRUCTOR;
            _salario = DEFAULT_CONSTRUCTOR_NUM;
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

        // MÉTODOS

        private float CalcularSalario()
        {
            return Salario * 1.110f;
        }
    }
}
