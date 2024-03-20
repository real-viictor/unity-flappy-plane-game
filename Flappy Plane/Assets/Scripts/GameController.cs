using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //Criando vari�vel que controla o timer e atribuindo intervalo inicial do timer
    private float timer = 2f;

    //Criando vari�vel de controle de pontos
    private float points = 0f;

    //Criando vari�vel que recebe o GameObject da montanha
    [SerializeField] private GameObject obstacle;

    //Criando vari�veis de display na interface
    [SerializeField] private Text pointsDisplay;
    [SerializeField] private Text levelDisplay;

    //Criando vari�veis de controle de level
    private int gameLevel = 1;
    [SerializeField] private int pointsToUpLevel = 10;

    // Start is called before the first frame update
    void Start()
    {
        //Exibindo level do jogo na tela
        levelDisplay.text = "Level " + gameLevel.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        CriarMontanhas();
        AdicionarPontos();
        AdicionarLevel();
    }

    //Criando montanhas baseado num timer
    void CriarMontanhas()
    {
        //Reduzindo tempo do timer por frame do jogo
        timer -= Time.deltaTime;
        
        //Se o valor do timer for menor ou igual a zero, instancie a montanha e redefina o timer
        if (timer <= 0)
        {
            //Redefinindo valor aleat�rio para o timer
            timer = Random.Range(1,3);
            //Instanciando montanha
            Instantiate(obstacle);
        }
    }

    void AdicionarPontos()
    {
        //Adicionando pontos ao jogador por tempo
        points += Time.deltaTime;

        //Exibindo pontos na tela
        pointsDisplay.text = "Pontos: " + Mathf.Round(points).ToString();
    }

    void AdicionarLevel()
    {
        if(points >= pointsToUpLevel)
        {
            gameLevel++;
            pointsToUpLevel*=2;

            //Alterando o level do jogo na tela quando o usu�rio passa de n�vel
            levelDisplay.text = "Level " + gameLevel.ToString();
        }
    }
}
