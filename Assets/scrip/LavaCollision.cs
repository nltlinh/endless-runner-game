using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaCollision : MonoBehaviour {

	public int damage;
	public float speed;

	public araharacter player;
	public GameObject lava;
	
	private void Update () {
		transform.Translate(Vector2.left * speed * Time.deltaTime);
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "player"){
			int health = player.getHealth();
			
			health -= damage;
			Debug.Log(health);
			Destroy(lava);
		}
	}
}
