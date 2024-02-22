using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //Criando vari�vel de timer e definindo valor para ele
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
        if (timer > 0f)
        {
            //Se timer n�o for 0 ou menor, reduza o valor do timer por deltaTime (O tempo que se passou entre um frame e outro)
            //Esta opera��o faz com que cada 1f seja 1 segundo, portanto 2f = 2s, 3f = 3s etc...
            timer -= Time.deltaTime;
        } else
        {
            //Caso contr�rio, redefina o timer e execute uma a��o
            timer = 1f;
            Debug.Log("oi");
        }
    }
}
