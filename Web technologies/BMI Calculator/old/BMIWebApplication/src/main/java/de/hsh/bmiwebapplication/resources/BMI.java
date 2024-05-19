/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package de.hsh.bmiwebapplication.resources;

import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author SAbde
 */
@XmlRootElement
public class BMI {
    double bmi;
    String ergebnis;
    
    public BMI () {}
    
    public double getBmi() {
        return bmi;
    }
    
    public String getErgebnis() {
        return ergebnis;
    }

    public void setBmi(double bmi) {
        this.bmi = bmi;
    }

    public void setErgebnis(String ergebnis) {
        this.ergebnis = ergebnis;
    }
    
    public void evaluate(double gewicht, double groese) {
        setBmi((double) Math.round(gewicht / Math.pow(groese / 100, 2) * 100) / 100);
        if (bmi > 25) {
            setErgebnis("Sie sind übergewichtig");
        } else if (bmi < 20) {
            setErgebnis("Sie sind untergewichtig");
        } else {
            setErgebnis("Sie sind normalgewichtig");
        }
    }
}