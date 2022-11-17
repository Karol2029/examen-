using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pruebaNetCore.Domain;

namespace pruebaNetCore.Aplication
{
    public interface ISalidaService
    {
        public ICollection<SalidaDto> consultar();

    }
}