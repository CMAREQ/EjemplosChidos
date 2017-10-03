package ejercicio4;
import java.util.*;

public class Ejercicio4 {

    public static void main(String[] args) 
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
