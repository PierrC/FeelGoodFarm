using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private static DialogueManager dialogueManager;


    public bool inDialogue;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI DialogueText;

    private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        dialogueManager = this;
        inDialogue = false;
        sentences = new Queue<string>();
    }

    public static DialogueManager GetInstance()
    {
        return dialogueManager;
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting conversation with " + dialogue.name);
        nameText.text = dialogue.name;
        inDialogue = true;
        sentences.Clear();
        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public float timer;
    public void DisplayNextSentence()
    {
     //   if (Time.time > timer + 0.5f)
   //     {
            if (DialogueText.text == "")
            {
                EndDialogue();
                return;
            }

            string sentence = sentences.Dequeue();
            // DialogueText.text = sentence;
            StopAllCoroutines();
            StartCoroutine(TypeSentence(sentence));
            timer = Time.time;

      //  }
    }

    IEnumerator TypeSentence (string sentence)
    {
        DialogueText.text = "";
        foreach(char c in sentence.ToCharArray())
        {
            DialogueText.text += c;
            yield return null;
        }
    }

    void EndDialogue()
    {
        nameText.text = "";
        DialogueText.text = "";
        inDialogue = false;
        Debug.Log("End of conversation");
    }
}
