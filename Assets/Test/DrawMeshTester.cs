using UnityEngine;

[ExecuteInEditMode]
public class DrawMeshTester : MonoBehaviour
{
    [SerializeField] Mesh _mesh;
    [SerializeField] Material _material;

    MaterialPropertyBlock _block;

    void OnEnable()
    {
        _block = new MaterialPropertyBlock();
    }

    void OnDisable()
    {
        _block = null;
    }

    void Update()
    {
        LightProbeUtility.SetSHCoefficients(transform.position, _block);

        Graphics.DrawMesh(
            _mesh,
            transform.position, transform.rotation,
            _material, gameObject.layer, null, 0, _block
        );
    }
}
