using System.ComponentModel.DataAnnotations.Schema;

namespace SzakmakApi.Models
{
    public class szakma
    {
        [ForeignKey("szakmaId")]
        public string id { get; set; }
        public string szakmaNev { get; set; }

        public ICollection<versenyzo> versenyzok { get; set; }

    }
}
