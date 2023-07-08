using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using TMPro;

public class Player : NetworkBehaviour
{
    private Camera mainCamera;
    private Rigidbody2D rb;

    public float speed;
    private Vector2 input;
    private Vector2 place;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Diamond1")
        {
            Destroy(collision.gameObject);
        }
    }

    void Update()
    {
        if (!isLocalPlayer) return; // если это не локальный игрок, то не совершать нижепрописанной проверки
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Flip();
        CameraMovement();
    }
        
    private void CameraMovement()
    {
        mainCamera.transform.localPosition = new Vector3(transform.position.x, transform.position.y, -1f);
        transform.position = Vector2.MoveTowards(transform.position, mainCamera.transform.localPosition, Time.deltaTime);
    }


    private void Flip()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }



    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + input * speed / 100);
    }

    public void Teleport1(int coordinate)
    {
        place = transform.position;
        if (place.x > 0)
            place.x += coordinate;
        else
            place.x -= coordinate; 
        if (place.y > 0)
            place.y += coordinate;
        else
            place.y -= coordinate; 
        transform.position = place;
    }
    public void Teleport2(float coordinateX = 11.5f, float coordinateY = 4.5f)
    {
        place = transform.position;
        if (place.x > 0)
            place.x = coordinateX;
        else
            place.x = -coordinateX;
        if (place.y > 0)
            place.y = coordinateY;
        else
            place.y = -coordinateY;
        transform.position = place;
    }
}
