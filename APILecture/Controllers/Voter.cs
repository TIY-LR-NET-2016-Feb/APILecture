using System.ComponentModel.DataAnnotations;

namespace APILecture.Controllers
{
    public class Voter
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Party { get; set; }
        public string Token { get; set; }
    }
}