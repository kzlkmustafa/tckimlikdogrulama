using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace tckimlikdogrulama.Model
{
    public class signupModel
    {
        [Key]
        public int SignupId { get; set; }
        public long? TCKimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumYili { get; set; }
        public string Email { get; set; }
        public string metamaskaddress { get; set; }
    }
}
