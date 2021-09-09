using System.Collections;
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
		if (Instance == null)
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
		StartCoroutine(LoadSceneSync(SCENE_MENU));
	}

	public void LoadSceneGame()
	{
		StartCoroutine(LoadSceneSync(SCENE_GAME));
	}

	public void LoadSceneFormation()
	{
		StartCoroutine(LoadSceneSync(SCENE_FORMATION));
	}

	private IEnumerator LoadSceneSync(string name)
	{
		Loading.Instance.Begin();
		yield return new WaitForSeconds(1f);
		yield return SceneManager.LoadSceneAsync(name);
		Loading.Instance.End();
	}
}