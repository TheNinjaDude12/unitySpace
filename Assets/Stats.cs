using UnityEngine;

[CreateAssetMenu(fileName = "Stats", menuName = "Stats")]
public class Stats : ScriptableObject
{
    [SerializeField] public int health;
    [SerializeField] public int speed;
}
