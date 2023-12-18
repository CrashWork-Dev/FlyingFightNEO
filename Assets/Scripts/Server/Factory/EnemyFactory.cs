using UnityEngine;

namespace Server.Factory
{
    public class EnemyFactory : MonoBehaviour
    {
        public static GameObject Create(GameObject enemy)
        {
            return Instantiate(enemy);
        }
    }
}