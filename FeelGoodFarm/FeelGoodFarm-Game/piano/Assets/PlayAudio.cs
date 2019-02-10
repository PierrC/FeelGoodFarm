using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    // Start is called before the first frame update
    private void Update()
    {
        if (Input.GetKeyDown("a")){
            OnPlay();
        }
        if (Input.GetKeyDown("w"))
        {
            OnPlay2();
        }
        if (Input.GetKeyDown("s"))
        {
            OnPlay2_5();
        }
        if (Input.GetKeyDown("e"))
        {
            OnPlay3();
        }
        if (Input.GetKeyDown("d"))
        {
            OnPlay3_5();
        }
        if (Input.GetKeyDown("f"))
        {
            OnPlay4();
        }
        if (Input.GetKeyDown("t"))
        {
            OnPlay5();
        }
        if (Input.GetKeyDown("g"))
        {
            OnPlay6();
        }
        if (Input.GetKeyDown("y"))
        {
            OnPlay7();
        }
        if (Input.GetKeyDown("h"))
        {
            OnPlay8();
        }
        if (Input.GetKeyDown("u"))
        {
            OnPlay9();
        }
        if (Input.GetKeyDown("j"))
        {
            OnPlay10();
        }
        if (Input.GetKeyDown("k"))
        {
            OnPlay11();
        }

    }
    public void OnPlay()
    {
        GetComponent<AudioSource>().pitch = 1f;
        GetComponent<AudioSource>().Play();
    }

    public void OnPlay2()
    {
        GetComponent<AudioSource>().pitch = 1.042f;
        GetComponent<AudioSource>().Play();
    }

    public void OnPlay2_5()
    {
        GetComponent<AudioSource>().pitch = 1.1f;
        GetComponent<AudioSource>().Play();
    }

    public void OnPlay3()
    {
        GetComponent<AudioSource>().pitch = 1.16f;
        GetComponent<AudioSource>().Play();
    }

    public void OnPlay3_5()
    {
        GetComponent<AudioSource>().pitch = 1.25f;
        GetComponent<AudioSource>().Play();
    }

    public void OnPlay4()
    {
        GetComponent<AudioSource>().pitch = 1.33f;
        GetComponent<AudioSource>().Play();
    }
    public void OnPlay5()
    {
        GetComponent<AudioSource>().pitch = 1.4f;
        GetComponent<AudioSource>().Play();
    }
    public void OnPlay6()
    {
        GetComponent<AudioSource>().pitch = 1.5f;
        GetComponent<AudioSource>().Play();
    }

    public void OnPlay7()
    {
        GetComponent<AudioSource>().pitch = 1.60f;
        GetComponent<AudioSource>().Play();
    }
    public void OnPlay8()
    {
        GetComponent<AudioSource>().pitch = 1.68f;
        GetComponent<AudioSource>().Play();
    }
    public void OnPlay9()
    {
        GetComponent<AudioSource>().pitch = 1.75f;
        GetComponent<AudioSource>().Play();
    }
    public void OnPlay10()
    {
        GetComponent<AudioSource>().pitch = 1.90f;
        GetComponent<AudioSource>().Play();
    }
    public void OnPlay11()
    {
        GetComponent<AudioSource>().pitch = 2.0f;
        GetComponent<AudioSource>().Play();
    }


}
