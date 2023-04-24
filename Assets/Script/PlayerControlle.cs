using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlle : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float hight;
   
    public float jumpDelay = 1f;
    public coin cointext;

    [SerializeField] AudioClip jumpsound;
    [SerializeField] AudioClip picksound;
    private float horizontalmove;
    
    private bool ismoveright;
    private bool ismoveleft;
   private bool isjump;
    Animator animator;
    private Coroutine jumpCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
        ismoveleft = false;
        ismoveright = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        jumping();
       movement();
        this.transform.rotation = Quaternion.Euler(new Vector3(0f,ismoveright?180f:0f,0f));
     

    }

    public void moveRightup()
    {
        ismoveright = false;

    }
    public void moveRightdown()
    {
        ismoveright = true;

    }
    public void moveLeftup()
    {
        ismoveleft = false;
    }
    public void moveLeftdown()
    {
        ismoveleft = true;
    }

    public void movement()
    {
        if (ismoveleft)
        {
            animator.SetBool("ismove", true);
            horizontalmove = -speed;
        }
        else if (ismoveright)
        {  
            
            animator.SetBool("ismove", true);
            horizontalmove = speed;
            
        }
        else
        {
            animator.SetBool("ismove", false);
            horizontalmove = 0;
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalmove, rb.velocity.y);
        
    }
     public void jumpup()
     {
         isjump= false;
        SoundManager.instance.PlaySound(jumpsound);
    }
     public void  jumpdown()
     {
         isjump = true;
        
     }

    public void jumping()
    {

        {
            if (isjump == true )
            {
               /* rb.AddForce(new Vector2(rb.velocity.x, hight));*/
               
                rb.velocity = Vector3.up * hight;
            }
            else
            {
                rb.AddForce(new Vector2(rb.velocity.x, 0));
            }


        }
    }
        /* bool isground()
         {
             return Physics.Raycast(transform.position, Vector3.down, groundDistance);
         }*/
        /* public void OnCollisionEnter2D(Collision2D collision)
         {
             if (collision.gameObject.CompareTag("ground"))
             {
                 Debug.Log(" in ground");

                 isjump = true;
             }
         }

         public void OnCollisionExit2D(Collision2D collision)
             {
                 if(collision.gameObject.CompareTag("ground"))
                  {
                 Debug.Log("not in ground");
                   isjump=false;
                 }
             }*/

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Coin")
            {
            SoundManager.instance.PlaySound(picksound);
            Destroy(collision.gameObject);
                 
                cointext.addcoin();
            }
        }
    IEnumerator EnableJumpAfterDelay(float delay)
    {
        rb.AddForce(new Vector2(rb.velocity.x, 0));
        yield return new WaitForSeconds(delay);
        
    }

}
