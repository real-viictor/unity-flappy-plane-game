using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //Criando variável que controla o timer e atribuindo intervalo inicial do timer
    private float timer = 2f;

    //Criando variável de controle de pontos
    private float points = 0f;

    //Criando variável que recebe o GameObject da montanha
    [SerializeField] private GameObject obstacle;
    [SerializeField] private Text pointsDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CriarMontanhas();
        AdicionarPontos();
    }

    //Criando montanhas baseado num timer
    void CriarMontanhas()
    {
        //Reduzindo tempo do timer por frame do jogo
        timer -= Time.deltaTime;
        
        //Se o valor do timer for menor ou igual a zero, instancie a montanha e redefina o timer
        if (timer <= 0)
        {
            //Redefinindo valor aleatório para o timer
            timer = Random.Range(1,3);
            //Instanciando montanha
            Instantiate(obstacle);
        }
    }

    void AdicionarPontos()
    {
        //Adicionando pontos ao jogador por tempo
        points += Time.deltaTime;
        pointsDisplay.text = Mathf.Round(points).ToString();
    }
}
