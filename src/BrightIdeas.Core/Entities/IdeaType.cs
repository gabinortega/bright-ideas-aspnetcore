using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Core.Entities
{
    public class IdeaType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

