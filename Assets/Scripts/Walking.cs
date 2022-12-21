using UnityEngine;

public class Walking : MonoBehaviour
{
 [SerializeField] private float speed;
 private Rigidbody2D body;
// private Animator anim;
 private bool Ground;

    // sound thingys DONT TOUCH OR ELSE
    [SerializeField] private AudioSource jumpSFX;
    [SerializeField] private AudioSource SlideSFX;

    private void Awake()
 {
//grab refeneces
  body = GetComponent<Rigidbody2D>();
//  anim = GetComponent<Animator>();
 }

 private void Update()
 {
    //handles walking
    float horizontalInput = Input.GetAxis("Horizontal");
 body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);
 
 //flip the sprite
if(horizontalInput > 0.01f)
 transform.localScale = new Vector3(1, 1, 1);
        else if(horizontalInput < -0.01f)
transform.localScale = new Vector3(-1, 1, 1);

//handles jumps
 if(Input.GetKey(KeyCode.UpArrow) && Ground)
        {
            jump();
            jumpSFX.Play();
        }
 
 
 //Handles Animation
// anim.SetBool("Running", horizontalInput != 0);
// anim.SetBool("Ground", Ground);

 // slidesound effect PROPERTY OF YURI DONT TOUCH
 if((horizontalInput > 0 || horizontalInput < 0) && Ground && !SlideSFX.isPlaying)
        {
            SlideSFX.Play();
        }
 if(horizontalInput == 0 || !Ground)
        {
            SlideSFX.Stop();
        }
 }

//handles juming part 2
 private void jump()
 {
 body.velocity = new Vector2(body.velocity.x, 15);
 Ground = false;
 }

//checks collision with ground seems to be a bit wacky
private void OnCollisionEnter2D(Collision2D collision)
{
 if(collision.gameObject.tag == "Ground")
 Ground = true;
}
} 