using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    public float shotSpeed;
    public Player1 _player1;
    void Awake()
    {
        _player1 = GameObject.FindGameObjectWithTag ("Player1").GetComponent<Player1>();
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
        if (other.gameObject.tag == "Player1"){
            _player1.getHit();
            Destroy (this.gameObject);
        }
    }
}
