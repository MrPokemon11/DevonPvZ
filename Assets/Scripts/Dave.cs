using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dave : MonoBehaviour
{
    
    private float speed = 2f;
    private GameObject player;
    private Rigidbody2D rb2d;

    private float bulletSpeed = 1000f;
    
    [SerializeField] GameObject bullet;
    private Rigidbody2D bulletRb;
    
    public float damage = 1;
    public float fireRate = 1;
    public int insanity = 0;
    
    bool canFire = true;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
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
        if (canFire)
        {
            canFire = false;
            Rigidbody2D proj = Instantiate(bulletRb, transform.position, Quaternion.identity);
            proj.gameObject.GetComponent<Projectile>().isFriendly = true;
            proj.gameObject.GetComponent<Rigidbody2D>().velocity = transform.right * bulletSpeed * Time.deltaTime;
            WaitForSeconds wait = new WaitForSeconds(3/fireRate);
            canFire = true;
        }

        
    }

    void MoveUp()
    {
        if (player.transform.position.y < 4)
        {
            player.transform.position += Vector3.up * speed;
        }
    }

    void MoveDown()
    {
        if (player.transform.position.y > -4)
        {
            player.transform.position += Vector3.down * speed;
        }
    }
}
