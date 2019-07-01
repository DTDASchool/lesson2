using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movements : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float turnSpeed = 200f;
    [SerializeField] private float jumpForce = 200f;

    private float currentV = 0f;
    private float currentH = 0f;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed += 1f;
    }

    // Update is called once per frame
    void Update()
    {
        /* --- Movements --- */
        float tempV = Input.GetAxis("Vertical");
        float tempH = Input.GetAxis("Horizontal");

        //m_currentV = Mathf.Lerp(m_currentV, v, Time.deltaTime * m_interpolation);
        //m_currentH = Mathf.Lerp(m_currentH, h, Time.deltaTime * m_interpolation);

        /* --- Rotation --- */
        //transform.position += transform.forward * tempV * moveSpeed * Time.deltaTime;
        //transform.Rotate(0f, tempH * turnSpeed * Time.deltaTime, 0f);

        transform.position = new Vector3 (transform.position.x + tempH * moveSpeed * Time.deltaTime, transform.position.y, transform.position.z + tempV * moveSpeed * Time.deltaTime);


        /* --- Jump --- */
        if (Input.GetKeyDown("space"))
        {
            transform.GetComponent<Rigidbody>().AddForce(transform.up * jumpForce);
        }
    }
}
