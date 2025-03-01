using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] string sceneName = "1_Main Menu";


    public void GoToScene(){
        SceneManager.LoadScene(sceneName);
    }
}
