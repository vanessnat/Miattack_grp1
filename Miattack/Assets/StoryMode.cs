using UnityEngine;
using UnityEngine.SceneManagement; 

public class StoryMode : MonoBehaviour
{
    public string levelToLoad;
   
   public GameObject nextArrow;

   public void Continue()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
