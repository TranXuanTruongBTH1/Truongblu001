using System.ComponentModel.DataAnnotations;
namespace truongblu001.Models;

    public class TXTStudent
    {
        [Key]
        public string? TXTID { get; set; }
        public string ?TXTSEX { get; set; }
        public string? TXTNAME {get; set;}
    }