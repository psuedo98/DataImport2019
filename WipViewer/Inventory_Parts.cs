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
    
    public partial class Inventory_Parts
    {
        public int id { get; set; }
        public string PartNumber { get; set; }
        public string JobNumber { get; set; }
        public Nullable<int> LotNumber { get; set; }
        public string DetailNumber { get; set; }
        public string MfgPart { get; set; }
        public string Nomenclature { get; set; }
        public string Supplier { get; set; }
        public Nullable<int> QtyReqdUnit { get; set; }
        public Nullable<int> QtyReqdTotal { get; set; }
        public string PO { get; set; }
    }
}
