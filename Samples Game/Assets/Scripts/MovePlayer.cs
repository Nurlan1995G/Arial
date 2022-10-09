using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 5f, hSpeed = 10f, _thrust = 500f;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // if (Input.GetKey(KeyCode.UpArrow)  || Input.GetKey(KeyCode.W))   //UpArrow это клавиша вверх
        //{
        //    transform.Translate(new Vector3(1,0,0) * speed * Time.deltaTime);
        // }
        // if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))   //UpArrow это клавиша вниз
        //{
        //  transform.Translate(new Vector3(1, 0, 0) * -speed * Time.deltaTime);
        //  }

       // float v = Input.GetAxis("Vertical");      // осуществление движения предмета
       // transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime * v);
       // float h = Input.GetAxis("Horizontal");                            
       // transform.Translate(new Vector3(0,0,1) * speed * Time.deltaTime * h);
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal") * hSpeed * Time.fixedDeltaTime;
        float v = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;

        rb.velocity = transform.TransformDirection(new Vector3(v, rb.velocity.y, -h));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Block")
        {
            rb.AddForce(new Vector3(0, 1, 0) * _thrust);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "TriggerMain")
            Debug.Log("Соприкосновение с триггером");
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "TriggerMain")
            Debug.Log("Продолжаем соприкосновение");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "TriggerMain")
            Destroy(gameObject);
    }
}
