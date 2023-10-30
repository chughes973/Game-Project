using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyLeft : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward* Time.deltaTime * speed); //moves powerup in same direction as boxes, ground and background but unsure why it needed to be right.

    }
}
