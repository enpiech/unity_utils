using UnityEngine;
using UnityEngine.AddressableAssets;

public sealed class SelfCleanup : MonoBehaviour
{
    private void OnDestroy()
    {
        Addressables.ReleaseInstance(gameObject);
    }
}