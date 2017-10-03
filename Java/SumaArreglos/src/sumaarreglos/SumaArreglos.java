// Suma de números enteros definidos por el usuario almacenados en un arreglo.

package sumaarreglos;

import javax.swing.JOptionPane;

public class SumaArreglos {

    public static void main(String[] args) 
    {        
        int p  = Integer.parseInt(JOptionPane.showInputDialog(null,"Longitud del arreglo: "));
        
        int sum[] = new int[p];
        
        int suma = 0, n;
        
        for (int count = 0; count < sum.length; count++)
        {
            sum[count] = Integer.parseInt(JOptionPane.showInputDialog(null,"Valor " + (count + 1) + ":"));
            suma += sum[count];
        }
        
        for (int count = 0; count < sum.length; count++) // Ciclo for para imprimir elementos dentro del arreglo.
        {
            System.out.println(""+(count +1)+"\t"+sum[count]);
        }
        
        JOptionPane.showMessageDialog(null,"La suma de los elementos del arreglo es: " + suma); //Imprimir suma total usando JOptionPane.
    }
}