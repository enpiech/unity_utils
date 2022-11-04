using NaughtyAttributes;
using TMPro;
using UnityEngine;

namespace Enpiech.Utils.Runtime.UI
{
    public sealed class GameVersion : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI _versionNumberText = default!;

        private void Start()
        {
            UpdateGameVersionText();
        }

        [Button]
        private void UpdateGameVersionText()
        {
#if PROD
            _versionNumberText.text = $"GAMEVERSION: {Application.version}";
#else
            _versionNumberText.text = $"GAMEVERSION: {Application.version}_dev";
#endif
        }
    }
}