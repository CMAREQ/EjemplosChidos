package dados;

import javax.swing.JOptionPane;


public class Dados {

    public static void main(String[] args) 
    {
       java.util.Random ran = new java.util.Random();
       java.util.Random dom = new java.util.Random();
       int d1, d2, suma1 = 0, suma2 = 0, emp = 0, turno = 1;
        for (int cont = 1; cont <= 10; cont ++)
        {
            d1 = (int) (ran.nextDouble() * 6 + 1);
            d2 = (int) (dom.nextDouble() * 6 + 1);
            if (d1 > d2)
            {
                JOptionPane.showMessageDialog(null,"Turno: " + turno + "\nDado 1: " + d1 + "    <======== Gana" + "\nDado 2: " + d2 + "    <======== Pierde");
                suma1 ++;
                turno ++;
            }
            if (d1 < d2)
            {
                JOptionPane.showMessageDialog(null,"Turno: " + turno + "\nDado 1: " + d1 + "    <======== Pierde" + "\nDado 2: " + d2 + "    <======== Gana");
                suma2 ++;
                turno ++;
            }
            if (d1 == d2)
            {
                JOptionPane.showMessageDialog(null,"Turno: " + turno + "\nDado 1: " + d1 + "\nDado 2: " + d2 + "\n        Empate");
                emp ++;
                turno ++;
            }
                                   
        }
        JOptionPane.showMessageDialog(null,"    Numero de veces ganadas" + "\nDado 1: " + suma1 + "\nDado 2: "+ suma2 + "\nEmpates: " + emp);
        if(suma1 > suma2)
        {
            JOptionPane.showMessageDialog(null,"El dado número 1 es el ganador");
        }
        if (suma1 < suma2)
        {
            JOptionPane.showMessageDialog(null, "El dado número 2 es el ganador");
        }
        if (suma1 == suma2)
        {
            JOptionPane.showMessageDialog(null, "Empate");
        }
    }
    
}
