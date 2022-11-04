using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Enpiech.Utils.Runtime
{
    public sealed class SelfCleanup : MonoBehaviour
    {
        private void OnDestroy()
        {
            Addressables.ReleaseInstance(gameObject);
        }
    }
}