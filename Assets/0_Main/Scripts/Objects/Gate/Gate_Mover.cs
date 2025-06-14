using UnityEngine;

namespace ColorDash.Gate.Mover
{
    public class Gate_Mover : MonoBehaviour
    {
        [Header("V A L U E S:")]
        [SerializeField] private float MoveSpeed;
        [SerializeField] private float SpeedIncreament;
        [SerializeField] private float IncreaseInterval;

        private void Update()
        {
            transform.Translate(MoveSpeed * Time.deltaTime * Vector2.left);

            if (transform.position.x < -2.2f) gameObject.SetActive(false);
        }
    }
}