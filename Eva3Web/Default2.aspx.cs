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
    public partial class Default2 : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidoresDALObjetos();
        private ILecturasDAL lecturasDAL = new LecturasDALObjetos();

        private List<Medidor> medidoresAAA = new List<Medidor>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Medidor> medidores = medidoresDAL.Obtener();
                this.medidorDd2.DataSource = medidores;
                this.medidorDd2.DataTextField = "numero";
                this.medidorDd2.DataValueField = "numero";
                this.medidorDd2.DataBind();
                

                this.medidoresAAA = medidores;
            }
        }

        protected void agregarBtn2_Click(object sender, EventArgs e)
        {
            
            string numero = this.medidorDd2.SelectedValue.ToString();
            string fecha = this.Calendar1.SelectedDate.ToString();
            string hora = this.horaTxt.Text.Trim();
            string minuto = this.minutosTxt.Text.Trim();
            string consumo = this.consumoTxt.Text.Trim();
            
            string lecturaValor = this.medidorDd2.SelectedValue;

            string lecturaTexto = this.medidorDd2.SelectedValue.ToString();

            List<Lectura> lecturas = lecturasDAL.ObtenerLecturas();
            Medidor medidor = this.medidoresAAA.Find(b => b.Numero == lecturaTexto);

            List<Medidor> medidores = this.medidoresAAA;
            Lectura lectura = new Lectura()
            {
                NumeroLec = numero,
                FechaLec = fecha,
                HoraLec = hora,
                MinutoLec = minuto,
                ConsumoLec = consumo,
            };
            
            
            lecturasDAL.Agregar(lectura);
            this.mensajeLb1.Text = "Lectura Ingresada";
            Response.Redirect("VerLecturas.aspx");
        }
    }
}