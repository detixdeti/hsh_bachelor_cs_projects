/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/GenericResource.java to edit this template
 */

import de.hsh.bmiwebapplication.resources.BMI;
import javax.ws.rs.Path;
import javax.enterprise.context.RequestScoped;
import javax.ws.rs.GET;
import javax.ws.rs.Produces;
import javax.ws.rs.QueryParam;
import javax.ws.rs.core.MediaType;

/**
 * REST Web Service
 *
 * @author SAbde
 */
@Path("BMIResource")
@RequestScoped
public class BMIResource {

    /**
     * Creates a new instance of BMIResource
     */
    public BMIResource() {
    }
    
    @GET
    @Produces(MediaType.APPLICATION_JSON)
    public BMI getBMI(@QueryParam("gewicht") double gewicht, @QueryParam("groese") double groese) {
        System.out.println("REST GET arrived");
        BMI bmi = new BMI();
        bmi.evaluate(gewicht, groese);
        return bmi;
    }
}
