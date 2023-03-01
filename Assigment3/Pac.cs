using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assigment3
{
    public class Pac
    {
        public int PacId { get; set; }
        public string PacName { get; set; } = "";
        public DateTime Birthday { get; set; }
        public string Problem { get; set; } = "";
        public string Note { get; set; } = "";

        public Pac(int pacId, string pacName, DateTime birthday, string problem, string note)
        {
            PacId = pacId;
            PacName = pacName;
            Birthday = birthday;
            Problem = problem;  
            Note = Regex.Replace(note, @";", "\r\n");
        }

        public Pac()
        {
        }

        public override string ToString()
        {
                return $"{PacName} (Note:{PacId})";
        }
    }
}
