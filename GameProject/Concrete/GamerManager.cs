using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        // Eğer bir sınıfın içerisinde başka bir sınıfı kullanmak istiyorsak asla onu new'leme! 
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService; //new'lemediğimiz için bu şekilde yaptık.
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine(gamer.FirstName + "Kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Doğrulama ve kayıt başarısız!!!");
            }
        }

        public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + "Kayıt silindi.");
            }
            else
            {
                Console.WriteLine("Doğrulama ve silme başarısız!!!");
            }
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + "Kayıt güncellendi.");
            }
            else
            {
                Console.WriteLine("Doğrulama ve güncelleme başarısız!!!");
            }
        }
    }
}
