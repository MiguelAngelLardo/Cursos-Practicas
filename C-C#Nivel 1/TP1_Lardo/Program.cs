using System;

namespace TP1_Lardo
{
    class Program
    {
        static void Main(string[] args)
        {
           int numero, mayornumeropar=0,contadorimpar=0,menornumprimo=0;
           bool banderapar=false, banderaprimo=false; 

           Console.WriteLine("Ingrese un Numero (Corta con Cero):");
           numero=int.Parse(Console.ReadLine());

            while (numero!=0)
            {
             Console.WriteLine("Ingrese un Numero (Corta con Cero):");
             numero=int.Parse(Console.ReadLine());            
              if (numero%2==0)
               {
                 if (banderapar==false)
                  {
                   mayornumeropar=numero;
                   banderapar=true;
                  }  
                 else if (numero>mayornumeropar)
                  {
                   mayornumeropar=numero;
                  }
               }
                else if (numero%2 != 0)
                  contadorimpar++;

              int contadorprimoB=0, j=1;
                  
                  while (j<=numero)
                   {                                      
                    if (numero%j==0)
                     {
                       contadorprimoB++;
                     }
                    j++; 

                    if (contadorprimoB==2 && banderaprimo==false)                     
                      {
                        menornumprimo=numero;
                        banderaprimo=true;
                      }
                     else if (numero<menornumprimo)
                      {
                        menornumprimo=numero;
                      }   
                   } 

                                         
            }             
            
             Console.WriteLine("El mayor de los números pares es: " + mayornumeropar + " ,la cantidad todal de números impares es: " + contadorimpar + " y el menor de los números primos es: " + menornumprimo);
                     



         }
          

 
            
    }

}


