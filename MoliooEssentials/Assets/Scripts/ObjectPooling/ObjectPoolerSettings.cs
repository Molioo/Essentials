using System.Collections.Generic;
using UnityEngine;

namespace Molioo.Essentials.ObjectPooling
{
    [CreateAssetMenu(fileName = "ObjectPoolerSettings", menuName = "Settings/ObjectPooling/Object Pooler Setting")]
    public class ObjectPoolerSettings : ScriptableObject
    {
        /// <summary> Only for team members, not used anywhere</summary>
        public string Description;

        /// <summary> List of poolable objects presets to create at start </summary>
        public List<ObjectToPoolPreset> ObjectsToPool = new List<ObjectToPoolPreset>();
    }
}