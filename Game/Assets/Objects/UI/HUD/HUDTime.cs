using System;
using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

namespace Objects.UI.HUD
{
    public class HUDTime : MonoBehaviour
    {
        [Header("COLORS")]
        [SerializeField] private Color green;
        [SerializeField] private Color orange;
        [SerializeField] private Color red;
        
        [Header("OBJECTS")]
        [SerializeField] private GameObject gameObjectLeft;
        [SerializeField] private GameObject gameObjectCenter;
        [SerializeField] private GameObject gameObjectRight;

        private Image _left;
        private Image _center;
        private Image _right;
        
        private Image[] _images;
        private GameObject[] _gameObjects;
        private float _time;

        private void Start()
        {
            _gameObjects = new[] { gameObjectLeft, gameObjectCenter, gameObjectRight };
            
            _left = gameObjectLeft.GetComponent<Image>();
            _center = gameObjectCenter.GetComponent<Image>();
            _right = gameObjectRight.GetComponent<Image>();
            _images = new[] { _left, _center, _right };
        }

        private void Update()
        {
            _time = TimeManager.Instance.RemainingTime;
            UpdateTime();
        }

        private void UpdateTime()
        {
            Color color;

            if (CheckTime(3))
            {
                color = green;
                foreach (var i in _gameObjects)
                {
                    i.SetActive(true);
                }
            } 
            else if (CheckTime(2))
            {
                color = orange;
                gameObjectRight.SetActive(false);
            } 
            else if (CheckTime(1))
            {
                color = red;
                gameObjectCenter.SetActive(false);
            }            
            else if (CheckTime(0))
            {
                gameObjectLeft.SetActive(false);
                return;
            }
            else
            {
                return;
            }
            
            UpdateColor(color);
        }

        private bool CheckTime(int comparer)
        {
            return Math.Abs(_time - comparer) < 0.1;
        }

        private void UpdateColor(Color color)
        {
            foreach (var image in _images)
            {
                image.color = color;
            }
        }
    }
}