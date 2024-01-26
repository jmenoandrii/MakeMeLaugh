//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Player/PlayerControls.inputactions
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

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""FPSControl"",
            ""id"": ""3a792d79-4075-4c12-a034-c8388a6bc5a0"",
            ""actions"": [
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8d83e410-6d0e-46eb-b6b8-ae950c1786d0"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""72d60bbe-1121-4499-9b8c-ea0933be7acd"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""344b2493-7f61-47eb-9fb8-4b0c89e2a8d1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""PassThrough"",
                    ""id"": ""531f0a44-b29a-4d36-8756-341677072b6c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""26c6c358-72e5-435d-b3c6-c0594db5ba3e"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04ed195f-b544-4d1d-b7dd-96ec73e4ad6b"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a1d6a8c1-9615-4578-a390-0910caff28c0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""75d94b6c-954a-4633-826d-b68ba7987d62"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d6f19953-a1a3-41cd-bf3e-164a6dd0768a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3b4945f3-4d44-440a-8f44-98be8bd4e6fe"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c6853179-c066-4d8b-a538-47965dc3c754"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0d07a344-e869-4c21-ba96-fb324eb7b2ce"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Actions"",
            ""id"": ""64970f27-77ee-48ee-8501-f7f3365f682f"",
            ""actions"": [
                {
                    ""name"": ""Action"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d684c948-f2d6-4852-8f34-bca6d6829113"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Drop"",
                    ""type"": ""Button"",
                    ""id"": ""6851e766-660c-4b76-a4ba-aa99e9868522"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""f1280eb3-9c79-43ed-b5cf-dd6673bc4612"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Clock"",
                    ""type"": ""Button"",
                    ""id"": ""8d6683b2-c8c5-4e9a-ae6f-595bb8bbc372"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2ca464fa-3ea6-42b6-8328-6bf91796492c"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9bf58aab-6ec2-4ade-9e91-5130af728423"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""edd49075-2c26-48ce-98b3-7e6d93f42ab2"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0f026db-6d71-4ed6-acd8-26781088d3bc"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Clock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""0ecc80fd-7107-4e74-96f6-5b97248e96ce"",
            ""actions"": [
                {
                    ""name"": ""Switch Pad"",
                    ""type"": ""Button"",
                    ""id"": ""c837fbda-0c32-4441-b236-d166215adca7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""2ecdb85b-456d-4191-b0c6-d6a26a5c4f57"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Enter"",
                    ""type"": ""Button"",
                    ""id"": ""5bcc0b50-1e77-4116-b7f3-e4538b927a31"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7f4187c3-8535-4a94-bbf1-4a1051c07d30"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Pad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05d55afe-b06a-439e-997c-5b6632461d1b"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae35eff4-3715-45b0-aff2-73552d2ab191"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Enter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // FPSControl
        m_FPSControl = asset.FindActionMap("FPSControl", throwIfNotFound: true);
        m_FPSControl_MouseX = m_FPSControl.FindAction("MouseX", throwIfNotFound: true);
        m_FPSControl_MouseY = m_FPSControl.FindAction("MouseY", throwIfNotFound: true);
        m_FPSControl_Movement = m_FPSControl.FindAction("Movement", throwIfNotFound: true);
        m_FPSControl_Crouch = m_FPSControl.FindAction("Crouch", throwIfNotFound: true);
        // Actions
        m_Actions = asset.FindActionMap("Actions", throwIfNotFound: true);
        m_Actions_Action = m_Actions.FindAction("Action", throwIfNotFound: true);
        m_Actions_Drop = m_Actions.FindAction("Drop", throwIfNotFound: true);
        m_Actions_Interact = m_Actions.FindAction("Interact", throwIfNotFound: true);
        m_Actions_Clock = m_Actions.FindAction("Clock", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_SwitchPad = m_Menu.FindAction("Switch Pad", throwIfNotFound: true);
        m_Menu_Exit = m_Menu.FindAction("Exit", throwIfNotFound: true);
        m_Menu_Enter = m_Menu.FindAction("Enter", throwIfNotFound: true);
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

    // FPSControl
    private readonly InputActionMap m_FPSControl;
    private List<IFPSControlActions> m_FPSControlActionsCallbackInterfaces = new List<IFPSControlActions>();
    private readonly InputAction m_FPSControl_MouseX;
    private readonly InputAction m_FPSControl_MouseY;
    private readonly InputAction m_FPSControl_Movement;
    private readonly InputAction m_FPSControl_Crouch;
    public struct FPSControlActions
    {
        private @PlayerControls m_Wrapper;
        public FPSControlActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseX => m_Wrapper.m_FPSControl_MouseX;
        public InputAction @MouseY => m_Wrapper.m_FPSControl_MouseY;
        public InputAction @Movement => m_Wrapper.m_FPSControl_Movement;
        public InputAction @Crouch => m_Wrapper.m_FPSControl_Crouch;
        public InputActionMap Get() { return m_Wrapper.m_FPSControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FPSControlActions set) { return set.Get(); }
        public void AddCallbacks(IFPSControlActions instance)
        {
            if (instance == null || m_Wrapper.m_FPSControlActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_FPSControlActionsCallbackInterfaces.Add(instance);
            @MouseX.started += instance.OnMouseX;
            @MouseX.performed += instance.OnMouseX;
            @MouseX.canceled += instance.OnMouseX;
            @MouseY.started += instance.OnMouseY;
            @MouseY.performed += instance.OnMouseY;
            @MouseY.canceled += instance.OnMouseY;
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Crouch.started += instance.OnCrouch;
            @Crouch.performed += instance.OnCrouch;
            @Crouch.canceled += instance.OnCrouch;
        }

        private void UnregisterCallbacks(IFPSControlActions instance)
        {
            @MouseX.started -= instance.OnMouseX;
            @MouseX.performed -= instance.OnMouseX;
            @MouseX.canceled -= instance.OnMouseX;
            @MouseY.started -= instance.OnMouseY;
            @MouseY.performed -= instance.OnMouseY;
            @MouseY.canceled -= instance.OnMouseY;
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Crouch.started -= instance.OnCrouch;
            @Crouch.performed -= instance.OnCrouch;
            @Crouch.canceled -= instance.OnCrouch;
        }

        public void RemoveCallbacks(IFPSControlActions instance)
        {
            if (m_Wrapper.m_FPSControlActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IFPSControlActions instance)
        {
            foreach (var item in m_Wrapper.m_FPSControlActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_FPSControlActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public FPSControlActions @FPSControl => new FPSControlActions(this);

    // Actions
    private readonly InputActionMap m_Actions;
    private List<IActionsActions> m_ActionsActionsCallbackInterfaces = new List<IActionsActions>();
    private readonly InputAction m_Actions_Action;
    private readonly InputAction m_Actions_Drop;
    private readonly InputAction m_Actions_Interact;
    private readonly InputAction m_Actions_Clock;
    public struct ActionsActions
    {
        private @PlayerControls m_Wrapper;
        public ActionsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Action => m_Wrapper.m_Actions_Action;
        public InputAction @Drop => m_Wrapper.m_Actions_Drop;
        public InputAction @Interact => m_Wrapper.m_Actions_Interact;
        public InputAction @Clock => m_Wrapper.m_Actions_Clock;
        public InputActionMap Get() { return m_Wrapper.m_Actions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionsActions set) { return set.Get(); }
        public void AddCallbacks(IActionsActions instance)
        {
            if (instance == null || m_Wrapper.m_ActionsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ActionsActionsCallbackInterfaces.Add(instance);
            @Action.started += instance.OnAction;
            @Action.performed += instance.OnAction;
            @Action.canceled += instance.OnAction;
            @Drop.started += instance.OnDrop;
            @Drop.performed += instance.OnDrop;
            @Drop.canceled += instance.OnDrop;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
            @Clock.started += instance.OnClock;
            @Clock.performed += instance.OnClock;
            @Clock.canceled += instance.OnClock;
        }

        private void UnregisterCallbacks(IActionsActions instance)
        {
            @Action.started -= instance.OnAction;
            @Action.performed -= instance.OnAction;
            @Action.canceled -= instance.OnAction;
            @Drop.started -= instance.OnDrop;
            @Drop.performed -= instance.OnDrop;
            @Drop.canceled -= instance.OnDrop;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
            @Clock.started -= instance.OnClock;
            @Clock.performed -= instance.OnClock;
            @Clock.canceled -= instance.OnClock;
        }

        public void RemoveCallbacks(IActionsActions instance)
        {
            if (m_Wrapper.m_ActionsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IActionsActions instance)
        {
            foreach (var item in m_Wrapper.m_ActionsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ActionsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ActionsActions @Actions => new ActionsActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private List<IMenuActions> m_MenuActionsCallbackInterfaces = new List<IMenuActions>();
    private readonly InputAction m_Menu_SwitchPad;
    private readonly InputAction m_Menu_Exit;
    private readonly InputAction m_Menu_Enter;
    public struct MenuActions
    {
        private @PlayerControls m_Wrapper;
        public MenuActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @SwitchPad => m_Wrapper.m_Menu_SwitchPad;
        public InputAction @Exit => m_Wrapper.m_Menu_Exit;
        public InputAction @Enter => m_Wrapper.m_Menu_Enter;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void AddCallbacks(IMenuActions instance)
        {
            if (instance == null || m_Wrapper.m_MenuActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MenuActionsCallbackInterfaces.Add(instance);
            @SwitchPad.started += instance.OnSwitchPad;
            @SwitchPad.performed += instance.OnSwitchPad;
            @SwitchPad.canceled += instance.OnSwitchPad;
            @Exit.started += instance.OnExit;
            @Exit.performed += instance.OnExit;
            @Exit.canceled += instance.OnExit;
            @Enter.started += instance.OnEnter;
            @Enter.performed += instance.OnEnter;
            @Enter.canceled += instance.OnEnter;
        }

        private void UnregisterCallbacks(IMenuActions instance)
        {
            @SwitchPad.started -= instance.OnSwitchPad;
            @SwitchPad.performed -= instance.OnSwitchPad;
            @SwitchPad.canceled -= instance.OnSwitchPad;
            @Exit.started -= instance.OnExit;
            @Exit.performed -= instance.OnExit;
            @Exit.canceled -= instance.OnExit;
            @Enter.started -= instance.OnEnter;
            @Enter.performed -= instance.OnEnter;
            @Enter.canceled -= instance.OnEnter;
        }

        public void RemoveCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMenuActions instance)
        {
            foreach (var item in m_Wrapper.m_MenuActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MenuActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface IFPSControlActions
    {
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
    }
    public interface IActionsActions
    {
        void OnAction(InputAction.CallbackContext context);
        void OnDrop(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnClock(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnSwitchPad(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
        void OnEnter(InputAction.CallbackContext context);
    }
}
