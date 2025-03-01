using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void MainMenuScene(){
        SceneManager.LoadScene("1_MainMenu");
    }
    public void CreateFolderScene(){
        SceneManager.LoadScene("2_CreateNewFolder");
    }
    public void OpenFolderScene(){
        SceneManager.LoadScene("2_Folders");
    }
    
}
