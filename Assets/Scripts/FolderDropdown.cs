using System.IO;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FolderDropdown : MonoBehaviour
{
    public TMP_Dropdown dropdown;

    void Start()
    {
        // Populate the dropdown with folder names on start
        PopulateDropdown();

        // Add listener for dropdown value changes
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    // This method populates the dropdown with the folder names from the "Folders" directory
    public void PopulateDropdown()
    {
        // Define the parent directory (Assets/Folders)
        string parentFolderPath = Path.Combine(Application.dataPath, "Folders");

        // Ensure the directory exists
        if (!Directory.Exists(parentFolderPath))
        {
            Debug.LogWarning("Directory does not exist: " + parentFolderPath);
            return;
        }

        // Get all subdirectories (folders)
        string[] directories = Directory.GetDirectories(parentFolderPath);

        // Clear existing options in the dropdown
        dropdown.ClearOptions();

        // Convert full paths to just folder names
        List<string> folderNames = new List<string>();
        foreach (string dir in directories)
        {
            folderNames.Add(Path.GetFileName(dir)); // Extract folder name only
        }

        // Add folder names to the dropdown
        dropdown.AddOptions(folderNames);
    }

    // This method is called when the dropdown selection changes
    public void OnDropdownValueChanged(int index)
    {
        // Get the folder name from the dropdown option (based on the selected index)
        string folderName = dropdown.options[index].text;

        // Construct the relative path from the "Assets/Folders/" directory
        //string folderPath = Path.Combine("Assets", "Folders", folderName);

        // Save the relative folder path to PlayerPrefs
        PlayerPrefs.SetString("myString", folderName);

        // Log the saved path (optional)
        //Debug.Log("Updated relative path in PlayerPrefs: " + folderPath);
    }
}
