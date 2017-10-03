package ejercicio;


public class Ejercicio {
    public static void main(String[] args) 
    {
        int suma = 0, cont;
        for (cont = 1; cont <= 100; cont ++)
        {
            System.out.println(cont);
            suma = cont + suma;
        }
        System.out.println(suma);
    }
    
}
