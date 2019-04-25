using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour
{
    void OnDestroy()
    {
        ScoreControl.score--;
    }
}
