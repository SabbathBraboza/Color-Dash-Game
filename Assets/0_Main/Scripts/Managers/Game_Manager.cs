using ColorDash.Managers.AudioManager;
using DG.Tweening;
using UnityEngine;

namespace ColorDash.Managers.GameManager
{
    /// <summary>
    /// Created Enums to Handle The Color
    /// </summary>
    public enum PlayerColor { Red, Green, Blue }

    public class Game_Manager : MonoBehaviour
    {
        public static Game_Manager instance;

        private SpriteRenderer _PlayerSprite;

        [Header("C O L O R S:")]
        public Color RedColor = Color.red;
        public Color GreenColor = Color.green;
        public Color BlueColor = Color.blue;

        [Space(5f)]
        [Header("C U R R E N T")]
        public PlayerColor CurrentColor;

        private void Awake()
        {
            instance = this;
            GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
            if (playerObject != null)
            {
                _PlayerSprite = playerObject.GetComponent<SpriteRenderer>();
            }
        }

        public void SetColorRed() 
        {
            Audio_Manager.AudioInstance.PlaySFX(0);
            SetColor(PlayerColor.Red); 
        }

        public void SetColorGreen()
        {
            Audio_Manager.AudioInstance.PlaySFX(0);
            SetColor(PlayerColor.Green);
        }

        public void SetColorBlue()
        {
            Audio_Manager.AudioInstance.PlaySFX(0);
            SetColor(PlayerColor.Blue);
        }


        /// <summary>
        /// Sets the player's color and updates the associated sprite to reflect the selected color.
        /// </summary>
        private void SetColor(PlayerColor color)
        {
            CurrentColor = color;

            Color TargetColor = Color.white;
            switch (CurrentColor)
            {
                case PlayerColor.Red:
                    TargetColor = RedColor; break;
                case PlayerColor.Green:
                    TargetColor = GreenColor; break;
                case PlayerColor.Blue:
                    TargetColor = BlueColor; break;
            }
            _PlayerSprite.DOColor(TargetColor, 0.7f);
        }

        public string GetCurrentColorTag()
        {
            return CurrentColor switch
            {
                PlayerColor.Red => "RedGate",
                PlayerColor.Green => "GreenGate",
                PlayerColor.Blue => "BlueGate",
                _ => "",
            };
        }

    }
}