//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Baza
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class State
    {
        public State()
        {
            this.City = new HashSet<City>();
        }
    
        public int ID { get; set; }

        [Display(Name = "Dr�ava")]
        public string stateName { get; set; }
    
        public virtual ICollection<City> City { get; set; }
    }
}
