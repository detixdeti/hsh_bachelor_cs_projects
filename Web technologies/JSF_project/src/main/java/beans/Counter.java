package beans;
import javax.inject.Named;
import javax.enterprise.context.SessionScoped;
import java.io.Serializable;

/**
 *
 * @author dunkel
 */

@Named(value = "counter")
@SessionScoped   
// musss SessionScoped sein, weil ganz viele HTTP-Requeset erfolgen
// und der Zähler weitergezählt werden mus

public class Counter implements Serializable{

    private int number;

    public int getNumber() {
        return number;
    }

    public void setNumber(int number) {
        this.number = number;
    }

    public void increment(){
        number++;
    }

}
