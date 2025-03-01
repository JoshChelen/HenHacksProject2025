using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] string sceneName = "";

    public void CreateFolderScene(){
        SceneManager.LoadScene("2_CreateNewFolder");
    }
    public void OpenFolderScene(){
        SceneManager.LoadScene("2_Folders");
    }
}
