package beans;

import javax.inject.Named;
import javax.enterprise.context.RequestScoped;

@Named(value = "ajaxTest")
@RequestScoped
public class AjaxTest {
    private String first, last , name;

    AjaxTest(){
        this.first = "Daisy";
        this.last ="Duck";
    }
    public String getName() {
        return first+ " " + last;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getFirst() {
        return first;
    }
    public void setFirst(String first) {
        this.first = first;
    }

    public String getLast() {
        return last;
    }
    public void setLast(String last) {
        this.last = last;
    }
}
