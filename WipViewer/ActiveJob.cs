//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WipViewer
{
    using System;
    using System.Collections.Generic;
    
    public partial class ActiveJob
    {
        public int Batch { get; set; }
        public string BaseID { get; set; }
        public Nullable<int> Weld { get; set; }
        public Nullable<int> Machine { get; set; }
        public Nullable<int> Design { get; set; }
        public Nullable<int> Tracker { get; set; }
        public Nullable<int> Build { get; set; }
        public Nullable<decimal> Comp { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public string Type { get; set; }
        public Nullable<decimal> POValue { get; set; }
        public Nullable<decimal> Actual { get; set; }
        public Nullable<decimal> Margin { get; set; }
        public string ShipMonth { get; set; }
    }
}
