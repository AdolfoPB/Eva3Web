using Eva3Model.DAL;
using Eva3Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eva3Web
{
    public partial class Default : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidoresDALObjetos();
        private ILecturasDAL lecturasDAL = new LecturasDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                
                

            }
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            
            string numero = this.numeroTxt.Text.Trim();
            
            int tipo = Convert.ToInt32(this.tipoRb1.SelectedItem.Value);

            List<Lectura> lecturas = lecturasDAL.ObtenerLecturas();
            

            Medidor medidor = new Medidor()
            {
                Numero = numero,
                Tipo = tipo,
            };
            medidor.Lecturas = new List<Lectura>();

            medidoresDAL.Agregar(medidor);
            this.mensajeLb1.Text = "Medidor Ingresado";
            Response.Redirect("VerMedidores.aspx");
        }
    }
}