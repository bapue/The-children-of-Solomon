using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Scriptable Object/EnemyData", order = int.MaxValue)]
public class EnemyData : ScriptableObject
{
    [SerializeField]
    private string enemyName;
    public string EnemyName { get { return enemyName; } }
    
    [SerializeField]
    private int hp;
    public int Hp { get { return hp; } }
    
    [SerializeField]
    private int damage;
    public int Damage { get { return damage; } }
    
    [SerializeField]
    private Sprite profileImage;
    public Sprite ProfileImage { get { return profileImage; } }
    
    
}
