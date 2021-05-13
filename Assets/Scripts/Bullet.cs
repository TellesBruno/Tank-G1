using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
	public float shotSpeed;
	public Player2 _player2;

    void Awake (){
        _player2 = GameObject.FindGameObjectWithTag ("Player2").GetComponent<Player2>();
    }

	void FixedUpdate () {
		transform.Translate (0, shotSpeed, 0);
	}

	void OnBecameInvisible(){
		Destroy (this.gameObject);
	}

    void OnCollisionEnter2D (Collision2D other){
        if (other.gameObject.tag == "Block"){
            Destroy (other.gameObject);
            Destroy (this.gameObject);
        }
        if (other.gameObject.tag == "Iron"){
            Destroy (this.gameObject);
        }
        if (other.gameObject.tag == "Player2"){
            _player2.getHit();
            Destroy (this.gameObject);
        }
    }
}
