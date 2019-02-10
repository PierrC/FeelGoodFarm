using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;
using static TreeData;
using System;

public class DataManager : MonoBehaviour
{
    private static DataManager instance;
    [SerializeField]
    public static List<TreeData> trees;
    static string treeDataPath;

    public static DataManager GetInstance()
    {
        return instance;
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        trees = new List<TreeData>();
        treeDataPath = Path.Combine(Application.persistentDataPath, "TreeData.txt");

        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        LoadTreesFunction();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("Tree Saved. Size of the tree list: " + trees.Count);
            SaveTrees();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            while(trees.Count != 0)
            {
                TreeData treeData = trees[0];
                trees.RemoveAt(0);
                Destroy(treeData.gameObject);
            }
            foreach (TreeDataSerializable td in LoadTrees())
            {
                Debug.Log("Load done");
                Debug.Log("Td position:" + td.position);
                trees.Add(Instantiate(LibraryOfPrefabs.GetInstance().prefabs[1]).GetComponent<TreeData>());
                trees[trees.Count - 1].transform.position = td.position;// = td.position;
                                                                         //  trees[trees.Count - 1].transform.position = trees[trees.Count - 1].position;
            }
            //Debug.Log("Load Tree count size: " + LoadTrees().Count);
        }
    }

    public void AddTreeData(TreeData data)
    {
        trees.Add(data);
    }

    static void SaveData()
    {

    }

    public static void SaveTrees()
    {

        Debug.Log("Before serialization");

        List<TreeDataSerializable> saves = new List<TreeDataSerializable>();
        foreach(TreeData treeData in trees)
        {
            saves.Add(new TreeDataSerializable(treeData.emotion, treeData.state, treeData.message, treeData.date, treeData.position));
        }
        string jsonStringTrees = JsonConvert.SerializeObject(saves);

        Debug.Log("after serialization");
        using (StreamWriter streamWriter = File.CreateText(treeDataPath))
        {
            streamWriter.Write(jsonStringTrees);
        }
    }

    void LoadTreesFunction()
    {
        while (trees.Count != 0)
        {
            TreeData treeData = trees[0];
            trees.RemoveAt(0);
            Destroy(treeData.gameObject);
        }
        foreach (TreeDataSerializable td in LoadTrees())
        {
            Debug.Log("Load done");
            Debug.Log("Td position:" + td.position);
            trees.Add(Instantiate(LibraryOfPrefabs.GetInstance().prefabs[1]).GetComponent<TreeData>());
            trees[trees.Count - 1].transform.position = td.position;// = td.position;
                                                                    //  trees[trees.Count - 1].transform.position = trees[trees.Count - 1].position;
        }
    }

    static List<TreeDataSerializable> LoadTrees()
    {
        using (StreamReader streamReader = File.OpenText(treeDataPath))
        {
            Debug.Log("Reading saves");
            string jsonString = streamReader.ReadToEnd();
           // TreeListWrapper treeListWrapper = JsonConvert.DeserializeObject<TreeListWrapper>(jsonString);
            return JsonConvert.DeserializeObject<List<TreeDataSerializable>>(jsonString);
        }
    }

}


class TreeDataSerializable
{
    public TreeDataSerializable(Emotion pemotion, TreeState ptreeState, string pMessage, DateTime pdateTime, Vector3 pvector3)
    {
        emotion = pemotion;
        state = ptreeState;
        message = pMessage;
        date = pdateTime;
        position = pvector3;
    }

    //public TreeDataSerializable(TreeData treeData)
    //{
    //    emotion = new Emotion();
    //    state = new TreeState();
    //    message = "";
    //    date = new DateTime();
    //    position = new Vector3();

    //    emotion = treeData.emotion;
    //    state = treeData.state;
    //    message = treeData.message;
    //    date = treeData.date;
    //    position = treeData.position;
    //}


    public Emotion emotion;
    public TreeState state;
    public string message;
    public DateTime date;
    public Vector3 position;
}
