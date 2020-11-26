using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) GoToScene("QuizScene");
    }
    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
