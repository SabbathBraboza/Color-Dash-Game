using ColorDash.Managers.GameManager;
using UnityEngine;
using UnityEngine.UI;

namespace ColorDash.Managers.InputManager
{
    public class Input_Manager : MonoBehaviour
    {
        [SerializeField] private Button RedButton;
        [SerializeField] private Button GreenButton;
        [SerializeField] private Button BlueButton;

        private void OnEnable()
        {
            RedButton.onClick.AddListener(Game_Manager.instance.SetColorRed);
            GreenButton.onClick.AddListener(Game_Manager.instance.SetColorGreen);
            BlueButton.onClick.AddListener(Game_Manager.instance.SetColorBlue);
        }

        private void OnDisable()
        {
            RedButton.onClick.RemoveListener(Game_Manager.instance.SetColorRed);
            GreenButton.onClick.RemoveListener(Game_Manager.instance.SetColorGreen);
            BlueButton.onClick.RemoveListener(Game_Manager.instance.SetColorBlue);
        }
    }
}