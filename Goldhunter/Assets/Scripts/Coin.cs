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

        // StartCoroutine(Spin());
        // StartCoroutine(Float());

    }

    

    private void Spin()
    {

            transform.Rotate(transform.up, 360 * rotateSpeed * Time.deltaTime);
            //yield return 0;

    }

    private void Float()
    {

            float newY = transform.position.y + (isMovingUp ? 1 : -1) * 2 * movementDistance * floatSpeed * Time.deltaTime;

            if (newY > startingY + movementDistance)
            {
                newY = startingY + movementDistance;
                isMovingUp = false;
            }
            else if (newY < startingY)
            {
                newY = startingY;
                isMovingUp = true;
            }

            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
            //yield return 0;
        
    }


}
