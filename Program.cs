using System;


public class Jogador{

      public int energia = 100;
      public bool situacao= true;

      }

      class teste{
        static void Main (){

          Jogador j1=new Jogador();
          Jogador j2=new Jogador();
          Jogador j3=new Jogador();

          j1.energia=89;
          j2.energia=74;
          j3.energia=39;
          
          Console.WriteLine("Vivo (True), Morto (False)");
          Console.WriteLine("Energia de Messi: {0}",j1.energia);
          Console.WriteLine("    ");
       
          Console.WriteLine("    ");
          Console.WriteLine("Messi está: {0}", j1.situacao);
          Console.WriteLine("    ");
          Console.WriteLine("    ");
          Console.WriteLine("    ");
          Console.WriteLine("Energia de CR7: {0}",j2.energia);
          Console.WriteLine("    ");
          Console.WriteLine("CR7 está: {0}", j2.situacao);
          Console.WriteLine("    ");
          Console.WriteLine("    ");
          Console.WriteLine("    ");
           Console.WriteLine("Energia de Neymar: {0}",j3.energia);
          Console.WriteLine("    ");
          Console.WriteLine("Neymar está: {0}", j3.situacao);
          Console.ReadLine();
        Console.Clear();
          




        }


      }
    
    



    

