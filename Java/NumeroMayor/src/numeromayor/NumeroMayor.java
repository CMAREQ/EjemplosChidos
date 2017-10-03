package numeromayor;
import javax.swing.*;

public class NumeroMayor {

    public static void main(String[] args) 
    {
        int n1, n2;
        n1 = Integer.parseInt(JOptionPane.showInputDialog(null,"Primer Numero"));
        n2 = Integer.parseInt(JOptionPane.showInputDialog(null,"Segundo Numero"));
        if (n1 > n2)
        {
            JOptionPane.showMessageDialog(null, "Primer numero: " + n1 + "    <======== Mayor" + "\nSegundo numero: " + n2 + "    <======== Menor");
        }
        if (n1 < n2)
        {
            JOptionPane.showMessageDialog(null, "Primer numero: " + n1 + "    <======== Menor" + "\nSegundo numero: " + n2 + "    <======== Mayor");  
        }
        if (n1 == n2)
        {
            JOptionPane.showMessageDialog(null, "Primer numero: " + n1 + "\nSegundo numero: " + n2 + "\nSon iguales");
        }
    }
    
}
