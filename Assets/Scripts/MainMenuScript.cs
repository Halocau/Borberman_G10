using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
	public void PlayGame()
	{
		Random.InitState(System.Environment.TickCount);
		SceneManager.LoadScene(Random.Range(1,6));
	}

}
