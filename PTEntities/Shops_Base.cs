namespace PTEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shops_Base
    {
        [Key]
        public int ShopID { get; set; }

        public int UID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(20)]
        public string Tel { get; set; }

        public short? Status { get; set; }

        public DateTime? Created_At { get; set; }

        public DateTime? Update_At { get; set; }
    }
}
