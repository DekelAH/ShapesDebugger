using UnityEngine;

namespace Assets.Scripts
{
    public abstract class Shape : MonoBehaviour
    {
        #region Editor

        [SerializeField]
        protected float _x;

        [SerializeField]
        protected float _y;

        [SerializeField]
        protected string _name;
        
        #endregion

        #region Methods

        protected abstract float CalculateArea();

        protected abstract Rect GetBoundingBox();
        
        public virtual string GetDebugString()
        {
            var debugString = $"{Name}, Area: {CalculateArea()}, Bounding Rect: {GetBoundingBox()}";
            return debugString;
        }

        #endregion

        #region Properties

        protected virtual string Name => _name;

        #endregion
    }
}