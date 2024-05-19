/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package beans;


import backend.TemperatureService;
import javax.enterprise.context.RequestScoped;
import javax.inject.Named;

@Named(value = "data")
@RequestScoped
public class CelsiusDataBean {
    float eingabe;
    float ergebnis;
    //getter/setter ...l

    public float getEingabe() {
        return eingabe;
    }

    public void setEingabe(float eingabe) {
        this.eingabe = eingabe;
    }

    public float getErgebnis() {
        return ergebnis;
    }

    public void setErgebnis(float ergebnis) {
        this.ergebnis = ergebnis;
    }
}
