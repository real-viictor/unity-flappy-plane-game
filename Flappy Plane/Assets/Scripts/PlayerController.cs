using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Criando uma variável para acessar as propriedades de RigidBody
    private Rigidbody2D PlayerRB;

    private bool isSpacePressed;
    private float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //Pegando o RigidBody do componente 
        PlayerRB = GetComponent<Rigidbody2D>();

        //Definindo velocidade do Player
        playerSpeed = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        //Checando se espaço está pressionado
        isSpacePressed = Input.GetKeyDown(KeyCode.Space);  

        //Executando pulo se espaço for pressionado
        if (isSpacePressed)
        {   
            //Definindo velocidade do rigidbody para cima e multiplicando pela velocidade determinada ao player
            PlayerRB.velocity = Vector2.up * playerSpeed;
        }

        //Limitando a velocidade de queda do Player
        if(PlayerRB.velocity.y < -playerSpeed)
        {
            PlayerRB.velocity = Vector2.down * playerSpeed;
        }
    }
}
