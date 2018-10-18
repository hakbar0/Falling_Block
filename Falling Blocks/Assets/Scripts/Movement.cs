using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 0.4f;
    public float xMin = -8.0f;
    public float xMax = 8.0f;
    public GameObject Missile;

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        float movement = (moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
        transform.Translate(movement, 0, 0);
        transform.position = new Vector3((Mathf.Clamp(transform.position.x, xMin, xMax)), -2.951542f, 0);

        if (Input.GetKeyDown("space"))
        {
            GameObject instance = Instantiate(Missile);
            instance.transform.position = new Vector3(transform.position.x, -1.5f, 0f);
            var instanceRB = instance.GetComponent<Rigidbody>();
            instanceRB.AddForce(0, 1000f, 0);
        }
    }
}