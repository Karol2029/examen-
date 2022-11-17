using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pruebaNetCore.Domain;
using Microsoft.AspNetCore.Mvc;
using pruebaNetCore.Aplication;

namespace pruebaNetCore.Controllers



{
    [ApiController]
    [Route("[controller]")]
    public class SalidaController : ControllerBase
    {

        private readonly ISalidaService salidaAppService;

        public SalidaController(ISalidaService salidaAppService)
        {
            this.salidaAppService = salidaAppService;
        }

        [HttpGet]
        public ICollection<SalidaDto> GetAll()
        {
            ICollection<SalidaDto> respuesta = salidaAppService.consultar();
            return respuesta;
        }
    }
}