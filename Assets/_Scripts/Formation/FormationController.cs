using UnityEngine;
using UnityEngine.SceneManagement;

public class FormationController : MonoBehaviour
{
	private const string SCENE_EQUIPMENTS = "Game";
	
	public static FormationController Instance;
	public FormationData Data;

	[SerializeField]
	private ArenaSetupByData _arena;
	[SerializeField]
	private PalletSetupByData _palletR;
	[SerializeField]
	private PalletSetupByData _palletL;
	[SerializeField]
	private GoalkeeperSetupByData _goalkeeper;

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
	}

	private void Start()
	{
		SetupFormation();
	}

	public void SetupFormation()
	{
		_arena.Data = Data.ArenaData;
		_palletL.Data = Data.PalletRData;
		_palletR.Data = Data.PalletRData;
		_goalkeeper.Data = Data.GoalkeeperData;
	}

	public void Close()
	{
		SceneManager.LoadScene(SCENE_EQUIPMENTS);
	}
}
