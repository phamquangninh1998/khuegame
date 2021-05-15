using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;


    public GameObject shotGun;
    public GameObject pistol;
    public SpriteRenderer hat;
    public SpriteRenderer glasses;
    public SpriteRenderer gun;

     Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            MoveRight();
        }
        if (Input.GetKey(KeyCode.A))
        {
            MoveLeft();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void MoveRight()
    {
        transform.position += Vector3.right * moveSpeed * Time.deltaTime;
    }
    private void MoveLeft()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
    private void Jump()
    {
        rb.AddForce(Vector2.up*jumpForce, ForceMode2D.Force);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Gun")
        {
            Debug.Log("Change Gun");
            ChangeGun(collision.gameObject.GetComponent<Gun>());
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "Hat")
        {
            ChangeHat(collision.gameObject.GetComponent<SpriteRenderer>());
            collision.gameObject.SetActive(false);

        }
        if (collision.gameObject.tag == "Glasses")
        {
            ChangeGlasses(collision.gameObject.GetComponent<SpriteRenderer>());
            collision.gameObject.SetActive(false);

        }
    }

    private void ChangeGlasses(SpriteRenderer _glasses)
    {
        glasses.sprite = _glasses.sprite;
    }

    private void ChangeHat(SpriteRenderer _hat)
    {
        hat.sprite = _hat.sprite;

    }

    private void ChangeGun(Gun _gun)
    {
        if (_gun.gunType == GunType.Pistol)
        {
            Debug.Log("pistol");
            pistol.SetActive(true);
            shotGun.SetActive(false);
        }
        if (_gun.gunType == GunType.ShotGun)
        {
            Debug.Log("shotgun");

            pistol.SetActive(false);
            shotGun.SetActive(true);
        }
        gun.sprite = _gun.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite;
    }
}
