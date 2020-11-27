using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) GoToScene("QuizScene");
        if (Input.GetKeyDown(KeyCode.O)) GoToScene("MemoryScene");
    }
    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
