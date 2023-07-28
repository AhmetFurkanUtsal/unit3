using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce = 10;
    public float gravityModifier;
    public bool isOnGround = true;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier; // Physics.gravity = Physics.gravity * gravitYModifier


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
            // Addforce gerçek hayatta cismin kütlesini aldı ve yukarı yöde hareket ettirdi.
            // ForceMode.Impulse anında uygular
            isOnGround = false;
            // buraya kadar yaptığımızda oyuncu bir kez zıplıyor. 
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
       isOnGround=true;
        //oyuncunun havada veya yerde olduğunu bilmiyoruz
        // yere çarptığı anda tekrar true yaptık
    }
}
