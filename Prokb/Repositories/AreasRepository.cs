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
    public class AreasRepository
    {
        private ProkbContext _context;
        private readonly IMapper _mapper;


        public AreasRepository(ProkbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public AreaDTO Create(AreaDTO dto)
        {
            // Mapeamos el dto a la entidad, la añadimos al contexto, guardamos y devolvemos el dto mapeado
            var model = _mapper.Map<Area>(dto);
            _context.Areas.Add(model);
            _context.SaveChanges();
            return _mapper.Map<AreaDTO>(model);
        }

        public AreaDTO Delete(int dto)
        {
            var model = _context.Empresas.Find(dto);
            if (model != null)
            {
                _context.Empresas.Remove(model);
                _context.SaveChanges();
                return _mapper.Map<AreaDTO>(model);
            }
            else
            {
                throw new DllNotFoundException("No se ha encontrado el area");
            }
        }

        public List<AreaDTO> GetAll()
        {

            var model = _context.Areas
                                .FromSqlRaw("Select * FROM Areas")
                                .FirstOrDefault();
            var ret = _mapper.Map<List<AreaDTO>>(model);
            return ret;
        }
    }
}

