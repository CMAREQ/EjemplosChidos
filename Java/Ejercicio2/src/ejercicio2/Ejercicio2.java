package ejercicio2;
import javax.swing.*;
import java.util.*;

public class Ejercicio2 {
    public static void main(String[] args) 
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
    
}
