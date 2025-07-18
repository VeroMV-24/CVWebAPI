using CVWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CVWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CurriculumController : Controller
    {
        [HttpGet]
        public ActionResult<Curriculum> GetCurriculum()
        {
            var curriculum = new Curriculum
            {
                Name = "Verónica de Jesús Mendoza Vidal",
                Birthdate = new DateTime(1996, 02, 03),
                SkillsData = new List<SkillGroup>
                {
                  new SkillGroup
                  {
                      Title = "Lenguajes de Programación y Tecnologias",
                      Skills = new List<Skill>
                      {
                          new Skill {Name= "HTML", StartDate= "Septiembre 2020", EndDate= "Presente"},
                          new Skill {Name= "CSS", StartDate= "Septiembre 2020", EndDate= "Presente"},
                          new Skill {Name= "JavaScript", StartDate= "Septiembre 2020", EndDate= "Presente"},
                          new Skill {Name= "C#", StartDate= "Septiembre 2020", EndDate= "Octubre 2021"},
                          new Skill {Name= ".Net Core", StartDate= "Septiembre 2020", EndDate= "Octubre 2021"},
                          new Skill {Name= ".Net Framework", StartDate= "Septiembre 2020", EndDate= "Octubre 2021"},
                          new Skill {Name= "Inyeccion de dependencias", StartDate= "Septiembre 2024", EndDate= "Presente"},
                          new Skill {Name= "Swagger", StartDate= "Septiembre 2024", EndDate= "Presente"},
                          new Skill {Name= "jQuery", StartDate= "Septiembre 2024", EndDate= "Presente" }
                      } 
                  },
                  new SkillGroup
                  {
                      Title = "Bases de datos",
                      Skills = new List<Skill>
                      {
                          new Skill {Name= "SQL Server", StartDate= "Septiembre 2020", EndDate= "Septiembre 2024"},
                          new Skill {Name= "MySQL", StartDate= "Septiembre 2020", EndDate= "Septiembre 2024"},
                          new Skill {Name= "Oracle", StartDate= "Septiembre 2020", EndDate= "Septiembre 2024"}
                      }
                  },
                  new SkillGroup
                  {
                      Title = "Otras habilidades",
                      Skills = new List<Skill>
                      {
                          new Skill {Name= "Git", StartDate= "Septiembre 2020", EndDate= "Octubre 2021"},
                          new Skill {Name= "Bootstrap", StartDate= "Septiembre 2020", EndDate= "Octubre 2021"},
                          new Skill {Name= "Docker", StartDate= "Septiembre 2020", EndDate= "Octubre 2021"},
                          new Skill {Name= "SAP BusinessObjects", StartDate= "Octubre 2021", EndDate= "Septiembre 2024"},
                          new Skill {Name= "Toad", StartDate= "Octubre 2021", EndDate= "Septiembre 2024"},
                          new Skill {Name= "PowerCenter", StartDate= "Octubre 2021", EndDate= "Septiembre 2024"},
                          new Skill {Name= "Programacion Orientada a Objetos", StartDate= "Septiembre 2020", EndDate= "Presente"},
                          new Skill {Name= "SCRUM", StartDate= "Septiembre 2020", EndDate= "Septiembre 2024"}
                      }
                  }
                },
                Work = new List<Trabajo>
                {
                    new Trabajo {Titulo= "Desarrollador Junior - Freelancer", Institucion= "Heladísimo", Fecha= "Noviembre 2024 - Presente"},
                    new Trabajo {Titulo= "Ingeniero de datos", Institucion= "SuKarne", Fecha= "Octubre 2021 - Septiembre 2024"},
                    new Trabajo {Titulo= "Desarrollador Junior", Institucion= "Heladísimo", Fecha= "Septiembre 2020 - Octubre 2021"},
                },
                Education = new List<Educacion>
                {
                    new Educacion {Titulo= "Ingeniería en Sistemas Computacionales", Institucion= "Instituto Tecnologico de Mérida", Fecha= "Agosto 2016 - Diciembre 2020"}
                },
                Project = new List<Proyecto>
                {
                    new Proyecto {Titulo= "CV Virtual - FrontEnd", Imagen= "images/CVweb.png", Descripcion= "Es una pagina web construida desde FrontEnd donde se muestra en tiempo real todo lo relacionado a mis habilidades y formacion academica. Para hacer esta página se usaron las siguientes tecnologías: HTML, CSS, JavaScrip", Link= "https://github.com/VeroMV-24/CVVirtual"},
                    new Proyecto {Titulo= "CV Virtual Web API - BackEnd", Imagen= "images/CVwebAPI.png", Descripcion= "Es una Web API para alimentar la pagina web CV Virtual, para hacer esta web api se usaron las siguientes tecnologías: C#, Swagger y Docker", Link= "https://github.com/VeroMV-24/CVWebAPI"}
                }
            };
            return Ok(curriculum);
        }
    }
}