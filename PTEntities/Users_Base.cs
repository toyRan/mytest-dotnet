namespace PTEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users_Base
    {
        [Key]
        public int UID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public int? Phone { get; set; }

        [StringLength(15)]
        public string Tel { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Avatar { get; set; }

        public short? Sex { get; set; }

        public DateTime? Birthday { get; set; }

        public short? Status { get; set; }

        public DateTime? Craeted_At { get; set; }

        public DateTime? Updated_At { get; set; }
    }
}
