using System.Collections;
using Client.Object.Interface;
using UnityEngine;

namespace Client.Object
{
    public class PlayerAmmo : MonoBehaviour , IAmmo
    {
        private Rigidbody2D _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            Shot();
        }
        private IEnumerator AmmoShot(GameObject obj)
        {
            yield return new WaitForSeconds(2);
            Main.PlayerAmmoPool.Release(obj);
        }
        public void Shot()
        {
            var temp = _rb.velocity;
            temp.y = 10;
            _rb.velocity = temp;
            StartCoroutine(AmmoShot(gameObject));
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if(other.CompareTag("Enemy")) Main.PlayerAmmoPool.Release(gameObject);
        }
    }
}