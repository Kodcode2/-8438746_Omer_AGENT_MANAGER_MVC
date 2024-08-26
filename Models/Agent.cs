using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Agent_Management_Client.Models
{
    public class Agent
    {
        [Key]
        public int AgentId { get; set; }
        public string nickname { get; set; }
        public string photoUrl { get; set; }
        public string? direction { get; set; }
        public status_enum_agent status { get; set; }
        [NotMapped]
        public Location? location { get; set; }

        public int locationY { get; set; }
        public int locationX { get; set; }
    }
}
