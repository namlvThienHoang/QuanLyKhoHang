//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKhoHang.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class InventoryReceiptDetail
    {
        public int ReceiptDetailID { get; set; }
        public Nullable<int> ReceiptID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public Nullable<decimal> Total { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual InventoryReceipt InventoryReceipt { get; set; }
    }
}
