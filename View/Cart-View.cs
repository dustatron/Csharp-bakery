using System;
using System.Collections.Generic;
using System.Drawing;
using Console = Colorful.Console;
using StyleSheet = Colorful.StyleSheet;
using Bakery.Model;

namespace Bakery.View
{
  class CartMenu
  {
    public static string Print()
    {
      Console.Clear();
      Console.WriteLine(@"

                          =================================================
                            ______      ___      .______     .___________.
                           /      |    /   \     |   _  \    |           |
                          |  ,----'   /  ^  \    |  |_)  |   `---|  |----`
                          |  |       /  /_\  \   |      /        |  |     
                          |  `----. /  _____  \  |  |\  \----.   |  |     
                           \______|/__/     \__\ | _| `._____|   |__|     
                         ================================================= 
                                                                          
      ", Color.Red);

      StyleSheet styleSheet = new StyleSheet(Color.Green);
      styleSheet.AddStyle("1[1-9]*", Color.Red);
      styleSheet.AddStyle("2[1-9]*", Color.Cyan);
      styleSheet.AddStyle("M[A-Z]", Color.White);

      //Menu string
      string Menu = (@"
        | [1] Checkout                 | 
        | [2] See Daily Deals          |
        | [M] Main Menu                |
        ");

      Cart.PrintItems();
      //print Menu
      Console.WriteStyled(Menu, styleSheet);
      Console.Write("Enter : ", Color.Green);
      string input = Console.ReadLine().ToLower();
      return input;

    }

  }

  class CartCheckout
  {
    public static void Print()
    {

      Console.Clear();
      Console.WriteLine(@"
         ===================================================================================
           ______  __    __   _______   ______  __  ___   ______    __    __  .___________.
          /      ||  |  |  | |   ____| /      ||  |/  /  /  __  \  |  |  |  | |           |
         |  ,----'|  |__|  | |  |__   |  ,----'|  '  /  |  |  |  | |  |  |  | `---|  |----`
         |  |     |   __   | |   __|  |  |     |    <   |  |  |  | |  |  |  |     |  |     
         |  `----.|  |  |  | |  |____ |  `----.|  .  \  |  `--'  | |  `--'  |     |  |     
          \______||__|  |__| |_______| \______||__|\__\  \______/   \______/      |__|     
        ====================================================================================                                                                                     
      ", Color.Green);
      string input = Console.ReadLine();

    }
  }

  class DailyDeal
  {
    public static void Print()
    {
      Console.Clear();
      Console.WriteLine(@"

                      ========================================================
                         _______       ___       __   __      ____    ____ 
                        |       \     /   \     |  | |  |     \   \  /   / 
                        |  .--.  |   /  ^  \    |  | |  |      \   \/   /  
                        |  |  |  |  /  /_\  \   |  | |  |       \_    _/   
                        |  '--'  | /  _____  \  |  | |  `----.    |  |     
                        |_______/ /__/     \__\ |__| |_______|    |__|     
                                                                           
                       _______   _______      ___       __           _______.
                      |       \ |   ____|    /   \     |  |         /       |
                      |  .--.  ||  |__      /  ^  \    |  |        |   (----`
                      |  |  |  ||   __|    /  /_\  \   |  |         \   \    
                      |  '--'  ||  |____  /  _____  \  |  `----..----)   |   
                      |_______/ |_______|/__/     \__\ |_______||_______/    
                    ===========================================================                                                                                      
      ", Color.Red);
      Console.WriteLine("Daily deal");
      Console.Write("Enter : ");
      string input = Console.ReadLine();
    }
  }

}