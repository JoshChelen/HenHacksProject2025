using TMPro;
using UnityEngine;
using System;
using System.IO;

#if UNITY_EDITOR
using UnityEditor; // Needed for AssetDatabase.Refresh()
#endif



public class CreateFolder : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public TMP_InputField playlistNameField;
    
    public void FolderCreation(){
        if(!IsValidFileName(playlistNameField.text)) {
            Debug.Log("Invalid File Name");   
            return;
        }
        CreatePlaylistDirectory(playlistNameField.text);
    }

    public bool IsValidFileName(string fileName)
    {
        // Check if filename is null, empty, or only whitespace
        if (string.IsNullOrWhiteSpace(fileName))
            return false;

        // Get invalid characters from the system
        char[] invalidChars = Path.GetInvalidFileNameChars();

        // Check if the filename contains any invalid character
        foreach (char c in fileName)
        {
            if (Array.Exists(invalidChars, invalid => invalid == c))
                return false;
        }

        return true; // If no invalid characters, return true
    }
    public void CreatePlaylistDirectory(string folderName){
            // Path to Assets/Folders/
            string folderPath = Path.Combine(Application.dataPath, "Folders", folderName);

            // Check if directory exists, if not, create it
            if (!Directory.Exists(folderPath)){
                Directory.CreateDirectory(folderPath);
                Debug.Log("Directory created at: " + folderPath);
            } else {
                Debug.Log("Directory already exists: " + folderPath);
            }

            CreateNecessaryFiles(folderPath);

            #if UNITY_EDITOR
            AssetDatabase.Refresh(); //updates directories in unity editor, doesnt otherwise 
            #endif
        }

    private static void CreateNecessaryFiles(string folderPath)
    {
        // Define the file path
        string videoFilePath = Path.Combine(folderPath, "VideoFilePaths.txt");
        string notesFilePath = Path.Combine(folderPath,"NotesFilePath.txt");
        // Check if file exists, if not, create it
        if (!File.Exists(videoFilePath)){
            File.WriteAllText(videoFilePath, ""); // Create an empty file
            Debug.Log("Created text file: " + videoFilePath);
        } else {
            Debug.Log("Text file already exists: " + videoFilePath);
        }
        if (!File.Exists(notesFilePath)){
            File.WriteAllText(notesFilePath, ""); // Create an empty file
            Debug.Log("Created text file: " + notesFilePath);
        } else {
            Debug.Log("Text file already exists: " + notesFilePath);
        }
    }

}
    
    /*
    using System.IO;
    using UnityEngine;

    public class DirectoryCreator : MonoBehaviour
    {
        public static void CreateDirectory(string folderPath)
        {
            // Check if the directory already exists
            if (!Directory.Exists(folderPath))
            {
                // Create the directory
                Directory.CreateDirectory(folderPath);
                Debug.Log("Directory created at: " + folderPath);
            }
            else
            {
                Debug.Log("Directory already exists: " + folderPath);
            }
        }
    }
    */



