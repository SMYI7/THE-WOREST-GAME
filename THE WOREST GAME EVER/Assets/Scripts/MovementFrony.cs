using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class MovementFrony: MonoBehaviour
{
    
    private Vector2 axis;
    public int MaxSpeed = 0;
    public float CurrentSpeed = 0;
    public Rigidbody2D rig;
    public float JumpHieght;
    [SerializeField] private FrontZone isItInZone;
    [SerializeField] SowredHit SowredHB;
    Vector2 moveD;
    

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();

        
  
    }

    // Update is called once per frame
    void Update()
    {
      if (isItInZone.TargtedZone == true)
        {
            axis.x = Input.GetAxisRaw("Horizontal");
            axis.y = Input.GetAxisRaw("Vertical");
            rig.gravityScale = 0;
          //  moveD = new Vector2(axis.x, axis.y);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
           
        }
    }
    private void FixedUpdate()
    {
        if (isItInZone.TargtedZone == true)
        {
            rig.MovePosition(rig.position + axis * MaxSpeed * Time.fixedDeltaTime);
        }
    }


}
