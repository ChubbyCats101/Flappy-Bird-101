using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeminddleSC : MonoBehaviour
{
    // Start is called before the first frame update
    public LogicSC logicSC;
    void Start()
    {
        logicSC = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicSC>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        logicSC.addScore();
    }
}
