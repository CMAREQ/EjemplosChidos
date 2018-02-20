package hanoi;

import java.util.Scanner;

public class Hanoi{

    static Scanner sc = new Scanner(System.in);
    
    static void hanoi(int N, int origen, int dest, int aux){
        
        if(N > 0){
            hanoi(N-1, origen, aux, dest);
            System.out.println("Se mueve de torre " + origen + " a torre " + dest);
            hanoi(N-1, aux, dest, origen);
        }
    }
    
    public static void main(String[] args){
        
        System.out.println("Ingresa el numero de discos: ");
        int N = sc.nextInt();
        hanoi(N, 1, 3, 2);
    }
}
