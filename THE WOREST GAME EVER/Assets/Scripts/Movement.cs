using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class Movement: MonoBehaviour
{

    public Rigidbody2D rig;
    public Transform GroundCheck  ;
    public LayerMask GroundMask;
    private bool Ground;
    public int MaxJumps = 1;
    public int CurrentJumps = 1;
    public int MaxSpeed = 0;
    public float CurrentSpeed = 0;
    public float WhereTocCheck;
    public float JumpHieght;
    [SerializeField] private FrontZone isItInZone;
    
   
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && CurrentJumps > 0 && isItInZone.TargtedZone == false )
        {
            rig.velocity = Vector2.up * JumpHieght;
            CurrentJumps --;
        }
        //else if (Input.GetKeyDown(KeyCode.Space) && CurrentJumps > 0 && Ground == true && isItInZone.TargtedZone == false)
        //{
          //  rig.velocity = Vector2.up * JumpHieght;

        //}
        if (isItInZone.TargtedZone == false)
        {
            rig.gravityScale = 15;
            rig.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * MaxSpeed, rig.velocity.y);
        }
        if (Ground == true)
        {
            CurrentJumps = MaxJumps;
        }
        Ground = Physics2D.OverlapCircle(GroundCheck.position, WhereTocCheck, GroundMask);
    }
    void FixedUpdate()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && CurrentJumps > 0 && isItInZone.TargtedZone == false)
        {
            rig.velocity = Vector2.up * JumpHieght * Time.fixedDeltaTime;
            CurrentJumps --;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(GroundCheck.position, WhereTocCheck);
    }
}
