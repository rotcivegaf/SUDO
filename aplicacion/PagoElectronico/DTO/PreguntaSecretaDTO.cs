using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.DTO
{
    class PreguntaSecretaDTO
    {
        public int value { get; set; }
        public String valor { get; set; }

        public static PreguntaSecretaDTO build(int value, String valor) {
            PreguntaSecretaDTO dto = new PreguntaSecretaDTO();
            dto.value = value;
            dto.valor = valor;
            return dto;
        }
    }
}
