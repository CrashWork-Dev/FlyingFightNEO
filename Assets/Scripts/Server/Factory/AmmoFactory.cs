using UnityEngine;

namespace Server.Factory
{
    public class AmmoFactory : MonoBehaviour
    {
        public static GameObject Create(GameObject ammo)
        {
            return Instantiate(ammo);
        }
    }
}