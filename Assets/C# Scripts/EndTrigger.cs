using UnityEngine;

public class EndTrigger : MonoBehaviour {

	//Objeto de acesso ao GameManager
    public GameManager gameManager;

	//Recebe a inform~ção de quando o Trigger é acionado
    void OnTriggerEnter()
    {
		//Invoca o método com Delay
        Invoke("tempoResposta", 1f);
    }

	//Incui um tempo de resposta
    void tempoResposta()
    {
		//Chama o a função od GameManager
        gameManager.completeLevel();
    }
}
