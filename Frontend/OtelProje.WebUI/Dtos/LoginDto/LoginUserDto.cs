using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace OtelProje.WebUI.Dtos.LoginDto;

    public class LoginUserDto
    {
        [Required(ErrorMessage ="Kullanıcı Adı Giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifreyi Giriniz")]
        public string Password { get; set; }
    }

