using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RESTcursos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoresController : ControllerBase
    {
        // GET: api/Autores
        [HttpGet]
        public IEnumerable<Autor> Get()
        {

            return new Autor[] {
                new Autor { DNI = "12345678A", nombre = "Ndelle Labarns", calificacion = 5, thumbnail ="https://multimediarepository.blob.core.windows.net/imagecontainer/fcaa7f1745ad408a90a49c0d081e7aec.jpg"},
                new Autor { DNI = "12345679B", nombre = "Megan Griffiths ", calificacion = 4, thumbnail ="https://multimediarepository.blob.core.windows.net/imagecontainer/30b3f99246d54ba089be620f46483364.jpg"},
                new Autor { DNI = "12345671C", nombre = "Erik Adars", calificacion = 4, thumbnail ="https://multimediarepository.blob.core.windows.net/imagecontainer/90c5bd6c9ba348baa9ccb91ad23799b9.jpg"}
            };
        }

        
    }
}
