using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveButtonScript : MonoBehaviour
{

    public string theText;
    public TMP_InputField ourNote;
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
