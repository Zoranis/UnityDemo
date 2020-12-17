using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Satellite : MonoBehaviour
{
    [SerializeField]
    private Transform pivot;
    Vector3 rotationVector;

    // Start is called before the first frame update
    void Start()
    {
        rotationVector = new Vector3(0, 0, -1);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = pivot.position;
        transform.Rotate(rotationVector * 70 * Time.deltaTime, Space.Self);
    }
}
