using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{


    private float speed = 20;
    public PlayerController playerControllerScript;
    private float leftBound = -15;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        
        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}

/*
 playerControllerScript: Bu bir değişken tanımıdır. Muhtemelen PlayerController türünden bir değişkendir. Bu değişkenin amacı,
"Player" adındaki GameObject'e bağlı olan PlayerController bileşenine referans tutmaktır.

GameObject: Unity'de sahnede herhangi bir nesneyi temsil eden bir sınıftır. Bu 3D model, arayüz öğesi, ışık, kamera vb. olabilir.

Find("Player"): Find(), sahnede belirtilen ada sahip bir GameObject'i aramak için kullanılan bir GameObject sınıfının yöntemidir. 
 Bu durumda, "Player" adında bir GameObject arar.

.GetComponent<PlayerController>(): GetComponent(), bir GameObject'in üzerine ekli olan belirli bir bileşeni almak için kullanılan bir yöntemdir
. Bu durumda, "Player" GameObject'inden PlayerController bileşenini almayı deniyor.

Eğer sahnede "Player" adında bir GameObject bulunuyorsa ve bu GameObject'e bağlı bir PlayerController bileşeni varsa,
bu kod satırı o GameObject'i bulacak ve PlayerController bileşenini alacak. 
playerControllerScript değişkeni daha sonra bu bileşene referans tutacak ve betik, 
PlayerController bileşeninin özelliklerine ve işlevlerine erişip onları değiştirebilecektir.
 
 
 */