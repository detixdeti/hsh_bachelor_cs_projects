
package beans;

import backend.TemperatureService;
import javax.inject.Named;
import javax.enterprise.context.RequestScoped;

@Named(value = "temperatureBean")
@RequestScoped
public class TemperatureBean {

    private float celsius;
    
    public float getCelsius() {
        return celsius;
    }

    public void setCelsius(float celsius) {
        this.celsius = celsius;
    }
    
    public float clickFahrenheit(){
        TemperatureService converter = new TemperatureService();
        System.out.println("************ " + this.celsius);
        return  converter.calcFahrenheit(this.celsius);
    }

}


