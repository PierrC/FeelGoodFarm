using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TreeData;

public class TreeSpriteHandler : MonoBehaviour
{
    public GameObject SpriteObject;
    // Start is called before the first frame update
    void Start()
    {
        SpriteObject = transform.GetChild(0).gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SelectSprite(TreeState treeSate, Emotion emotion)
    {
        switch (treeSate)
        {
            case TreeState.SEED:
                SpriteObject.transform.GetChild(0);
                return;
            case TreeState.SPROUT:
                SpriteObject.transform.GetChild(1);
                return;
            case TreeState.SAMPLING:
                SpriteObject.transform.GetChild(3);
                return;
            case TreeState.TREE:
                switch (emotion)
                {
                    case Emotion.YELLOW:
                        SpriteObject.transform.GetChild(5);
                        return;
                    case Emotion.BLUE:
                        SpriteObject.transform.GetChild(6);
                        return;
                    default:
                        SpriteObject.transform.GetChild(4);
                        return;
                }
            default:
                SpriteObject.transform.GetChild(0);
                return;
        }
    }
}
