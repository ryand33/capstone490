using UnityEngine;
using System.Collections;
namespace Completed
{
    public class OrthoSmoothFollow : MonoBehaviour
    {

        public GameObject target;

        private Vector3 offset = new Vector3(0, 0, -1);

        public float smoothTime = 0.3f;

        private Vector3 velocity = Vector3.zero;

        void Start()
        {
        }

        void FixedUpdate()
        {
            if (target)
            {
                transform.position = new Vector3(target.transform.position.x + offset.x,
                    target.transform.position.y + offset.y,
                    target.transform.position.z + offset.z);
            }
        }
    }
}