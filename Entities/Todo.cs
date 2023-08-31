using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Entities
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime EndAt { get; set; } = DateTime.Now.AddDays(1);

        [ForeignKey("UserId")]
        public User User { get; set; } = default!;
        public Guid UserId { get; set; }

    }
}