/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package managedBeans;

/**
 *
 * @author lushaj
 */
public class Utils {

    private static final Utils instance = new Utils();

    public String username;

    private Utils() {
    }

    public static Utils getInstance() {
        return instance;
    }

    public void setUsername(String s) {
        System.out.print("Set static Username to:" + s);
        this.username = s;
    }

    public String getUsername() {
        return this.username;
    }

}
