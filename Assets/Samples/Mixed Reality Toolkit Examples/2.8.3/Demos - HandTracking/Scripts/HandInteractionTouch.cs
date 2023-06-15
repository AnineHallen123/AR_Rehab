// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.



using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Examples.Demos
{
    [AddComponentMenu("Scripts/MRTK/Examples/HandInteractionTouch")]
    public class HandInteractionTouch : MonoBehaviour, IMixedRealityTouchHandler
    {
        [SerializeField]
        private TextMesh debugMessage = null;
        [SerializeField]
        private TextMesh debugMessage2 = null;

        #region Event handlers
        public TouchEvent OnTouchCompleted;
        public TouchEvent OnTouchStarted;
        public TouchEvent OnTouchUpdated;
        #endregion

        private Renderer TargetRenderer; 
        private Color originalColor;
        private Color highlightedColor;

        protected float duration = 1.5f;
        protected float t = 0;

        //---------------------------------------------------------//
        private CubeManager cubeManager;
        //---------------------------------------------------------//

        private void Start()
        {
            //---------------------------------------------------------//
            cubeManager = GameObject.Find("CubeManager").GetComponent<CubeManager>();
            //cubeManager.LightUpRandomCube();
            //---------------------------------------------------------//

        }

        void IMixedRealityTouchHandler.OnTouchCompleted(HandTrackingInputEventData eventData)
        {
            OnTouchCompleted.Invoke(eventData);

            //---------------------------------------------------------//
            cubeManager.HandleCubeTouch();
            Debug.Log("HandleCubeTouch");
            //---------------------------------------------------------//

        }

        void IMixedRealityTouchHandler.OnTouchStarted(HandTrackingInputEventData eventData)
        {
            OnTouchStarted.Invoke(eventData);

       

        }

        void IMixedRealityTouchHandler.OnTouchUpdated(HandTrackingInputEventData eventData)
        {
            OnTouchUpdated.Invoke(eventData);

        }
    }
}
