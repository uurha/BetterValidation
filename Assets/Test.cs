using System;
using System.Collections.Generic;
using Better.Validation.Runtime.Attributes;
using UnityEngine;

[Serializable]
public class TestManaged
{
    [SceneReference]
    [SerializeField] private List<GameObject> _gameObject;

    [Find(typeof(Test), ValidateIfFieldEmpty = true)]
    [SerializeField] private Test _test;

}

public class Test : MonoBehaviour
{
    [SerializeField] private TestManaged _testManaged;
    
    [PrefabField]
    [SerializeField] private List<GameObject> _gameObject;
}