using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BWMode : MonoBehaviour
{
    public void SaveBWOption(bool option) {
        Debug.Log(option);
        if (option == true) {
            PlayerPrefs.SetInt("BW", 1);
        } else {
             PlayerPrefs.SetInt("BW", 0);
        }
       
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
