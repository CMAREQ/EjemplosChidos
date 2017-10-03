package aprobado;
import javax.swing.*;

public class Aprobado {

    public static void main(String[] args)
    {
        int calif;
        calif = Integer.parseInt(JOptionPane.showInputDialog(null,"Calificacion obtenida"));
        if (calif >= 70)
        {
            JOptionPane.showMessageDialog(null, calif + "       =       Aprobado");
        }
        else
        {
            JOptionPane.showMessageDialog(null, calif + "       =       NO Aprobado");
        }
    }
    
}
