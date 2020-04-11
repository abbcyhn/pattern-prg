namespace PRGPattern.ViewModels
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class UserViewModel
    {
        [DisplayName("Ad:")]
        [Required(ErrorMessage = "Ad boş ola bilməz")]
        public string FirstName { get; set; }

        [DisplayName("Soyad:")]
        [Required(ErrorMessage = "Soyad boş ola bilməz")]
        public string LastName { get; set; }

        [DisplayName("Ata adı:")]
        [Required(ErrorMessage = "Ata adı boş ola bilməz")]
        public string Patronymic { get; set; }
    }
}