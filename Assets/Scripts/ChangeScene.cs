using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.IO;
using System;

public class ChangeScene : MonoBehaviour
{
    

    public void MainMenuScene(){
        SceneManager.LoadScene("1_MainMenu");
    }

    public void OpenFolderScene(){
        SceneManager.LoadScene("2_OpenFolder");
    }
}
