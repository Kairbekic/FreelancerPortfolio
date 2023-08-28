using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerPortfolio.Domain.Entity
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Skills { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public string ImgBig { get; set; }
        public string GitHubLink { get; set; }
    }
}
