using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UpdateTimestamps : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Dropdown dropdown;
    public Button addButton;

    void Start()
    {
        // Add listener to button click
        //addButton.onClick.AddListener(AddInputToDropdown);
    }

    public void AddInputToDropdown()
    {
        string inputText = inputField.text.Trim(); // Get input and trim spaces

        if (!string.IsNullOrEmpty(inputText)) // Ensure input is not empty
        {
            dropdown.options.Add(new TMP_Dropdown.OptionData(inputText)); // Add to dropdown
            dropdown.RefreshShownValue(); // Refresh UI
            inputField.text = ""; // Clear input field
        }
    }
}
