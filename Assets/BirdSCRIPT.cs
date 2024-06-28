using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdSCRIPT : MonoBehaviour
{
    public Rigidbody2D myRigibody;
    public LogicSC logicSC;
    public bool birdIsAlive = true;
    
    // Start is called before the first frame update
    void Start()
    {
        logicSC = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicSC>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigibody.velocity = Vector2.up * 15;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        logicSC.gameOver();
        birdIsAlive = false;
    }

}
