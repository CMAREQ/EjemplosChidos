package radio;
import javax.swing.*;
import java.text.DecimalFormat;
public class Radio {
    
    public static void main(String[] args)
    {
        DecimalFormat df = new DecimalFormat("#.####");
        double r, a;
        r = Double.parseDouble(JOptionPane.showInputDialog(null,"Radio de la circunferencia"));
        a = Math.PI  * (Math.pow(r, 2));
        JOptionPane.showMessageDialog(null,"La circunferencia con Radio: " + r + " tiene un area de: " + df.format(a));
    }
    
}
