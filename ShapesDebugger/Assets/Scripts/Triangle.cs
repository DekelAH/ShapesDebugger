using UnityEngine;

namespace Assets.Scripts
{
    public class Triangle : Shape
    {
        #region Editor

        [SerializeField]
        private float _sideA;

        [SerializeField]
        private float _sideB;

        [SerializeField]
        private float _sideC;

        [SerializeField]
        private float _height;

        #endregion

        #region Methods

        protected override float CalculateArea()
        {
            return (_sideC * _height) / 2;
        }

        protected override Rect GetBoundingBox()
        {
            return new Rect
            {
                x = _x,
                y = _y,
                height = _height,
                width = _sideC
            };
        }

        #endregion

        #region Properties

        protected override string Name => _name;

        #endregion
    }
}
