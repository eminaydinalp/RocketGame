using UnityEngine;
using UnityEngine.InputSystem;

namespace Game.Scripts.Concretes.Inputs
{
    public class DefaultInput
    {
        private DefaultAction _input;

        public bool isForceUp { get; private set; }
        public float leftRightValue { get; set; }
        public DefaultInput()
        {
            _input = new DefaultAction();
            
            
            _input.Rocket.Forceup.performed += ForceupOnperformed;

            //_input.Rocket.Forceup.canceled += context => isForceUp = context.ReadValueAsButton();  //Eğer pass through değilde button yapsaydık bunu da eklememiz gerekirdi.
            // çünkü isForceUP false olmazdı. pass through adeta update gibi eğer basılmıyorsa kendiliğinden false yapıyor.
            
            _input.Rocket.LeftRightRotate.performed += LeftRightRotateOnperformed;
            _input.Enable();
        }

        private void LeftRightRotateOnperformed(InputAction.CallbackContext obj)
        {
            leftRightValue = obj.ReadValue<float>();
        }

        private void ForceupOnperformed(InputAction.CallbackContext obj)
        {
            isForceUp = obj.ReadValueAsButton();
        }
    }
}
