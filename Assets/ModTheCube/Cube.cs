using UnityEngine;

namespace ModTheCube
{
    public class Cube : MonoBehaviour
    {
        public MeshRenderer Renderer;
        private float _speed = 1.0f;
        private float _colorChangeSpeed = 1.0f;
        private float _timestamp;
        private float _colorTimestamp;
        private Vector3 _scaleChange = new Vector3(0.1f, 0.1f, 0.1f);


        void Start()
        {
            transform.position = new Vector3(3, 4, 1);
            transform.localScale = Vector3.one * 1.3f;

            Material material = Renderer.material;

            material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
        }

        void Update()
        {
            Material material = Renderer.material;


            // Rotates the cube over time.
            transform.Rotate(0.0f, 10.0f * Time.deltaTime * _speed, 0.0f);

            // Moves the cube over time.
            transform.Translate(Vector3.right * (Time.deltaTime * _speed));

            // Scales the cube over time.
            if (Time.time >= _timestamp)
            {
                transform.localScale += _scaleChange;
                _timestamp = Time.time + (_speed / 10);
            }

            // Change the cubes color and opacity over time.
            if (Time.time >= _colorTimestamp)
            {
                // pick a random color
                Color newColor = new Color(Random.value, Random.value, Random.value, Random.value);
                // apply it on current object's material
                material.color = newColor;
                _colorTimestamp = Time.time + _colorChangeSpeed;
            }
        }
    }
}