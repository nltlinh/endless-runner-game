using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class araharacter : MonoBehaviour {
	public float moveSpeed;
	public float jumpForce;
	public float maxHeight;
	public float minHeight;
    public int health = 3;


    private Rigidbody2D myRigidbody;


    public int Health
    {
        get
        {
            return health;
        }

        set
        {
            health = value;
        }
    }


    // Use this for initialization

    public int getHealth()
	{
		return Health;
	}
	void Start () {
		myRigidbody=GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	private void Update () {
		if (health <= 0){
            // SceneManager.LoadScene("GameOver");
            Debug.Log("GAME OVER!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
		
		myRigidbody.velocity = new Vector2(moveSpeed,myRigidbody.velocity.y);

		if (Input.GetKeyDown(KeyCode.Space) && transform.position.y < maxHeight && transform.position.y >minHeight || Input.GetMouseButtonDown(0))
		{
			myRigidbody.velocity = new Vector2(myRigidbody.velocity.x,jumpForce);
		} 
		
	}
}
