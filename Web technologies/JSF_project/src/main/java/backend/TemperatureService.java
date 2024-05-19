/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package backend;

// !! das ist keine ManagedBean !!
// man ist selber für die Erzeung von Objekten sorgen 

public class TemperatureService {  
    public float calcFahrenheit(float celsius){
        return (celsius * 9/5) + 32;
    }
}


