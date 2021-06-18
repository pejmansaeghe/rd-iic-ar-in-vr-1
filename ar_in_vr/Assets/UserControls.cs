// GENERATED AUTOMATICALLY FROM 'Assets/UserControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @UserControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @UserControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""UserControls"",
    ""maps"": [
        {
            ""name"": ""SetUp"",
            ""id"": ""cac837e9-c5cd-430e-9203-e244e755f88b"",
            ""actions"": [
                {
                    ""name"": ""RecentreView"",
                    ""type"": ""Button"",
                    ""id"": ""178b7187-8d1a-41fe-8552-64139b138ee5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveForward"",
                    ""type"": ""Button"",
                    ""id"": ""31fdbde9-2b4a-4f67-b221-4d70567dc07c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveBack"",
                    ""type"": ""Button"",
                    ""id"": ""badda646-810f-4779-a273-ec070a6c9d21"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""1d9e55d7-91cf-49eb-ba71-28d534ef79c9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""d12bdd55-0a92-4c14-aacf-3159a085f900"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveUp"",
                    ""type"": ""Button"",
                    ""id"": ""46b4b65f-9db8-4253-bb6a-6e2eaab258ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveDown"",
                    ""type"": ""Button"",
                    ""id"": ""8bce6581-9b44-4ae4-b3e4-a8e56e76e775"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Quit"",
                    ""type"": ""Button"",
                    ""id"": ""ddae7044-300d-4115-9983-20f7fa0900da"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b6aad7aa-3bce-46ac-bc4b-4ebfe926c81e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RecentreView"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70633872-01d2-4c2b-b560-456377673d78"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dbb25947-f198-492a-80c5-59f1b2a364f5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30316db1-23e8-4e79-9852-b837529f119d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""923cdd6c-16d3-40fd-beff-c4605f67fff3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14ff8cf5-8442-4bb2-9fb2-5be754cecafb"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""101c7684-dfd2-4c77-a396-e8ff7754158c"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66b6d8cf-4413-4ea7-8295-7bd37b683331"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""af50fe62-df43-4984-bf17-b963659b0a8b"",
            ""actions"": [
                {
                    ""name"": ""UI Button Click"",
                    ""type"": ""Button"",
                    ""id"": ""8a1196e9-d5a7-4280-a378-b82c2f3c37b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f1eb7197-4ce7-4e8b-9beb-696be77c1912"",
                    ""path"": ""<ViveWand>/triggerPressed"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UI Button Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Debug"",
            ""id"": ""9cc28a41-3fd2-4fb9-b3c5-637d80d652b9"",
            ""actions"": [
                {
                    ""name"": ""PlayNextVideoSequence"",
                    ""type"": ""Button"",
                    ""id"": ""9295fbbf-f28c-4baf-9621-3d8218a2e927"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TriggerPath"",
                    ""type"": ""Button"",
                    ""id"": ""0784f02e-f0c9-4d86-8738-1697a7131be1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""190dd12b-d96f-45ea-bc3b-244790a1d067"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayNextVideoSequence"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab9e22b7-cf28-4edb-a949-9461cf6b9d02"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerPath"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // SetUp
        m_SetUp = asset.FindActionMap("SetUp", throwIfNotFound: true);
        m_SetUp_RecentreView = m_SetUp.FindAction("RecentreView", throwIfNotFound: true);
        m_SetUp_MoveForward = m_SetUp.FindAction("MoveForward", throwIfNotFound: true);
        m_SetUp_MoveBack = m_SetUp.FindAction("MoveBack", throwIfNotFound: true);
        m_SetUp_MoveRight = m_SetUp.FindAction("MoveRight", throwIfNotFound: true);
        m_SetUp_MoveLeft = m_SetUp.FindAction("MoveLeft", throwIfNotFound: true);
        m_SetUp_MoveUp = m_SetUp.FindAction("MoveUp", throwIfNotFound: true);
        m_SetUp_MoveDown = m_SetUp.FindAction("MoveDown", throwIfNotFound: true);
        m_SetUp_Quit = m_SetUp.FindAction("Quit", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_UIButtonClick = m_UI.FindAction("UI Button Click", throwIfNotFound: true);
        // Debug
        m_Debug = asset.FindActionMap("Debug", throwIfNotFound: true);
        m_Debug_PlayNextVideoSequence = m_Debug.FindAction("PlayNextVideoSequence", throwIfNotFound: true);
        m_Debug_TriggerPath = m_Debug.FindAction("TriggerPath", throwIfNotFound: true);
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

    // SetUp
    private readonly InputActionMap m_SetUp;
    private ISetUpActions m_SetUpActionsCallbackInterface;
    private readonly InputAction m_SetUp_RecentreView;
    private readonly InputAction m_SetUp_MoveForward;
    private readonly InputAction m_SetUp_MoveBack;
    private readonly InputAction m_SetUp_MoveRight;
    private readonly InputAction m_SetUp_MoveLeft;
    private readonly InputAction m_SetUp_MoveUp;
    private readonly InputAction m_SetUp_MoveDown;
    private readonly InputAction m_SetUp_Quit;
    public struct SetUpActions
    {
        private @UserControls m_Wrapper;
        public SetUpActions(@UserControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @RecentreView => m_Wrapper.m_SetUp_RecentreView;
        public InputAction @MoveForward => m_Wrapper.m_SetUp_MoveForward;
        public InputAction @MoveBack => m_Wrapper.m_SetUp_MoveBack;
        public InputAction @MoveRight => m_Wrapper.m_SetUp_MoveRight;
        public InputAction @MoveLeft => m_Wrapper.m_SetUp_MoveLeft;
        public InputAction @MoveUp => m_Wrapper.m_SetUp_MoveUp;
        public InputAction @MoveDown => m_Wrapper.m_SetUp_MoveDown;
        public InputAction @Quit => m_Wrapper.m_SetUp_Quit;
        public InputActionMap Get() { return m_Wrapper.m_SetUp; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SetUpActions set) { return set.Get(); }
        public void SetCallbacks(ISetUpActions instance)
        {
            if (m_Wrapper.m_SetUpActionsCallbackInterface != null)
            {
                @RecentreView.started -= m_Wrapper.m_SetUpActionsCallbackInterface.OnRecentreView;
                @RecentreView.performed -= m_Wrapper.m_SetUpActionsCallbackInterface.OnRecentreView;
                @RecentreView.canceled -= m_Wrapper.m_SetUpActionsCallbackInterface.OnRecentreView;
                @MoveForward.started -= m_Wrapper.m_SetUpActionsCallbackInterface.OnMoveForward;
                @MoveForward.performed -= m_Wrapper.m_SetUpActionsCallbackInterface.OnMoveForward;
                @MoveForward.canceled -= m_Wrapper.m_SetUpActionsCallbackInterface.OnMoveForward;
                @MoveBack.started -= m_Wrapper.m_SetUpActionsCallbackInterface.OnMoveBack;
                @MoveBack.performed -= m_Wrapper.m_SetUpActionsCallbackInterface.OnMoveBack;
                @MoveBack.canceled -= m_Wrapper.m_SetUpActionsCallbackInterface.OnMoveBack;
                @MoveRight.started -= m_Wrapper.m_SetUpActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_SetUpActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_SetUpActionsCallbackInterface.OnMoveRight;
                @MoveLeft.started -= m_Wrapper.m_SetUpActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_SetUpActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_SetUpActionsCallbackInterface.OnMoveLeft;
                @MoveUp.started -= m_Wrapper.m_SetUpActionsCallbackInterface.OnMoveUp;
                @MoveUp.performed -= m_Wrapper.m_SetUpActionsCallbackInterface.OnMoveUp;
                @MoveUp.canceled -= m_Wrapper.m_SetUpActionsCallbackInterface.OnMoveUp;
                @MoveDown.started -= m_Wrapper.m_SetUpActionsCallbackInterface.OnMoveDown;
                @MoveDown.performed -= m_Wrapper.m_SetUpActionsCallbackInterface.OnMoveDown;
                @MoveDown.canceled -= m_Wrapper.m_SetUpActionsCallbackInterface.OnMoveDown;
                @Quit.started -= m_Wrapper.m_SetUpActionsCallbackInterface.OnQuit;
                @Quit.performed -= m_Wrapper.m_SetUpActionsCallbackInterface.OnQuit;
                @Quit.canceled -= m_Wrapper.m_SetUpActionsCallbackInterface.OnQuit;
            }
            m_Wrapper.m_SetUpActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RecentreView.started += instance.OnRecentreView;
                @RecentreView.performed += instance.OnRecentreView;
                @RecentreView.canceled += instance.OnRecentreView;
                @MoveForward.started += instance.OnMoveForward;
                @MoveForward.performed += instance.OnMoveForward;
                @MoveForward.canceled += instance.OnMoveForward;
                @MoveBack.started += instance.OnMoveBack;
                @MoveBack.performed += instance.OnMoveBack;
                @MoveBack.canceled += instance.OnMoveBack;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveUp.started += instance.OnMoveUp;
                @MoveUp.performed += instance.OnMoveUp;
                @MoveUp.canceled += instance.OnMoveUp;
                @MoveDown.started += instance.OnMoveDown;
                @MoveDown.performed += instance.OnMoveDown;
                @MoveDown.canceled += instance.OnMoveDown;
                @Quit.started += instance.OnQuit;
                @Quit.performed += instance.OnQuit;
                @Quit.canceled += instance.OnQuit;
            }
        }
    }
    public SetUpActions @SetUp => new SetUpActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_UIButtonClick;
    public struct UIActions
    {
        private @UserControls m_Wrapper;
        public UIActions(@UserControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @UIButtonClick => m_Wrapper.m_UI_UIButtonClick;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @UIButtonClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnUIButtonClick;
                @UIButtonClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnUIButtonClick;
                @UIButtonClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnUIButtonClick;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @UIButtonClick.started += instance.OnUIButtonClick;
                @UIButtonClick.performed += instance.OnUIButtonClick;
                @UIButtonClick.canceled += instance.OnUIButtonClick;
            }
        }
    }
    public UIActions @UI => new UIActions(this);

    // Debug
    private readonly InputActionMap m_Debug;
    private IDebugActions m_DebugActionsCallbackInterface;
    private readonly InputAction m_Debug_PlayNextVideoSequence;
    private readonly InputAction m_Debug_TriggerPath;
    public struct DebugActions
    {
        private @UserControls m_Wrapper;
        public DebugActions(@UserControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlayNextVideoSequence => m_Wrapper.m_Debug_PlayNextVideoSequence;
        public InputAction @TriggerPath => m_Wrapper.m_Debug_TriggerPath;
        public InputActionMap Get() { return m_Wrapper.m_Debug; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DebugActions set) { return set.Get(); }
        public void SetCallbacks(IDebugActions instance)
        {
            if (m_Wrapper.m_DebugActionsCallbackInterface != null)
            {
                @PlayNextVideoSequence.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnPlayNextVideoSequence;
                @PlayNextVideoSequence.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnPlayNextVideoSequence;
                @PlayNextVideoSequence.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnPlayNextVideoSequence;
                @TriggerPath.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnTriggerPath;
                @TriggerPath.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnTriggerPath;
                @TriggerPath.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnTriggerPath;
            }
            m_Wrapper.m_DebugActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PlayNextVideoSequence.started += instance.OnPlayNextVideoSequence;
                @PlayNextVideoSequence.performed += instance.OnPlayNextVideoSequence;
                @PlayNextVideoSequence.canceled += instance.OnPlayNextVideoSequence;
                @TriggerPath.started += instance.OnTriggerPath;
                @TriggerPath.performed += instance.OnTriggerPath;
                @TriggerPath.canceled += instance.OnTriggerPath;
            }
        }
    }
    public DebugActions @Debug => new DebugActions(this);
    public interface ISetUpActions
    {
        void OnRecentreView(InputAction.CallbackContext context);
        void OnMoveForward(InputAction.CallbackContext context);
        void OnMoveBack(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveUp(InputAction.CallbackContext context);
        void OnMoveDown(InputAction.CallbackContext context);
        void OnQuit(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnUIButtonClick(InputAction.CallbackContext context);
    }
    public interface IDebugActions
    {
        void OnPlayNextVideoSequence(InputAction.CallbackContext context);
        void OnTriggerPath(InputAction.CallbackContext context);
    }
}
