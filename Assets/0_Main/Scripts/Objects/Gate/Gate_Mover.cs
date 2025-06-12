using UnityEngine;

namespace ColorDash.Gate.Mover
{
    public class Gate_Mover : MonoBehaviour
    {
        [SerializeField] private float MoveSpeed;

        private void Update()
        {
            transform.Translate(MoveSpeed * Time.deltaTime * Vector2.left);
            
            if(transform.position.x< - 2.2f)
            {
                gameObject.SetActive(false);
            }
        }

    }
}