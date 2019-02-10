using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickAnger : MonoBehaviour
{
    public void NextScene()
    {

        DataManager.SaveTrees();
        SceneManager.LoadScene("AngryMinigame");
    }
}
