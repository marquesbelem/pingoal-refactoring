using UnityEngine;

[CreateAssetMenu(fileName = "PalletData", menuName = "Pingoal/Palheta")]
public class PalletData : ScriptableObject
{
    public PalletType Power;
    public Sprite Skin;

    [SerializeField]
    private string _id;

    public string ID
    {
        get => string.Format("{0}_{1}", Power, _id).ToUpper();
    }
}
