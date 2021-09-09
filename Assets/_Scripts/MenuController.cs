using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup _panelOffline;
	[SerializeField]
	private GameObject _boardOffline;
	[SerializeField]
	private Button _buttonVsBot;

	[SerializeField]
	private CanvasGroup _panelEquipments;
	[SerializeField]
	private GameObject _formationEquipments;
	[SerializeField]
	private GameObject _skillEquipments;
	[SerializeField]
	private GameObject _storeEquipments;
	private void Start()
	{
		var buttonFormation = _formationEquipments.GetComponent<Button>();
		buttonFormation.onClick.AddListener(() => SceneManagerHelper.Instance.LoadSceneFormation());

		_buttonVsBot.onClick.AddListener(() => SceneManagerHelper.Instance.LoadSceneGame());

		ResetPainelOffline();
		ResetPanelEquipments();
	}

	#region Panel Offline
	private void BeginPainelOffline(float alpha, float delay, Vector3 target, bool blocksRaycasts)
	{
		_panelOffline.blocksRaycasts = blocksRaycasts;
		_panelOffline.LeanAlpha(alpha, delay);
		_boardOffline.LeanScale(target, delay);
	}
	private void ResetPainelOffline()
	{
		_panelOffline.alpha = 0;
		_panelOffline.blocksRaycasts = false;
		_boardOffline.LeanScale(Vector3.zero, 0);
	}

	public void OpenPanelOffline(float delay)
	{
		BeginPainelOffline(1, delay, new Vector3(1, 1, 1), true);
	}

	public void ClosePanelOffline(float delay)
	{
		BeginPainelOffline(0, delay, Vector3.zero, false);
	}
	#endregion

	#region Panel Equipments
	private void BeginPanelEquipments(float alpha, float delay, bool blocksRaycasts, Vector3 target)
	{
		_panelEquipments.blocksRaycasts = blocksRaycasts;
		_panelEquipments.LeanAlpha(alpha, delay);
		_formationEquipments.LeanScale(target, delay);
		_skillEquipments.LeanScale(target, delay);
		_storeEquipments.LeanScale(target, delay);
	}

	private void ResetPanelEquipments()
	{
		_panelEquipments.blocksRaycasts = false;
		_panelEquipments.alpha = 0;
		_formationEquipments.LeanScale(Vector3.zero, 0);
		_skillEquipments.LeanScale(Vector3.zero, 0);
		_storeEquipments.LeanScale(Vector3.zero, 0);
	}

	public void OpenPanelEquipments(float delay)
	{
		BeginPanelEquipments(1, delay, true, new Vector3(1, 1, 1));
	}

	public void ClosePanelEquipments(float delay)
	{
		BeginPanelEquipments(0, delay, false, Vector3.zero);
	}
	#endregion
}