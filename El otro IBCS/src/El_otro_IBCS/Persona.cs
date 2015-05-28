using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace El_otro_IBCS
{
    enum EstadoCivil { Casado, Soltero, Divorciado, UnionLibre, Viudo }

    public class Persona
    {
        private DateTime edad;
        private string nombre;
        private string apellido;
        private EstadoCivil estadoCivi;

        public DateTime Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        internal EstadoCivil EstadoCivi
        {
            get
            {
                return estadoCivi;
            }

            set
            {
                estadoCivi = value;
            }
        }
    }
}
