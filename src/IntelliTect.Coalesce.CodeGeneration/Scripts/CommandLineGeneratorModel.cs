﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Web.CodeGeneration.CommandLine;

namespace IntelliTect.Coalesce.CodeGeneration.Scripts
{
    public class CommandLineGeneratorModel
    {
        [Option(Name = "dataContext", ShortName = "dc", Description = "DbContext class to use")]
        public string DataContextClass { get; set; }

        [Option(Name = "force", ShortName = "f", Description = "Use this option to overwrite existing files")]
        public bool Force { get; set; }

        [Option(Name = "relativeFolderPath", ShortName = "outDir", Description = "Specify the relative output folder path from project where the file needs to be generated, if not specified, file will be generated in the project folder")]
        public string RelativeFolderPath { get; set; }
        [Option(Name = "onlyGenerateFiles", ShortName="filesOnly", Description = "Will only generate the file output and will not restore any of the packages.")]
        public bool OnlyGenerateFiles { get; set; }
        [Option(Name = "validateOnly", ShortName = "validateOnly", Description = "Validates the model but does not generate the models.")]
        public bool ValidateOnly { get; set; }
        [Option(Name = "area", ShortName = "a", Description = "The area where the generated/scaffolded code should be placed.")]
        public string AreaLocation { get; set; }
        [Option(Name = "module", ShortName = "module", Description = "The prefix to apply to the module name of the generated typescript files.")]
        public string TypescriptModulePrefix { get; set; }
        [Option(Name = "namespace", ShortName = "namespace", Description = "Target Namespace for the generated code.")]
        public string TargetNamespace { get; set; }
    }
}
