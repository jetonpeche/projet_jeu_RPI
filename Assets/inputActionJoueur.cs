// GENERATED AUTOMATICALLY FROM 'Assets/inputActionJoueur.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActionJoueur : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActionJoueur()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""inputActionJoueur"",
    ""maps"": [
        {
            ""name"": ""joueur1"",
            ""id"": ""33adcd1b-de02-4155-99b4-146e69bb0aa0"",
            ""actions"": [
                {
                    ""name"": ""Sauter"",
                    ""type"": ""Button"",
                    ""id"": ""023b419f-6729-4b8e-a4b3-6aa80ae44f2f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Value"",
                    ""id"": ""7f69c307-3d3e-4660-8fa7-9592c7cdcbf8"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Value"",
                    ""id"": ""477c6b9a-5ba8-4b16-8835-78a36d6f080e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Soigner"",
                    ""type"": ""Button"",
                    ""id"": ""9333063c-7bfd-43db-80f4-b680fe77d58a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9762b8ac-42fc-4b7e-83b7-7625cf1cb239"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""joueurClavierSouris"",
                    ""action"": ""Sauter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e69f75bc-8a7c-41f7-9c12-725bf9ebc155"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""manette"",
                    ""action"": ""Sauter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""1e21d037-59f3-468f-9b1b-9d44c4bd2e72"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""29d45657-6fd6-4ff1-a9ab-5cb23f83d2be"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""joueurClavierSouris"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5edc3cd1-3423-49de-83a4-a3991e97d386"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""joueurClavierSouris"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""655d7a8f-d47f-42fe-8190-19fe50018628"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""82662f57-b5d6-4f42-9911-0ce1cbd7ba2a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""joueurClavierSouris"",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""28f95447-a9e9-4765-8d43-84dfa735f3bb"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""joueurClavierSouris"",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""43bc62c6-1cb7-4040-869c-711261f4eb32"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""joueurClavierSouris"",
                    ""action"": ""Soigner"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""joueurClavierSouris"",
            ""bindingGroup"": ""joueurClavierSouris"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""manette"",
            ""bindingGroup"": ""manette"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<DualShockGamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // joueur1
        m_joueur1 = asset.FindActionMap("joueur1", throwIfNotFound: true);
        m_joueur1_Sauter = m_joueur1.FindAction("Sauter", throwIfNotFound: true);
        m_joueur1_Horizontal = m_joueur1.FindAction("Horizontal", throwIfNotFound: true);
        m_joueur1_Vertical = m_joueur1.FindAction("Vertical", throwIfNotFound: true);
        m_joueur1_Soigner = m_joueur1.FindAction("Soigner", throwIfNotFound: true);
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

    // joueur1
    private readonly InputActionMap m_joueur1;
    private IJoueur1Actions m_Joueur1ActionsCallbackInterface;
    private readonly InputAction m_joueur1_Sauter;
    private readonly InputAction m_joueur1_Horizontal;
    private readonly InputAction m_joueur1_Vertical;
    private readonly InputAction m_joueur1_Soigner;
    public struct Joueur1Actions
    {
        private @InputActionJoueur m_Wrapper;
        public Joueur1Actions(@InputActionJoueur wrapper) { m_Wrapper = wrapper; }
        public InputAction @Sauter => m_Wrapper.m_joueur1_Sauter;
        public InputAction @Horizontal => m_Wrapper.m_joueur1_Horizontal;
        public InputAction @Vertical => m_Wrapper.m_joueur1_Vertical;
        public InputAction @Soigner => m_Wrapper.m_joueur1_Soigner;
        public InputActionMap Get() { return m_Wrapper.m_joueur1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Joueur1Actions set) { return set.Get(); }
        public void SetCallbacks(IJoueur1Actions instance)
        {
            if (m_Wrapper.m_Joueur1ActionsCallbackInterface != null)
            {
                @Sauter.started -= m_Wrapper.m_Joueur1ActionsCallbackInterface.OnSauter;
                @Sauter.performed -= m_Wrapper.m_Joueur1ActionsCallbackInterface.OnSauter;
                @Sauter.canceled -= m_Wrapper.m_Joueur1ActionsCallbackInterface.OnSauter;
                @Horizontal.started -= m_Wrapper.m_Joueur1ActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_Joueur1ActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_Joueur1ActionsCallbackInterface.OnHorizontal;
                @Vertical.started -= m_Wrapper.m_Joueur1ActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_Joueur1ActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_Joueur1ActionsCallbackInterface.OnVertical;
                @Soigner.started -= m_Wrapper.m_Joueur1ActionsCallbackInterface.OnSoigner;
                @Soigner.performed -= m_Wrapper.m_Joueur1ActionsCallbackInterface.OnSoigner;
                @Soigner.canceled -= m_Wrapper.m_Joueur1ActionsCallbackInterface.OnSoigner;
            }
            m_Wrapper.m_Joueur1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Sauter.started += instance.OnSauter;
                @Sauter.performed += instance.OnSauter;
                @Sauter.canceled += instance.OnSauter;
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
                @Soigner.started += instance.OnSoigner;
                @Soigner.performed += instance.OnSoigner;
                @Soigner.canceled += instance.OnSoigner;
            }
        }
    }
    public Joueur1Actions @joueur1 => new Joueur1Actions(this);
    private int m_joueurClavierSourisSchemeIndex = -1;
    public InputControlScheme joueurClavierSourisScheme
    {
        get
        {
            if (m_joueurClavierSourisSchemeIndex == -1) m_joueurClavierSourisSchemeIndex = asset.FindControlSchemeIndex("joueurClavierSouris");
            return asset.controlSchemes[m_joueurClavierSourisSchemeIndex];
        }
    }
    private int m_manetteSchemeIndex = -1;
    public InputControlScheme manetteScheme
    {
        get
        {
            if (m_manetteSchemeIndex == -1) m_manetteSchemeIndex = asset.FindControlSchemeIndex("manette");
            return asset.controlSchemes[m_manetteSchemeIndex];
        }
    }
    public interface IJoueur1Actions
    {
        void OnSauter(InputAction.CallbackContext context);
        void OnHorizontal(InputAction.CallbackContext context);
        void OnVertical(InputAction.CallbackContext context);
        void OnSoigner(InputAction.CallbackContext context);
    }
}
