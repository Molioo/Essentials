namespace Molioo.Essentials.ObjectPooling
{
    /// <summary>
    /// Preset of object that will be pooled and used in object pooling
    /// </summary>
    [System.Serializable]
    public class ObjectToPoolPreset
    {
        /// <summary> Reference to object we want to pool </summary>
        public PoolableObject ObjectToPool;

        /// <summary> How much objects should be created at start for pooling? </summary>
        public int AmountToPool;

        /// <summary> Should amount of pooled objects from this preset be expanded when there are no free objects to take</summary>
        public bool ShouldExpandIfNeeded=true;
    }
}