using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{

    public GameObject explosion;
    public GameObject playerExplosion;

    public int scoreValue;
    private GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        GameObject go = GameObject.FindWithTag("GameController");
        if (go != null)
        {
            gameController = go.GetComponent<GameController>();
        }
        else
        {
            Debug.Log("找不到脚本GameController");
        }

        if (gameController == null)
        {
            Debug.Log("找不到GameController.cs"); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }
        Instantiate(explosion, transform.position, transform.rotation);
        if (other.tag == "Player")
        {
            Instantiate(explosion, other.transform.position, other.transform.rotation);
            gameController.GameOver();
        }
        gameController.AddScore(scoreValue);
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
