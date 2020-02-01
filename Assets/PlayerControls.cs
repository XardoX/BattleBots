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
            ""name"": ""PlayerOne"",
            ""id"": ""127c9d29-1c94-40bc-b5d5-43447e3ea179"",
            ""actions"": [
                {
                    ""name"": ""LeftTrackForward"",
                    ""type"": ""Button"",
                    ""id"": ""67d0303a-de76-424d-a1dc-8b21e1a41a35"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftTrackBackward"",
                    ""type"": ""Button"",
                    ""id"": ""0657d1f0-4393-45a3-8caa-be01eeda1766"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightTrackForward"",
                    ""type"": ""Button"",
                    ""id"": ""4edffd86-dc54-4fe4-8d0e-f64767214ee8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightTrackBackward"",
                    ""type"": ""Button"",
                    ""id"": ""41327d42-8e3a-4459-a920-cc96f26204ab"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Value"",
                    ""id"": ""e72f47c9-e2e6-4f8c-a489-4f16bf14aa26"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""48c682a2-726e-423c-85b2-e78368b00b0f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player Two"",
                    ""action"": ""LeftTrackForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24eb637e-5f62-44eb-b0f4-e24c075c8536"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player One"",
                    ""action"": ""LeftTrackForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3af25418-9252-4c59-969a-e88488c2b572"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player Two"",
                    ""action"": ""LeftTrackBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8bacc33-9c37-47ae-9411-4148a5e9640d"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player One"",
                    ""action"": ""LeftTrackBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""18bbd917-a581-4ab0-bf5c-b4a6b2544c23"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player Two"",
                    ""action"": ""RightTrackForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94b77564-7b17-4c43-887f-75989c88d55f"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player One"",
                    ""action"": ""RightTrackForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e5f9a41-b920-4901-beca-ed4cb93d245c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player Two"",
                    ""action"": ""RightTrackBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""800663d4-261e-4c3f-8b86-5480612e4b7b"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player One"",
                    ""action"": ""RightTrackBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32dc9338-58cc-4a80-af12-80b6643bbdee"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player One"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerTwo"",
            ""id"": ""fcbaa880-7777-4f5c-97ef-af64cf5e7d88"",
            ""actions"": [
                {
                    ""name"": ""LeftTrackForward"",
                    ""type"": ""Button"",
                    ""id"": ""c91509ae-422b-4ae0-88d4-2944a0991532"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftTrackBackward"",
                    ""type"": ""Button"",
                    ""id"": ""928a753d-c84d-4b03-89e8-2d2a4b476e36"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightTrackForward"",
                    ""type"": ""Button"",
                    ""id"": ""00219994-1868-41a5-a660-54a079c59839"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightTrackBackward"",
                    ""type"": ""Button"",
                    ""id"": ""2a1d8c9b-1de9-4bea-aaa1-e01eb5bfb6f1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Value"",
                    ""id"": ""3e4c3973-8e2c-4d87-b150-8a8b3fbb09ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e18813d6-c406-4d7a-b233-84bc4f3d62a0"",
                    ""path"": ""<DualShockGamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player Two"",
                    ""action"": ""LeftTrackForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ddf4be5c-b532-4ad6-bd04-e425ec2481f8"",
                    ""path"": ""<DualShockGamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player Two"",
                    ""action"": ""LeftTrackBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""92bfa386-5473-4c8f-9ccc-f02d45da15ee"",
                    ""path"": ""<DualShockGamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player Two"",
                    ""action"": ""RightTrackForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dee192db-44cc-493a-b0ba-993595b4d7b7"",
                    ""path"": ""<DualShockGamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player Two"",
                    ""action"": ""RightTrackBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ffce7ed-3633-4ff1-b2b9-8a7599d12ceb"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player Two"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Player One"",
            ""bindingGroup"": ""Player One"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Player Two"",
            ""bindingGroup"": ""Player Two"",
            ""devices"": [
                {
                    ""devicePath"": ""<DualShockGamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerOne
        m_PlayerOne = asset.FindActionMap("PlayerOne", throwIfNotFound: true);
        m_PlayerOne_LeftTrackForward = m_PlayerOne.FindAction("LeftTrackForward", throwIfNotFound: true);
        m_PlayerOne_LeftTrackBackward = m_PlayerOne.FindAction("LeftTrackBackward", throwIfNotFound: true);
        m_PlayerOne_RightTrackForward = m_PlayerOne.FindAction("RightTrackForward", throwIfNotFound: true);
        m_PlayerOne_RightTrackBackward = m_PlayerOne.FindAction("RightTrackBackward", throwIfNotFound: true);
        m_PlayerOne_Confirm = m_PlayerOne.FindAction("Confirm", throwIfNotFound: true);
        // PlayerTwo
        m_PlayerTwo = asset.FindActionMap("PlayerTwo", throwIfNotFound: true);
        m_PlayerTwo_LeftTrackForward = m_PlayerTwo.FindAction("LeftTrackForward", throwIfNotFound: true);
        m_PlayerTwo_LeftTrackBackward = m_PlayerTwo.FindAction("LeftTrackBackward", throwIfNotFound: true);
        m_PlayerTwo_RightTrackForward = m_PlayerTwo.FindAction("RightTrackForward", throwIfNotFound: true);
        m_PlayerTwo_RightTrackBackward = m_PlayerTwo.FindAction("RightTrackBackward", throwIfNotFound: true);
        m_PlayerTwo_Confirm = m_PlayerTwo.FindAction("Confirm", throwIfNotFound: true);
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

    // PlayerOne
    private readonly InputActionMap m_PlayerOne;
    private IPlayerOneActions m_PlayerOneActionsCallbackInterface;
    private readonly InputAction m_PlayerOne_LeftTrackForward;
    private readonly InputAction m_PlayerOne_LeftTrackBackward;
    private readonly InputAction m_PlayerOne_RightTrackForward;
    private readonly InputAction m_PlayerOne_RightTrackBackward;
    private readonly InputAction m_PlayerOne_Confirm;
    public struct PlayerOneActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerOneActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftTrackForward => m_Wrapper.m_PlayerOne_LeftTrackForward;
        public InputAction @LeftTrackBackward => m_Wrapper.m_PlayerOne_LeftTrackBackward;
        public InputAction @RightTrackForward => m_Wrapper.m_PlayerOne_RightTrackForward;
        public InputAction @RightTrackBackward => m_Wrapper.m_PlayerOne_RightTrackBackward;
        public InputAction @Confirm => m_Wrapper.m_PlayerOne_Confirm;
        public InputActionMap Get() { return m_Wrapper.m_PlayerOne; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerOneActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerOneActions instance)
        {
            if (m_Wrapper.m_PlayerOneActionsCallbackInterface != null)
            {
                @LeftTrackForward.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnLeftTrackForward;
                @LeftTrackForward.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnLeftTrackForward;
                @LeftTrackForward.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnLeftTrackForward;
                @LeftTrackBackward.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnLeftTrackBackward;
                @LeftTrackBackward.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnLeftTrackBackward;
                @LeftTrackBackward.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnLeftTrackBackward;
                @RightTrackForward.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnRightTrackForward;
                @RightTrackForward.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnRightTrackForward;
                @RightTrackForward.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnRightTrackForward;
                @RightTrackBackward.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnRightTrackBackward;
                @RightTrackBackward.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnRightTrackBackward;
                @RightTrackBackward.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnRightTrackBackward;
                @Confirm.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnConfirm;
            }
            m_Wrapper.m_PlayerOneActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftTrackForward.started += instance.OnLeftTrackForward;
                @LeftTrackForward.performed += instance.OnLeftTrackForward;
                @LeftTrackForward.canceled += instance.OnLeftTrackForward;
                @LeftTrackBackward.started += instance.OnLeftTrackBackward;
                @LeftTrackBackward.performed += instance.OnLeftTrackBackward;
                @LeftTrackBackward.canceled += instance.OnLeftTrackBackward;
                @RightTrackForward.started += instance.OnRightTrackForward;
                @RightTrackForward.performed += instance.OnRightTrackForward;
                @RightTrackForward.canceled += instance.OnRightTrackForward;
                @RightTrackBackward.started += instance.OnRightTrackBackward;
                @RightTrackBackward.performed += instance.OnRightTrackBackward;
                @RightTrackBackward.canceled += instance.OnRightTrackBackward;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
            }
        }
    }
    public PlayerOneActions @PlayerOne => new PlayerOneActions(this);

    // PlayerTwo
    private readonly InputActionMap m_PlayerTwo;
    private IPlayerTwoActions m_PlayerTwoActionsCallbackInterface;
    private readonly InputAction m_PlayerTwo_LeftTrackForward;
    private readonly InputAction m_PlayerTwo_LeftTrackBackward;
    private readonly InputAction m_PlayerTwo_RightTrackForward;
    private readonly InputAction m_PlayerTwo_RightTrackBackward;
    private readonly InputAction m_PlayerTwo_Confirm;
    public struct PlayerTwoActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerTwoActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftTrackForward => m_Wrapper.m_PlayerTwo_LeftTrackForward;
        public InputAction @LeftTrackBackward => m_Wrapper.m_PlayerTwo_LeftTrackBackward;
        public InputAction @RightTrackForward => m_Wrapper.m_PlayerTwo_RightTrackForward;
        public InputAction @RightTrackBackward => m_Wrapper.m_PlayerTwo_RightTrackBackward;
        public InputAction @Confirm => m_Wrapper.m_PlayerTwo_Confirm;
        public InputActionMap Get() { return m_Wrapper.m_PlayerTwo; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerTwoActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerTwoActions instance)
        {
            if (m_Wrapper.m_PlayerTwoActionsCallbackInterface != null)
            {
                @LeftTrackForward.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnLeftTrackForward;
                @LeftTrackForward.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnLeftTrackForward;
                @LeftTrackForward.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnLeftTrackForward;
                @LeftTrackBackward.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnLeftTrackBackward;
                @LeftTrackBackward.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnLeftTrackBackward;
                @LeftTrackBackward.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnLeftTrackBackward;
                @RightTrackForward.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnRightTrackForward;
                @RightTrackForward.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnRightTrackForward;
                @RightTrackForward.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnRightTrackForward;
                @RightTrackBackward.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnRightTrackBackward;
                @RightTrackBackward.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnRightTrackBackward;
                @RightTrackBackward.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnRightTrackBackward;
                @Confirm.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnConfirm;
            }
            m_Wrapper.m_PlayerTwoActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftTrackForward.started += instance.OnLeftTrackForward;
                @LeftTrackForward.performed += instance.OnLeftTrackForward;
                @LeftTrackForward.canceled += instance.OnLeftTrackForward;
                @LeftTrackBackward.started += instance.OnLeftTrackBackward;
                @LeftTrackBackward.performed += instance.OnLeftTrackBackward;
                @LeftTrackBackward.canceled += instance.OnLeftTrackBackward;
                @RightTrackForward.started += instance.OnRightTrackForward;
                @RightTrackForward.performed += instance.OnRightTrackForward;
                @RightTrackForward.canceled += instance.OnRightTrackForward;
                @RightTrackBackward.started += instance.OnRightTrackBackward;
                @RightTrackBackward.performed += instance.OnRightTrackBackward;
                @RightTrackBackward.canceled += instance.OnRightTrackBackward;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
            }
        }
    }
    public PlayerTwoActions @PlayerTwo => new PlayerTwoActions(this);
    private int m_PlayerOneSchemeIndex = -1;
    public InputControlScheme PlayerOneScheme
    {
        get
        {
            if (m_PlayerOneSchemeIndex == -1) m_PlayerOneSchemeIndex = asset.FindControlSchemeIndex("Player One");
            return asset.controlSchemes[m_PlayerOneSchemeIndex];
        }
    }
    private int m_PlayerTwoSchemeIndex = -1;
    public InputControlScheme PlayerTwoScheme
    {
        get
        {
            if (m_PlayerTwoSchemeIndex == -1) m_PlayerTwoSchemeIndex = asset.FindControlSchemeIndex("Player Two");
            return asset.controlSchemes[m_PlayerTwoSchemeIndex];
        }
    }
    public interface IPlayerOneActions
    {
        void OnLeftTrackForward(InputAction.CallbackContext context);
        void OnLeftTrackBackward(InputAction.CallbackContext context);
        void OnRightTrackForward(InputAction.CallbackContext context);
        void OnRightTrackBackward(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
    }
    public interface IPlayerTwoActions
    {
        void OnLeftTrackForward(InputAction.CallbackContext context);
        void OnLeftTrackBackward(InputAction.CallbackContext context);
        void OnRightTrackForward(InputAction.CallbackContext context);
        void OnRightTrackBackward(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
    }
}
