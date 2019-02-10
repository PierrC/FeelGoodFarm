using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Pawn
{

    public Dialogue dialogue;
    // Start is called before the first frame update
    void Start()
    {
        if(dialogue != null)
        {
            dialogue.name = Name;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public override void TriggerDialogue()
    {
        Debug.Log("You are talking with me.");
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
