using System;

namespace PASSWORD_GENERATOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string charRepo = "!abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rando = new Random();
            int ranNum1 = rando.Next(0, charRepo.Length);
            int ranNum2 = rando.Next(0, charRepo.Length);
            int ranNum3 = rando.Next(0, charRepo.Length);
            int ranNum4 = rando.Next(0, charRepo.Length);
            int ranNum5 = rando.Next(0, charRepo.Length);
            int ranNum6 = rando.Next(0, charRepo.Length);
            int ranNum7 = rando.Next(0, charRepo.Length);
            int ranNum8 = rando.Next(0, charRepo.Length);
            int ranNum9 = rando.Next(0, charRepo.Length);
            int ranNum10 = rando.Next(0, charRepo.Length);
            int ranNum11 = rando.Next(0, charRepo.Length);
            int ranNum12 = rando.Next(0, charRepo.Length);
            int ranNum13 = rando.Next(0, charRepo.Length);
            int ranNum14 = rando.Next(0, charRepo.Length);
            int ranNum15 = rando.Next(0, charRepo.Length);
            int ranNum16 = rando.Next(0, charRepo.Length);
            int ranNum17 = rando.Next(0, charRepo.Length);
            int ranNum18 = rando.Next(0, charRepo.Length);
            int ranNum19 = rando.Next(0, charRepo.Length);
            int ranNum20 = rando.Next(0, charRepo.Length);

            char ranChar1 = charRepo[ranNum1];
            char ranChar2 = charRepo[ranNum2];
            char ranChar3 = charRepo[ranNum3];
            char ranChar4 = charRepo[ranNum4];
            char ranChar5 = charRepo[ranNum5];
            char ranChar6 = charRepo[ranNum6];
            char ranChar7 = charRepo[ranNum7];
            char ranChar8 = charRepo[ranNum8];
            char ranChar9 = charRepo[ranNum9];
            char ranChar10 = charRepo[ranNum10];
            char ranChar11 = charRepo[ranNum11];
            char ranChar12 = charRepo[ranNum12];
            char ranChar13 = charRepo[ranNum13];
            char ranChar14 = charRepo[ranNum14];
            char ranChar15 = charRepo[ranNum15];
            char ranChar16 = charRepo[ranNum16];
            char ranChar17 = charRepo[ranNum17];
            char ranChar18 = charRepo[ranNum18];
            char ranChar19 = charRepo[ranNum19];
            char ranChar20 = charRepo[ranNum20];

            Console.WriteLine($"Your 20-character randomly generated PASSWORD is:");
            Console.WriteLine();
            Console.WriteLine($"{ranChar1}{ranChar2}{ranChar3}{ranChar4}{ranChar5}{ranChar6}-{ranChar7}{ranChar8}{ranChar9}{ranChar10}{ranChar11}{ranChar12}-{ranChar13}{ranChar14}{ranChar15}{ranChar16}{ranChar17}{ranChar18}{ranChar19}{ranChar20}");
            Console.WriteLine();
        }
    }
}
