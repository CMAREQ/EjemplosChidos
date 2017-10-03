package promediocalif;

import javax.swing.JOptionPane;


public class PromedioCalif {


    public static void main(String[] args) 
    {
        double c1, c2, c3;
        c1 = Double.parseDouble(JOptionPane.showInputDialog(null,"Primer Calificacion"));
        c2 = Double.parseDouble(JOptionPane.showInputDialog(null,"Segunda Calificacion"));
        c3 = Double.parseDouble(JOptionPane.showInputDialog(null,"Tercera Calificacion"));
        JOptionPane.showMessageDialog(null,"Calificacion 1: " + c1 + "\nCalificacion 2: " + c2 + "\nCalificacion 3: " + c3 + "\nPromedio: " + ((c1 + c2 + c3)/3));
    }
    
}
