using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AnimatePlayer : MonoBehaviour
{

   public Animator anim;
   public float speed;




   // Use this for initialization
   void Start()
   {
       anim = GetComponent<Animator>();
   }






    // Update is called once per frame
    void Update()
    {


  /*      if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Vector2.right * speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector2.up * speed);
        }
    */





       if (Input.GetKeyDown("a"))
       {
           anim.SetBool("Left", true);
           anim.SetBool("Right", false);
           anim.SetBool("Up", false);
           anim.SetBool("Down", false);
       }
       if (Input.GetKeyDown("s"))
       {
           anim.SetBool("Down", true);
           anim.SetBool("Up", false);
           anim.SetBool("Left", false);
           anim.SetBool("Right", false);

       }
       if (Input.GetKeyDown("d"))
       {
           anim.SetBool("Right", true);
           anim.SetBool("Left", false);
           anim.SetBool("Up", false);
           anim.SetBool("Down", false);
       }
       if (Input.GetKeyDown("w"))
       {
           anim.SetBool("Up", true);
           anim.SetBool("Down", false);
           anim.SetBool("Left", false);
           anim.SetBool("Right", false);
       }



       if (Input.GetKeyDown("a"))
       {
           anim.SetBool("Player_Right1", true);
       }
       else
       {
           anim.SetBool("Player_Right1", false);
       }



       if (Input.GetKeyDown("s"))
       {
           anim.SetBool("Player_Down", true);
       }
       else
       {
           anim.SetBool("Player_Down", false);
       }



       if (Input.GetKeyDown("d"))
       {
           anim.SetBool("Player_Right", true);
       }
       else
       {
           anim.SetBool("Player_Right", false);
       }



       if (Input.GetKeyDown("w"))
       {
           anim.SetBool("Player_Up", true);
       }
       else
       {
           anim.SetBool("Player_Up", false);
       }


   }


}