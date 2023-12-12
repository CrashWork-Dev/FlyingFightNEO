using UnityEngine;

namespace Server.Factory
{
    public class EnemyFactory : MonoBehaviour
    {
        public static GameObject Create(GameObject enemy,GameObject parent)
        {
            return Instantiate(enemy, parent.transform);
        }
    }
}