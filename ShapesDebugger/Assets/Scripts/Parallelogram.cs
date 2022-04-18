using UnityEngine;

namespace Assets.Scripts
{
    public class Parallelogram : Shape
    {
        #region Editor

        [SerializeField]
        private float _height;

        [SerializeField]
        private float _sideA;

        [SerializeField]
        private float _sideB;

        #endregion

        #region Methods

        protected override float CalculateArea()
        {
            return _height * _sideA;
        }

        protected override Rect GetBoundingBox()
        {
            return new Rect
            {
                x = _x,
                y = _y,
                height = _height
            };
        }

        #endregion

        #region Properties

        protected override string Name => base.Name;

        #endregion
    }
}
