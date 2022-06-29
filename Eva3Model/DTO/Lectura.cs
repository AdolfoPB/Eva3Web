using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva3Model.DTO
{
    public class Lectura
    {
        private string numeroLec;
        private string fechaLec;
        private string horaLec;
        private string minutoLec;
        private string consumoLec;

        public string NumeroLec { get => numeroLec; set => numeroLec = value; }
        public string FechaLec { get => fechaLec; set => fechaLec = value; }
        public string ConsumoLec { get => consumoLec; set => consumoLec = value; }
        public string HoraLec { get => horaLec; set => horaLec = value; }
        public string MinutoLec { get => minutoLec; set => minutoLec = value; }
    }
}
