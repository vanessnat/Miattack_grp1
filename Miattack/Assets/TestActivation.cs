using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;


public class TestActivation : MonoBehaviour
{
     public PostProcessVolume volume;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("BW") == 1) {
        volume.enabled = true;
      } else {
        volume.enabled = false;
      }
    }
}
