using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class playerMovementScript : MonoBehaviour
{

    [SerializeField] private float speed = 1000f;
    private Vector3 moveDirection;


    Rigidbody rb;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        moveDirection = new Vector3(horizontal, 0, vertical);
        
        if (rb)
        {
            rb.AddForce((moveDirection * speed) * Time.deltaTime);
        }
    }
}
