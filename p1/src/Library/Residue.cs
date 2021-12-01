using System;
using System.Collections.Generic;

namespace Ucu.Poo.Defense
{
    public class Residue
    {
        public string Name { get; set; }
        public ResidueType Resid { get; set; }
        public Residue(string name, ResidueType type)
        {
            this.Name = name;
            ResidueType resid = new ResidueType (type);
            this.Resid = resid;  
            
        }
    
    }
}