using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class CreateFolder : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public TMP_InputField fileNameField;
    public int test;
    public void FolderCreation(){
        if(fileNameField.text == ""){
            Debug.Log("Empty file name, cant create");
        } else {
            Debug.Log("Valid File Name");
        }
    }

}
