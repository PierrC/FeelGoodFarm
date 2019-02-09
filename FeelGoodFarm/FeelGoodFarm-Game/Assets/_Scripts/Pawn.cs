using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Pawn : MonoBehaviour
{

    [SerializeField]
    protected string Name;

    protected Rigidbody2D rigidbody;



    // Start is called before the first frame update
    public virtual void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        
    }
    
    public void Hub_Move(Vector2 v)
    {
        rigidbody.velocity = v;
    }

    public virtual void TriggerDialogue()
    {
        Debug.Log("Basic interacting");
    }

}
