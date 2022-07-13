//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lost_And_Found.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Found_Product = new HashSet<Found_Product>();
            this.Lost_Product = new HashSet<Lost_Product>();
            this.Messages_Details = new HashSet<Messages_Details>();
        }
    
        public long Product_ID { get; set; }
        public Nullable<long> Postedby { get; set; }
        public string Product_Name { get; set; }
        public string Product_Category { get; set; }
        public string Product_Image { get; set; }
        public string Product_Description { get; set; }
        public System.DateTime Product_Created_ON { get; set; }
        public string Product_Location { get; set; }
        public bool Product_IsActive { get; set; }
    
        public virtual App_User App_User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Found_Product> Found_Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lost_Product> Lost_Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Messages_Details> Messages_Details { get; set; }
    }
}
