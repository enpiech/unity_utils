using NaughtyAttributes;
using TMPro;
using UnityEngine;

namespace Enpiech.Utils.Runtime.UI
{
    public sealed class GameVersion : MonoBehaviour
    {
        [Header("Config")]
        [SerializeField]
        private string _prefix = "GAME VERSION: ";

        [Header("References")]
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
            _versionNumberText.text = $"{_prefix}{Application.version}";
#else
            _versionNumberText.text = $"{_prefix}{Application.version}_dev";
#endif
        }
    }
}