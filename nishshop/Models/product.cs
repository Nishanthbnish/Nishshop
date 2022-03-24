namespace nishshop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("product")]
    public partial class product
    {
        public int id { get; set; }

        [StringLength(50)]
        public string prodname { get; set; }

        public int? cat_id { get; set; }

        public int? brand_id { get; set; }

        public decimal? qty { get; set; }

        public decimal? price { get; set; }

        public virtual brand brand { get; set; }

        public virtual category category { get; set; }
    }
}
