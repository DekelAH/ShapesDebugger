using UnityEngine;

namespace Assets.Scripts
{
    public class Circle : Shape
    {
        #region Editor

        [SerializeField]
        private float _radius;

        #endregion

        #region Methods

        protected override float CalculateArea()
        {
            return Mathf.PI * Mathf.Pow(_radius, 2);
        }

        protected override Rect GetBoundingBox()
        {
            return new Rect
            {
                x = _x - _radius,
                y = _x + _radius,
                width = _radius * 2,
                height = _radius * 2
            };
        }

        #endregion

        #region Properties

        protected override string Name => _name;

        #endregion
    }
}