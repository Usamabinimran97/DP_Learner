using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;
    private GameObject DialogueBox;
    // Reference to the sentences 
    private Queue<string> sentences;
    
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();

    }

    public void StartDialogue(Dialogue dialogue)
    {

        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        
        DisplayNextSentence();
        
    }

    public void DisplayNextSentence()
    {
        string sentence = sentences.Dequeue();
        string lastSentence = "end";
        dialogueText.text = sentence;


        if (String.Equals(lastSentence, sentence))
        {
            Destroy(GameObject.Find("DialogCanvas"));
        }
           
        



        

    }

   public void EndDialogue()
    {
        

        //dialogue = GameObject.FindWithTag("Dialoguebox").GetComponent<GameObject>();
        //dialogue.SetActive(false);
       
        // Debug.Log(" End of Conversion");
    }
  
}
