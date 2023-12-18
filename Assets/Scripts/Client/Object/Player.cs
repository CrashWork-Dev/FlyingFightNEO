using UnityEngine;
using Client.Getter;

namespace Client.Object
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private GameObject ammo;
        private short _hp;
        private KeyGetter _keyGetter;
        private Rigidbody2D _rigidbody2D;

        private void Awake()
        {
            _keyGetter = gameObject.AddComponent<KeyGetter>();
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _rigidbody2D.freezeRotation = true;
        }

        private void Start()
        {
            Main.PlayerAmmoPool.Init(ammo);
        }

        private void Update()
        {
            Move();
            Main.PlayerAmmoPool.Spawn(gameObject);
        }

        private void Move()
        {
            var temp = _keyGetter.GetPlayerMove();
            _rigidbody2D.velocity = temp * speed;
        }
    }
}