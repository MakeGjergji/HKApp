//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyTest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cleaner_Task
    {
        public string cleaner_id { get; set; }
        public string task_id { get; set; }
        public string room_id { get; set; }
    
        public virtual Cleaner Cleaner { get; set; }
        public virtual Room Room { get; set; }
        public virtual Task Task { get; set; }
    }
}
