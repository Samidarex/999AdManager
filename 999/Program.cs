using System;
using _999.Models;
using OpenQA.Selenium.Chrome;

namespace _999
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();
            var driver999 = new Base(driver);
            var login = "testLogin";
            var password = "testPassword";
            driver999.Login(login, password);

            var _999Product = new _999Products()
            {
                Categories = new string[]
                {
                    "Транспорт",
                    "Телефоны,связь и гаджеты",
                    "Строительство и ремонт",
                    "Мебель и интерьер",
                    "Всё остальное",
                    "Бытовая техника",
                    "Услуги",
                    "Туризм, отдых и развлечения",
                    "Все для дома и офиса",
                    "Сельское хозяйство",
                    "Музыкальные инструменты",
                    "Недвижимость",
                    "Компьютеры и оргтехника",
                    "Одежда обувь и аксессуары",
                    "Аудио-Видео-Фото",
                    "Всё для торжеств",
                    "Работа",
                    "Спорт здоровье красота",
                    "Бизнес",

                },
                Title = "Test",
                Description = "TestDescription",
                OfferType = _999OfferType.Sell,
                ImagesUrl = null,
                Price = 100,
                State = _999State.New
               
            };
            driver999.Publish(_999Product);
        }
    }
}
