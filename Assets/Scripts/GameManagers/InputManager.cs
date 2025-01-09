using System;
using UnityEngine;

namespace Managers
{
    public class InputManager : Singleton<InputManager>
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A)) DebugManager.Instance.PrintDebugText("A pressed");
            if (Input.GetMouseButtonDown(0))
            {
                DebugManager.Instance.PrintDebugText(Input.mousePosition.ToString());
            }
        }
    }
}