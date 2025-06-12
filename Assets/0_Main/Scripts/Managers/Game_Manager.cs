using UnityEngine;

namespace ColorDash.Managers.GameManager
{
    /// <summary>
    /// Created Enums to Handle The Color
    /// </summary>
    public enum PlayerColor { Red, Green, Blue }

    /// <summary>
    /// Used Custom Singleton 
    /// </summary>
    public class Game_Manager : MonoBehaviour
    {
        public static Game_Manager instance;

        private SpriteRenderer _PlayerSprite;

        public Color RedColor = Color.red;
        public Color GreenColor = Color.green;
        public Color BlueColor = Color.blue;
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

        public void SetColorRed() => SetColor(PlayerColor.Red);
        public void SetColorGreen() => SetColor(PlayerColor.Green);
        public void SetColorBlue() => SetColor(PlayerColor.Blue);


        /// <summary>
        /// Sets the player's color and updates the associated sprite to reflect the selected color.
        /// </summary>
        private void SetColor(PlayerColor color)
        {
            CurrentColor = color;

            switch (CurrentColor)
            {
                case PlayerColor.Red:
                    _PlayerSprite.color = RedColor; break;
                case PlayerColor.Green:
                    _PlayerSprite.color = GreenColor; break;
                case PlayerColor.Blue:
                    _PlayerSprite.color = BlueColor; break;
            }
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