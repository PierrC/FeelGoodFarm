/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTriggerAnger : MonoBehaviour
{
    public InputField inputField;

    GameController controller;

    void Awake()
    {
        controller = GetComponent<GameController>();
        inputField.onEndEdit.AddListener(AcceptStringInputstring);
    }

    void AcceptStringInputstring (string userInput)
    {
        controller.LogStringWithReturn(userInput);
        InputComplete;
    }

    void InputComplete()
    {
        controller.DisplayLoggedText();
        inputField.ActivateInputField();
        inputField.text = null;
    }

}*/
