//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebForm_V1.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class disbursement_list
    {
        public int disbursement_list_id { get; set; }
        public int disbursement_list_item_qty { get; set; }
        public int disbursement_list_item_balance { get; set; }
        public string item_item_id { get; set; }
        public int department_department_id { get; set; }
    
        public virtual department department { get; set; }
        public virtual item item { get; set; }
    }
}
