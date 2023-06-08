using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Bob Birdington";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && logic.birdIsAlive)
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
        if(myRigidBody.position.y > 15 || myRigidBody.position.y < -15){
            logic.gameOver();
            logic.birdIsAlive = false;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision){
        logic.gameOver();
        logic.birdIsAlive = false;
    }
}
