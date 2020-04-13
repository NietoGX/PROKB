

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Prokb.Data;
using Prokb.Data.DataDTO;
using Prokb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Prokb.Repositories
{
    public class EmpresasRepository
    {
        private ProkbContext _context;
        private IMapper _mapper;
        
        public EmpresasRepository(ProkbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public EmpresaDTO Create(EmpresaDTO dto)
        {
            // Mapeamos el dto a la entidad, la añadimos al contexto, guardamos y devolvemos el dto mapeado
            var model = _mapper.Map<Empresa>(dto);
            _context.Empresas.Add(model);
            _context.SaveChanges();
            return _mapper.Map<EmpresaDTO>(model);
        }

        public EmpresaDTO Delete(int dto)
        {
            var model = _context.Empresas.Find(dto);
            if (model != null)
            {
                _context.Empresas.Remove(model);
                _context.SaveChanges();
                return _mapper.Map<EmpresaDTO>(model);
            }
            else
            {
                throw new DllNotFoundException("No se ha encontrado la empresa");
            }
        }

        public List<EmpresaDTO> GetAll()
        {

            var model = _context.Empresas
                                .FromSqlRaw("Select * FROM Empresas")
                                .FirstOrDefault();
            var ret=_mapper.Map<List<EmpresaDTO>>(model);
            return ret;
        }



        
    }
}
