package de.hsh.steam.main;

import java.util.ArrayList;
import de.hsh.steam.entities.Genre;
import de.hsh.steam.entities.Score;
import de.hsh.steam.entities.Series;
import de.hsh.steam.entities.Streamingprovider;
import de.hsh.steam.repositories.SerializedSeriesRepository;
import de.hsh.steam.services.SteamService;

public class SteamTest {

    public static void initData() {
        SteamService facade = SteamService.getInstance();

        // init users
        facade.newUser("daisy", "123");
        facade.newUser("donald", "abc");
        facade.newUser("goofy", "???");

        // init series
        String username = "daisy";
        facade.addOrModifySeries("Dark", 3, Genre.Drama, Streamingprovider.Netflix, username, Score.good, "strange");
        facade.addOrModifySeries("Breaking Bad", 7, Genre.Drama, Streamingprovider.Netflix, username, Score.very_good, "interesting");
        facade.addOrModifySeries("Game Of Thrones", 50, Genre.ScienceFiction, Streamingprovider.Sky, username, Score.mediocre, "no  comment");
        facade.addOrModifySeries("Narcos", 2, Genre.Thriller, Streamingprovider.Sky, username, Score.mediocre, "no  comment");

//		username = "donald";
        facade.addOrModifySeries("Dark", 3, Genre.ScienceFiction, Streamingprovider.Netflix, username, Score.mediocre, "strange");
        facade.addOrModifySeries("Stranger Things", 4, Genre.ScienceFiction, Streamingprovider.AmazonPrime, username, Score.very_good, "interesting");

    }

    public static void userstory() {
        SteamService facade = SteamService.getInstance();
        SerializedSeriesRepository repository = SerializedSeriesRepository.getInstance();

        String username = "daisy";
        facade.login(username, "123");
        facade.addOrModifySeries("Casa del Papel", 4, Genre.Drama, Streamingprovider.Netflix, username, Score.good, "no  comment");
        //ändere bereits vorhandene Serie
        facade.addOrModifySeries("Narcos", 3, Genre.Comedy, Streamingprovider.AmazonPrime, username, Score.good, "strange");

        System.out.println("*********** print all series for user " + username + ":");
        repository.printAllSeries(username);

        ArrayList<Series> searchResult;
        System.out.println("[SEARCH RESULT]");
        searchResult = facade.search(username, Genre.Drama, Streamingprovider.Netflix, Score.good);
        //searchResult = facade.search(username, null, Streamingprovider.AmazonPrime, null);
        for (Series s : searchResult) {
            System.out.println(s + "  score:" + facade.getRating(s.getTitle(), username).getScore());
        }

        //-------------------------
//		System.out.println();
//		username = "donald";
//		facade.addOrModifySeries("Casa del Papel", 4, Genre.Drama, Streamingprovider.Netflix, username, Score.mediocre, "no  comment");		
//		facade.addOrModifySeries("Fleabag", 4, Genre.Drama, Streamingprovider.AmazonPrime, username, Score.good, "no  comment");	
//		System.out.println("*********** print all series for user "  + username +":");
//		repository.printAllSeries(username);
//		
//		System.out.println("[SEARCH RESULT]");
//		searchResult = facade.search("donald", Genre.Drama, Streamingprovider.Netflix, Score.mediocre);
//		for (Series s: searchResult)
//			System.out.println(s + "  score:" + facade.getRating(s.getTitle(), username).getScore());	
//		System.out.println("[TITLE SEARCH RESULT]");
//		searchResult = facade.getAllSeriesWithTitle("ing");
//		//searchResult = facade.search(username, null, Streamingprovider.AmazonPrime, null);
//		for (Series s: searchResult)
//			System.out.println(s);
    }

    public static void main(String[] args) {
        // zunächst: lösche ggf die Datei allSeriesData.ser
        Boolean create = true;   // setze auf true um einen Anfangsbestand von Benutzern und Serien zu erzeugen
        if (create) {
            initData();
        }
        userstory();

        SerializedSeriesRepository repository = SerializedSeriesRepository.getInstance();
        repository.dumpRepository();
    }
}
