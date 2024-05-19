/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bmiserver;

import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author dunkel
 */
@XmlRootElement
public class Person {
    // eingaben
    float height;
    float weight;
    
    // ausgaben
    float bmi = 0;
    String answer = "";

    public float getHeight() {
        return height;
    }

    public void setHeight(float height) {
        this.height = height;
    }

    public float getWeight() {
        return weight;
    }

    public void setWeight(float weight) {
        this.weight = weight;
    }

    public float getBmi() {
        return bmi;
    }

    public void setBmi(float bmi) {
        this.bmi = bmi;
    }

    public String getAnswer() {
        return answer;
    }

    public void setAnswer(String answer) {
        this.answer = answer;
    }

    public Person(float bmi, String answer) {
        this.bmi = bmi;
        this.answer = answer;
    }

    public Person() {
    }
    
    public String toString(){
        return "height:" + this.height + "  weight:" + this.weight 
                + "  bmi:" + this.bmi + " answer:" + this.answer;
    }
    
    
}
