using System.ComponentModel.DataAnnotations;

namespace universityApiBackend.Models.DataModels
{
    public enum LevelNames
    {
        Básico,
        Intermedio,
        Avanzado
    }
public class Course: BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string DescriptionShort { get; set; } = string.Empty;
        [Required]
        public string DescriptionLarge { get; set; } = string.Empty;
        [Required]
        public string ObjectivePublic { get; set; } = string.Empty;
        [Required]
        public string Objectives { get; set;} = string.Empty;
        [Required]
        public string Requirements { get; set; } = string.Empty;
        [Required]
        public LevelNames Level { get; set; }
    }
}
