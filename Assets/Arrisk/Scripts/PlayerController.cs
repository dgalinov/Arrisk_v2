using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {

	Rigidbody2D rb;
	float dirX;

    GameController player;

    Animator animator;

	[SerializeField]
	float moveSpeed = 10f, jumpForce = 400f, bulletSpeed = 500f;

	bool facingRight = true;
	Vector3 localScale;

	public Transform barrel;
	public Rigidbody2D bullet;

    bool jump = false;

	// Use this for initialization
	void Start () {
		localScale = transform.localScale;
		rb = GetComponent<Rigidbody2D> ();
        Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		dirX = CrossPlatformInputManager.GetAxis ("Horizontal");
        //animator.SetFloat("isWalking", Mathf.Abs(dirX));

		if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            Jump();
        }
			
		
		if (CrossPlatformInputManager.GetButtonDown("Fire1"))
        {
            Fire();
        }
			
	}

	void FixedUpdate()
	{
		rb.velocity = new Vector2 (dirX * moveSpeed, rb.velocity.y);
	}

	void LateUpdate()
	{
		CheckWhereToFace ();
	}

	void CheckWhereToFace()
	{
		if (dirX > 0)
			facingRight = true;
		else
			if (dirX < 0)
				facingRight = false;
		if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
			localScale.x *= -1;
		transform.localScale = localScale;
	}

	void Jump()
	{
        if (jump)
        {
            if (rb.velocity.y <= 0)
            {
                rb.AddForce(Vector2.up * jumpForce);
            }
        }
        jump = false;
			
	}

	void Fire()
	{
		var firedBullet = Instantiate (bullet, barrel.position, barrel.rotation);
		firedBullet.AddForce (barrel.up * bulletSpeed);
        //Destroy(firedBullet);
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Coin"))
        {
            CoinsController.coinsAmount += 100;
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jump = true;
    }
}
