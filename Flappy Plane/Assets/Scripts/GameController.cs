using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //Criando variável de timer e definindo valor para ele
    private float timer = 2f;
    [SerializeField] private GameObject obstacle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CriarMontanhas();
    }

    //Dando um trigger para o Timer
    void CriarMontanhas()
    {
        timer -= Time.deltaTime;
        
        if (timer <= 0)
        {
            //Caso contrário, redefina o timer e execute uma ação
            timer = 1f;
            Instantiate(obstacle);
        }
    }
}
