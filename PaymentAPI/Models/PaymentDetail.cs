using System.ComponentModel.DataAnnotations;

namespace PaymentAPI.Models
{
    public class PaymentDetail
    {
        
        public int PaymentDetailId { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(50)]
        public string CardOwnerName { get; set; }
        [Required]
        [MinLength(16)]
        [MaxLength(16)]
        public string CardNumber { get; set; }
        [Required]
        [Range(minimum: 1000, maximum: 9999)]
        public int ExpirationDate { get; set; }
        [Required]
        [Range(minimum: 100, maximum: 999)]
        public int SecurityCode { get; set; }
    }
}
