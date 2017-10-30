using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KnockbackOnHit : MonoBehaviour {

    //public AudioSource hitsound;
    //public Rigidbody2D knight;

	void Start () {
        //hitsound = GetComponent<AudioSource>()
        //knight = GetComponent<Rigidbody2D>();
	}

   

    public class Knockback : MonoBehaviour
    {
        private void OnTrigger(Collider2D other)
        {
            if (other.tag == "Enemy")
            {
                GetComponent<AudioSource>().Play();
                SceneManager.LoadScene(2);
            }
            else if(other.tag == "Obstacle")
            {
                GetComponent<AudioSource>().Play();
                GetComponent<Rigidbody2D>().AddForce(new Vector2(5f, 0f));
            }
        }
    }
}
