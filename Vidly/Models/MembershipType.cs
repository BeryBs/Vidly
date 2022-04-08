using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; } //Ilgılı tablonun primary keyi ile eşleşebilmesi için burada bir key oluştur.
        public short SignUpFee { get; set; } //12 gıbı kucuk sayılar kullanılacagı ıcın short
        public byte DurationInMonths { get; set; } 
        public byte DiscountRate { get; set; } // 0 ile 100 arasında bır deger olacagı ıcın byte
        [Required]
        public string Name { get; set; }

    }
}