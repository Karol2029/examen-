using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using pruebaNetCore.Domain;
using pruebaNetCore.Infraestructura;

namespace pruebaNetCore.Aplication
{
    public class SalidaService : ISalidaService
    {
        private readonly ISalidaRepository salidaRepository;


        public SalidaService(ISalidaRepository salidaRepository)
        {
            this.salidaRepository = salidaRepository;
        }


        public ICollection<SalidaDto> consultar()
        {
            SalidaRepositoryDto responesService = salidaRepository.consultar();
            var carroListDto =  (from c in responesService.Results
                            select new SalidaDto(){
                                Id = c.Id,
                                Name = c.Name
                            }).ToList();
            ICollection<SalidaDto> respuesta = new Collection<SalidaDto>();
            return respuesta;
        }
    }
}