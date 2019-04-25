using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LayoutController : MonoBehaviour
{
    public GameObject NextLayout;
    private List<GameObject> pickups = new List<GameObject>();
    private bool start = false;

    void Awake()
    {
        StartCoroutine(CountChildren());
    }

    void Update()
    {
        StartCoroutine(CountChildren());

        if (pickups.Count <= 0 && start == true)
        {
            StartCoroutine(Next());
        }
    }

    public IEnumerator CountChildren()
    {
        start = false;
        pickups.Clear();
        foreach (Transform child in transform)
        {
            pickups.Add(child.gameObject);
        }
        start = true;

        //print("COUNT: " + pickups.Count);
        yield return null;
    }

    private IEnumerator Next()
    {
        while (Input.anyKey)
        {
            //print("HOLDING");
            yield return null;
        }
        yield return new WaitForSeconds(0.5f);

        NextLayout.SetActive(true); // turn on next layout
        transform.parent.gameObject.SetActive(false); // turn off current layout
    }
}
