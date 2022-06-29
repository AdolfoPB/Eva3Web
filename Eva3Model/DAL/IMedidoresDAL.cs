using Eva3Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva3Model.DAL
{
    public interface IMedidoresDAL
    {
        List<Medidor> Obtener();
        void Agregar(Medidor medidor);

        void Eliminar(string numero);

        List<Medidor> Filtrar(int tipo);
    }
}
