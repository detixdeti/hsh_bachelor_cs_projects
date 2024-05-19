package Sounds;

import java.io.File;
import java.io.IOException;

import javax.sound.sampled.AudioInputStream;
import javax.sound.sampled.AudioSystem;
import javax.sound.sampled.Clip;
import javax.sound.sampled.FloatControl;
import javax.sound.sampled.LineUnavailableException;
import javax.sound.sampled.UnsupportedAudioFileException;

import java.io.File;
import javafx.scene.media.Media;
import javafx.scene.media.MediaPlayer;

/**
 * sound effects class
 * 
 *
 */
public class Sound {
    // SOUND F�R BUTTONS
    private String buttonSoundPath;
    private MediaPlayer buttonSoundMediaPlayer;

    // SOUND F�R SCORE
    private String scoreSoundPath ;
    private MediaPlayer scoreSoundMediaPlayer;

    private String backgroundSoundPath;
    private MediaPlayer backgroundSoundMediaPlayer;

    // SOUND F�R Shot
    private String shotSoundPath;
    private MediaPlayer shotSoundMediaPlayer;

    // SOUND F�R Explosion
    private String explosionSoundPath ;
    private MediaPlayer explosionSoundMediaPlayer ;

    public void loadSounds() {
//        if (eingabe.equals("buttonSound")) {        // SOUND F�R BUTTONS

            buttonSoundPath = getClass().getResource("buttonSound.wav").toExternalForm();
            buttonSoundMediaPlayer = new MediaPlayer(new Media(buttonSoundPath));
//        } else if (eingabe.equals("scoreSound")) {            // SOUND F�R SCORE

            scoreSoundPath = getClass().getResource("scoreSound.wav").toExternalForm();
            scoreSoundMediaPlayer = new MediaPlayer(new Media(scoreSoundPath));
//        } else if (eingabe.equals("backgroundSound")) {    // SOUND F�R BUTTONS

            backgroundSoundPath = getClass().getResource("backgroundSound.wav").toExternalForm();
            backgroundSoundMediaPlayer = new MediaPlayer(new Media(backgroundSoundPath));

//        } else if (eingabe.equals("shotSound")) {    // SOUND F�R Shot

            shotSoundPath = getClass().getResource("shotSound.wav").toExternalForm();
            shotSoundMediaPlayer = new MediaPlayer(new Media(shotSoundPath));
//        } else if (eingabe.equals("explosionSound")) {    // SOUND F�R Explosion

            explosionSoundPath = getClass().getResource("explosionSound.wav").toExternalForm();
            explosionSoundMediaPlayer = new MediaPlayer(new Media(explosionSoundPath));

//        }

    }

    // Stop steht f�r reset
    /* Sound Methoden f�r Buttons */
    public void buttonSoundStart() {
        buttonSoundMediaPlayer.setVolume(0.2);
        buttonSoundMediaPlayer.play();
    }

    public void buttonSoundStop() {
        buttonSoundMediaPlayer.stop();
    }

    /* Sound Methoden f�r Score */
    public void scoreSoundStart() {
        scoreSoundMediaPlayer.setVolume(0.2);
        scoreSoundMediaPlayer.play();
    }

    public void scoreSoundStop() {
        scoreSoundMediaPlayer.stop();
    }

    /* Sound Methoden f�r Explosion */
    public void explosionSoundStart() {
        explosionSoundMediaPlayer.setVolume(0.2);
        explosionSoundMediaPlayer.play();
    }

    public void explosionSoundStop() {
        explosionSoundMediaPlayer.stop();
    }

    /* Sound Methoden f�r Shot */
    public void shotSoundStart() {
        shotSoundMediaPlayer.setVolume(0.2);
        shotSoundMediaPlayer.play();
    }

    public void shotSoundStop() {
        shotSoundMediaPlayer.stop();
    }

    /* Sound Methoden f�r Background */
    public void backgroundStart() {
        backgroundSoundMediaPlayer.setVolume(0.2);
        backgroundSoundMediaPlayer.play();
    }

    public void backgroundStop() {
        backgroundSoundMediaPlayer.stop();
    }

}