using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsRepository
{
    public class BugHistory
    {
        public int Id { get; set; }
        public Bug Bug { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public int Priority { get; set; }
        public int Severity { get; set; }
    }
}
