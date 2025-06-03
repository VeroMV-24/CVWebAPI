namespace CVWebAPI.Models
{
    public class Curriculum
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public List<SkillGroup> SkillsData { get; set; }
        public List<Trabajo> Work { get; set; }
        public List<Educacion> Education { get; set; }
        public List<Proyecto> Project { get; set; }
    }

    public class Skill
    {
        public string Name { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }

    public class SkillGroup
    {
        public string Title { get; set; }
        public List<Skill> Skills { get; set; }
    }

    public class Trabajo
    {
        public string Titulo { get; set; }
        public string Institucion { get; set; }
        public string Fecha { get; set; }
    }

    public class Educacion
    {
        public string Titulo { get; set; }
        public string Institucion { get; set; }
        public string Fecha { get; set; }
    }

    public class Proyecto
    {
        public string Titulo { get; set; }
        public string Imagen { get; set; }
        public string Descripcion { get; set; }
        public string Link { get; set; }
    }
}
