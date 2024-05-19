package managedBeans;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSF/JSFManagedBean.java to edit this template
 */
import de.hsh.steam.services.SteamService;
import javax.enterprise.context.SessionScoped;
import javax.inject.Named;
import java.io.Serializable;

/**
 *
 * @author lushaj
 */
@Named(value = "userBean")
@SessionScoped
public class userBean implements Serializable {

    /**
     * Creates a new instance of LoginBean
     */
    public userBean() {
    }

    private String username;
    private String pwd;
    private String result;

    public String getUsername() {
        System.out.println("Getter user: " + this.username + "\t obj: " + this);
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
        System.out.println("Setter user: " + this.username + "\t obj: " + this);
    }

    public String getPwd() {
        System.out.println("Getter pwd: " + this.pwd + "\t obj: " + this);
        return pwd;
    }

    public void setPwd(String pwd) {
        this.pwd = pwd;
        System.out.println("setter pwd: " + this.pwd + "\t obj: " + this);
    }

    public String login() {
        boolean valid = SteamService.getInstance().login(this.username, this.pwd);
        SteamService.getInstance().dumpRepository();

        if (valid) {
            this.result = "";
            Utils.getInstance().setUsername(this.username);
            return "series.xhtml";
        } else {
            this.result = "RESULT:: INVALID - username or password ist wrong";
            return null;
        }

    }

    public void register() {
        boolean valid = SteamService.getInstance().newUser(this.username, this.pwd);
        SteamService.getInstance().dumpRepository();
        if (valid) {
            this.result = "RESULT:: SUCCESS - user created";
        } else {
            this.result = "RESULT:: INVALID - username taken";
        }
    }

    public String getResult() {
        return result;
    }

    public void setResult(String result) {
        this.result = result;
    }

}
