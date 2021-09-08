using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerHelper : MonoBehaviour
{
	public static SceneManagerHelper Instance; 

	private const string SCENE_MENU = "Menu";
	private const string SCENE_GAME = "Game";
	private const string SCENE_FORMATION = "Formation";

	private void Awake()
	{
		if(Instance == null)
		{
			Instance = this;
		}	
		else
		{
			Destroy(gameObject);
		}

		DontDestroyOnLoad(gameObject);
	}

	public void LoadSceneMenu()
	{
		SceneManager.LoadScene(SCENE_MENU);
	}

	public void LoadSceneGame()
	{
		SceneManager.LoadScene(SCENE_GAME);
	}

	public void LoadSceneFormation()
	{
		SceneManager.LoadScene(SCENE_FORMATION);
	}
}