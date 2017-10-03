package ejercicio3;


public class Ejercicio3 {
    public static void main(String[] args) 
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
    
}
