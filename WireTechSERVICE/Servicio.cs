using System.Reflection;
using System.Text.RegularExpressions;
using WireTechSERVICE;

namespace WireTechSERVICE
{
    public class Servicio : Proovedor
    {
     public List<Proovedor> ListaDeProovedores = new List<Proovedor>();
        public int CodUnicoServicio {  get; set; }
    public string NombreServicio { get; set; }
    public int CodAutoIncremental { get; set; }
    public string ZonaOperacion { get; set; }
        

        public virtual string Descripcion()
        {
            return "DESCRIPCION";
        }
    public Servicio() {
       Proovedor proovedor1 = new Proovedor();
            proovedor1.CodigoUnico = 0;
            proovedor1.SaldoAcumuladoCobro = 0;
            proovedor1.NombreProv = "ESIREF";
            proovedor1.PaisOperando = "BRASIL";

            Proovedor proovedor2 = new Proovedor();
            proovedor1.CodigoUnico = 1;
            proovedor1.SaldoAcumuladoCobro = 0;
            proovedor1.NombreProv = "RACLO";
            proovedor1.PaisOperando = "ARGENTINA";

            Proovedor proovedor3 = new Proovedor();
            proovedor1.CodigoUnico = 2;
            proovedor1.SaldoAcumuladoCobro = 0;
            proovedor1.NombreProv = "CHOBB";
            proovedor1.PaisOperando = "MEXICO";

            Proovedor proovedor4 = new Proovedor();
            proovedor1.CodigoUnico = 3;
            proovedor1.SaldoAcumuladoCobro = 0;
            proovedor1.NombreProv = "CURUBITA";
            proovedor1.PaisOperando = "BRASIL";

           


        }







    }
}





//descripcion de la entidad
//codigo de proveedor que efectua el cobro
