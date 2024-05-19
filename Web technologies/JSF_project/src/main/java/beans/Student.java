/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package beans;

import java.io.Serializable;

/**
 *
 * @author dunkel
 */
// keine Managed Bean !!!
public class Student implements Serializable {

    private  String firstName;
    private  String lastName;
    private  int nr;

    public Student(){
    
    }
    
    public Student(String firstName, String lastName, int nr) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.nr = nr;
    }

    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public void setNr(int nr) {
        this.nr = nr;
    }
    

    public String getLastName() {
        return lastName;
    }

    public int getNr() {
        return nr;
    }

}
