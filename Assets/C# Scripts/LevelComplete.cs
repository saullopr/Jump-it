using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

	//Carrega o próximo nivel
	public void loadNextLevel()
    {
		//Carrega a a proxima cena que foi incluida no Build atravez de seu Index
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
