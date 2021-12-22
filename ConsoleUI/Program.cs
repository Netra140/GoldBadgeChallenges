using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaimRepo claimRepo = new ClaimRepo();
            ClaimUI cui = new ClaimUI(claimRepo);
            GreetingRepo GreetingRepo = new GreetingRepo();
            GreetingUI gui = new GreetingUI(GreetingRepo);
            MenuRepo MenuRepo = new MenuRepo();
            CafeUI cafui = new CafeUI(MenuRepo);
            Console.WriteLine("Pick an editor by typing 'Claim', 'Greeting', or 'Cafe'");
            string challenge = Console.ReadLine();
            if (challenge == "Claim" || challenge == "claim") {
                cui.Commands();
            } else if (challenge == "Greeting" || challenge == "greeting")
            {
                gui.Commands();
            } else if (challenge == "Cafe" || challenge == "cafe") {
                cafui.Commands();        
            }
        }
    }
}
