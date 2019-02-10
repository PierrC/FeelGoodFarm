using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class TreeData : MonoBehaviour
{
    public Emotion emotion;
    public TreeState state;
    public string message;
    public DateTime date;
    public Vector3 position;


    private void Awake()
    {
        position = new Vector3();
        date = DateTime.Now;
        position = transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {

        Invoke("TimedGrowth", 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void TimedGrowth()
    {
        if ((DateTime.Today - date).TotalDays > 1)
        {
            GrowTree();
            date = DateTime.Today;
        }
        GetComponent<TreeSpriteHandler>().SelectSprite(state, emotion);
        Invoke("TimedGrowth", 10);
    }

    void GrowTree()
    {
        switch (state)
        {
            case TreeState.SEED:
                state = TreeState.SPROUT;
                return;
            case TreeState.SPROUT:
                state = TreeState.SAMPLING;
                return;
            case TreeState.SAMPLING:
                state = TreeState.TREE;
                return;
        }
    }

    
    void SetDateTime(DateTime date)
    {
        this.date = date;
    }

    public enum TreeState
    {
        SEED = 10,
        SPROUT = 20,
        SAMPLING = 30,
        TREE = 40
    }

    public enum Emotion
    {
        BLUE = 1,  // SAD,
        RED = 2, // ANGRY
        YELLOW =3 , // HAPPY
        GREY = 4, // STRESSED
        BLACK = 5, // FEAR

    }
}
