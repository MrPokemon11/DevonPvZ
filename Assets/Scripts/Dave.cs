using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dave : MonoBehaviour
{
    private float speed = 2f;
    private GameObject player;
    private Rigidbody2D rb2d;

    private float bulletSpeed = 10f;
    
    [SerializeField] GameObject bullet;
    private Rigidbody2D bulletRb;
    
    public float damage;
    public float fireRate;
    public int insanity;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        bulletRb = bullet.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            MoveUp();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            MoveDown();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    void Fire()
    {
        Rigidbody2D proj = Instantiate(bulletRb, transform.position, Quaternion.identity);
        proj.velocity = transform.right * bulletSpeed * Time.deltaTime;
        
    }

    void MoveUp()
    {
        if (player.transform.position.y < 4)
        {
            rb2d.transform.position += Vector3.up * speed;
        }
    }

    void MoveDown()
    {
        if (player.transform.position.y > -4)
        {
            rb2d.transform.position += Vector3.down * speed;
        }
    }
}
