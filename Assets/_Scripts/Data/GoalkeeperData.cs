using UnityEngine;

[CreateAssetMenu(fileName = "GoalkeeperData", menuName = "Pingoal/Goleiro")]
public class GoalkeeperData : ScriptableObject
{
    public GoalkeeperType Power;
    public Sprite Skin;

    [SerializeField]
    private string _id;

    public string ID
    {
        get => string.Format("{0}_{1}", Power, _id).ToUpper();

    }
}
