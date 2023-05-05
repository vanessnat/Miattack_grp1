using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWinManager : MonoBehaviour

{
  public string tagToFind = "";
  public string sceneToGo = "";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (GameObject.FindGameObjectsWithTag(tagToFind).Length <= 0) {
        SceneManager.LoadScene(sceneToGo);
      }
    }
}
