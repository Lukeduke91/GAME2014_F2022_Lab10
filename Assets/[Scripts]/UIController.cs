using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public GameObject miniMap;

    // Start is called before the first frame update
    void Start()
    {
        miniMap = GameObject.Find("MiniMap");

    }

    // Update is called once per frame
    public void OnRestartButton_Pressed()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OnYButton_Pressed()
    {
        if(miniMap)
        {
            miniMap.SetActive(!miniMap.activeInHierarchy);
        }
    }
}
