using System.IO;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class FolderDropdown : MonoBehaviour
{
    public TMP_Dropdown dropdown;

    void Start()
    {
        PopulateDropdown();
    }

    public void PopulateDropdown()
    {
        // Define the parent directory
        string parentFolderPath = Path.Combine(Application.dataPath, "Folders");

        // Ensure the directory exists
        if (!Directory.Exists(parentFolderPath))
        {
            Debug.LogWarning("Directory does not exist: " + parentFolderPath);
            return;
        }

        // Get all subdirectories
        string[] directories = Directory.GetDirectories(parentFolderPath);

        // Clear existing options
        dropdown.ClearOptions();

        // Convert full paths to just folder names
        List<string> folderNames = new List<string>();
        foreach (string dir in directories)
        {
            folderNames.Add(Path.GetFileName(dir)); // Extract folder name
        }

        // Add to dropdown
        dropdown.AddOptions(folderNames);
    }

}
