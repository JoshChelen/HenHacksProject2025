using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveButtonScript : MonoBehaviour
{
    //field to hold our current notepad string
    public string theText;
    //notepad object
    public TMP_InputField ourNote;
    //object to load our saved string into
    public TMP_InputField notePad;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        theText = PlayerPrefs.GetString("SavedNotes");
        notePad.text = theText;
    }

    public void saveNote() {
        theText = ourNote.text;
        PlayerPrefs.SetString("SavedNotes", theText);
    }
}
