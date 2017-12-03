namespace MvcTest11.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tvCustomerOrdersHistory")]
    public partial class tvCustomerOrdersHistory
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long numRowCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long numCustomerRef { get; set; }

        public int? numOrderSerialNo { get; set; }

        [StringLength(25)]
        public string strOrderCode { get; set; }

        [StringLength(10)]
        public string dtOrderDate { get; set; }

        public double? numOrderPrice { get; set; }

        public double? numOrderItemsCnt { get; set; }
    }
}
