using UnityEngine;
namespace Server.Factory
{
    public class PlayerAmmoFactory : MonoBehaviour
    {
        public static GameObject Create(GameObject ammo)
        {
            var temp = AmmoFactory.Create(ammo);
            temp.tag = "PlayerAmmo";
            return temp;
        }
    }
}