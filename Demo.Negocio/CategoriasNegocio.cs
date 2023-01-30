using Demo.Entidades;

namespace Demo.Negocio
{
    public class CategoriasNegocio
    {
        private List<Categoria> _categorias = default!;

        public CategoriasNegocio()
        {
            Inicializar();
        }

        public List<Categoria> ObtenerCategorias()
        {
            return _categorias;
        }

        private void Inicializar()
        {
            _categorias = new List<Categoria> {
                new Categoria
                {
                    Id = 1,
                    Nombre = "Frescos"
                },
                new Categoria
                {
                    Id = 2,
                    Nombre = "Despensa"
                },
                new Categoria
                {
                    Id = 3,
                    Nombre = "Congelados"
                },
                new Categoria
                {
                    Id = 4,
                    Nombre = "Bebidas"
                }};
        }
    }
}