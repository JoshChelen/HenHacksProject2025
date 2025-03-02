using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Date : MonoBehaviour
{

    public TextMeshProUGUI dateText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        string time = System.DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy");
        dateText.text = time;
    }
}
