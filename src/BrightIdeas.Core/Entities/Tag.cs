using System.ComponentModel.DataAnnotations;

namespace BrightIdeas.Core.Entities
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Idea> Ideas { get; set; }
    }
}
