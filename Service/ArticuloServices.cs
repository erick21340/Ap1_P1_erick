using Ap1_P1_erick.DAL;
using Ap1_P1_erick.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Ap1_P1_erick.Service
{
    public class ArticuloService
    {
        private readonly Contexto _contexto;

        public ArticuloService(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> Existe(int ID)
        {
            return await _contexto.Articulos!.AnyAsync(a => a.ArticulosId == ID);
        }

        public async Task<bool> Insertar(Articulos articulo)
        {
            _contexto.Add(articulo);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> Modificar(Articulos articulo)
        {
            _contexto.Update(articulo);
            var guardado = await _contexto.SaveChangesAsync() > 0;
            _contexto.Entry(articulo).State = EntityState.Detached;
            return guardado;
        }

        public async Task<bool> Eliminar(int articuloId)
        {
            var articulo = await _contexto.Articulos!.FindAsync(articuloId);
            if (articulo != null)
            {
                _contexto.Articulos.Remove(articulo);
                return await _contexto.SaveChangesAsync() > 0;
            }
            return false;
        }

        public async Task<Articulos?> Buscar(int articuloId)
        {
            return await _contexto.Articulos!.AsNoTracking().FirstOrDefaultAsync(a => a.ArticulosId == articuloId);
        }

        public async Task<List<Articulos>> Listar(Expression<Func<Articulos, bool>> criterio)
        {
            return await _contexto.Articulos!.AsNoTracking().Where(criterio).ToListAsync();
        }

        public async Task<bool> Guardar(Articulos articulo)
        {
            if (await Existe(articulo.ArticulosId))
            {
                return await Modificar(articulo);
            }
            else
            {
                return await Insertar(articulo);
            }
        }
    }
}


