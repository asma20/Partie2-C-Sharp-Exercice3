using System;

namespace Partie2_Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            String sexe;
            Console.WriteLine("Quelle est votre age");
            age=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quelle votre sexe");
            sexe = Console.ReadLine();
            
            
            if (age > 18 && sexe.ToLower() == "homme") {
                Console.WriteLine("Vous êtes un homme et vous êtes majeur.");
               }else if (age < 18 && sexe.ToLower() == "homme")
                {
                    Console.WriteLine("Vous êtes un homme et vous êtes mineur. ");
                }
              else if(age > 18 && sexe.ToLower() == "femme") {
                Console.WriteLine("Vous êtes une femme et vous êtes majeure.");
            }
            else if (age > 18 && sexe.ToLower() == "femme") 
            {
                Console.WriteLine("Vous êtes une femme et vous êtes mineure.");
            }

        }
    }
}
