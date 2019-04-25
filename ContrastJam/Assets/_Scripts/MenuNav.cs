using UnityEngine;
using System.Collections;

public class MenuNav : MonoBehaviour
{
    public GameObject[] othersOff;
    public GameObject[] othersOn;

    public bool credits = false;

    public IEnumerator LoadLevel()
    {
        while (Input.anyKey)
        { yield return null; }

        yield return new WaitForSeconds(0.35f);

        Application.LoadLevel(Application.loadedLevel + 1);
    }

    public IEnumerator LoadCredits()
    {
        foreach (GameObject g in othersOff)
        { g.SetActive(false); }

        foreach (GameObject g in othersOn)
        { g.SetActive(true); }

        while (Input.anyKey)
        { yield return null; }

        yield return new WaitForSeconds(0.35f);

        foreach (GameObject g in othersOn)
        { g.SetActive(false); }

        foreach (GameObject g in othersOff)
        { g.SetActive(true); }
    }
}
