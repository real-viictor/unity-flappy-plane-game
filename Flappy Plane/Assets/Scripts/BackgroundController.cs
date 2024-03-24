using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    //Localizando o material que renderiza o Background
    private Renderer background;

    //Declarando a variável que controlará a variação no cenário
    private float backgroundXOffset = 0f;

    private float backgroundSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        //Pegando o renderer do background do jogo
        background = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Adicionando valor ao backgroundXOffset para mover o fundo
        backgroundXOffset += Time.deltaTime * backgroundSpeed;

        //Alterando o parâmetro de Offset no background do jogo
        background.material.mainTextureOffset = Vector2.right * backgroundXOffset;
    }
}
