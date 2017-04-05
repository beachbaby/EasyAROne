/**
* Copyright (c) 2015-2016 VisionStar Information Technology (Shanghai) Co., Ltd. All Rights Reserved.
* EasyAR is the registered trademark or trademark of VisionStar Information Technology (Shanghai) Co., Ltd in China
* and other countries for the augmented reality technology developed by VisionStar Information Technology (Shanghai) Co., Ltd.
*/
using UnityEngine;

namespace EasyAR
{
    public class ImageTargetBehaviour : ImageTargetBaseBehaviour
    {
        protected override void Awake()
        {
            base.Awake();
            TargetFound += OnTargetFound;
            TargetLost += OnTargetLost;
            TargetLoad += OnTargetLoad;
            TargetUnload += OnTargetUnload;
        }
        void OnTargetFound(ImageTargetBaseBehaviour behaviour)
        {
            Debug.Log("Found:" + Target.Id);
        }
        void OnTargetLost(ImageTargetBaseBehaviour behaviour)
        {
            Debug.Log("Lost:" + Target.Id);
        }
        void OnTargetLoad(ImageTargetBaseBehaviour behaviour, ImageTrackerBaseBehaviour tracker, bool status)
        {
            Debug.Log("Load target(" + status + "):" + Target.Id + "(" + Target.Name + ")" + "->" + tracker);
        }
        void OnTargetUnload(ImageTargetBaseBehaviour behaviour, ImageTrackerBaseBehaviour tracker, bool status)
        {
            Debug.Log("Unload target(" + status + "):" + Target.Id + "(" + Target.Name + ")" + "->" + tracker);
        }
    }
}


