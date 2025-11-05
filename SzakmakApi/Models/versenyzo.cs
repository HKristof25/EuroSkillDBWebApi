using System.ComponentModel.DataAnnotations;

namespace SzakmakApi.Models
{
    public class versenyzo
    {
        [Key]
        public int id {  get; set; }
        public string nev { get; set; }

        public string szakmaId { get; set; }
        public string orszagId { get; set; }
        public int pont {  get; set; }

    }
}
