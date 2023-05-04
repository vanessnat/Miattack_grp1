using UnityEngine;
using UnityEngine.SceneManagement; 

public class Credits : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Home");
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            LoadMainMenu();
        }
    }
}
