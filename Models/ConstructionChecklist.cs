using System;
using Microsoft.AspNetCore.Http;

namespace construction_checklist.Models
{
    public class ConstructionChecklist
    {
        public string Construction { get; set; }

        public string Eclairage { get; set; }
        public IFormFile PhotoEclairage { get; set; }
        public string CommentsEclairage { get; set; }

        public string Hygrometrie { get; set; }
        public IFormFile PhotoHygrometrie { get; set; }
        public string CommentsHygrometrie { get; set; }
    }
}
