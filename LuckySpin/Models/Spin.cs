using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LuckySpin.Models
{
    public class Spin
    {
        public long Id { get; set; }
        [Required]
        public Boolean IsWinning { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }
    }
}
