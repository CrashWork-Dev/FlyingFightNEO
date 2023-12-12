using Server.Factory;
using UnityEngine;
using UnityEngine.Pool;

namespace Server.Pool
{
    public class PlayerAmmoPool : MonoBehaviour
    {
        private ObjectPool<GameObject> _pool;
        private GameObject _ammo;
        
        public void Init(GameObject ammo)
        {
            _ammo = ammo;
            _pool = new ObjectPool<GameObject>(CreateFunc,ActionOnGet,ActionOnRelease,ActionOnDestroy,true,1,10);
        }
        private GameObject CreateFunc()
        {
            return PlayerAmmoFactory.Create(_ammo);
        }

        private static void ActionOnGet(GameObject obj)
        {
            obj.SetActive(true);
        }

        private static void ActionOnRelease(GameObject obj)
        {
            obj.SetActive(false);
        }

        private static void ActionOnDestroy(GameObject obj)
        {
            Destroy(obj);
        }
        
        public GameObject Spawn(GameObject parent)
        {
            var temp = _pool.Get();
            temp.transform.position = parent.transform.position;
            return temp;
        }

        public void Release(GameObject obj)
        {
            _pool.Release(obj);
        }
    }
}