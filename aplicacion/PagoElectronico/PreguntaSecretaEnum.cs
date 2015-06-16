using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Utils
{
    public sealed class PreguntaSecretaEnum
    {
        private readonly String name;
        private readonly int value; 

        public static readonly PreguntaSecretaEnum PRIMER_MASCOTA = new PreguntaSecretaEnum (1, "¿Nombre de la Primer Mascota?");
        public static readonly PreguntaSecretaEnum NOMBRE_ABUELA = new PreguntaSecretaEnum (2, "¿Nombre Abuelo/a?");
        public static readonly PreguntaSecretaEnum CANCION_FAVORITA = new PreguntaSecretaEnum (3, "¿Canción Favorita?");

        private PreguntaSecretaEnum(int value, String name)
        {
            this.name = name;
            this.value = value;
        }

        public override String ToString(){
            return name;
        }

        public int GetValue() {
            return this.value;
        }

        public String GetName() {
            return this.name;
        }
    }
}
