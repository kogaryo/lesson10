using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class InstancedBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Color color = Color.white;
    void Start()
    {
        var renderer = GetComponent<Renderer>();
        Assert.IsNotNull(renderer);

        MaterialPropertyBlock block = new MaterialPropertyBlock();
        block.SetColor("_Color", color);

        renderer.SetPropertyBlock(block);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
