package beans;

import backend.TemperatureService;
import javax.enterprise.context.RequestScoped;
import javax.inject.Named;

@Named(value = "handler")
@RequestScoped
public class CelsiusEventBean {
    public String handleEvent(CelsiusDataBean dataBean) {
        TemperatureService service = new TemperatureService();
        float fahrenheit = service.calcFahrenheit(dataBean.getEingabe());
        dataBean.setErgebnis(fahrenheit);
        return "DesignCelsiusAnzeige";
    }
}


