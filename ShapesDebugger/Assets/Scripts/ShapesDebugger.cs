using UnityEngine;

namespace Assets.Scripts
{
    public class ShapesDebugger : MonoBehaviour
    {
        #region Editor

        [SerializeField]
        private Shape[] _shapes;

        #endregion

        #region Methods

        public void DebugShapes()
        {
            foreach (var shape in _shapes)
            {
                Debug.Log(shape.GetDebugString());
            }
        }

        #endregion
    }
}