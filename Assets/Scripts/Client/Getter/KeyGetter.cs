using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Client.Getter
{
    public class KeyGetter : MonoBehaviour
    {
        private Vector2 _playerMove;
        // private Vector2 _playerMove;
        //
        // private void Update()
        // {
        //     if (Keyboard.current.upArrowKey.isPressed && Keyboard.current.downArrowKey.isPressed)
        //     {
        //         _playerMove.y = 0;
        //     }
        //     else
        //     {
        //         if (Keyboard.current.upArrowKey.isPressed)
        //         {
        //             _playerMove.y = 1;
        //         }
        //
        //         if (Keyboard.current.downArrowKey.isPressed)
        //         {
        //             _playerMove.y = -1;
        //         }
        //     }
        //
        //     if (Keyboard.current.leftArrowKey.isPressed && Keyboard.current.rightArrowKey.isPressed)
        //     {
        //         _playerMove.x = 0;
        //     }
        //     else
        //     {
        //         if (Keyboard.current.leftArrowKey.isPressed) _playerMove.x = -1;
        //         if (Keyboard.current.rightArrowKey.isPressed) _playerMove.x = 1;
        //     }
        //
        //     if (!Keyboard.current.upArrowKey.isPressed && !Keyboard.current.downArrowKey.isPressed) _playerMove.y = 0;
        //     if (!Keyboard.current.leftArrowKey.isPressed && !Keyboard.current.rightArrowKey.isPressed)
        //         _playerMove.x = 0;
        // }
        //
        // public Vector2 GetPlayerMove()
        // {
        //     return _playerMove.normalized;
        // }
        private InputControl _inputControl;

        private void Awake()
        {
            _inputControl = new InputControl();
        }

        private void OnEnable()
        {
            _inputControl.Enable();
        }

        private void OnDisable()
        {
            _inputControl.Disable();
        }

        private void FixedUpdate()
        {
            _playerMove = _inputControl.InGame.WASD.ReadValue<Vector2>();
        }

        public Vector2 GetPlayerMove()
        {
            return _playerMove;
        }
    }
}