using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]
    private float rotateSpeed = 1.0f;  // rotates per second

    [SerializeField]
    private float floatSpeed = 0.5f; // In cycles (up and down) per second

    [SerializeField]
    private float movementDistance = 0.5f; // The maximum distance the coin can move up and down

    private float startingY;
    private bool isMovingUp = true;

    // Start is called before the first frame update
    void Start()
    {
        startingY = transform.position.y;
        transform.Rotate(transform.up, Random.Range(0f, 360f));
        StartCoroutine(Spin());
        

    }

    private IEnumerator Spin()
    {
        while (true)
        {

            transform.Rotate(transform.up, 360 * rotateSpeed * Time.deltaTime);
            yield return 0;

        }
    }
    
}
