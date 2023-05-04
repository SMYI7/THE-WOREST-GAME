using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class Movement: MonoBehaviour
{
    public float WhereTocCheck;
    public Transform GroundCheck  ;
    public LayerMask GroundMask;
    private bool Ground;
    public int MaxJumps = 1;
    public int CurrentJumps = 1;
    public int MaxSpeed = 0;
    public float CurrentSpeed = 0;
    public Rigidbody2D rig;
    public float JumpHieght;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && CurrentJumps >= 1 )
        {
            rig.velocity = Vector2.up * JumpHieght;
            CurrentJumps --;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && CurrentJumps > 0 && Ground == true)
        {
            rig.velocity = Vector2.up * JumpHieght;

        }

        rig.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * MaxSpeed,rig.velocity.y) ;
        if (Ground == true)
        {
            CurrentJumps = MaxJumps;
        }
       
     }
    void FixedUpdate()
    {
        Ground = Physics2D.OverlapCircle(GroundCheck.position, WhereTocCheck, GroundMask);
        if (Input.GetKeyDown(KeyCode.Space) && CurrentJumps > 0)
        {
            rig.velocity = Vector2.up * JumpHieght * Time.deltaTime;
            CurrentJumps --;
        }
    }
}
