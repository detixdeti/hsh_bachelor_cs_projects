/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package beans;

import java.io.Serializable;
import javax.enterprise.context.SessionScoped;
import javax.inject.Named;

/**
 *
 * @author lushaj
 */
@Named(value = "banes_tableControl")
@SessionScoped
public class DataTableControlBean implements Serializable {

    int nr;
    String vorname;
    String nachname;

    public DataTableControlBean() {

    }

    public String saveStudent() {
        
        return "DataTable_ShowStudents.xhtml";

    }

    public String editStudent(Student s) {
        this.nr = s.getNr();
        this.vorname = s.getFirstName();
        this.nachname = s.getLastName();

        return "DataTable_EditStudent.xhtml";
    }

    public int getNr() {
        return this.nr;
    }

    public String getVorname() {
        return this.vorname;
    }

    public String getNachname() {
        return this.nachname;
    }

}
