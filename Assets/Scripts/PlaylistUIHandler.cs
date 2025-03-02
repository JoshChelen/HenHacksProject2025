using UnityEngine;
using TMPro;
public class PlaylistUIHandler : MonoBehaviour
{
    public TMP_Text title;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        title.text = PlayerPrefs.GetString("myString", "No path set");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
