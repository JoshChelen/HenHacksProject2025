using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;

public class PlaylistUIHandler : MonoBehaviour
{
    public TMP_Text title;
    public TMP_Dropdown videoSelect;
    public TMP_InputField mp4PathInput;
    public Button saveMP4;

    string selectedFolder;
    string videoPath;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        selectedFolder = PlayerPrefs.GetString("myString", "No path set");
        videoPath = Path.Combine(Application.dataPath, "Folders", title.text, "VideoFilePaths.txt");
        title.text = selectedFolder;
        PopulateDropdown();
    }

    public void SaveMP4(){
        string mp4Path = mp4PathInput.text;
        
         if (string.IsNullOrEmpty(mp4Path)){
            Debug.Log("Must be a valid string.");
            return;
        }

        string folderPath = Path.Combine(Application.dataPath, "Folders", title.text);
        videoPath = Path.Combine(folderPath, "VideoFilePaths.txt");

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath); // Create the folder if it doesn't exist
        }

        // Write the MP4 path to the "VideoFilePaths.txt" file
        using (StreamWriter writer = new StreamWriter(videoPath, true))
        {
            writer.WriteLine(mp4Path); // Save the path to the file
        }

        Debug.Log("Saved MP4 path to: " + videoPath);
        PopulateDropdown();
    }


    public void PopulateDropdown()
    {
        // Check if the file exists
        if (!File.Exists(videoPath))
        {
            Debug.Log("VideoFilePaths.txt does not exist.");
            return;
        }

        // Read all lines from the VideoFilePaths.txt
        string[] lines = File.ReadAllLines(videoPath);

        // Clear existing dropdown options
        videoSelect.ClearOptions();

        // Add the file paths to the dropdown
        List<string> filePaths = new List<string>();
        foreach (string line in lines)
        {
            filePaths.Add(line); // Add each path to the list
        }

        // Add the paths as options in the dropdown
        videoSelect.AddOptions(filePaths);

        Debug.Log("Dropdown updated with video paths.");
    }
}
