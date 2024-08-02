using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Invoices.Data.DataConstraints;

namespace Invoices.Data.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ClientNameMaxLength)]
        public string Name { get; set; } = null!; // NVARCHAR(25)

        [Required]
        [MaxLength(ClientNumberVatMaxLength)]
        public string NumberVat { get; set; } = null!;

        public virtual ICollection<Address> Addresses { get; set; }
            = new HashSet<Address>();

        public virtual ICollection<Invoice> Invoices { get; set; }
            = new HashSet<Invoice>();

        public virtual ICollection<ProductClient> ProductsClients { get; set; }
            = new HashSet<ProductClient>();
    }
}