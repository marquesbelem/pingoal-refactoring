using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChooseFormation : MonoBehaviour
{
	private const string INDEX_KEY = "INDEX_CHOOSE_FORMATION_KEY";

	[SerializeField]
	private Button _buttonNext;
	[SerializeField]
	private Button _buttonPrevious;

	[SerializeField]
	protected int _indexChoose = 0;
	[SerializeField]
	protected int _indexMax;

	public virtual void NextChoose()
	{
		_indexChoose++;

		if (_indexChoose >= _indexMax)
		{
			_indexChoose = _indexMax;

			SetInteractableButtonNext(false);
		}
		else
		{
			SetInteractableButtonNext(true);
		}

		SetInteractableButtonPrevious(_indexChoose == 0 ? false : true);

		SaveIndex();
	}

	public virtual void PreviousChoose()
	{
		_indexChoose--;

		if (_indexChoose <= 0)
		{
			_indexChoose = 0;

			SetInteractableButtonPrevious(false);
		}
		else
		{
			SetInteractableButtonPrevious(true);
		}

		SetInteractableButtonNext(_indexChoose >= 0 && _indexChoose < _indexMax ? true : false);

		SaveIndex();
	}

	public void SetInteractableButtonNext(bool value)
	{
		_buttonNext.interactable = value;
	}

	public void SetInteractableButtonPrevious(bool value)
	{
		_buttonPrevious.interactable = value;
	}

	public virtual void SetDataFormationController()
	{
		FormationController.Instance.SetupFormation();
	}

	public virtual void Start()
	{
		LoadIndex();

		SetInteractableButtonPrevious(_indexChoose == 0 ? false : true);
		SetInteractableButtonNext(_indexChoose >= 0 && _indexChoose < _indexMax ? true : false);
	}

	private void SaveIndex()
	{
		PlayerPrefs.SetInt(INDEX_KEY, _indexChoose);
	}

	private void LoadIndex()
	{
		if (PlayerPrefs.HasKey(INDEX_KEY))
		{
			_indexChoose = PlayerPrefs.GetInt(INDEX_KEY);
		}
	}
}
