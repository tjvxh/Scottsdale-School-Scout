using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottsdaleSchoolScout
{
    public class Result
    {
        public string description;
        public string imageName;

        public Result(string imageName, string description)
        {
            this.description = description;
            this.imageName = imageName;
        }
    }
}
