using Server.Pool;
using UnityEngine;

public class Main : MonoBehaviour
{
    //todo 对象池应用 像素打飞机
    public static PlayerAmmoPool PlayerAmmoPool;

    private void Awake()
    {
        PlayerAmmoPool = gameObject.AddComponent<PlayerAmmoPool>();
    }
}
