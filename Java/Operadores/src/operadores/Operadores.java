package operadores;

public class Operadores {

    public static void main(String[] args) 
    {
        int m = 30, n = 10, resultado;
        resultado = m + n;
        System.out.println("\tOperaciones con operandos m = 30 y n = 10");
        System.out.println("Operador suma + resultado: " + (int) resultado);
        resultado = m - n;
        System.out.println("Operador resta - resultado: " + (int) resultado);
        resultado = m * n;
        System.out.println("Operador multiplicacion * resultado: " + (int) resultado);
        resultado = m / n;
        System.out.println("Operador division / resultado: " + (int) resultado);
        resultado = m % n;
        System.out.println("Operador residuo % resultado: " + (int) resultado);
        resultado = --m;
        System.out.println("Operador decremento -- resultado: " + (int) resultado);
        resultado = ++m;
        System.out.println("Operador incremento ++ resuktado: " + (int) resultado);
        resultado = m++;
        System.out.println("Operador incremento ++ resultado: " + (int) resultado);
        resultado = -m;
        System.out.println("Operador menos unitario - resultado: " + (int) resultado);
    }
    
}
