using System.ComponentModel.DataAnnotations;
namespace truongblu001.Models;

    public class TXTCompany
    {
        [Key]
        public string? CompanyID { get; set; }
        public string ?CompanyName { get; set; }
        public string? AddressID {get; set;}
    }