using ColorDash.Managers.AudioManager;
using ColorDash.Managers.GameManager;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string GateTag = collision.tag;
        string PlayerTag = Game_Manager.instance.GetCurrentColorTag();

        if (GateTag == PlayerTag)
        {
            Audio_Manager.AudioInstance.PlaySFX(2);
            In_Game_UI.instance.InceraseScore(1);
            Debug.Log($"Correct Gate Passed: {GateTag}");
        }
        else
        {
            Time.timeScale = 0;
            In_Game_UI.instance.GameOverUI();
            Debug.Log($"Wrong Color Gate: {GateTag}");
        }
    }
}
