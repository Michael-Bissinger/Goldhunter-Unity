using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]
    private float rotateSpeed = 1.0f;  // rotates per second

    // Start is called before the first frame update
    void Start()
    {

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
