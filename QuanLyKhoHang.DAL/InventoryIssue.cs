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
    
    public partial class InventoryIssue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InventoryIssue()
        {
            this.InventoryIssueDetails = new HashSet<InventoryIssueDetail>();
        }
    
        public int IssueID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryIssueDetail> InventoryIssueDetails { get; set; }
    }
}
