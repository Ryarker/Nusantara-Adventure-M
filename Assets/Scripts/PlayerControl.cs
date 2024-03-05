//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/PlayerControl.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControl : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControl"",
    ""maps"": [
        {
            ""name"": ""Ground"",
            ""id"": ""c87eb64c-6f76-4e28-9101-c0608a28c6ba"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""00e8fe05-9d88-4325-8e98-674dd56e3d3e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jumping"",
                    ""type"": ""Value"",
                    ""id"": ""7bbf6d36-1d72-463c-a999-18efff49a250"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Attacking"",
                    ""type"": ""Value"",
                    ""id"": ""ee9cefaa-3d9c-4637-b416-ebfbef22c6a0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interacting"",
                    ""type"": ""Value"",
                    ""id"": ""42c81d7c-b872-4fd5-84f4-2daa7210ecd2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""54e4c982-5dd0-4042-852c-580d5866508b"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""AD keys"",
                    ""id"": ""2d06200b-0a95-46fe-8698-45d594ba0245"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5bf6533b-edba-4841-9fd4-4f95f8854f74"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f09afb78-d6ca-401f-b46b-72ddc1ff3872"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""cb0db7c4-bdff-4b8e-86d5-fec761bda791"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jumping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""852a5666-57c0-4c08-84ff-f3515edf425c"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attacking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c89c7d3-c8f7-4e2b-a435-c94f8f1dbd07"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interacting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Ground
        m_Ground = asset.FindActionMap("Ground", throwIfNotFound: true);
        m_Ground_Move = m_Ground.FindAction("Move", throwIfNotFound: true);
        m_Ground_Jumping = m_Ground.FindAction("Jumping", throwIfNotFound: true);
        m_Ground_Attacking = m_Ground.FindAction("Attacking", throwIfNotFound: true);
        m_Ground_Interacting = m_Ground.FindAction("Interacting", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Ground
    private readonly InputActionMap m_Ground;
    private IGroundActions m_GroundActionsCallbackInterface;
    private readonly InputAction m_Ground_Move;
    private readonly InputAction m_Ground_Jumping;
    private readonly InputAction m_Ground_Attacking;
    private readonly InputAction m_Ground_Interacting;
    public struct GroundActions
    {
        private @PlayerControl m_Wrapper;
        public GroundActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Ground_Move;
        public InputAction @Jumping => m_Wrapper.m_Ground_Jumping;
        public InputAction @Attacking => m_Wrapper.m_Ground_Attacking;
        public InputAction @Interacting => m_Wrapper.m_Ground_Interacting;
        public InputActionMap Get() { return m_Wrapper.m_Ground; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GroundActions set) { return set.Get(); }
        public void SetCallbacks(IGroundActions instance)
        {
            if (m_Wrapper.m_GroundActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GroundActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GroundActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GroundActionsCallbackInterface.OnMove;
                @Jumping.started -= m_Wrapper.m_GroundActionsCallbackInterface.OnJumping;
                @Jumping.performed -= m_Wrapper.m_GroundActionsCallbackInterface.OnJumping;
                @Jumping.canceled -= m_Wrapper.m_GroundActionsCallbackInterface.OnJumping;
                @Attacking.started -= m_Wrapper.m_GroundActionsCallbackInterface.OnAttacking;
                @Attacking.performed -= m_Wrapper.m_GroundActionsCallbackInterface.OnAttacking;
                @Attacking.canceled -= m_Wrapper.m_GroundActionsCallbackInterface.OnAttacking;
                @Interacting.started -= m_Wrapper.m_GroundActionsCallbackInterface.OnInteracting;
                @Interacting.performed -= m_Wrapper.m_GroundActionsCallbackInterface.OnInteracting;
                @Interacting.canceled -= m_Wrapper.m_GroundActionsCallbackInterface.OnInteracting;
            }
            m_Wrapper.m_GroundActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jumping.started += instance.OnJumping;
                @Jumping.performed += instance.OnJumping;
                @Jumping.canceled += instance.OnJumping;
                @Attacking.started += instance.OnAttacking;
                @Attacking.performed += instance.OnAttacking;
                @Attacking.canceled += instance.OnAttacking;
                @Interacting.started += instance.OnInteracting;
                @Interacting.performed += instance.OnInteracting;
                @Interacting.canceled += instance.OnInteracting;
            }
        }
    }
    public GroundActions @Ground => new GroundActions(this);
    public interface IGroundActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJumping(InputAction.CallbackContext context);
        void OnAttacking(InputAction.CallbackContext context);
        void OnInteracting(InputAction.CallbackContext context);
    }
}
