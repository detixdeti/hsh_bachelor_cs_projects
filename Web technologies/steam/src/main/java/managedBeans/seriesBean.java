/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSF/JSFManagedBean.java to edit this template
 */
package managedBeans;

import de.hsh.steam.entities.Genre;
import de.hsh.steam.entities.Rating;
import de.hsh.steam.entities.Score;
import de.hsh.steam.entities.Series;
import de.hsh.steam.entities.Streamingprovider;
import de.hsh.steam.services.SteamService;
import javax.enterprise.context.RequestScoped;
import javax.inject.Named;
import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author lushaj
 */
@Named(value = "seriesBean")
@RequestScoped
public class seriesBean implements Serializable {

    /**
     * Creates a new instance of userBean
     */
    public seriesBean() {
    }

    private String title;
    private int seasons;
    private String genre;
    private String streamingprovider;
    private String score;
    private String remark;
    private String result;

    List<Rating> ratingList = new ArrayList<Rating>();

    public String getTitle() {
        System.out.println("Getter title: " + this.title + "\t obj: " + this);
        return this.title;
    }

    public void setTitle(String s) {
        this.title = s;
        System.out.println("Setter title: " + this.title + "\t obj: " + this);
    }

    public int getSeasons() {
        System.out.println("Getter seasons: " + this.seasons + "\t obj: " + this);
        return this.seasons;
    }

    public void setSeasons(int i) {
        this.seasons = i;
        System.out.println("Setter seasons: " + this.seasons + "\t obj: " + this);
    }

    public String getGenre() {
        System.out.println("Getter genre: " + this.genre + "\t obj: " + this);
        return this.genre;
    }

    public void setGenre(String g) {
        this.genre = g;
        System.out.println("Setter genre: " + this.genre + "\t obj: " + this);
    }

    public String getStreamingprovider() {
        System.out.println("Getter streamingprovider: " + this.streamingprovider + "\t obj: " + this);
        return this.streamingprovider;
    }

    public void setStreamingprovider(String s) {
        this.streamingprovider = s;
        System.out.println("Setter streamingprovider: " + this.streamingprovider + "\t obj: " + this);
    }

    public String getScore() {
        System.out.println("Getter score: " + this.score + "\t obj: " + this);
        return score;
    }

    public void setScore(String s) {
        this.score = s;
        System.out.println("Setter score: " + this.score + "\t obj: " + this);
    }

    public String getRemark() {
        System.out.println("Getter remark: " + this.remark + "\t obj: " + this);
        return remark;
    }

    public void setRemark(String s) {
        this.remark = s;
        System.out.println("Setter remark: " + this.remark + "\t obj: " + this);
    }

    public List<Rating> getRatingList() {
        System.out.println("Getter RatingList: " + this.ratingList + "\t obj: " + this);
        return this.ratingList;
    }

    public void submit() {
        this.ratingList.clear(); //clearen vor der neuen operation
        String username = Utils.getInstance().getUsername();

        if (!(this.title.equals("")) && (this.seasons != 0) && !(this.genre.equals("null")) && !(this.streamingprovider.equals("null")) && !(this.score.equals("null")) && !(this.remark.equals(""))) {
            System.out.println("Current values: " + "username: " + username + ", Title: " + this.title + ", Seasons: " + this.seasons + ", Genre: " + StringToGenre(this.genre) + ", Streamingprovider: " + StringToStreamingprovider(this.streamingprovider) + ", Score: " + StringToScore(this.score) + ", remark: " + this.remark);
            SteamService.getInstance().addOrModifySeries(this.title, this.seasons, StringToGenre(this.genre), StringToStreamingprovider(this.streamingprovider), username, StringToScore(this.score), this.remark);

            SteamService.getInstance().getAllSeriesWithTitle(this.title).get(0).putOnWatchListOfUser(SteamService.getInstance().getRepository().getUserObject(username));
            result = "RESULT:: SUCCESS - A rating has been added "; // + SteamService.getInstance().getAllSeriesWithTitle(this.title);
        } else {
            result = "RESULT:: INVALID - No rating was added";
        }
        SteamService.getInstance().dumpRepository();
    }

    public void find() {
        result = "";
        String username = Utils.getInstance().getUsername();
        this.ratingList.clear(); //clearen vor der neuen operation
        System.out.println("Current values: " + "username: " + username + ", Seasons: " + this.seasons + ", Genre: " + StringToGenre(this.genre) + ", Streamingprovider: " + StringToStreamingprovider(this.streamingprovider) + ", Score: " + StringToScore(this.score));

        if (this.title.equals("")) {
            ArrayList<Series> searchSeries = SteamService.getInstance().search(username, StringToGenre(this.genre), StringToStreamingprovider(this.streamingprovider), StringToScore(this.score));

            for (Series series : searchSeries) {
                Rating seriesRating = SteamService.getInstance().getRating(series.getTitle(), username);

                // falls weitere Kriterien nicht erfüllt dann skippen
                if (this.seasons > 0 && series.getNumberOfSeasons() != this.seasons
                        || !this.remark.equals("") && !seriesRating.getRemark().equals(this.remark)) {
                    continue;
                }

                ratingList.add(seriesRating);
            }
            if (this.ratingList.isEmpty()) {
                result = "RESULT:: INVALID - No ratings found";
            }

        } else {
            ArrayList<Series> arrSeries = SteamService.getInstance().getAllSeriesWithTitle(this.title);
            if (arrSeries.size() <= 0) {
                result = "RESULT:: INVALID - No ratings found";
                return;
            }
            Series series = arrSeries.get(0);
            Rating seriesRating = SteamService.getInstance().getRating(series.getTitle(), username);

            if (StringToGenre(this.genre) != null
                    && series.getGenre() != StringToGenre(this.genre)
                    || this.seasons > 0
                    && series.getNumberOfSeasons() != this.seasons
                    || StringToStreamingprovider(this.streamingprovider) != null
                    && series.getStreamedBy() != StringToStreamingprovider(this.streamingprovider)
                    || StringToScore(this.score) != null
                    && seriesRating.getScore() != StringToScore(this.score)
                    || !this.remark.equals("")
                    && !seriesRating.getRemark().equals(this.remark)) {
                result = "RESULT:: INVALID - No ratings found";

                return;
            }
            ratingList.add(seriesRating);

        }
    }

    public String getResult() {
        return result;
    }

    public void setResult(String result) {
        this.result = result;
    }

    private Genre StringToGenre(String s) {
        if (s.equals("Thriller")) {
            return Genre.Thriller;
        }
        if (s.equals("ScienceFiction")) {
            return Genre.ScienceFiction;
        }
        if (s.equals("Drama")) {
            return Genre.Drama;
        }
        if (s.equals("Action")) {
            return Genre.Action;
        }
        if (s.equals("Comedy")) {
            return Genre.Comedy;
        }
        if (s.equals("Documentary")) {
            return Genre.Documentary;
        }
        return null;
    }

    private Streamingprovider StringToStreamingprovider(String s) {
        if (s.equals("Netflix")) {
            return Streamingprovider.Netflix;
        }
        if (s.equals("AmazonPrime")) {
            return Streamingprovider.AmazonPrime;
        }
        if (s.equals("Sky")) {
            return Streamingprovider.Sky;
        }
        return null;
    }

    private Score StringToScore(String s) {
        if (s.equals("bad")) {
            return Score.bad;
        }
        if (s.equals("mediocre")) {
            return Score.mediocre;
        }
        if (s.equals("good")) {
            return Score.good;
        }
        if (s.equals("very_good")) {
            return Score.very_good;
        }
        return null;
    }

}
