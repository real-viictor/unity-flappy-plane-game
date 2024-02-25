using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //Criando variável que controla o timer e o valor que o timer receberá como tempo
    private float timer;
    [SerializeField] private GameObject obstacle;

    // Start is called before the first frame update
    void Start()
    {
        //Atribuindo intervalo inicial do timer
        timer = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        CriarMontanhas();
    }

    //Criando montanhas baseado num timer
    void CriarMontanhas()
    {
        //Reduzindo tempo do timer por frame do jogo
        timer -= Time.deltaTime;
        
        //Se o valor do timer for menor ou igual a zero, instancie a montanha e redefina o timer
        if (timer <= 0)
        {
            timer = Random.Range(1,3);
            Instantiate(obstacle);
        }
    }
}
