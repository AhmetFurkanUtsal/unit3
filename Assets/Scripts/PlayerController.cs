using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAnim;
    public float jumpForce = 20;
    public float gravityModifier;
    
    public bool isOnGround = true;
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier; // Physics.gravity = Physics.gravity * gravitYModifier
        // gravitymodifier 2 olarak ayarlandı oyunda
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver) 
        {
            playerRb.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
            // Addforce gerçek hayatta cismin kütlesini aldı ve yukarı yönde hareket ettirdi.
            // ForceMode.Impulse anında uygular

            isOnGround = false;
            // buraya kadar yaptığımızda oyuncu bir kez zıplıyor. 
            // oyuncunun space e spam yapması engellendi
            playerAnim.SetTrigger("Jump_trig");
        }
    }
    private void OnCollisionEnter(Collision collision) // çarpışmalalrı kontrol eder
    {
        // Zemine ve engele  yeni tag oluşturduk ve isimlendirdik 
       

        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true; // yere çarptığında 

        }else if(collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("GameOver"); // engele çarptığında 
            gameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
        }
        
    }
}
