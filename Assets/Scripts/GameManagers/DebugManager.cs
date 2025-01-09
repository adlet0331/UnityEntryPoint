using System;
using TMPro;
using UnityEngine;

namespace Managers
{
    public class DebugManager : Singleton<DebugManager>
    {
        [SerializeField] private TextMeshProUGUI debugText;

        public void PrintDebugText(string text)
        {
            debugText.text = text;
        }
    }
}