using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrightIdeas.Core.Entities
{
    public class Idea
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Title { get; set; }


        [Required]
        [ForeignKey("TypeId")]
        public IdeaType Type { get; set; }
        public int TypeId { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}
