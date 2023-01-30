using Demo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Negocio
{
    public class ProductosNegocio
    {
        private List<Producto> _productos = default!;

        public ProductosNegocio()
        {
            Inicializar();
        }

        public List<Producto> ObtenerProductos(int categoriaId)
        {
            return _productos.Where(x=>x.CategoriaId == categoriaId).ToList();
        }

        public Producto? ObtenerProducto(int productoId)
        {
            return _productos.Where(x => x.Id == productoId).FirstOrDefault();
        }

        private void Inicializar()
        {
            _productos.Add(new Producto()
            {
                Id = 1,
                CategoriaId = 1,
                Nombre = "Maíz dulce cocido al vacío 400 gr",
                UrlImagen = "/images/10477990608926.jpg",
                Descripcion = "Calibre: 3 PIEZAS"
            });

            _productos.Add(new Producto()
            {
                Id = 2,
                CategoriaId = 1,
                Nombre = "Cebolla malla 2 Kg",
                UrlImagen = "/images/8847033073694.png",
                Descripcion = "Malla 2 Kg"
            });

            _productos.Add(new Producto()
            {
                Id = 3,
                CategoriaId = 1,
                Nombre = "OSCAR MAYER salchichas con queso envase 200 gr",
                UrlImagen = "/images/10971771764766.jpg",
                Descripcion = "Salchichas con queso"
            });

            _productos.Add(new Producto()
            {
                Id = 4,
                CategoriaId = 1,
                Nombre = "Naranja premium bolsa 2 Kg",
                UrlImagen = "/images/11272783953950.jpg",
                Descripcion = "Naranja 2Kg"
            });

            _productos.Add(new Producto()
            {
                Id = 5,
                CategoriaId = 1,
                Nombre = "Tomate rosa de la reina unidad (peso aprox. 900 gr)",
                UrlImagen = "/images/10937809993758.jpg",
                Descripcion = "Tomate rosa"
            });

            _productos.Add(new Producto()
            {
                Id = 6,
                CategoriaId = 1,
                Nombre = "Melón selección unidad (3.5 Kg aprox.)",
                UrlImagen = "/images/producto17p.jpg",
                Descripcion = "Melón"
            });

            _productos.Add(new Producto()
            {
                Id = 7,
                CategoriaId = 2,
                Nombre = "KOIPE Sol aceite girasol botella 1 lt",
                UrlImagen = "/images/11160116756510.jpg",
                Descripcion = "Aceite girasol"
            });

            _productos.Add(new Producto()
            {
                Id = 8,
                CategoriaId = 2,
                Nombre = "LAUKI leche desnatada envase 1 lt",
                UrlImagen = "/images/11238530220062.jpg",
                Descripcion = "Leche desnatada"
            });

            _productos.Add(new Producto()
            {
                Id = 9,
                CategoriaId = 2,
                Nombre = "KELLOGGS cereales corn flakes caja 500 gr",
                UrlImagen = "/images/11265824653342.jpg",
                Descripcion = "Cereales"
            });

            _productos.Add(new Producto()
            {
                Id = 10,
                CategoriaId = 2,
                Nombre = "FINI golosinas jelly cola bolsa 100 gr",
                UrlImagen = "/images/10905632178206.jpg",
                Descripcion = "FINI golosinas"
            });

            _productos.Add(new Producto()
            {
                Id = 11,
                CategoriaId = 3,
                Nombre = "RAPUN trenza de Huesca caja 450 gr",
                UrlImagen = "/images/10465404551198.jpg",
                Descripcion = "Trenza"
            });

            _productos.Add(new Producto()
            {
                Id = 110,
                CategoriaId = 3,
                Nombre = "DR OETKER ristorante pizza spinaci caja 390 gr",
                UrlImagen = "/images/11106487664670.jpg",
                Descripcion = "Pizza"
            });

            _productos.Add(new Producto()
            {
                Id = 12,
                CategoriaId = 4,
                Nombre = "Agua 50cl",
                UrlImagen = "/images/producto1p.jpg"
            });

            _productos.Add(new Producto()
            {
                Id = 13,
                CategoriaId = 4,
                Nombre = "Kas Naranja",
                UrlImagen = "/images/producto2p.jpg"
            });

            _productos.Add(new Producto()
            {
                Id = 14,
                CategoriaId = 4,
                Nombre = "Kas Limón",
                UrlImagen = "/images/producto3p.jpg"
            });

            _productos.Add(new Producto()
            {
                Id = 15,
                CategoriaId = 4,
                Nombre = "Pepsi",
                UrlImagen = "/images/producto4p.jpg"
            });

            _productos.Add(new Producto()
            {
                Id = 16,
                CategoriaId = 4,
                Nombre = "Pepsi Light",
                UrlImagen = "/images/producto5p.jpg"
            });

            _productos.Add(new Producto()
            {
                Id = 17,
                CategoriaId = 4,
                Nombre = "Pepsi Max",
                UrlImagen = "/images/producto6p.jpg"
            });

            _productos.Add(new Producto()
            {
                Id = 18,
                CategoriaId = 4,
                Nombre = "Seven Up",
                UrlImagen = "/images/producto9p.jpg"
            });
        }
    }
}
