using System;
using System.Collections.Generic;

namespace Ucu.Poo.Defense
{
    public class ResidueType
    {
        public string Name { get; set; }

        public bool IsOrganic { get; set; }

        public ResidueType(Residue name, bool isOrganic)
        {
            this.IsOrganic = isOrganic;
            Residue residu = new Residue (name);
            this.residu = residu;
        }
    }
}