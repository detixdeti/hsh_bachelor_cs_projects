/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bmiserver;

import javax.ws.rs.Consumes;
import javax.ws.rs.Produces;
import javax.ws.rs.Path;
import javax.ws.rs.PUT;
import javax.ws.rs.core.MediaType;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;
import org.json.simple.parser.ParseException;

@Path("bmiserver")

public class BmiServer {

    //konsumiert Plain JavaScript-Request
    @PUT
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    public String calculateBMI(String input) throws ParseException {
        // Eingabe lesen (weight - height)
        System.out.println("REST_PUT-Aufruf:: " + input);
        JSONParser parser = new JSONParser();
        JSONObject json = (JSONObject) parser.parse(input);
        String weight = json.get("weight").toString();
        String height = json.get("height").toString();     
        float w = Float.parseFloat(weight);      
        float h = Float.parseFloat(height); 

        // bmi und Antwort berechnen
        float bmi = w / (h * h);

        String answer = "Du hast Normalgewicht!"; //default 
        if (bmi > 25) {
            answer = "Du hast Übergewicht!";
        }
        if (bmi < 20) {
            answer = "Du hast Untergewicht!";
        }

        // Ausgabe erzeugen
        JSONObject obj = new JSONObject();
        obj.put("bmi", bmi);
        obj.put("answer", answer);
        String result = obj.toJSONString();
        System.out.println("REST-PUT: " + result);
        return result;
    }
}
