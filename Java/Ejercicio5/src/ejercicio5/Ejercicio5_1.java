package ejercicio5;

import java.util.Random;
import javax.swing.*;


public class Ejercicio5 {
    
    public static void main(String[] args) 
    {
     int prog;
     prog = Integer.parseInt(JOptionPane.showInputDialog("¿Que programa quiere usar?"));
     if (prog == 1)
     {
         int suma = 0, cont;
         for (cont = 1; cont <= 100; cont++)
         {
             System.out.println(cont);
             suma += cont;
         }
         System.out.println(suma);
     }
     if (prog == 2)
     {
         Random r = new Random();
         int suma = 0, cont, ran;
         for(cont = 1; cont <= 100; cont++)
         {
             ran = (int) (r.nextDouble() * 10000 + 0);
             System.out.println(ran);
             suma += ran;
         }
         System.out.println(suma);
     }
     if (prog == 3)
     {
       int suma = 0, cont = 1;
       while(cont <= 100)
       {
           if (cont % 2 == 0)
           {
               System.out.println(cont);
               suma += cont;
           }
           cont ++;
       }
         System.out.println(suma);
     }
     if (prog == 4)
     {
         Random r = new Random();
         int suma = 0, cont = 1, ran;
         while (cont <= 100)
         {
             ran = (int) (r.nextDouble() * 10000 + 0);
             if (ran % 2 == 0)
             {
                 System.out.println(ran);
                 suma += ran;
             }
             cont ++;
         }
         System.out.println(suma);
     }  }
    
}
