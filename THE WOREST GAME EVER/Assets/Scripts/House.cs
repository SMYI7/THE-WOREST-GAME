using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class House : MonoBehaviour
{
    public bool Targeted;
    public Transform PlayerPosition;
    public Transform HouesPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Targeted == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                PlayerPosition.transform.position = HouesPosition.position;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       Targeted = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Targeted = false;
    }
}
