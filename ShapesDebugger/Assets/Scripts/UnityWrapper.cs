using UnityEngine;

namespace Assets.Scripts
{
    public class UnityWrapper : MonoBehaviour
    {
        #region Editor

        [SerializeField]
        private ShapesDebugger _shapesDebugger;

        #endregion

        #region Methods

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _shapesDebugger.DebugShapes();
            }
        }

        #endregion
    }
}