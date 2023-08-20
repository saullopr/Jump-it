using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

	//Contador do empo máximo
    public float cont = 25.0f;

	//Texto do UI
    public Text timerText;
	//Tempo atual para fazer o calculo da contagem regressiva
    private float startTime;
	
	//Quando o jogo inicia
	void Start () {
        startTime = Time.time;	//Declara o tmpo atual
	}
    
	//Função para ganhar mais tempo
    public void moreTime()
    {
        cont = cont + 10.0f;	//Adiciona mais 10 segundos ao tempo atual
        Debug.Log("TA FUNCIONANDO!!! AMÉM");	//Debug para fins de controle de chamada de função
    }
	
	//Update chamado a cada frame
	void Update () {
        if (cont > 0.0f)	//Enquanto o tempo for maior que 0
        {
            cont -= Time.deltaTime; 	//Calcula o tempo atual

            string minutes = ((int)cont / 60).ToString();	//Passa para String
            string seconds = (cont % 60).ToString("f0");	//Passa para String
            timerText.text = minutes + ":" + seconds;		//Exibe o tempo atual na tela
        }
        else	//quando o tempo for <= 0
        {
            FindObjectOfType<GameManager>().endGame();	//O jogo termina
        }
	}
}
