using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pruebaNetCore.Domain;

namespace pruebaNetCore.Infraestructura
{
    public interface ISalidaRepository
    {
        public Task<SalidaRepositoryDto> consultar();
    }
}