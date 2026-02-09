using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text text;
    public GameObject Dialogue;
    public List<string> messages = new List<string>();
    private int currentMessageIndex = 0;

   
    void Start()
    {
        Dialogue.SetActive(false);
        StartCoroutine(StartDialogueSequence());
    }
    private IEnumerator StartDialogueSequence()
    {
        yield return new WaitForSeconds(5f);
        if (messages.Count > 0)
        {
            ShowMessage();
        }
    }
    
    public void ShowMessage()
    {
        Dialogue.SetActive(true);
        text.text = messages[currentMessageIndex];

    }
    public void skip ()
        {
        if (currentMessageIndex < messages.Count)
        {
            text.text = messages[currentMessageIndex];
            currentMessageIndex += 1;
        }
        else
        {
            currentMessageIndex = 0;
            Dialogue.SetActive(false);
        }
        }
}
