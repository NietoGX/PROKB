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
    public class DecisionesRepository
    {
        private ProkbContext _context;
        private readonly IMapper _mapper;

        public DecisionDTO Create(DecisionDTO dto)
        {
            // Mapeamos el dto a la entidad, la añadimos al contexto, guardamos y devolvemos el dto mapeado
            var model = _mapper.Map<Decision>(dto);
            _context.Decisiones.Add(model);
            _context.SaveChanges();
            return _mapper.Map<DecisionDTO>(model);
        }

        public DecisionDTO Delete(int dto)
        {
            var model = _context.Decisiones.Find(dto);
            if (model != null)
            {
                _context.Decisiones.Remove(model);
                _context.SaveChanges();
                return _mapper.Map<DecisionDTO>(model);
            }
            else
            {
                throw new DllNotFoundException("No se ha encontrado la decisión");
            }
        }

        public List<DecisionDTO> GetAll()
        {

            var model = _context.Empresas
                                .FromSqlRaw("Select * FROM Decisiones")
                                .FirstOrDefault();
            var ret = _mapper.Map<List<DecisionDTO>>(model);
            return ret;
        }
    }
}
