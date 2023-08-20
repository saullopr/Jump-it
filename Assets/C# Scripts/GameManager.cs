using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	//restartDelay será usado como tempo de resposta
    public float restartDelay = 1.2f;
	//Declara uma forca de chamar o object TimerScript
    public TimerScript ts;

	//Objeto de controle da UI
    public GameObject completeLevelUI;

	//Nome auto-explicativo
    public void completeLevel()
    {
        Debug.Log("LEVEL WON");	//Debug para fins de controle de chamada de função
        completeLevelUI.SetActive(true);	//Faz com que a UI se ative quando a função for chamada
    }

	//Ocorre quanto o jogador morre
    public void endGame()
    {
		//Utiliza o restartDelay para que a função não seja chamada instantaneamente
        Invoke("Restart", restartDelay);
    }

	//Reinicia a cena/fase
    void Restart()
    {
		//Chama a cena atual fazendo com que ela se reinicie
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
