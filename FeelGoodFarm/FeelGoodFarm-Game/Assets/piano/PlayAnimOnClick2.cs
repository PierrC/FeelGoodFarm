//Script Made By StrupsGames//
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
 
public class PlayAnimOnClick2 : MonoBehaviour 
{
     
    public Button Text;
    public AudioClip sound;
    public Animator ani;
    public Canvas yourcanvas;
     
     
     
    void Start () 
    {
        Text = Text.GetComponent<Button> ();
        ani.enabled = false;
        yourcanvas.enabled = true;
    }
 
     
    public void Press() 
         
    {
        Text.enabled = true;
        AudioSource.PlayClipAtPoint(sound, transform.position);
        ani.enabled = true;
        Destroy(Text,1);
        yourcanvas.enabled = true;
 
    }
}