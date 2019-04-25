using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
    public float movementSpeed = 1.0f;

    void Start()
    {
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("Number"))
        {
            Destroy(g);
        }
        ScoreControl.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        #region x
        if (Input.GetAxis("Horizontal") < 0) // left
        {
            Move(-1, gameObject.transform.position.y);
        }
        else if (Input.GetAxis("Horizontal") > 0) //right
        {
            Move(1, gameObject.transform.position.y);
        }
        else // middle
        {
            Move(0, gameObject.transform.position.y);
        }
        #endregion

        #region y
        if (Input.GetAxis("Vertical") < 0) // up
        {
            Move(gameObject.transform.position.x, -1);
        }
        else if (Input.GetAxis("Vertical") > 0) // down
        {
            Move(gameObject.transform.position.x, 1);
        }
        else // middle
        {
            Move(gameObject.transform.position.x, 0);
        }
        #endregion
    }

    void Move(float x, float y)
    {
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(x, y, 0), movementSpeed);
    }
}