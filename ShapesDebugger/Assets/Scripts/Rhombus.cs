using UnityEngine;

namespace Assets.Scripts
{
    public class Rhombus : Shape
    {
        #region Editor

        [SerializeField]
        private float _height;

        [SerializeField]
        private float _width;

        [SerializeField]
        private float _side;

        #endregion

        #region Methods

        protected override float CalculateArea()
        {
            return (_height * _width) / 2;
        }

        protected override Rect GetBoundingBox()
        {
            return new Rect
            {
                x = _x,
                y = _y,
                height = _height,
                width = _width,        
            };
        }

        #endregion

        #region Properties

        protected override string Name => base.Name; 

        #endregion
    }
}
