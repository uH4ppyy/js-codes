using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player2 : MonoBehaviour
{


    // x > y  X eh maior que Y
    // x < y X eh menor que Y
    // x == y X eh igual Y
    // x != y X eh diferente de Y
    // x = y X recebe o valor de Y
    // x >= y X eh maior ou igual Y
    // x <= y X eh menor ou igual Y
    //&& - E (AND)
    //|| - OU (OR)
    public float velocidade;
    public float vida;
    public float forca;
    public float estamina;
  
    private void Start()
    {
        //Executa quando eu der play no projeto
        Caminhar("Caminhado por parametro");

    }
    private void Update()
    {
        //Executar a cada frame / Executa os codigos continuamentes
        Atacar();
        Morrer();
        Correr();
    }

    //Metodos
    public void Caminhar(string mensagem)
    {
        Debug.Log(mensagem);
    }
    public void Correr()
    {
        if(estamina > 0 && Input.GetKey(KeyCode.LeftShift))
        {
            //Implementar correr
            Debug.Log("Correndo!");
            //estamina -= 1; estamina --  estamina = estamina - 1;
            estamina -= 2 * Time.deltaTime;
        }

    }
    public void Atacar()
    {
        //Implementar atacar
        //if(Input.GetKeyDown(KeyCode.Escape)) Metodo que diz se estou clicando em uma tecla
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Atacou");
        }

    }
    public void Morrer()
    {
        //Implementar morte
        if(vida <= 0)
        {
            Debug.Log("Morreu");
        }
    }
}
