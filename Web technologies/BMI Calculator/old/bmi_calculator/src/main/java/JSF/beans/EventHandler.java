/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package JSF.beans;

import JSF.backend.bmi_calculator;
import java.util.Date;
import javax.enterprise.context.RequestScoped;
import javax.inject.Named;

/**
 *
 * @author uni
 */
@Named(value = "bean_handler")
@RequestScoped
public class EventHandler {
    
    public Date today() {
        return new Date();
    }
    
    public String calculateBMI(Person person) {
        bmi_calculator cal = bmi_calculator.getCalculator();
        double bmi = cal.calculateBMI(person.getWeight(),person.getHeight());
        person.setBmi(bmi);
        
        return "bmi_result.xhtml";
    }

    public String createMessage(Person person) {
       bmi_calculator cal = bmi_calculator.getCalculator();
       return cal.bmiMessage(person.getWeight(), person.getHeight());
    }

    public double getMax(){
        bmi_calculator cal = bmi_calculator.getCalculator();
        return cal.getMax();
    }
}

