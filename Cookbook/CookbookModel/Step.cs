//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CookbookModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Step
    {
        public Step()
        {
            this.Recipes = new HashSet<Recipe>();
        }
    
        public int ID { get; set; }
        public string Instruction { get; set; }
        public int numStep { get; set; }
    
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
