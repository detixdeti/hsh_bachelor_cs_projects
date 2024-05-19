package de.hsh.steam.entities;

import java.io.Serializable;
import javax.xml.bind.annotation.XmlRootElement;

/**
 * Class Rating
 */
@XmlRootElement(name = "rating")
public class Rating implements Serializable {

    private static final long serialVersionUID = -7806234457596021877L;

    private Score score;
    private String remark;

    private User ratingUser;
    private Series ratedSeries;

    public Rating() {
    }

    /**
     * Constructor
     *
     * @param score
     * @param remark
     * @param ratingUser
     * @param ratedSeries
     */
    public Rating(Score score, String remark, User ratingUser, Series ratedSeries) {
        super();
        this.score = score;
        this.remark = remark;
        this.ratingUser = ratingUser;
        this.ratedSeries = ratedSeries;
    }

    /**
     * @return Score
     */
    public Score getScore() {
        return score;
    }

    /**
     * @param score
     */
    public void setScore(Score score) {
        this.score = score;
    }

    /**
     * @return String
     */
    public String getRemark() {
        return remark;
    }

    /**
     * @param remark
     */
    public void setRemark(String remark) {
        this.remark = remark;
    }

    /**
     * @return User
     */
    public User getRatingUser() {
        return ratingUser;
    }

    /**
     * @param ofUser
     */
    public void setRatingUser(User ofUser) {
        this.ratingUser = ofUser;
    }

    /**
     * @return Series
     */
    public Series getRatedSeries() {
        return ratedSeries;
    }

    /**
     * @param ofSeries
     */
    public void setRatedSeries(Series ofSeries) {
        this.ratedSeries = ofSeries;
    }

    @Override
    public String toString() {
        return this.ratingUser.getUsername() + " watched " + this.ratedSeries.toString() + " - Rating : " + this.score + ", remark: " + this.remark;
    }

}
