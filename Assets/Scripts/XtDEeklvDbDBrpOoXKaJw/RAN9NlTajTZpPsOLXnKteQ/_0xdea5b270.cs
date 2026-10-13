using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0xdea5b270 : MonoBehaviour
{
    private void Awake()
    {
        this._0x7ed70819 = this.GetComponent<Camera>();
        _0x7a66e34c = this;
        this._0xea288a82();
    }

    private new Camera _0x7ed70819;
    private Vector3 _0xd61f70fe { get; set; }
    private Vector3 _0x94247ae5 { get; set; }

    private float _0x489d0d56 = 1;
    private _0x37b1d71f _0x64ced6c8 = _0x37b1d71f.Portrait;
    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x47d2224e;
        Matrix4x4 _0xd5468eac = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0x7ed70819.orthographic)
        {
            float _0xa0567bbd = this._0x7ed70819.farClipPlane - this._0x7ed70819.nearClipPlane;
            float _0xa3365403 = (this._0x7ed70819.farClipPlane + this._0x7ed70819.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0xa3365403), new Vector3(this._0x7ed70819.orthographicSize * 2 * this._0x7ed70819.aspect, this._0x7ed70819.orthographicSize * 2, _0xa0567bbd));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0x7ed70819.fieldOfView, this._0x7ed70819.farClipPlane, this._0x7ed70819.nearClipPlane, this._0x7ed70819.aspect);
        }

        Gizmos.matrix = _0xd5468eac;
    }

    private Vector3 _0xb9a127cc { get; set; }
    private Vector3 _0x45e3c415 { get; set; }
    private Vector3 _0xe7861dfa { get; set; }
    private Vector3 _0x1a5d395c { get; set; }

    public enum _0x37b1d71f
    {
        Landscape,
        Portrait
    }

    private void _0xea288a82()
    {
        float _0x424a80da, _0xc7546b22, _0x5604d443, _0xfb374ce9;
        if (this._0x64ced6c8 == _0x37b1d71f.Landscape)
            this._0x7ed70819.orthographicSize = 1f / this._0x7ed70819.aspect * this._0x489d0d56 / 2f;
        else
            this._0x7ed70819.orthographicSize = this._0x489d0d56 / 2f;
        this._0x76b71962 = 2f * this._0x7ed70819.orthographicSize;
        this._0x83732d96 = this._0x76b71962 * this._0x7ed70819.aspect;
        float _0x1ebf0b04 = this._0x7ed70819.transform.position.x;
        float _0xf247857c = this._0x7ed70819.transform.position.y;
        _0x424a80da = _0x1ebf0b04 - this._0x83732d96 / 2;
        _0xc7546b22 = _0x1ebf0b04 + this._0x83732d96 / 2;
        _0x5604d443 = _0xf247857c + this._0x76b71962 / 2;
        _0xfb374ce9 = _0xf247857c - this._0x76b71962 / 2;
        this._0x45e3c415 = new Vector3(_0x424a80da, _0xfb374ce9, 0);
        this._0xe7861dfa = new Vector3(_0x1ebf0b04, _0xfb374ce9, 0);
        this._0xbcf7723e = new Vector3(_0xc7546b22, _0xfb374ce9, 0);
        this._0x35c33a8d = new Vector3(_0x424a80da, _0xf247857c, 0);
        this._0xd61f70fe = new Vector3(_0x1ebf0b04, _0xf247857c, 0);
        this._0xbb04fef3 = new Vector3(_0xc7546b22, _0xf247857c, 0);
        this._0x1a5d395c = new Vector3(_0x424a80da, _0x5604d443, 0);
        this._0xb9a127cc = new Vector3(_0x1ebf0b04, _0x5604d443, 0);
        this._0x94247ae5 = new Vector3(_0xc7546b22, _0x5604d443, 0);
    }

    private Color _0x47d2224e = Color.white;
    private Vector3 _0xbcf7723e { get; set; }
    //public bool executeInUpdate;
    private float _0x83732d96 { get; set; }
    private Vector3 _0x35c33a8d { get; set; }
    private Vector3 _0xbb04fef3 { get; set; }

    private static _0xdea5b270 _0x7a66e34c;
    private float _0x76b71962 { get; set; }
}