using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LibraryOfPrefabs : MonoBehaviour
{
    private static LibraryOfPrefabs instance;
    public GameObject[] prefabs;
    

    public static LibraryOfPrefabs GetInstance()
    {
        return instance;
    }
    private void Start()
    {
        instance = this;
    }
}
