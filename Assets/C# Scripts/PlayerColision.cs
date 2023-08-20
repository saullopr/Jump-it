using UnityEngine;

public class PlayerColision : MonoBehaviour {

	//Objeto utilizado para recuperar energia
    public GameObject capsula;
	
	//Quando o player colide com algo expecífico
    private void OnCollisionEnter(Collision colisionInfo)
    {
        //Se colidir com terreno
        if(colisionInfo.collider.tag == "Terreno")
        {
			//O player morre e a fase reinicia
            FindObjectOfType<GameManager>().endGame();
        }

		//Se colidir com um objeto com TAG "TimeBonus"
        if (colisionInfo.collider.tag == "TimeBonus")
        {
			//O objeto desaparece para não haver problemas
            capsula.SetActive(false);
			//Chama a função que da mais tempo para o jogador "recuperando energia"
            FindObjectOfType<TimerScript>().moreTime();
        }
    }

}
