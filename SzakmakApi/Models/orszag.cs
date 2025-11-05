using System.ComponentModel.DataAnnotations.Schema;

namespace SzakmakApi.Models
{
    public class orszag
    {
        [ForeignKey("orszagId")]
        public string id { get; set; }
        public string orszagNev {  get; set; }
        public ICollection<versenyzo> versenyzok { get; set; }
    }
}
