using UnityEngine;

[CreateAssetMenu(fileName = "ArenaData", menuName = "Pingoal/Arena")]
public class ArenaData : ScriptableObject
{
    public Sprite Mask;
    public Sprite Background;

    [SerializeField]
    private string _id;

    public string ID
    {
        get => string.Format("{0}", _id).ToUpper();
    }
}
