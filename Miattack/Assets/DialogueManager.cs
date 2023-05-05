using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text nameText; 
    public TMP_Text dialogueText;

    public static DialogueManager instance; 

    private void Awake ()
    {
        if(instance != null)
        {
            Debug.LogWarning("Il y plus d'une instance dans la scene");
            return;
        }
        instance = this; 
    }
}
