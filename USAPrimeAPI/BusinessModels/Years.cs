using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace USAPrimeAPI.BusinessModels
{
    public class Years
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Year_ID { get; set; }

        public string Year_Decode { get; set; }
    }
}
