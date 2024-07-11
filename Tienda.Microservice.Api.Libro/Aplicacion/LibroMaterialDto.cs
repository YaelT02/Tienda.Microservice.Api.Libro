﻿namespace Tienda.Microservice.Api.Libro.Aplicacion
{
    public class LibroMaterialDto
    {
        public Guid? Id { get; set; }
        public string Titulo { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public int Cantidad { get; set; }
        public Guid? AutorLibro { get; set; }
    }
}