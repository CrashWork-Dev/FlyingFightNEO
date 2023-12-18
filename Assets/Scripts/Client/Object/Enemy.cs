using Client.Object.Interface;
using UnityEngine;

namespace Client.Object
{
    public class Enemy : MonoBehaviour,IEnemy
    {
        private GameObject _player;
        [SerializeField] private string whichStage;
        private int _hp;
        private void Start()
        {
            _player = GameObject.FindGameObjectWithTag("Player");
            _hp = whichStage switch
            {
                "flying" => 8,
                _ => 1
            };
        }

        private void FixedUpdate()
        {
            if (whichStage != "Boss")
            {
                var c = (_player.transform.position - transform.position).normalized;
                transform.right = c;
            }
            Dead();
            
        }

        public void GetHurt()
        {
            _hp -= 1;
        }

        public void Dead()
        {
            if (_hp >= 0) return;
            Main.EnemyPool.Release(gameObject);
            _hp = whichStage switch
            {
                "flying" => 8,
                _ => 1
            };
        }
        private void OnTriggerEnter2D(Collider2D other)
        {
            if(!other.CompareTag("PlayerAmmo")) return;
            GetHurt();
        }
    }
}