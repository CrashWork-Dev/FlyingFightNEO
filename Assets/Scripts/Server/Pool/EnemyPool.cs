using Server.Factory;
using UnityEngine;
using UnityEngine.Pool;

namespace Server.Pool
{
    public class EnemyPool : MonoBehaviour
    {
        private ObjectPool<GameObject> _pool;
        private GameObject _enemy;

        public void Init(GameObject enemy)
        {
            _enemy = enemy;
            _pool = new ObjectPool<GameObject>(CreateFunc,ActionOnGet,ActionOnRelease,ActionOnDestroy,true,1,4);
        }

        private GameObject CreateFunc()
        {
            return EnemyFactory.Create(_enemy);
        }

        private void ActionOnGet(GameObject obj)
        {
            obj.SetActive(true);
        }

        private void ActionOnRelease(GameObject obj)
        {
            obj.SetActive(false);
        }

        private void ActionOnDestroy(GameObject obj)
        {
            Destroy(obj);
        }

        public void Release(GameObject obj)
        {
            _pool.Release(obj);
        }
        public GameObject Spawn(GameObject parent)
        {
            var temp = _pool.Get();
            temp.transform.position = parent.transform.position;
            return temp;
        }
    }
}