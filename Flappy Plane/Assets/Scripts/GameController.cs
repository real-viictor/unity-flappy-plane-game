using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //Criando variável de timer e definindo valor para ele
    private float timer = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AtivarTimer();
    }

    //Dando um trigger para o Timer
    void AtivarTimer()
    {
        timer -= Time.deltaTime;
        
        if (timer <= 0)
        {
            //Caso contrário, redefina o timer e execute uma ação
            timer = 1f;
            Debug.Log("oi");
        }
    }
}
