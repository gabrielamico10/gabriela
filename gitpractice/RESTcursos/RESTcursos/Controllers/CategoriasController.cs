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
    public class CategoriasController : ControllerBase
    {
        // GET: api/Categorias
        [HttpGet]
        public IEnumerable<Categoria> Get()
        {
            return new Categoria[] {
                new Categoria { id = 1, nombre = "Programación"},
                new Categoria { id = 1, nombre = "Matemáticas"},
                new Categoria { id = 1, nombre = "Biología"}
            };
        }



    }
}
