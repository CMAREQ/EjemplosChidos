package ejercicio5;

import java.util.Random;
import javax.swing.*;

public class Ejercicio5 {

    public static void main(String[] args) 
    {
        int prog;
        prog = Integer.parseInt(JOptionPane.showInputDialog(null,"Que programa desea usar el admirable usuario???"));
        if (prog == 1)
        {
             int suma = 0, cont;
        for (cont = 1; cont <= 100; cont ++)
        {
            System.out.println(cont);
            suma = cont + suma;
        }
        System.out.println(suma);
        }
        if (prog == 2)
        {
            Random  rmd = new Random();
        int suma = 0, cont, rdm;
        for (cont = 1;cont <= 100; cont ++)
        {
            rdm = (int)(rmd.nextDouble() * 10000 + 0);
            System.out.println(rdm);
            suma = suma + rdm;
        }
        System.out.println(suma);
        }
        if (prog == 3)
        {
            int suma = 0, cont = 1;
   
        while (cont <= 100)
        {
            if (cont % 2 == 0)
            {
            System.out.println(cont);
            suma = suma + cont;
            }
            cont ++;
        }
        
        System.out.println(suma);
        }
        if (prog == 4)
        {
            Random rndm = new Random();
        int suma = 0, cont = 1, ran;
        while (cont <= 100)
        {
            ran = (int) (rndm.nextDouble() * 10000 + 0);
            if (ran % 2 == 0)
            {
            System.out.println(ran);
            suma = suma + ran;
            }
            cont ++;
        }
        System.out.println(suma);
        }
    }
    
}
