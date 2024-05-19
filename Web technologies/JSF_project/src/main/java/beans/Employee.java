
package beans;

import java.util.Date;
import javax.enterprise.context.RequestScoped;
import javax.inject.Named;
import javax.validation.constraints.DecimalMax;
import javax.validation.constraints.DecimalMin;
import javax.validation.constraints.Max;
import javax.validation.constraints.Min;
import javax.validation.constraints.NotNull;
import javax.validation.constraints.Past;
import javax.validation.constraints.Size;


@Named(value = "employee")
@RequestScoped
public class Employee {

    @NotNull
    @Size(min=3, max=10)
    private String nickname = "Daisy Duck";

    @Past
    private Date dateOfBirth = new Date();

    @DecimalMin("1000")
    @DecimalMax("2000")
    private int income = 1500;

  
    public Date getDateOfBirth() {
        return dateOfBirth;
    }

    public void setDateOfBirth(Date dateOfBirth) {
        this.dateOfBirth = dateOfBirth;
    }

    public int getIncome() {
        return income;
    }

    public void setIncome(int income) {
        this.income = income;
    }

    public String getNickname() {
        return nickname;
    }

    public void setNickname(String nickname) {
        this.nickname = nickname;
        System.out.println("!!!!!!! set nickname 2: " + this.nickname);
    }
}
