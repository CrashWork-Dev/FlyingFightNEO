using Server.Pool;
using UnityEngine;

public class Main : MonoBehaviour
{
    //todo 敌人AI(行为树) 随机生成 BOSS 弹幕升级 EnemySet(Sender)
    public static PlayerAmmoPool PlayerAmmoPool;
    public static EnemyPool EnemyPool;
    private void Awake()
    {
        PlayerAmmoPool = gameObject.AddComponent<PlayerAmmoPool>();
        EnemyPool = gameObject.AddComponent<EnemyPool>();
    }
}
