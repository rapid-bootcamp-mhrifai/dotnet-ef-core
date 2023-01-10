using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_mvc_ef_core.DataContext
{
    [Table("tbl_customer")]
    public class CustomerEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("customer_name")]
        public String Name { get; set; }

        [Column("address")]
        public String Address { get; set; }

        [Column("gender")]
        public String Gender { get; set; }

        [Column("city")]
        public String City { get; set; }
    }
}
