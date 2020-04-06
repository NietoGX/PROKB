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
    public class ProveedoresRepository
    {
       
        private ProkbContext _context;
        private readonly IMapper _mapper;

        public ProveedorDTO Create(ProveedorDTO dto)
        {
            // Mapeamos el dto a la entidad, la añadimos al contexto, guardamos y devolvemos el dto mapeado
            var model = _mapper.Map<Proveedor>(dto);
            _context.Proveedores.Add(model);
            _context.SaveChanges();
            return _mapper.Map<ProveedorDTO>(model);
        }

        public ProveedorDTO Delete(int dto)
        {
            var model = _context.Proveedores.Find(dto);
            if (model != null)
            {
                _context.Proveedores.Remove(model);
                _context.SaveChanges();
                return _mapper.Map<ProveedorDTO>(model);
            }
            else
            {
                throw new DllNotFoundException("No se ha encontrado el proveedor");
            }
        }

        public List<ProveedorDTO> GetAll()
        {

            var model = _context.Proveedores
                                .FromSqlRaw("Select * FROM Empresas")
                                .FirstOrDefault();
            var ret = _mapper.Map<List<ProveedorDTO>>(model);
            return ret;
        }




    }
    
}
