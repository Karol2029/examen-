using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pruebaNetCore.Domain;

namespace pruebaNetCore.Infraestructura
{
    public class SalidaRepository : ISalidaRepository
    {
    
        public async Task<SalidaRepositoryDto> consultar()
        {
            SalidaRepositoryDto rr = new SalidaRepositoryDto();
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync("https://rickandmortyapi.com/api/character");
                var result1 = JsonConvert.DeserializeObject<SalidaRepositoryDto>(result);
                return result1;
            }

        }
    }
}