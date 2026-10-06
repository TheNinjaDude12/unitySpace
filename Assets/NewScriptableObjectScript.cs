using UnityEngine;

[CreateAssetMenu(fileName = "Stats", menuName = "Stats")]
public class NewScriptableObjectScript : ScriptableObject
{
    [SerializeField] public int speed;
    [SerializeField] public int health;
}
