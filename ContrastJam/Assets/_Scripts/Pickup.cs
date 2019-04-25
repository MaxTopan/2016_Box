using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour
{
    void OnDestroy()
    {
        ScoreControl.score++;
    }
}
