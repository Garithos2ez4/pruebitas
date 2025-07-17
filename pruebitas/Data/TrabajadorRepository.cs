using Microsoft.EntityFrameworkCore;
using pruebitas.Models;// <--- clave

namespace pruebitas.Data
{
    public class TrabajadorRepository
    {
        private readonly TrabajadoresContext _context;

        public TrabajadorRepository(TrabajadoresContext context)
        {
            _context = context;
        }

        public async Task<List<TrabajadorViewModel>> Listar()
        {
            return await _context.TrabajadorViewModel
                .FromSqlRaw("EXEC sp_ListarTrabajadores")
                .ToListAsync();
        }



        public async Task Insertar(Trabajador t)
        {
            await _context.Database.ExecuteSqlRawAsync(
                "EXEC sp_InsertarTrabajador @p0, @p1, @p2, @p3, @p4, @p5, @p6",
                t.TipoDocumento,
                t.NumeroDocumento,
                t.Nombres,
                t.Sexo,
                t.IdDepartamento,
                t.IdProvincia,
                t.IdDistrito
            );
        }

        public async Task Actualizar(Trabajador t)
        {
            await _context.Database.ExecuteSqlRawAsync(
                "EXEC sp_ActualizarTrabajador @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7",
                t.Id,
                t.TipoDocumento,
                t.NumeroDocumento,
                t.Nombres,
                t.Sexo,
                t.IdDepartamento,
                t.IdProvincia,
                t.IdDistrito
            );
        }

        public async Task Eliminar(int id)
        {
            await _context.Database.ExecuteSqlRawAsync("EXEC sp_EliminarTrabajador @p0", id);
        }
        public async Task<List<Departamento>> ListarDepartamentos()
        {
            return await _context.Departamento.ToListAsync();
        }

        public async Task<List<Provincia>> ListarProvincias()
        {
            return await _context.Provincia.ToListAsync();
        }

        public async Task<List<Distrito>> ListarDistritos()
        {
            return await _context.Distrito.ToListAsync();
        }

    }
}
