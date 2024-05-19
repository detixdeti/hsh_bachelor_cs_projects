package beans;

import javax.enterprise.context.RequestScoped;
import javax.inject.Named;

@Named(value = "ageNavigator")
@RequestScoped
public class AgeNavigator {
    public String goTo(Person p){
        if (p.getAlter() >= 18)
            return "ageAdult";
        else
            return "ageYoung";
    }
}

