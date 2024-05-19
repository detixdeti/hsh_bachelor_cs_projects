/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package de.hsh.steam.resources;

import de.hsh.steam.entities.Genre;
import de.hsh.steam.entities.Score;
import de.hsh.steam.entities.Streamingprovider;

/**
 *
 * @author SAbde
 */
public class Utils {

    public static Genre stringToGenre(String genre) {
        if (genre == null) {
            return null;
        }
        switch (genre.toLowerCase()) {
            case "thriller":
                return Genre.Thriller;
            case "sciencefiction":
                return Genre.ScienceFiction;
            case "drama":
                return Genre.Drama;
            case "action":
                return Genre.Action;
            case "comedy":
                return Genre.Comedy;
            case "documentary":
                return Genre.Documentary;
            default:
                return null;
        }
    }

    public static Streamingprovider stringToProvider(String provider) {
        if (provider == null) {
            return null;
        }
        switch (provider.toLowerCase()) {
            case "netflix":
                return Streamingprovider.Netflix;
            case "amazonprime":
                return Streamingprovider.AmazonPrime;
            case "sky":
                return Streamingprovider.Sky;
            default:
                return null;
        }
    }

    public static Score stringToScore(String score) {
        if (score == null) {
            return null;
        }
        switch (score.toLowerCase()) {
            case "bad":
                return Score.bad;
            case "mediocre":
                return Score.mediocre;
            case "good":
                return Score.good;
            case "very_good":
                return Score.very_good;
            default:
                return null;
        }
    }
}
