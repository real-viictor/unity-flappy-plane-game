using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Criando uma variável para acessar as propriedades de RigidBody
    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        //Pegando o RigidBody do componente 
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
