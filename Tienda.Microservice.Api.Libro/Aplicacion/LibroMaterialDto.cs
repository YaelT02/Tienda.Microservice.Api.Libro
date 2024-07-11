namespace Tienda.Microservice.Api.Libro.Aplicacion
{
    public class LibroMaterialDto
    {
        public int? Id { get; set; }
        public string Titulo { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public int Cantidad { get; set; }
        public int? AutorLibro { get; set; }
    }
}
