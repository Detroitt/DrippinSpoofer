using System;

namespace HWIDSpoofer
{
    class Program
    {
        
        public static string textLogo =
            @"" + Environment.NewLine +
            @"$$$$$$$\            $$\                     $$\                  $$$$$$\                                 $$$$$$\                     " + Environment.NewLine +
            @"$$  __$$\           \__|                    \__|                $$  __$$\                               $$  __$$\               " + Environment.NewLine +
            @"$$ |  $$ | $$$$$$\  $$\  $$$$$$\   $$$$$$\  $$\ $$$$$$$\        $$ /  \__| $$$$$$\   $$$$$$\   $$$$$$\  $$ /  \__|$$$$$$\   $$$$$$\ " + Environment.NewLine +
            @"$$ |  $$ |$$  __$$\ $$ |$$  __$$\ $$  __$$\ $$ |$$  __$$\       \$$$$$$\  $$  __$$\ $$  __$$\ $$  __$$\ $$$$\    $$  __$$\ $$  __$$\ " + Environment.NewLine +
            @"$$ |  $$ |$$ |  \__|$$ |$$ /  $$ |$$ /  $$ |$$ |$$ |  $$ |       \____$$\ $$ /  $$ |$$ /  $$ |$$ /  $$ |$$  _|   $$$$$$$$ |$$ |  \__|" + Environment.NewLine +
            @"$$ |  $$ |$$ |      $$ |$$ |  $$ |$$ |  $$ |$$ |$$ |  $$ |      $$\   $$ |$$ |  $$ |$$ |  $$ |$$ |  $$ |$$ |     $$   ____|$$ |      " + Environment.NewLine +
            @"$$$$$$$  |$$ |      $$ |$$$$$$$  |$$$$$$$  |$$ |$$ |  $$ |      \$$$$$$  |$$$$$$$  |\$$$$$$  |\$$$$$$  |$$ |     \$$$$$$$\ $$ |      " + Environment.NewLine +
            @"                        $$ |      $$ |                                    $$ |                                                       " + Environment.NewLine +
            @"                        $$ |      $$ |                                    $$ |                                                       " + Environment.NewLine +
            @"                        \__|      \__|                                    \__|                                                       " + Environment.NewLine; 


        static void Main(string[] args) // 
        {
        begin:
            Console.Title = "Drippin Spoofer ";
            
            Console.ResetColor();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(textLogo);
            Console.WriteLine("  ┌─────────────────────────────────────────┐");
            Console.WriteLine("  │ [/hwid] Spoof  ur HWID                  │");
            Console.WriteLine("  │ [/guid] Spoof ur Guid                   │");
            Console.WriteLine("  │ [/pcName] Spoof ur Computer Name        │");
            Console.WriteLine("  │ [/productId] Spoof ProductId            │");
            Console.WriteLine("  └─────────────────────────────────────────┘");
            Console.WriteLine("  ┌─────────────────────────────────────────┐");
            Console.WriteLine("  │Discord ID: 476140629899083798           │");
            Console.WriteLine("  └─────────────────────────────────────────┘");

            string input = Console.ReadLine();
            if(input == "/hwid") 
            {
                Console.Clear();
                Console.WriteLine(textLogo);
                if (Spoofer.HWID.Spoof())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Spoofer.HWID.Log.ToString());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Spoofer.HWID.Log.ToString());
                }
                Console.ReadLine();
                goto begin;
            }
            else if (input == "/guid")
            {
                Console.Clear();
                Console.WriteLine(textLogo);
                if (Spoofer.PCGuid.Spoof())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Spoofer.PCGuid.Log.ToString());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Spoofer.PCGuid.Log.ToString());
                }
                Console.ReadLine();
                goto begin;
            }
            else if (input == "/pcName")
            {
                Console.Clear();
                Console.WriteLine(textLogo);
                if (Spoofer.PCName.Spoof())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Spoofer.PCName.Log.ToString());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Spoofer.PCName.Log.ToString());
                }
                Console.ReadLine();
                goto begin;
            }
            else if (input == "/productId")
            {
                Console.Clear();
                Console.WriteLine(textLogo);
                if (Spoofer.ProductId.Spoof())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Spoofer.ProductId.Log.ToString());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Spoofer.ProductId.Log.ToString());
                }
                Console.ReadLine();
                goto begin;
            }
            else
            {
                goto begin;
            }
        }
    }
}
