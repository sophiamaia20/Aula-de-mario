//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AulaScaffoldFramework.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class REQUISICAO
    {
        public int ID_REQ { get; set; }
        public int ID_CLI { get; set; }
        public Nullable<decimal> TOTAL_REQ { get; set; }
        public Nullable<int> QTD_ITEN { get; set; }
        public System.DateTime DATA_REQ { get; set; }
        public int ANO { get; set; }
        public int MES { get; set; }
        public int ID_SEC { get; set; }
        public Nullable<int> ID_SET { get; set; }
        public string OBSERVACAO { get; set; }
    }
}
