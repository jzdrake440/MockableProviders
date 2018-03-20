using System;
using System.Collections.Generic;
using System.Text;

namespace CodeGenerator.Model
{
    public class OutputSettings
    {
        public string FileName { get; set; }
        public string SolutionDirectory { get; set; }
        public string ProjectDirectory { get; set; }
        public string ProjectName { get; set; }
    }
}
