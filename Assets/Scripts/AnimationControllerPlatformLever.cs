//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class AnimationControllerPlatformLever : MonoBehaviour
//{
//    private Animator animator;
//
    // Start is called before the first frame update
//    void Start()
//    {
//        animator = GetComponent<Animator>();
//    }

    // Update is called once per frame
//    void Update()
//    {
//        animator.SetTrigger("PlatformAir");
//    }
//}

//-----------------------------------------------------------------------
// <copyright file="ObjectController.cs" company="Google LLC">
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections;

using UnityEngine;

/// <summary>
/// Controls target objects behaviour.
/// </summary>
public class AnimationControllerPlatformLever : MonoBehaviour
{
    /// <summary>
    /// The material to use when this object is inactive (not being gazed at).
    /// </summary>
    public Material InactiveMaterial;

    /// <summary>
    /// The material to use when this object is active (gazed at).
    /// </summary>
    public Material GazedAtMaterial;

    public GameObject player;

    // The objects are about 1 meter in radius, so the min/max target distance are
    // set so that the objects are always within the room (which is about 5 meters
    // across).

    private Renderer _myRenderer;
    private Vector3 _startingPosition;

    private Animator animator;
    public Animator animatorPlatform1;
    public Animator animatorPlatform2;
    public Animator animatorPlatform3;
    public Animator animatorPlatform4;

    /// <summary>
    /// Start is called before the first frame update.
    /// </summary>
    public void Start()
    {
        _startingPosition = transform.localPosition;
        _myRenderer = GetComponent<Renderer>();
        SetMaterial(false);

        animator = GetComponent<Animator>();
    }

    /// <summary>
    /// Teleports this instance randomly when triggered by a pointer click.
    /// </summary>

    /// <summary>
    /// This method is called by the Main Camera when it starts gazing at this GameObject.
    /// </summary>
    public void OnPointerEnterXR()
    {
        SetMaterial(true);
    }

    /// <summary>
    /// This method is called by the Main Camera when it stops gazing at this GameObject.
    /// </summary>
    /// 

    public void OnPointerExitXR()
    {
        SetMaterial(false);
    }


    public void OnPointerClickXR()
    {
        animator.SetTrigger("Lever");
        animatorPlatform1.SetTrigger("PlatformAir");
        animatorPlatform2.SetTrigger("PlatformAir");
        animatorPlatform3.SetTrigger("PlatformAir");
        animatorPlatform4.SetTrigger("PlatformAir");
    }

    /// <summary>
    /// Sets this instance's material according to gazedAt status.
    /// </summary>
    ///
    /// <param name="gazedAt">
    /// Value `true` if this object is being gazed at, `false` otherwise.
    /// </param>
    private void SetMaterial(bool gazedAt)
    {
        if (InactiveMaterial != null && GazedAtMaterial != null)
        {
            _myRenderer.material = gazedAt ? GazedAtMaterial : InactiveMaterial;
        }
    }
}
