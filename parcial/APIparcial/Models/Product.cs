using System.ComponentModel.DataAnnotations;

namespace APIparcial.Models
{

    public enum TipoEstado
    {
        Activo,
        Inactivo
    }
    public enum TipoUnidad //enum es un listado constante para crear un tipo de dato, son parte de la clase el estado no es tipo entero ni string sino unidad, es un nuevo dominio de dato
    {
        Botella,
        Metro,
        Litro,
        Caja
    }
    public class Product
    {
        [Key]
        public int ProductId { get; set; }//prod tabtab

        [Required]//contrl punto y using // si o si ingresaod como dato
        [Display(Name = "Product Name")] //muestra en el backend el producto

        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        [Required]
        public int Cantidad { get; set; }
        [Required]
        public TipoUnidad Unidad { get; set; }
        [Required]
        public TipoEstado Estado { get; set; }


    }
}