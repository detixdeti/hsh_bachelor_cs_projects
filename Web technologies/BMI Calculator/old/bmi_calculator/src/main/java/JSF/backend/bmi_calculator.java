/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package JSF.backend;

/**
 *
 * @author uni
 */
public class bmi_calculator {

    private static double max = 0;
    private static bmi_calculator cal = null;

    
    public static bmi_calculator getCalculator() {
        if (cal == null) {
            cal = new bmi_calculator();
        }
        return cal;
    }

    public double calculateBMI(double weight, double height) {
        double bmi = weight / ((height/100) * (height/100));
        bmi = Math.round(bmi * 100.0)/100.0;
        if (bmi > max)
            max = bmi;
       
        return bmi;
    }

    public String bmiMessage(double weight, double height) {
        double bmi = weight / ((height/100) * (height/100));
        bmi = Math.round(bmi * 100.0)/100.0;

        if (bmi < 18.5) {
            return "Ein Wert unter 18,5 wird als Untergewicht eingestuft!";
        } else if (bmi > 25) {
            return "Ab 25,0 bis 29,9 spricht man von Übergewicht!";
        } else if (bmi > 30){
            return "Ab einem BMI-Wert über 30 handelt es sich um Adipositas (Fettleibigkeit)!";
        }
        return "Das Normalgewicht eines Menschen liegt bei einem BMI von 18,5 bis 24,9!";
    }

    public double getMax() {
        return max;
    }

}
