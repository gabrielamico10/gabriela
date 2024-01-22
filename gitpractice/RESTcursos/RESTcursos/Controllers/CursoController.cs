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
    public class CursoController : ControllerBase
    {
        // GET: api/Curso
        [HttpGet("ultimos")]
        public IEnumerable<Curso> GetUltimos()
        {
            return new Curso[] { 
                new Curso { id = 1, titulo = "Git", descripcion = "Curso de Git Básico que nos permitirá trabajar con repositorios locales y remotos", url = "gitbasico", thumbnail = "https://multimediarepository.blob.core.windows.net/imagecontainer/6331ebcadbf74d4da787f3c8207f6d27.png"},
                new Curso { id = 2, titulo = "Bootstrap", descripcion = "Curso de Bootstrap para la maquetación de páginas web", url = "bootstrap", thumbnail="https://multimediarepository.blob.core.windows.net/imagecontainer/6821750c3eca4154b78765db3c609299.PNG"},
                new Curso { id = 3, titulo = "GitHub", descripcion = "Curso de GitHub. Trabajaremos con repositorios remotos y flujos de trabajo.", url = "github", thumbnail="https://multimediarepository.blob.core.windows.net/imagecontainer/6744af223ec74734b46a424f68e86a14.png"},
                new Curso { id = 4, titulo = "Jasmine", descripcion = "Curso de Jasmine para test unitarios.", url = "jasine", thumbnail="https://multimediarepository.blob.core.windows.net/imagecontainer/b376c6d1ff4e46b89eea93408a92306c.png"},
                new Curso { id = 5, titulo = "Azure DevOps", descripcion = "Completo curso de Azure DevOps donde veremos repositorios, scrum y CI /CD.", url = "azuredevops", thumbnail= "https://multimediarepository.blob.core.windows.net/imagecontainer/b59ab3b6b1564fa39be4c909993d24a4.png"}

            };
        }

        // GET: api/Curso
        [HttpGet("valorados")]
        public IEnumerable<Curso> GetValorados()
        {
            return new Curso[] {
                new Curso { id = 1, titulo = "Git", descripcion = "Curso de Git Básico que nos permitirá trabajar con repositorios locales y remotos", url = "gitbasico", thumbnail = "https://multimediarepository.blob.core.windows.net/imagecontainer/6331ebcadbf74d4da787f3c8207f6d27.png"},
                new Curso { id = 2, titulo = "Azure DevOps", descripcion = "Completo curso de Azure DevOps donde veremos repositorios, scrum y CI /CD.", url = "azuredevops", thumbnail= "https://multimediarepository.blob.core.windows.net/imagecontainer/b59ab3b6b1564fa39be4c909993d24a4.png"},
                new Curso { id = 3, titulo = "Java", descripcion = "Curso de introducción a java", url = "java", thumbnail = "https://multimediarepository.blob.core.windows.net/imagecontainer/81638f56fc3f48e4aabda5648a3f3b4e.jpg"},
                new Curso { id = 4, titulo = "HTML, CSS y JavaScript", descripcion = "En este curso veremos HTML5, CSS3 y JavaScript", url = "html", thumbnail="https://multimediarepository.blob.core.windows.net/imagecontainer/3b19aed2be7c4d63b38288edf5a28c25.png"},
                new Curso { id = 5, titulo = "Jasmine", descripcion = "Curso de Jasmine para test unitarios.", url = "jasine", thumbnail="https://multimediarepository.blob.core.windows.net/imagecontainer/b376c6d1ff4e46b89eea93408a92306c.png"}
            };
        }

        // GET: api/Curso/5
        [HttpGet("categoria/{id}", Name = "Get")]
        public IEnumerable<Curso> GetCursosCategoria(int id)
        {
            switch (id)
            {
                case 1:
                    return new Curso[] {
                        new Curso { id = 1, titulo = "Git Básico", descripcion = "Curso de Git Básico", url = "gitbasico"},
                        new Curso { id = 2, titulo = "Git Avanzado", descripcion = "Curso de Git Avanzado", url = "gitavanzado"},
                        new Curso { id = 3, titulo = "Java Básico", descripcion = "Curso de Java Básico", url = "javabasico"},
                        new Curso { id = 4, titulo = "Java Medio", descripcion = "Curso de Java Medio", url = "javamedio"},
                        new Curso { id = 5, titulo = "Java Avanzado", descripcion = "Curso de Java Avanzado", url = "javaavanzado"}
                    };
                case 2:
                    return new Curso[] {
                        new Curso { id = 6, titulo = "Cálculo I", descripcion = "Curso de Cálculo I", url = "calculo1"},
                        new Curso { id = 7, titulo = "Cálculo II", descripcion = "Curso de Cálcilo II", url = "calculo2"},
                    };
                case 3:
                    return new Curso[] {
                        new Curso { id = 8, titulo = "Biología", descripcion = "Curso de Biología", url = "biologia"}
                    };
                default:
                    return new Curso[] { };
            }
        }

    }
}
