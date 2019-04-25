using UnityEngine;
using System.Collections;

public class DeathSpawn : MonoBehaviour
{
    public GameObject toSpawn;
    void OnDestroy()
    {
        Vector3 pos = gameObject.transform.position + new Vector3(0, 0, -1);
        Instantiate(toSpawn, pos, Quaternion.identity);
    }
}
