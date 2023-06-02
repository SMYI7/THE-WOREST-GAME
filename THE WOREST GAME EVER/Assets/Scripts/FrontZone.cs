using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontZone : MonoBehaviour
{
    public bool TargtedZone;
    // Start is called before the first frame update
    void Start()
    {
        bool TargtedZone = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        TargtedZone = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        TargtedZone = false;
    }
}
