package de.hsh.steam.entities;

import java.io.Serializable;
import java.util.ArrayList;
import javax.xml.bind.annotation.XmlRootElement;

/**
 * Class Series
 */
@XmlRootElement(name = "series")
public class Series implements Serializable {

    private static final long serialVersionUID = 1130974711328366348L;

    private String title;
    private int numberOfSeasons;
    private Genre genre;
    private Streamingprovider streamedBy;
    private ArrayList<User> seenBy = new ArrayList<User>();

    /**
     * Constructor
     */
    public Series() {
    }

    /**
     * Constructor
     *
     * @param title
     * @param numberOfSeasons
     * @param genre
     * @param streamedBy
     */
    public Series(String title, int numberOfSeasons, Genre genre, Streamingprovider streamedBy) {
        this.title = title;
        this.numberOfSeasons = numberOfSeasons;
        this.genre = genre;
        this.streamedBy = streamedBy;
    }

    /**
     * @param u
     */
    public void putOnWatchListOfUser(User u) {
        if (!seenBy.contains(u)) {
            this.seenBy.add(u);
        }
    }

    /**
     * @param username
     * @return Boolean
     */
    public Boolean isSeenBy(String username) {
        for (User u : seenBy) {
            if (u.getUsername().equals(username)) {
                return true;
            }
        }
        return false;
    }

    /**
     * @return ArrayList<User>
     */
    public ArrayList<User> getSeenBy() {
        return seenBy;
    }

    /**
     * @return String
     */
    public String getTitle() {
        return title;
    }

    /**
     * @param title
     */
    public void setTitle(String title) {
        this.title = title;
    }

    /**
     * @return Genre
     */
    public Genre getGenre() {
        return genre;
    }

    /**
     * @param myGenre
     */
    public void setGenre(Genre myGenre) {
        this.genre = myGenre;
    }

    /**
     * @return int
     */
    public int getNumberOfSeasons() {
        return numberOfSeasons;
    }

    /**
     * @param numberOfSeasons
     */
    public void setNumberOfSeasons(int numberOfSeasons) {
        this.numberOfSeasons = numberOfSeasons;
    }

    /**
     * @return Streamingprovider
     */
    public Streamingprovider getStreamedBy() {
        return streamedBy;
    }

    /**
     * @param streamedBy
     */
    public void setStreamedBy(Streamingprovider streamedBy) {
        this.streamedBy = streamedBy;
    }

    /**
     * @param o
     * @return boolean
     */
    public boolean equals(Object o) {
        if (o == null) {
            return false;
        }
        if (o == this) {
            return true;
        }
        Series s = (Series) o;
        return this.title == s.title;
    }

    /**
     * @return String
     */
    @Override
    public String toString() {
        return this.title + " - numberOfSeasons:" + this.numberOfSeasons + " -  genre:" + this.genre + "   - watched on :" + this.streamedBy;
    }

}
