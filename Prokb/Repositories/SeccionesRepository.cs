using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Prokb.Data;
using Prokb.Data.DataDTO;
using Prokb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prokb.Repositories
{
    public class SeccionesRepository
    {
        private ProkbContext _context;
        private readonly IMapper _mapper;

        public SeccionDTO Create(SeccionDTO dto)
        {
            // Mapeamos el dto a la entidad, la añadimos al contexto, guardamos y devolvemos el dto mapeado
            var model = _mapper.Map<Seccion>(dto);
            _context.Secciones.Add(model);
            _context.SaveChanges();
            return _mapper.Map<SeccionDTO>(model);
        }

        public SeccionDTO Delete(int dto)
        {
            var model = _context.Secciones.Find(dto);
            if (model != null)
            {
                _context.Secciones.Remove(model);
                _context.SaveChanges();
                return _mapper.Map<SeccionDTO>(model);
            }
            else
            {
                throw new DllNotFoundException("No se ha encontrado la sección");
            }
        }

        public List<SeccionDTO> GetAll()
        {

            var model = _context.Empresas
                                .FromSqlRaw("Select * FROM Secciones")
                                .FirstOrDefault();
            var ret = _mapper.Map<List<SeccionDTO>>(model);
            return ret;
        }




    }
}
