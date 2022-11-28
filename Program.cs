using System;

namespace StopWatch
{
  class StopWatch
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("Escolha quando tempo deseja contar: ");
      Console.WriteLine("");

      Console.WriteLine("Para minutos utilize o m ao final do tempo escolhido!");
      Console.WriteLine("");

      Console.WriteLine("Para segundos utilize o s ao final do tempo escolhido! ");
      Console.WriteLine("");

      string data = Console.ReadLine().ToLower();
      char type = char.Parse(data.Substring(data.Length -1, 1));
      int time = int.Parse(data.Substring(0, data.Length -1));
      int multiplier = 1;

      if (type == 'm') multiplier = 60;

      if (time == 0) System.Environment.Exit(0);

      int exacTime = time * multiplier;

      PreStart(exacTime);
      Console.WriteLine("Tempo Finalizado!");
    }

    static void PreStart(int time)
    {
      Console.Clear();
      Console.WriteLine("Ready...!");
      Thread.Sleep(1000);

      Console.WriteLine("Set...!");
      Thread.Sleep(1000);

      Console.WriteLine("Go...!");
      Thread.Sleep(2500);

      Start(time);
    }
    static void Start(int time)
    {
      int currentTime = 0;
      while(currentTime != time)
      {
         Console.Clear();
         currentTime++;
         Console.WriteLine(currentTime);
         Thread.Sleep(1000);
      }
    }
  }
}