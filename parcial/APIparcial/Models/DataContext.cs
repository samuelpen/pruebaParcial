using System.Data.Entity;
//ctl punto eliminar
namespace APIparcial.Models
{
    public class DataContext:DbContext  // using data entity solo el uno
    {
        public DataContext():base("DefaultConnection")//ctor tabtab   //y luego ir a webconfig para ver como se escribe  //
        {

        }

        public System.Data.Entity.DbSet<APIparcial.Models.Product> Products { get; set; }
    }
}