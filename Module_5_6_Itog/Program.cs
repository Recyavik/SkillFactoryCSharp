using System.Collections.Generic;
using System.ComponentModel;

namespace Module_5_6_Itog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var users = GetDataUser();
            Console.WriteLine(users);
        }

        static (string Name, string LastName, int Age, string isPets, string Pets) GetDataUser() 
        {
            (string Name, string LastName, int Age, string isPets, string Pets) User;
            
            Console.WriteLine("Введите имя: ");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите Фамилию: ");
            User.LastName = Console.ReadLine();

            string age = "";
            int intage;

            do
            {
                Console.WriteLine("Введите возраст: ");
                age = Console.ReadLine();
            } while (CheckNum(age, out intage) == false | (age == ""));
            User.Age = intage;

            string isPets = "";
            do
            {
                Console.WriteLine("У вас есть питомцы? [Да/Нет]: ");
                isPets = Console.ReadLine();
            } while (CheckYesNO(ref isPets) == false | (isPets == ""));
            User.isPets = isPets;
            

            string countPets = "";
            int intСountPets;

            if (isPets == "ДА")
            {
                do
                {
                    Console.WriteLine("Сколько у вас питомцев: ");
                    countPets = Console.ReadLine();
                } while (CheckNum(countPets, out intСountPets) == false | (countPets == ""));
                User.Pets = String.Join(", ", CreateArrayPets(intСountPets));
            }
            else
            {

                User.Pets = "";
            }
          
            return User;
        }

        static string[] CreateArrayPets(int count)
        {
            var result = new string[count];
            for (int i = 0; i<count; i ++)
            {
                Console.Write($"ВВедите кличку {i+1}-го питомца:", i);
                result[i] = Console.ReadLine();
            }
            Console.WriteLine(result);
            return result;
        }

        static bool CheckNum(string number, out int coormumber) 
        {
            bool isAge = int.TryParse(number, out int intnum);
            if (intnum > 0 && isAge)
            {
                coormumber = intnum;
                return true;
            }
            else
            {
                coormumber = 0;
                return false;
             }
        }

        static bool CheckYesNO(ref string isPets) 
        {
            if (isPets.ToUpper() is "ДА" or "YES" or "АГА" or "Y")
                {
                isPets = "ДА";
                return true;
                }
            else if (isPets.ToUpper() is "НЕТ" or "NO" or "НЕА" or "N")
            {
                isPets = "НЕТ";
                return true;
                }
            else
            {
                isPets = "";
                return (false);
            }

        }
    }
}