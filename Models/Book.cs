using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Book
    {
        public int Id { get; set; }
        
        [Display(Name = "ISBN")]
        public string Isbn { get; set; } = String.Empty;
        
        [Display(Name = "タイトル")]
        public string Title { get; set; } = String.Empty;

        [DataType(DataType.Currency)]
        [Display(Name = "価格")]
        public int Price { get; set; }
        
        [Display(Name = "出版社")]
        public string Publisher { get; set; } = String.Empty;
        
        [Display(Name = "刊行日")]
        public DateTime Published { get; set; }
        
        [Display(Name = "配布サンプル")]
        public bool Sample { get; set; }
    }
}
