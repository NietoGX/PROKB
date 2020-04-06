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
    public class MotivosRepository
    {
        private ProkbContext _context;
        private readonly IMapper _mapper;

        public MotivoDTO Create(MotivoDTO dto)
        {
            // Mapeamos el dto a la entidad, la añadimos al contexto, guardamos y devolvemos el dto mapeado
            var model = _mapper.Map<Motivo>(dto);
            _context.Motivos.Add(model);
            _context.SaveChanges();
            return _mapper.Map<MotivoDTO>(model);
        }

        public MotivoDTO Delete(int dto)
        {
            var model = _context.Motivos.Find(dto);
            if (model != null)
            {
                _context.Motivos.Remove(model);
                _context.SaveChanges();
                return _mapper.Map<MotivoDTO>(model);
            }
            else
            {
                throw new DllNotFoundException("No se ha encontrado el motivo");
            }
        }

        public List<MotivoDTO> GetAll()
        {

            var model = _context.Documentos
                                .FromSqlRaw("Select * FROM Motivos")
                                .FirstOrDefault();
            var ret = _mapper.Map<List<MotivoDTO>>(model);
            return ret;
        }
    }
}
