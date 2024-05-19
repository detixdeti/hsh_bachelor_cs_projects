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

import org.json.simple.parser.ParseException;

@Path("bmi")

public class Bmi {

    //konsumiert Plain JavaScript-Request
    @PUT
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    public Person calculateBMI(Person p) {
        System.out.println("REST_PUT-Aufruf:: " + p );

        // bmi und Antwort berechnen
        float bmi = p.getWeight()/(p.getHeight() * p.getHeight());

        String answer = "Du hast Normalgewicht!"; //default 
        if (bmi > 25) {
            answer = "Du hast Übergewicht!";
        }
        if (bmi < 20) {
            answer = "Du hast Untergewicht!";
        }

        // Ausgabe erzeugen
        p.setBmi(bmi);
        p.setAnswer(answer);
        System.out.println("REST_PUT-Return: "  + p );

        return p;
    }
}

