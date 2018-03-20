using System;
using System.Collections.Generic;
using System.Text;

namespace CodeGenerator.Model
{
    public class GeneratorSettings
    {
        public static readonly OutputSettings DefaultOutputSettings = new OutputSettings
        {
            SolutionDirectory = ".." //this solution
        };
        public ProviderSettings Defaults { get; set; }
        public ProviderSettings[] Providers { get; set; }
    }
}
