using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneAfterSecond : MonoBehaviour
{
    //public LoadScene ls;
    [SerializeField] private LoadScene ls;

    public float second;
    public string SceneName;

    void Start()
    {
        ls = GetComponent<LoadScene>();
        Invoke("ChangeAfterSecond", second);
    }
    
    public void ChangeAfterSecond()
    {
        Ls.ChangeScene(SceneName);
    }
}
