using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Prokb.Data;
using Prokb.Data.DataDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prokb.Repositories
{
    public class IncidenciasRepository
    {
        private ProkbContext _context;
        private readonly IMapper _mapper;

        public IncidenciaDTO Create(IncidenciaDTO dto)
        {
            // Mapeamos el dto a la entidad, la añadimos al contexto, guardamos y devolvemos el dto mapeado
            var model = _mapper.Map<Incidencia>(dto);
            _context.Incidencias.Add(model);
            _context.SaveChanges();
            return _mapper.Map<IncidenciaDTO>(model);
        }

        public IncidenciaDTO Delete(int dto)
        {
            var model = _context.Incidencias.Find(dto);
            if (model != null)
            {
                _context.Incidencias.Remove(model);
                _context.SaveChanges();
                return _mapper.Map<IncidenciaDTO>(model);
            }
            else
            {
                throw new DllNotFoundException("No se ha encontrado la incidencia");
            }
        }

        public List<IncidenciaDTO> GetAll()
        {

            var model = _context.Incidencias
                                .FromSqlRaw("Select * FROM Incidencias")
                                .FirstOrDefault();
            var ret = _mapper.Map<List<IncidenciaDTO>>(model);
            return ret;
        }
    }
}
