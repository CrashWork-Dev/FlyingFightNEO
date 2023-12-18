using System;
using System.Collections;
using Server.Pool;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

namespace Client.Object
{
    public class EnemySpawnPoint : MonoBehaviour
    {
        private Vector2 _pointVector2;
        [SerializeField]private GameObject[] enemy;

        private void Start()
        {
            Main.EnemyPool.Init(enemy[0]);
            StartCoroutine(EnemySpawn());
        }

        private IEnumerator EnemySpawn()
        {
            yield return new WaitForSeconds(2);
            Main.EnemyPool.Spawn(gameObject);
            StartCoroutine(EnemySpawn());
        }
        private void FixedUpdate()
        {
            //todo 随机生成点
            _pointVector2 = gameObject.transform.position;
            _pointVector2.x += Random.Range(-2, 2);
            
        }
    }
}