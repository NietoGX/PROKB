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
    public class DocumentosRepository
    {
        private ProkbContext _context;
        private readonly IMapper _mapper;

        public DocumentoDTO Create(DocumentoDTO dto)
        {
            // Mapeamos el dto a la entidad, la añadimos al contexto, guardamos y devolvemos el dto mapeado
            var model = _mapper.Map<Documento>(dto);
            _context.Documentos.Add(model);
            _context.SaveChanges();
            return _mapper.Map<DocumentoDTO>(model);
        }

        public DocumentoDTO Delete(int dto)
        {
            var model = _context.Documentos.Find(dto);
            if (model != null)
            {
                _context.Documentos.Remove(model);
                _context.SaveChanges();
                return _mapper.Map<DocumentoDTO>(model);
            }
            else
            {
                throw new DllNotFoundException("No se ha encontrado el documento");
            }
        }

        public List<DocumentoDTO> GetAll()
        {

            var model = _context.Documentos
                                .FromSqlRaw("Select * FROM Documentos")
                                .FirstOrDefault();
            var ret = _mapper.Map<List<DocumentoDTO>>(model);
            return ret;
        }
        //public List<DocumentoDTO> GetAllByFicha(int id)
        //{
        //TODO: Filtrar por id de ficha
            
                                
        //    var ret = _mapper.Map<List<DocumentoDTO>>(model);
        //    return ret;
        //}
    }
}
