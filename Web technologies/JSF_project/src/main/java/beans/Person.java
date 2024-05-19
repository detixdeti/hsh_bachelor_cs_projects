package beans;

import javax.enterprise.context.RequestScoped;
import javax.inject.Named;

@Named(value = "person")
@RequestScoped
public class Person {
    private int alter;
    private String nickname;
    
    
    public int getAlter() {
        return alter;
    }
    public void setAlter(int alter) {
        this.alter = alter;
    }
    

    public String getNickname() {
        return nickname;
    }
    public void setNickname(String vorname) {
        this.nickname = vorname;
    }
    
    public String toString(){
        return this.nickname + "  age:" + this.alter;
    }
    

}
