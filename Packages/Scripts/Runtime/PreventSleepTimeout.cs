using UnityEngine;

namespace Enpiech.Utils.Runtime
{
    public sealed class PreventSleepTimeout : MonoBehaviour
    {
        private void Start()
        {
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
        }
    }
}