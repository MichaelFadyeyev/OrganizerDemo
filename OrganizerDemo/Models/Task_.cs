using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerDemo.Models
{
    public class Task_
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public bool IsDone { get; set; }
        public bool Flagged { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
