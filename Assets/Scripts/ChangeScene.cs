using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void MainMenuScene(){
        SceneManager.LoadScene("1_MainMenu");
    }
    public void OpenFolder(){
        SceneManager.LoadScene("2_OpenFolder");
    }
}
