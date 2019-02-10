using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTransitionScript : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Will keep track of where the player left the scene and therefore 
    // where he will appear once he returns to the scene
    private int spawnPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
