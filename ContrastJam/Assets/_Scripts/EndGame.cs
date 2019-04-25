using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour
{
    public GameObject[] others;

    // Use this for initialization
    void Awake()
    {
        foreach (GameObject go in others)
        {
            go.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            Application.LoadLevel(Application.loadedLevel);
        else if (Input.GetKeyDown(KeyCode.E))
            Application.LoadLevel(Application.loadedLevel - 1);
    }
}
