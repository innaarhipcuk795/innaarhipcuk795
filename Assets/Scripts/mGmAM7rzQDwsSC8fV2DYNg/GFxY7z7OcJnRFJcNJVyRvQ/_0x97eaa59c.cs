using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x97eaa59c : MonoBehaviour
{
    private Touch? _0xd72963b3(Bounds _0x82705760)
    {
        if (!_0x2bc80d8c.Instance._0x41e1785e)
            return null;
        foreach (Touch _0x11056e92 in Touch.activeTouches)
            if (!_0x11056e92.ended)
            {
                Vector3 _0xd95d24f1 = Camera.main.ScreenToWorldPoint(_0x11056e92.screenPosition);
                Vector3 _0xbe06ff30 = new(_0xd95d24f1.x, _0xd95d24f1.y, _0x82705760.center.z);
                if (_0x82705760.Contains(_0xbe06ff30) && this._0x442cb40b(_0x11056e92))
                    return _0x11056e92;
            }

        return null;
    }

    private static _0x97eaa59c _0x7f351342;
    public BoxCollider2D CameraTouchBounds;
    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x7f351342 = this.gameObject.GetComponent<_0x97eaa59c>();
    }

    private Touch? _0x6b837074()
    {
        if (!_0x2bc80d8c.Instance._0x41e1785e)
            return null;
        foreach (Touch _0x5210ff13 in Touch.activeTouches)
            if (!_0x5210ff13.ended)
                if (this._0x442cb40b(_0x5210ff13))
                    return _0x5210ff13;
        return null;
    }

    private bool _0x2e07d421(Touch? _0xc76c5fea, Bounds _0x795776ae, TouchPhase _0xc0f21aab)
    {
        if (!_0x2bc80d8c.Instance._0x41e1785e)
        {
            _0xc76c5fea = null;
            return false;
        }

        if (_0xc76c5fea != null)
            if (_0xc76c5fea.Value.phase == _0xc0f21aab)
            {
                Vector3 _0x8ac37cd3 = Camera.main.ScreenToWorldPoint(_0xc76c5fea.Value.screenPosition);
                Vector3 _0x0ec58c55 = new(_0x8ac37cd3.x, _0x8ac37cd3.y, _0x795776ae.center.z);
                if (_0x795776ae.Contains(_0x0ec58c55) && this._0x442cb40b(_0xc76c5fea.Value))
                    return true;
            }

        return false;
    }

    private bool _0x442cb40b(Touch? _0x110320d0)
    {
        if (!_0x110320d0.HasValue)
            return false;
        Vector3 _0xe99d8920 = Camera.main.ScreenToWorldPoint(_0x110320d0.Value.screenPosition);
        Vector3 _0xbe5208b7 = _0xe99d8920;
        _0xbe5208b7.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0xbe5208b7))
            return true;
        _0x110320d0 = null;
        return false;
    }

    private Touch? _0xeca194f7(Bounds _0x2e2717a4, TouchPhase _0x04adb824)
    {
        if (!_0x2bc80d8c.Instance._0x41e1785e)
            return null;
        foreach (Touch _0xe8f29230 in Touch.activeTouches)
            if (_0xe8f29230.phase == _0x04adb824)
            {
                Vector3 _0x47ecf94f = Camera.main.ScreenToWorldPoint(_0xe8f29230.screenPosition);
                Vector3 _0x06213920 = new(_0x47ecf94f.x, _0x47ecf94f.y, _0x2e2717a4.center.z);
                if (_0x2e2717a4.Contains(_0x06213920) && this._0x442cb40b(_0xe8f29230))
                    return _0xe8f29230;
            }

        return null;
    }

    private Touch? _0xd680f42f(Bounds _0x4fead68a)
    {
        if (!_0x2bc80d8c.Instance._0x41e1785e)
            return null;
        foreach (Touch _0x3ce438f0 in Touch.activeTouches)
            if (_0x3ce438f0.ended)
            {
                Vector3 _0x947ffbbd = Camera.main.ScreenToWorldPoint(_0x3ce438f0.screenPosition);
                Vector3 _0xf9ee4ca9 = new(_0x947ffbbd.x, _0x947ffbbd.y, _0x4fead68a.center.z);
                if (_0x4fead68a.Contains(_0xf9ee4ca9) && this._0x442cb40b(_0x3ce438f0))
                    return _0x3ce438f0;
            }

        return null;
    }

    private void _0xaf804625(Touch? _0xce48faac)
    {
        if (!_0x2bc80d8c.Instance._0x41e1785e)
        {
            _0xce48faac = null;
            return;
        }

        int _0x64d5c4e5 = _0xce48faac.Value.touchId;
        _0xce48faac = Touch.activeTouches.FirstOrDefault(_0x4c044fda => _0x4c044fda.touchId == _0x64d5c4e5);
        if (!this._0x442cb40b(_0xce48faac.Value))
            _0xce48faac = null;
    }

    private Touch? _0xa53b4b7a()
    {
        if (!_0x2bc80d8c.Instance._0x41e1785e)
            return null;
        foreach (Touch _0xef0daf84 in Touch.activeTouches)
            if (_0xef0daf84.ended)
                if (this._0x442cb40b(_0xef0daf84))
                    return _0xef0daf84;
        return null;
    }
}