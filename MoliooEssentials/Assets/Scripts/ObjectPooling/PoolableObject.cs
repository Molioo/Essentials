using UnityEngine;

namespace Molioo.Essentials.ObjectPooling
{
    public class PoolableObject : MonoBehaviour
    {
        public string PoolableTag;

        /*As there is possibility that objects with this script will not only be created by object pooler but also they will be placed in scene by designers,
         * this will tell us if it was created by object pooler. If so,we should deactivate it instead of destroying it. If it was placed by designers we can destroy it*/

        /// <summary>
        /// Was this gameobject created by object pooler at start, check for more in comment above
        /// </summary>
        internal bool WasCreatedByObjectPooler = false;

        /// <summary>
        /// Time that object was last used(taken from pool and activated). Measured in seconds from game start
        /// </summary>
        internal float LastUsed;

        /// <summary>
        /// Was this object created when there werent free objects in pool and pool was expanded with this object
        /// </summary>
        internal bool WasAddedAsExpansion = false;

        public void OnDisable()
        {
            LastUsed = Time.time;
        }
    }
}