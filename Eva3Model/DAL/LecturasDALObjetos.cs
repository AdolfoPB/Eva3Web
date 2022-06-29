using Eva3Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva3Model.DAL
{
    public class LecturasDALObjetos : ILecturasDAL
    {


        private static List<Lectura> lecturas = new List<Lectura>();
        private static string idLectura;
        public void Agregar(Lectura lectura)
        {
            Medidor medidor = new Medidor();
            //idLectura++;
            //idLectura = medidor.Numero;

            //lectura.NumeroLec = idLectura;
            lecturas.Add(lectura);
        }

        

        public void Eliminar(string numeroLec)
        {
            Lectura eliminado = lecturas.Find(c => c.NumeroLec == numeroLec);
            lecturas.Remove(eliminado);
        }

        public List<Lectura> Filtrar (string numeroLec)
        {
            return lecturas.FindAll(c => c.NumeroLec == numeroLec);
        }

        public List<Lectura> ObtenerLecturas()
        {
            return lecturas;
            
        }
    }
}
