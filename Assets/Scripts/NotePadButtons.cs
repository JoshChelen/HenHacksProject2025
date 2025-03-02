using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NotePadButtons : MonoBehaviour {

    public TMP_InputField theText;

    public void clearText() {
        theText.text = "";
    }

}
