namespace MvcTest11.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tvCustomer")]
    public partial class tvCustomer
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long numCustomerCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string strMobile { get; set; }

        [StringLength(70)]
        public string strName { get; set; }

        [StringLength(20)]
        public string strTel { get; set; }

        [StringLength(250)]
        public string strEmail { get; set; }

        public int? numTelegramChatID { get; set; }

        [StringLength(10)]
        public string strOstanRef { get; set; }

        [StringLength(10)]
        public string strCityRef { get; set; }

        [StringLength(500)]
        public string strLastAddress { get; set; }

        [StringLength(10)]
        public string dtEnterDate { get; set; }

        public int? numEnterRefCode { get; set; }

        public int? numStatus { get; set; }

        public int? numSex { get; set; }

        public int? numEmailIsValid { get; set; }

        [StringLength(10)]
        public string dtBirthDay { get; set; }

        [StringLength(10)]
        public string dtMarriageDay { get; set; }

        [StringLength(10)]
        public string dtRegisterDate { get; set; }

        public int? numSumHistoryBuyCnt { get; set; }
    }
}
