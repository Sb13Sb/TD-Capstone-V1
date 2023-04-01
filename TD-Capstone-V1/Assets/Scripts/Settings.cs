using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer; // Reference to the audio mixer
    public Slider volumeSlider; // Reference to the volume slider
    public Slider mouseSensitivitySlider; // Reference to the mouse sensitivity slider
    public Toggle specialModeToggle; // Reference to the special mode toggle
    public Toggle musicMuteToggle; // Reference to the music mute toggle

    private float defaultVolume = 0.5f; // Default volume
    private float defaultMouseSensitivity = 50f; // Default mouse sensitivity
    private bool defaultSpecialMode = true; // Default special mode
    private bool defaultMusicMute = false; // Default music mute

    void Start()
    {
        LoadSettings(); // Load settings from PlayerPrefs
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("MasterVolume", Mathf.Log10(volume) * 20); // Convert the slider value to decibels and set the volume of the master group in the audio mixer
    }

    public void SetMouseSensitivity(float sensitivity)
    {
        // Set the mouse sensitivity
        // You can use this value to adjust the sensitivity of the mouse look script in your game
    }

    public void SetSpecialMode(bool isOn)
    {
        // Set the special mode
        // You can use this value to enable or disable a special mode in your game
    }

    public void SetMusicMute(bool isOn)
    {
        // Set the music mute
        // You can use this value to mute or unmute the music in your game
    }

    public void SaveSettings()
    {
        // Save the settings to PlayerPrefs
        PlayerPrefs.SetFloat("Volume", volumeSlider.value);
        PlayerPrefs.SetFloat("MouseSensitivity", mouseSensitivitySlider.value);
        PlayerPrefs.SetInt("SpecialMode", specialModeToggle.isOn ? 1 : 0);
        PlayerPrefs.SetInt("MusicMute", musicMuteToggle.isOn ? 1 : 0);
        PlayerPrefs.Save();
    }

    public void LoadSettings()
    {
        // Load the settings from PlayerPrefs and set the UI elements accordingly
        float volume = PlayerPrefs.GetFloat("Volume", defaultVolume);
        volumeSlider.value = volume;
        audioMixer.SetFloat("MasterVolume", Mathf.Log10(volume) * 20);

        float mouseSensitivity = PlayerPrefs.GetFloat("MouseSensitivity", defaultMouseSensitivity);
        mouseSensitivitySlider.value = mouseSensitivity;

        bool specialMode = PlayerPrefs.GetInt("SpecialMode", defaultSpecialMode ? 1 : 0) == 1;
        specialModeToggle.isOn = specialMode;

        bool musicMute = PlayerPrefs.GetInt("MusicMute", defaultMusicMute ? 1 : 0) == 1;
        musicMuteToggle.isOn = musicMute;
    }


        // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(2);
        }
    }
}
