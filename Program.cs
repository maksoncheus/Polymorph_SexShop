using System.Linq;
namespace SexShop
{ internal class Program
   
    {
        static void Main(string[] args)
        {
            User _someUser = new User(
                "Дэбикс",
                "ул. Русская 1",
                400,
                5000
                );
            Condoms gusarskie = new Condoms(
                "Гусарские пр.",
                50,
                8
                );
            Condoms nevalyashka = new Condoms(
                "Неваляшка пр.",
                75,
                6
                );

            Condoms nevidimka = new Condoms(
                "Шапка-невидимка пр.",
                100,
                11
                );

            Dolls goose = new Dolls(
                "Гусь",
                200,
                "Гусыня"
                );

            Product[] products = {
                gusarskie,
                nevalyashka,
                nevidimka,
                goose
            };
            Informer informer = new Informer();
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Добро пожаловать в наш теплый райский уголок, {_someUser.Name}, ваш баланс : {_someUser.Balance} бразильских долларов");
                Console.WriteLine("Что бы вы хотели приобрести?");
                for(int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Товар {i+1}: {products[i].Name}. Стоимость: {products[i].Price}");
                }
                Console.WriteLine("0 : Выход");
                int chosenNumber = Convert.ToInt32(Console.ReadLine());
                if(chosenNumber >= 1 && chosenNumber < products.Length+1)
                {
                    if (products[chosenNumber-1].Price < _someUser.Balance)
                    {
                        informer.Buy(_someUser, products[chosenNumber - 1]);
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств!");
                    }
                }

                if (chosenNumber == 0) break;
                Console.ReadLine();
            }

            informer.Buy(_someUser, gusarskie);
            informer.Buy(_someUser, nevidimka);
            informer.Buy(_someUser, goose);
            
        }
    }
}