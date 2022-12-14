//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.3
//     from Assets/Game/Scripts/Concretes/Inputs/DefaultAction.inputactions
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

public partial class @DefaultAction : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @DefaultAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultAction"",
    ""maps"": [
        {
            ""name"": ""Rocket"",
            ""id"": ""79c3941d-8bfd-495b-8178-891bbe4a4be7"",
            ""actions"": [
                {
                    ""name"": ""Forceup"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0b89c3d4-9072-44fb-a097-d241f56527ac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LeftRightRotate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""88af4fd6-5e05-4df7-87b4-2e94a5571ed1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e0141122-f748-4825-a48c-aff15debbf20"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forceup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab3e9976-e760-4e14-9503-2f8d5c38ebf8"",
                    ""path"": ""<Touchscreen>/touch*/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forceup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""c192d990-7c3e-40ac-8b8e-ba8461aedea3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRightRotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""34161163-7200-4d7e-8856-64e7d0be5208"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRightRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8e87a49a-396d-4d56-b370-fa5c9911ada5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRightRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Touch"",
                    ""id"": ""24598d0d-3e04-4971-a4dd-b9277d9f744c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRightRotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""de0666e0-9bf2-41fb-b2ee-cf0552ff1de9"",
                    ""path"": ""<Touchscreen>/delta/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRightRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""534be003-fda6-4426-a7c0-8ecef37cd992"",
                    ""path"": ""<Touchscreen>/delta/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRightRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Rocket
        m_Rocket = asset.FindActionMap("Rocket", throwIfNotFound: true);
        m_Rocket_Forceup = m_Rocket.FindAction("Forceup", throwIfNotFound: true);
        m_Rocket_LeftRightRotate = m_Rocket.FindAction("LeftRightRotate", throwIfNotFound: true);
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

    // Rocket
    private readonly InputActionMap m_Rocket;
    private IRocketActions m_RocketActionsCallbackInterface;
    private readonly InputAction m_Rocket_Forceup;
    private readonly InputAction m_Rocket_LeftRightRotate;
    public struct RocketActions
    {
        private @DefaultAction m_Wrapper;
        public RocketActions(@DefaultAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Forceup => m_Wrapper.m_Rocket_Forceup;
        public InputAction @LeftRightRotate => m_Wrapper.m_Rocket_LeftRightRotate;
        public InputActionMap Get() { return m_Wrapper.m_Rocket; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RocketActions set) { return set.Get(); }
        public void SetCallbacks(IRocketActions instance)
        {
            if (m_Wrapper.m_RocketActionsCallbackInterface != null)
            {
                @Forceup.started -= m_Wrapper.m_RocketActionsCallbackInterface.OnForceup;
                @Forceup.performed -= m_Wrapper.m_RocketActionsCallbackInterface.OnForceup;
                @Forceup.canceled -= m_Wrapper.m_RocketActionsCallbackInterface.OnForceup;
                @LeftRightRotate.started -= m_Wrapper.m_RocketActionsCallbackInterface.OnLeftRightRotate;
                @LeftRightRotate.performed -= m_Wrapper.m_RocketActionsCallbackInterface.OnLeftRightRotate;
                @LeftRightRotate.canceled -= m_Wrapper.m_RocketActionsCallbackInterface.OnLeftRightRotate;
            }
            m_Wrapper.m_RocketActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Forceup.started += instance.OnForceup;
                @Forceup.performed += instance.OnForceup;
                @Forceup.canceled += instance.OnForceup;
                @LeftRightRotate.started += instance.OnLeftRightRotate;
                @LeftRightRotate.performed += instance.OnLeftRightRotate;
                @LeftRightRotate.canceled += instance.OnLeftRightRotate;
            }
        }
    }
    public RocketActions @Rocket => new RocketActions(this);
    public interface IRocketActions
    {
        void OnForceup(InputAction.CallbackContext context);
        void OnLeftRightRotate(InputAction.CallbackContext context);
    }
}
