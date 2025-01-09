using System;
using UnityEngine;

namespace Managers
{
    public class InputManager : Singleton<InputManager>
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A)) Debug.Log("A Pressed");
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log(Input.mousePosition.ToString());
            }
        }
    }
}