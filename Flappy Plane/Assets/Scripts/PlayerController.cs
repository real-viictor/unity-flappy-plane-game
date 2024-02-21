using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //Criando uma vari�vel para acessar as propriedades de RigidBody
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
        Subir();
        LimitarVelocidade();
    }

    //Mandando o Player subir se o espa�o for apertado
    private void Subir()
    {
        //Checando se espa�o est� pressionado
        isSpacePressed = Input.GetKeyDown(KeyCode.Space);

        //Executando pulo se espa�o for pressionado
        if (isSpacePressed)
        {
            //Definindo velocidade do rigidbody para cima e multiplicando pela velocidade determinada ao player
            PlayerRB.velocity = Vector2.up * playerSpeed;
        }
    }

    //Limitando a velocidade de queda do Player
    private void LimitarVelocidade()
    {
        if (PlayerRB.velocity.y < -playerSpeed)
        {
            PlayerRB.velocity = Vector2.down * playerSpeed;
        }
    }

    //Configurando a��o de colis�o do Player com o obst�culo
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Ap�s colidir, resete a Scene
        SceneManager.LoadScene("Main");
    }
}
