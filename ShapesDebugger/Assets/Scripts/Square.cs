using UnityEngine;

namespace Assets.Scripts
{
    public class Square : Shape
    {
        #region Editor

        [SerializeField]
        private float _side;

        #endregion
        
        #region Methods
        
        protected override float CalculateArea()
        {
            return Mathf.Pow(_side, 2);
        }

        protected override Rect GetBoundingBox()
        {
            return new Rect
            {
                x = _x,
                y = _y,
                height = _side,
                width = _side
            };
        }

        #endregion

        #region Properties

        protected override string Name => _name;

        #endregion
    }
}