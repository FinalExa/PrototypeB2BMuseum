using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) GoToScene("QuizScene");
        if (Input.GetKeyDown(KeyCode.O)) GoToScene("MemoryScene");
        if (Input.GetKeyDown(KeyCode.I)) GoToScene("FindTheDifferencesScene");
    }
    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
