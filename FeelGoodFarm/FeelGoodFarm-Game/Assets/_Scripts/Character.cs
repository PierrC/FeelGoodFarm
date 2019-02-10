using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Character : Pawn
{

    [SerializeField]
    private float movementSpeed;

    public TextMeshProUGUI textMeshPro;

    public Pawn pawn;

    // Start is called before the first frame update
    public override void Start()
    {
        vector = Vector2.zero;
        base.Start();
    }



    Vector2 vector = new Vector2();
    private void Update()
    {
        if (DialogueManager.GetInstance().inDialogue)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                DialogueManager.GetInstance().DisplayNextSentence();
            }
        }
        else
        {
            float moveHorizontal = Input.GetAxisRaw("Horizontal");
            float moveVertical = Input.GetAxisRaw("Vertical");

            vector = new Vector2(moveHorizontal, moveVertical).normalized / 1f;

            Hub_Move(vector);

            if (Input.GetKeyDown(KeyCode.E))
            {
                {
                    if (pawn != null)
                    {
                        pawn.TriggerDialogue();

                    }
                    else
                    {
                        textMeshPro.text = "";
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                PlantTreeTest();
            }
        }
    }
    // Update is called once per frame

    Vector3 buffer = new Vector3(-0.1f, -0.1f, -0.1f);
    public GameObject treePrefab;
    private void PlantTree(TreeData.Emotion pEmotion, string pmessage)
    {
        GameObject obj = Instantiate(treePrefab, transform.position + buffer, new Quaternion());
        obj.GetComponent<TreeData>().emotion = pEmotion;
        obj.GetComponent<TreeData>().message = pmessage;

        DataManager.GetInstance().AddTreeData(obj.GetComponent<TreeData>());
    }

    private void PlantTreeTest()
    {
        GameObject obj = Instantiate(treePrefab, transform.position + buffer, new Quaternion());
        obj.GetComponent<TreeData>().emotion = TreeData.Emotion.YELLOW;
        obj.GetComponent<TreeData>().message = "Test Tree";

        DataManager.GetInstance().AddTreeData(obj.GetComponent<TreeData>());
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision tag:" + collision.tag);
        if (collision.tag == "Interactable")
        {
            Debug.Log("Correct tag");
            pawn = collision.gameObject.GetComponent<NPC>();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (pawn != null && other.gameObject == pawn.gameObject)
        {
            pawn = null;
        }
    }


    public override void TriggerDialogue()
    {
        Debug.Log("This is not supposed to happen.");
    }

}
