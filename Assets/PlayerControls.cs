// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""RobotMovement"",
            ""id"": ""127c9d29-1c94-40bc-b5d5-43447e3ea179"",
            ""actions"": [
                {
                    ""name"": ""L1"",
                    ""type"": ""Button"",
                    ""id"": ""67d0303a-de76-424d-a1dc-8b21e1a41a35"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L2"",
                    ""type"": ""Button"",
                    ""id"": ""0657d1f0-4393-45a3-8caa-be01eeda1766"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""R1"",
                    ""type"": ""Button"",
                    ""id"": ""4edffd86-dc54-4fe4-8d0e-f64767214ee8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""R2"",
                    ""type"": ""Button"",
                    ""id"": ""41327d42-8e3a-4459-a920-cc96f26204ab"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""e72f47c9-e2e6-4f8c-a489-4f16bf14aa26"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e871b1ae-469d-4531-a4cd-63a0acea5387"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96437a74-7c49-463c-a37d-3532a6ca0720"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad8b6e43-3de7-4c10-80d1-d81ed91244ef"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba751dfe-c453-459d-8ec7-4113ce9adbac"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6fb34cb-333a-4357-8f4d-05c6707b19b1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // RobotMovement
        m_RobotMovement = asset.FindActionMap("RobotMovement", throwIfNotFound: true);
        m_RobotMovement_L1 = m_RobotMovement.FindAction("L1", throwIfNotFound: true);
        m_RobotMovement_L2 = m_RobotMovement.FindAction("L2", throwIfNotFound: true);
        m_RobotMovement_R1 = m_RobotMovement.FindAction("R1", throwIfNotFound: true);
        m_RobotMovement_R2 = m_RobotMovement.FindAction("R2", throwIfNotFound: true);
        m_RobotMovement_A = m_RobotMovement.FindAction("A", throwIfNotFound: true);
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

    // RobotMovement
    private readonly InputActionMap m_RobotMovement;
    private IRobotMovementActions m_RobotMovementActionsCallbackInterface;
    private readonly InputAction m_RobotMovement_L1;
    private readonly InputAction m_RobotMovement_L2;
    private readonly InputAction m_RobotMovement_R1;
    private readonly InputAction m_RobotMovement_R2;
    private readonly InputAction m_RobotMovement_A;
    public struct RobotMovementActions
    {
        private @PlayerControls m_Wrapper;
        public RobotMovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @L1 => m_Wrapper.m_RobotMovement_L1;
        public InputAction @L2 => m_Wrapper.m_RobotMovement_L2;
        public InputAction @R1 => m_Wrapper.m_RobotMovement_R1;
        public InputAction @R2 => m_Wrapper.m_RobotMovement_R2;
        public InputAction @A => m_Wrapper.m_RobotMovement_A;
        public InputActionMap Get() { return m_Wrapper.m_RobotMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RobotMovementActions set) { return set.Get(); }
        public void SetCallbacks(IRobotMovementActions instance)
        {
            if (m_Wrapper.m_RobotMovementActionsCallbackInterface != null)
            {
                @L1.started -= m_Wrapper.m_RobotMovementActionsCallbackInterface.OnL1;
                @L1.performed -= m_Wrapper.m_RobotMovementActionsCallbackInterface.OnL1;
                @L1.canceled -= m_Wrapper.m_RobotMovementActionsCallbackInterface.OnL1;
                @L2.started -= m_Wrapper.m_RobotMovementActionsCallbackInterface.OnL2;
                @L2.performed -= m_Wrapper.m_RobotMovementActionsCallbackInterface.OnL2;
                @L2.canceled -= m_Wrapper.m_RobotMovementActionsCallbackInterface.OnL2;
                @R1.started -= m_Wrapper.m_RobotMovementActionsCallbackInterface.OnR1;
                @R1.performed -= m_Wrapper.m_RobotMovementActionsCallbackInterface.OnR1;
                @R1.canceled -= m_Wrapper.m_RobotMovementActionsCallbackInterface.OnR1;
                @R2.started -= m_Wrapper.m_RobotMovementActionsCallbackInterface.OnR2;
                @R2.performed -= m_Wrapper.m_RobotMovementActionsCallbackInterface.OnR2;
                @R2.canceled -= m_Wrapper.m_RobotMovementActionsCallbackInterface.OnR2;
                @A.started -= m_Wrapper.m_RobotMovementActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_RobotMovementActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_RobotMovementActionsCallbackInterface.OnA;
            }
            m_Wrapper.m_RobotMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @L1.started += instance.OnL1;
                @L1.performed += instance.OnL1;
                @L1.canceled += instance.OnL1;
                @L2.started += instance.OnL2;
                @L2.performed += instance.OnL2;
                @L2.canceled += instance.OnL2;
                @R1.started += instance.OnR1;
                @R1.performed += instance.OnR1;
                @R1.canceled += instance.OnR1;
                @R2.started += instance.OnR2;
                @R2.performed += instance.OnR2;
                @R2.canceled += instance.OnR2;
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
            }
        }
    }
    public RobotMovementActions @RobotMovement => new RobotMovementActions(this);
    public interface IRobotMovementActions
    {
        void OnL1(InputAction.CallbackContext context);
        void OnL2(InputAction.CallbackContext context);
        void OnR1(InputAction.CallbackContext context);
        void OnR2(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
    }
}
