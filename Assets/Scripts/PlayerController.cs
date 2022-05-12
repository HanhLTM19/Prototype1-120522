using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //bat dieu khien bang phim dieu huong
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //dieu khien xe chay tu dong ve truoc
        //transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);

        //Tu kiem soat toc do chay cua xe
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * moveVertical);

        // di chuyen trai/phai
        //cach 1: di chuyen co ban
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * moveHorizontal);

        //cach 2: di chuyen dau xe co do cong hon
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveHorizontal);
    }
}
