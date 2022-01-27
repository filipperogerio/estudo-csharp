using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FR.DependencyInjection.CasesDI.InRealLife
{
    public class BoardGame
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Designer { get; set; }
        public string Artist { get; set; }
        public string Publisher { get; set; }

    }
}
