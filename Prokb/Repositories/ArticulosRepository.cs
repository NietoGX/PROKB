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
    public class ArticulosRepository
    {
        private ProkbContext _context;
        private readonly IMapper _mapper;

        public ArticuloDTO Create(ArticuloDTO dto)
        {
            // Mapeamos el dto a la entidad, la añadimos al contexto, guardamos y devolvemos el dto mapeado
            var model = _mapper.Map<Articulo>(dto);
            _context.Articulo.Add(model);
            _context.SaveChanges();
            return _mapper.Map<ArticuloDTO>(model);
        }

        public ArticuloDTO Delete(int dto)
        {
            var model = _context.Articulo.Find(dto);
            if (model != null)
            {
                _context.Articulo.Remove(model);
                _context.SaveChanges();
                return _mapper.Map<ArticuloDTO>(model);
            }
            else
            {
                throw new DllNotFoundException("No se ha encontrado el articulo");
            }
        }

        public List<ArticuloDTO> GetAll()
        {

            var model = _context.Empresas
                                .FromSqlRaw("Select * FROM Articulos")
                                .FirstOrDefault();
            var ret = _mapper.Map<List<ArticuloDTO>>(model);
            return ret;
        }
        
        
    }
}
