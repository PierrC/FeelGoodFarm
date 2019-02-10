using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pianoscript : Pawn
{
    // Start is called before the first frame update
    public override void TriggerDialogue()
    {
        SceneManager.LoadScene("PianoMinigame");
    }
}
