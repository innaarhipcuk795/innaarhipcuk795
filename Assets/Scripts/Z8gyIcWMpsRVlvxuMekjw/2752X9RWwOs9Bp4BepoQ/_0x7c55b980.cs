using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0x7c55b980 : MonoBehaviour
{
    private bool _0x3b39ee38()
    {
        var _0x32bff83a = _0xe08cbcab();
        if (_0x32bff83a == null)
            return false;
        WLog(_0x3491765a._0xbc716140(new byte[31] { 240, 217, 202, 220, 207, 217, 202, 221, 152, 218, 217, 219, 211, 152, 149, 134, 152, 200, 215, 200, 205, 200, 152, 255, 215, 250, 217, 219, 211, 130, 152 }, 184) + _0x32bff83a.Id);
        _0x32bff83a.GoBack();
        return true;
    }

    private IEnumerator _0xa4555d41(float _0x35e37ec2)
    {
        yield return new WaitForSeconds(_0x35e37ec2);
        if (!_0x62e8e93b)
        {
            _0x62e8e93b = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x528738ec}");
                }
#endif
            }
        }
    }

    private void _0x8cd13c7f()
    {
        WLog(_0x3491765a._0xbc716140(new byte[21] { 56, 17, 2, 20, 7, 17, 2, 21, 80, 18, 17, 19, 27, 80, 0, 2, 21, 3, 3, 21, 20 }, 112));
        if (Time.frameCount == _0x4986d21e)
            return;
        _0x4986d21e = Time.frameCount;
        if (_0xd73eb76f())
            return;
        _0x93f75e22();
    }

    private string _0x1e3f0912 = "";
    internal Rect lastSafe = Rect.zero;
    private UniWebViewPopup _0xe08cbcab()
    {
        for (int _0xba0277ad = _0x09e95873.Count - 1; _0xba0277ad >= 0; _0xba0277ad--)
        {
            var _0xa1e72ccb = _0x09e95873[_0xba0277ad];
            if (_0xa1e72ccb != null && _0xa1e72ccb.IsAlive)
                return _0xa1e72ccb;
            _0x09e95873.RemoveAt(_0xba0277ad);
        }

        return null;
    }

    private Canvas _0xcc254594()
    {
        if (_0x17cfd06c != null)
            return _0x17cfd06c;
        var _0x71cad7da = gameObject.GetComponentInChildren<Canvas>();
        if (_0x71cad7da == null)
        {
            var _0xbe01391e = new GameObject(_0x3491765a._0xbc716140(new byte[6] { 68, 102, 105, 113, 102, 116 }, 7), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x71cad7da = _0xbe01391e.GetComponent<Canvas>();
            _0x71cad7da.transform.SetParent(transform, false);
            _0x71cad7da.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x17cfd06c = _0x71cad7da;
        return _0x17cfd06c;
    }

    private void Awake()
    {
        if (_0x9ab4bb01 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x9ab4bb01 = gameObject.GetComponent<_0x7c55b980>();
        DontDestroyOnLoad(gameObject);
        _0x50c2f798 = _0x167c4fd6 = _0x406f22ee = "";
        _0xceb87870 = "";
        _0xb5e80385 = false;
    }

    private string Decrypt(string _0x13cd085f, string _0x0902734a)
    {
        try
        {
            var _0x5ac9095c = Convert.FromBase64String(_0x13cd085f);
            using var _0xeef328cd = Aes.Create();
            _0xeef328cd.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x0902734a));
            var _0xf911993a = new byte[16];
            Buffer.BlockCopy(_0x5ac9095c, 0, _0xf911993a, 0, 16);
            _0xeef328cd.IV = _0xf911993a;
            using var _0xb6575f01 = new MemoryStream(_0x5ac9095c, 16, _0x5ac9095c.Length - 16);
            using var _0x36f537a1 = new CryptoStream(_0xb6575f01, _0xeef328cd.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0x89ac3c61 = new StreamReader(_0x36f537a1, Encoding.UTF8);
            return _0x89ac3c61.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private string _0x406f22ee { get; set; }

    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x93c108d4(string _0x5f815d25, string _0xc9ab62b2)
    {
        try
        {
            using var _0xfc208f98 = Aes.Create();
            _0xfc208f98.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xc9ab62b2));
            _0xfc208f98.GenerateIV();
            using var _0xac09ace9 = new MemoryStream();
            _0xac09ace9.Write(_0xfc208f98.IV, 0, _0xfc208f98.IV.Length);
            using (var _0x97cb7c8d = new CryptoStream(_0xac09ace9, _0xfc208f98.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0xbd6a5661 = Encoding.UTF8.GetBytes(_0x5f815d25);
                _0x97cb7c8d.Write(_0xbd6a5661, 0, _0xbd6a5661.Length);
                _0x97cb7c8d.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0xac09ace9.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    internal Vector2 lastSize = Vector2.zero;
    private string _0x98497db8;
    private void _0x49602e44(string _0x8d171543)
    {
        bool _0x23a9a583 = !string.IsNullOrEmpty(_0x8d171543);
        if (_0x23a9a583)
        {
            {
#if B_LOGS
                Debug.Log(_0x3491765a._0xbc716140(new byte[13] { 155, 148, 165, 179, 180, 157, 224, 147, 168, 175, 183, 250, 224 }, 192) + _0x8d171543);
#endif
            }

            _0x726d616d(_0x8d171543);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x3491765a._0xbc716140(new byte[39] { 39, 40, 25, 15, 8, 33, 92, 58, 29, 16, 16, 30, 29, 31, 23, 92, 158, 250, 238, 92, 59, 29, 17, 25, 92, 84, 18, 19, 92, 26, 21, 18, 29, 16, 92, 41, 46, 48, 85 }, 124));
#endif
            }

            _0xac43ce9b();
            return;
        }
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0xab6c5cfb()
    {
        var _0x7feebca9 = _0x3491765a._0xbc716140(new byte[40] { 82, 78, 78, 74, 73, 0, 21, 21, 77, 77, 77, 20, 89, 86, 85, 79, 94, 92, 86, 91, 72, 95, 20, 89, 85, 87, 21, 89, 94, 84, 23, 89, 93, 83, 21, 78, 72, 91, 89, 95 }, 58);
        using (UnityWebRequest _0xe75ba80a = UnityWebRequest.Get(_0x7feebca9))
        {
            await _0xe75ba80a.SendWebRequest();
            string[] _0xcc01d26f = _0xe75ba80a.downloadHandler.text.Split('\n');
            foreach (string _0x66c0a6cf in _0xcc01d26f)
            {
                if (_0x66c0a6cf.StartsWith(_0x3491765a._0xbc716140(new byte[3] { 79, 86, 27 }, 38)))
                {
                    string _0x178d2c23 = _0x66c0a6cf.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x178d2c23} from {_0x7feebca9}");
                        }
#endif
                    }

                    return _0x178d2c23;
                }
            }
        }

        return "";
    }

    private string _0x7d6e2124 = "";
    // WS_SOURCE MONO
    public static _0x7c55b980 _0x9ab4bb01 { get; private set; }

    private IEnumerator _0x38337e6c(string _0x0335530f)
    {
        if (_0x8d5c37a3 != null && _0xb5e80385)
            yield break;
        _0x8d5c37a3 = gameObject.AddComponent<UniWebView>();
        _0x088669be(_0x8d5c37a3);
        _0xb1cfce03(_0x8d5c37a3);
        _0x8d5c37a3.BackgroundColor = Color.clear;
        var _0xb27219dc = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0xbcdfe34b();
        yield return new WaitForEndOfFrame();
        _0xb5e80385 = true;
        _0x547c8b2d();
        _0x93e6be98(true);
        _0x45d091a1 = false;
        _0x4c75da0d = false;
        _0x09e95873.Clear();
        _0x4986d21e = -1;
        firstLoadShown = false;
        _0x8bf9bece = false;
        _0x531a739b = false;
        _0x8d5c37a3.SetUserAgent("");
        _0x2900b1ec = Time.realtimeSinceStartup;
        _0x8d5c37a3.Stop();
        _0x8d5c37a3.Load(_0x0335530f);
        _0x8d5c37a3.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x3491765a._0xbc716140(new byte[25] { 179, 159, 151, 144, 222, 169, 155, 156, 168, 151, 155, 137, 222, 183, 144, 151, 138, 151, 159, 146, 222, 173, 150, 145, 137 }, 254));
    }

    internal bool firstLoadShown = false;
    private bool _0x531a739b = false;
    private string _0x57c45ca6 = "";
    private bool _0x4c75da0d = false;
    private string _0x46cb6548 = "";
    private void _0xb1cfce03(UniWebView _0x9d7b0e5e)
    {
        if (_0xd95de150)
            return;
        _0xd95de150 = true;
        _0x9d7b0e5e.AddUrlScheme(_0x3491765a._0xbc716140(new byte[2] { 182, 165 }, 194));
        _0x9d7b0e5e.AddUrlScheme(_0x3491765a._0xbc716140(new byte[6] { 66, 69, 95, 78, 69, 95 }, 43));
        _0x9d7b0e5e.AddUrlScheme(_0x3491765a._0xbc716140(new byte[6] { 185, 181, 166, 191, 177, 160 }, 212));
        _0x9d7b0e5e.OnMessageReceived += (_0x20841a30, _0x2728e13f) =>
        {
            if (TryOpenExternalLikeChrome(_0x2728e13f.RawMessage))
            {
                _0x93e6be98(false);
                return;
            }
        };
        _0x9d7b0e5e.RegisterShouldHandleRequest(_0x87bcac96 =>
        {
            string _0x7ea8a477 = _0x87bcac96 != null ? _0x87bcac96.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x7ea8a477))
                return true;
            WLog(_0x3491765a._0xbc716140(new byte[21] { 240, 203, 204, 214, 207, 199, 235, 194, 205, 199, 207, 198, 241, 198, 210, 214, 198, 208, 215, 153, 131 }, 163) + _0x7ea8a477);
            if (TryOpenExternalLikeChrome(_0x7ea8a477))
            {
                _0x93e6be98(false);
                return false;
            }

            if (_0x87bcac96 != null && _0x87bcac96.IsMainFrame && IsGoogleAuthFlowUrl(_0x7ea8a477) && !_0x4c75da0d)
            {
                WLog(_0x3491765a._0xbc716140(new byte[62] { 185, 149, 157, 154, 212, 163, 145, 150, 162, 157, 145, 131, 212, 144, 145, 128, 145, 151, 128, 145, 144, 212, 179, 155, 155, 147, 152, 145, 212, 149, 129, 128, 156, 212, 161, 166, 184, 212, 217, 202, 212, 134, 145, 152, 155, 149, 144, 212, 131, 157, 128, 156, 212, 179, 155, 155, 147, 152, 145, 212, 161, 181 }, 244));
                _0x4c75da0d = true;
                _0x93e6be98(true);
                _0x8d5c37a3.SetUserAgent(_0xd89619bd());
                _0x8d5c37a3.Load(_0x7ea8a477);
                return false;
            }

            return true;
        });
        _0x9d7b0e5e.OnLoadingErrorReceived += (_0x20841a30, _0xddcd59ba, _0x2728e13f, _0x866d42f1) =>
        {
            WLog(_0x3491765a._0xbc716140(new byte[25] { 8, 36, 44, 43, 101, 18, 32, 39, 19, 44, 32, 50, 101, 0, 55, 55, 42, 55, 127, 101, 38, 42, 33, 32, 120 }, 69) + _0xddcd59ba + _0x3491765a._0xbc716140(new byte[9] { 192, 141, 133, 147, 147, 129, 135, 133, 221 }, 224) + _0x2728e13f);
            string _0x42c2c2e0 = GetFailingUrl(_0x866d42f1);
            if (string.IsNullOrEmpty(_0x42c2c2e0) || IsAboutBlank(_0x42c2c2e0))
                return;
            _ = _0x7fc01c8f(_0x3491765a._0xbc716140(new byte[8] { 253, 252, 213, 239, 248, 248, 229, 248 }, 138));
            WLog(_0x3491765a._0xbc716140(new byte[45] { 100, 72, 64, 71, 9, 126, 76, 75, 127, 64, 76, 94, 9, 79, 72, 64, 69, 64, 71, 78, 9, 124, 123, 101, 9, 4, 23, 9, 70, 89, 76, 71, 9, 76, 81, 93, 76, 91, 71, 72, 69, 69, 80, 19, 9 }, 41) + _0x42c2c2e0);
            StopCurrentFailedLoad(_0x20841a30);
            _0x082d130b(_0x42c2c2e0);
        };
        _0x9d7b0e5e.OnPageStarted += (_0x20841a30, _0x0b7ea4f8) =>
        {
            _0xe1da6e3b = 0;
            if (_0x45d091a1 && IsAboutBlank(_0x0b7ea4f8))
            {
                WLog(_0x3491765a._0xbc716140(new byte[27] { 112, 82, 69, 87, 65, 82, 77, 0, 65, 66, 79, 85, 84, 26, 66, 76, 65, 78, 75, 0, 83, 84, 65, 82, 84, 69, 68 }, 32));
                return;
            }

            WLog(_0x3491765a._0xbc716140(new byte[29] { 203, 231, 239, 232, 166, 209, 227, 228, 208, 239, 227, 241, 166, 201, 232, 214, 231, 225, 227, 213, 242, 231, 244, 242, 227, 226, 188, 166, 173 }, 134) + (Time.realtimeSinceStartup - _0x2900b1ec).ToString(_0x3491765a._0xbc716140(new byte[5] { 11, 21, 11, 11, 11 }, 59)) + _0x3491765a._0xbc716140(new byte[2] { 254, 173 }, 141) + _0x0b7ea4f8);
            if (TryOpenExternalLikeChrome(_0x0b7ea4f8))
            {
                StopCurrentFailedLoad(_0x20841a30);
                return;
            }

            if (ContainsIgnoreCase(_0x0b7ea4f8, _0x3491765a._0xbc716140(new byte[8] { 31, 18, 18, 26, 85, 26, 11, 11 }, 123)) || ContainsIgnoreCase(_0x0b7ea4f8, _0x3491765a._0xbc716140(new byte[15] { 170, 187, 163, 244, 173, 179, 190, 189, 191, 174, 244, 184, 182, 181, 189 }, 218)) || _0x0b7ea4f8.StartsWith(_0x3491765a._0xbc716140(new byte[25] { 193, 221, 221, 217, 218, 147, 134, 134, 203, 217, 206, 197, 198, 203, 200, 197, 207, 200, 223, 135, 197, 192, 223, 204, 134 }, 169), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x20841a30);
                OpenUrlExternally(_0x0b7ea4f8);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x0b7ea4f8))
            {
                _0x93e6be98(true);
                WLog(_0x3491765a._0xbc716140(new byte[41] { 195, 235, 235, 227, 232, 225, 164, 229, 241, 240, 236, 164, 226, 232, 235, 243, 164, 224, 225, 240, 225, 231, 240, 225, 224, 164, 169, 186, 164, 239, 225, 225, 244, 164, 242, 237, 247, 237, 230, 232, 225 }, 132));
                return;
            }

            _0x8bf9bece = true;
            _0x93e6be98(true);
            WLog(_0x3491765a._0xbc716140(new byte[43] { 90, 104, 111, 91, 100, 104, 122, 45, 97, 98, 108, 105, 100, 99, 106, 34, 127, 104, 105, 100, 127, 104, 110, 121, 100, 99, 106, 45, 32, 51, 45, 102, 104, 104, 125, 45, 123, 100, 126, 100, 111, 97, 104 }, 13));
        };
        _0x9d7b0e5e.OnPageCommitted += (_0x20841a30, _0x0b7ea4f8) =>
        {
            if (_0x45d091a1 && IsAboutBlank(_0x0b7ea4f8))
                return;
            WLog(_0x3491765a._0xbc716140(new byte[31] { 85, 121, 113, 118, 56, 79, 125, 122, 78, 113, 125, 111, 56, 87, 118, 72, 121, 127, 125, 91, 119, 117, 117, 113, 108, 108, 125, 124, 34, 56, 51 }, 24) + (Time.realtimeSinceStartup - _0x2900b1ec).ToString(_0x3491765a._0xbc716140(new byte[5] { 204, 210, 204, 204, 204 }, 252)) + _0x3491765a._0xbc716140(new byte[2] { 192, 147 }, 179) + _0x0b7ea4f8);
            if (!firstLoadShown && IsHttpUrl(_0x0b7ea4f8))
            {
                firstLoadShown = true;
                _0x8bf9bece = false;
                _0x93e6be98(false);
                _0x406e485b();
                _0xbcdfe34b();
                _0x20841a30.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x7fc01c8f(_0x3491765a._0xbc716140(new byte[9] { 123, 122, 83, 99, 124, 105, 98, 105, 104 }, 12));
                WLog(_0x3491765a._0xbc716140(new byte[39] { 111, 67, 75, 76, 2, 117, 71, 64, 116, 75, 71, 85, 2, 81, 74, 77, 85, 76, 2, 77, 76, 2, 65, 77, 79, 79, 75, 86, 86, 71, 70, 2, 65, 77, 76, 86, 71, 76, 86 }, 34));
            }
        };
        _0x9d7b0e5e.OnPageProgressChanged += (_0x20841a30, _0xa449ff38) =>
        {
            if (_0x45d091a1)
                return;
            if (!firstLoadShown && _0xa449ff38 >= 0.65f)
            {
                firstLoadShown = true;
                _0x8bf9bece = false;
                _0x93e6be98(false);
                _0x406e485b();
                _0xbcdfe34b();
                _0x20841a30.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x7fc01c8f(_0x3491765a._0xbc716140(new byte[9] { 175, 174, 135, 183, 168, 189, 182, 189, 188 }, 216));
                WLog(_0x3491765a._0xbc716140(new byte[32] { 93, 113, 121, 126, 48, 71, 117, 114, 70, 121, 117, 103, 48, 99, 120, 127, 103, 126, 48, 114, 105, 48, 96, 98, 127, 119, 98, 117, 99, 99, 42, 48 }, 16) + _0xa449ff38);
            }
        };
        _0x9d7b0e5e.OnPageFinished += (_0x20841a30, _0xddcd59ba, _0x0b7ea4f8) =>
        {
            if (_0x45d091a1 && IsAboutBlank(_0x0b7ea4f8))
            {
                _0x45d091a1 = false;
                WLog(_0x3491765a._0xbc716140(new byte[28] { 28, 62, 41, 59, 45, 62, 33, 108, 45, 46, 35, 57, 56, 118, 46, 32, 45, 34, 39, 108, 42, 37, 34, 37, 63, 36, 41, 40 }, 76));
                return;
            }

            WLog(_0x3491765a._0xbc716140(new byte[24] { 41, 5, 13, 10, 68, 51, 1, 6, 50, 13, 1, 19, 68, 34, 13, 10, 13, 23, 12, 1, 0, 94, 68, 79 }, 100) + (Time.realtimeSinceStartup - _0x2900b1ec).ToString(_0x3491765a._0xbc716140(new byte[5] { 10, 20, 10, 10, 10 }, 58)) + _0x3491765a._0xbc716140(new byte[7] { 51, 96, 35, 47, 36, 37, 125 }, 64) + _0xddcd59ba + _0x3491765a._0xbc716140(new byte[5] { 8, 93, 90, 68, 21 }, 40) + _0x0b7ea4f8);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x8bf9bece = false;
                _0x93e6be98(false);
                _0x406e485b();
                _0xbcdfe34b();
                _0x20841a30.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x7fc01c8f(_0x3491765a._0xbc716140(new byte[9] { 223, 222, 247, 199, 216, 205, 198, 205, 204 }, 168));
                WLog(_0x3491765a._0xbc716140(new byte[33] { 44, 0, 8, 15, 65, 54, 4, 3, 55, 8, 4, 22, 65, 7, 8, 19, 18, 21, 65, 13, 14, 0, 5, 65, 2, 14, 12, 17, 13, 4, 21, 4, 5 }, 97));
            }
            else if (_0x8bf9bece)
            {
                _0x8bf9bece = false;
                _0x93e6be98(false);
                _0x20841a30.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x3491765a._0xbc716140(new byte[40] { 196, 232, 224, 231, 169, 222, 236, 235, 223, 224, 236, 254, 169, 218, 225, 230, 254, 169, 232, 239, 253, 236, 251, 169, 229, 230, 232, 237, 224, 231, 238, 169, 239, 224, 231, 224, 250, 225, 236, 237 }, 137));
            }
            else
            {
                _0x93e6be98(false);
            }

            if (_0x4c75da0d && !IsGoogleAuthFlowUrl(_0x0b7ea4f8) && !IsGoogleAuthFlowUrl(_0x0b7ea4f8))
            {
                WLog(_0x3491765a._0xbc716140(new byte[48] { 178, 154, 154, 146, 153, 144, 213, 148, 128, 129, 157, 213, 134, 144, 144, 152, 134, 213, 147, 156, 155, 156, 134, 157, 144, 145, 213, 216, 203, 213, 135, 144, 134, 129, 154, 135, 144, 213, 145, 144, 147, 148, 128, 153, 129, 213, 160, 180 }, 245));
                _0x4c75da0d = false;
                _0x8d5c37a3.SetUserAgent("");
            }
        };
        _0x9d7b0e5e.OnShouldClose += _0x20841a30 =>
        {
            WLog(_0x3491765a._0xbc716140(new byte[41] { 233, 230, 215, 193, 198, 239, 146, 255, 211, 219, 220, 146, 229, 215, 208, 228, 219, 215, 197, 146, 253, 220, 225, 218, 221, 199, 222, 214, 241, 222, 221, 193, 215, 146, 219, 220, 196, 221, 217, 215, 214 }, 178));
            _0x8cd13c7f();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x9d7b0e5e.SetPopupPageEventEnabled(true);
        bool _0x5add05cd = false;
        bool _0x82e21d55 = false;
        _0x9d7b0e5e.OnMultipleWindowOpened += (_0x20841a30, _0xa673c7ae) =>
        {
            _0x20841a30.ScrollTo(0, 0, false);
            WLog(_0x3491765a._0xbc716140(new byte[43] { 240, 255, 206, 216, 223, 246, 139, 230, 202, 194, 197, 139, 252, 206, 201, 253, 194, 206, 220, 139, 230, 222, 199, 223, 194, 219, 199, 206, 252, 194, 197, 207, 196, 220, 139, 228, 219, 206, 197, 206, 207, 145, 139 }, 171) + _0xa673c7ae);
            var _0x07d98fcf = _0x9d7b0e5e.GetPopupWindow(_0xa673c7ae);
            if (_0x07d98fcf == null)
                return;
            _0x09e95873.Add(_0x07d98fcf);
            Debug.Log($"[Test] Popup ID: {_0x07d98fcf.Id}");
            _0x07d98fcf.OnPageStarted += (_0x9e6bd995, _0x0b7ea4f8) =>
            {
                WLog(_0x3491765a._0xbc716140(new byte[36] { 181, 186, 139, 157, 154, 179, 206, 190, 129, 158, 155, 158, 206, 185, 139, 140, 184, 135, 139, 153, 206, 161, 128, 190, 143, 137, 139, 189, 154, 143, 156, 154, 139, 138, 212, 206 }, 238) + _0x0b7ea4f8);
                _0xe1da6e3b = 0;
                if (string.IsNullOrEmpty(_0x0b7ea4f8) || IsAboutBlank(_0x0b7ea4f8))
                    return;
                if (IsGoogleAuthFlowUrl(_0x0b7ea4f8))
                {
                    WLog(_0x3491765a._0xbc716140(new byte[57] { 78, 65, 112, 102, 97, 72, 53, 69, 122, 101, 96, 101, 53, 82, 122, 122, 114, 121, 112, 53, 116, 96, 97, 125, 53, 115, 121, 122, 98, 53, 56, 43, 53, 102, 101, 122, 122, 115, 53, 82, 122, 122, 114, 121, 112, 53, 86, 125, 103, 122, 120, 112, 53, 64, 84, 47, 53 }, 21) + _0x0b7ea4f8);
                    _0x5add05cd = false;
                    _0x5df66c78();
                    if (_0x9e6bd995 != null && _0x9e6bd995.IsAlive)
                        _0x9e6bd995.EvaluateJavaScript(_0xfc37461f());
                    return;
                }

                if (_0x8d5c37a3 == null)
                    return;
                if (!_0x5add05cd)
                {
                    _0x5add05cd = true;
                    _0x8d5c37a3.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x3491765a._0xbc716140(new byte[39] { 85, 90, 107, 125, 122, 83, 46, 94, 97, 126, 123, 126, 46, 111, 126, 126, 98, 119, 46, 89, 103, 96, 106, 97, 121, 125, 46, 106, 107, 125, 101, 122, 97, 126, 46, 91, 79, 52, 46 }, 14) + _0x0b7ea4f8);
                }

                if (_0x9e6bd995 != null && _0x9e6bd995.IsAlive)
                    _0x9e6bd995.EvaluateJavaScript(_0xb9155443());
                if (!_0x82e21d55 && _0x9e6bd995 != null && _0x9e6bd995.IsAlive && IsHttpUrl(_0x0b7ea4f8))
                {
                    _0x82e21d55 = true;
                }
            };
            _0x07d98fcf.OnPageFinished += (_0x9e6bd995, _0x866d42f1) =>
            {
                string _0x92f21716 = _0x866d42f1 != null ? _0x866d42f1.data : string.Empty;
                WLog(_0x3491765a._0xbc716140(new byte[35] { 149, 154, 171, 189, 186, 147, 238, 158, 161, 190, 187, 190, 238, 153, 171, 172, 152, 167, 171, 185, 238, 136, 167, 160, 167, 189, 166, 171, 170, 244, 238, 187, 188, 162, 243 }, 206) + _0x92f21716);
                if (_0x9e6bd995 == null || !_0x9e6bd995.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x92f21716))
                {
                    _0x5df66c78();
                    _0x9e6bd995.EvaluateJavaScript(_0xfc37461f());
                    return;
                }

                if (!_0x5add05cd)
                    return;
                _0x9e6bd995.EvaluateJavaScript(_0xb9155443());
            };
        };
        _0x9d7b0e5e.OnMultipleWindowClosed += (_0x20841a30, _0xa673c7ae) =>
        {
            _0x09e95873.RemoveAll(_0xe9b7512b => _0xe9b7512b == null || _0xe9b7512b.Id == _0xa673c7ae || !_0xe9b7512b.IsAlive);
            _0x93e6be98(false);
            if (_0x09e95873.Count == 0 && _0x8d5c37a3 != null)
            {
                _0x5add05cd = false;
                _0x82e21d55 = false;
                _0x09cde434();
            }

            WLog(_0x3491765a._0xbc716140(new byte[43] { 23, 24, 41, 63, 56, 17, 108, 1, 45, 37, 34, 108, 27, 41, 46, 26, 37, 41, 59, 108, 1, 57, 32, 56, 37, 60, 32, 41, 27, 37, 34, 40, 35, 59, 108, 15, 32, 35, 63, 41, 40, 118, 108 }, 76) + _0xa673c7ae);
        };
        _0x9d7b0e5e.RegisterOnRequestMediaCapturePermission(_0x87bcac96 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    internal string _0x8b3e3380(string _0xf5b142f8)
    {
        int _0x778e2df2 = _0xf5b142f8.IndexOf(_0x3491765a._0xbc716140(new byte[3] { 32, 45, 116 }, 73), StringComparison.OrdinalIgnoreCase);
        if (_0x778e2df2 < 0)
            return null;
        string _0x5c5e7849 = _0xf5b142f8.Substring(_0x778e2df2 + 3);
        int _0x516c3593 = _0x5c5e7849.IndexOf('&');
        return _0x516c3593 >= 0 ? _0x5c5e7849.Substring(0, _0x516c3593) : _0x5c5e7849;
    }

    internal bool isApplicationPause = false;
    private string _0x09b6630b = "";
    private bool _0xa1d00b9d = false;
    private void _0x088669be(UniWebView _0x89340196)
    {
        _0x89340196.BackgroundColor = Color.clear;
        _0x89340196.SetSupportMultipleWindows(true, true);
        _0x89340196.SetBackButtonEnabled(false);
        _0x8d5c37a3.SetUserAgent(_0xd89619bd());
    }

    private bool _0x6568385c = false;
    internal bool isApplicationFocus = false;
    private IEnumerator _0x6d4fd975()
    {
        yield return _0xf74d7fc7(Permission.Camera);
    }

    private float _0x2900b1ec = 0f;
    private string _0x922c57f1 = "";
    private int _0x4986d21e = -1;
    private async Task _0x638169fe()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x7d6e2124 = _0x3491765a._0xbc716140(new byte[5] { 55, 48, 61, 34, 52 }, 81);
        _0x1e3f0912 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x616dc027 = DateTime.UtcNow.Ticks.ToString();
        _0x3a858cc8 = "";
        JObject _0xf3b7e58a = _0xf3c26f66(_0x306710f0, _0x69e2bf7c, _0x2f2b91b8, _0x50c2f798, _0x528738ec, _0x167c4fd6, _0x406f22ee, _0xc1ffb983, _0xeca08a3a, _0xd5f50f6c, _0x7d6e2124, _0x3a858cc8, _0x57c45ca6, _0x08cdaa66, _0xcad4d087.ToString(), _0x922c57f1, _0x616dc027, _0x1e3f0912, _0x09b6630b, _0x5e5aac4b, _0x9c33ef27, _0x46cb6548, _0x64d280ea());
        var _0x3fe4654b = _0x93c108d4(_0xf3b7e58a.ToString(), _0x09b6630b);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0xf3b7e58a}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x3491765a._0xbc716140(new byte[7] { 209, 192, 216, 205, 206, 192, 197 }, 161) + _0x09b6630b, _0x3fe4654b } });
            await Task.Delay(500);
            string _0x773b76db = "";
            for (int _0xbc49634d = 0; _0xbc49634d < 20; _0xbc49634d++)
            {
                if (await _0x8ea624e9(1, 1))
                {
                    await _0x7fc01c8f(_0x3491765a._0xbc716140(new byte[7] { 142, 128, 131, 143, 135, 137, 136 }, 236));
                    _0xac43ce9b();
                    return;
                }

                _0x773b76db = await _0xc96f54f7(1, 500);
                if (!string.IsNullOrEmpty(_0x773b76db))
                    break;
            }

            _0x49602e44(_0x773b76db);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x3491765a._0xbc716140(new byte[22] { 49, 62, 47, 57, 62, 55, 74, 45, 15, 4, 15, 24, 11, 6, 74, 15, 24, 24, 5, 24, 80, 74 }, 106) + e.Message);
#endif
            }

            _0xac43ce9b();
        }
    }

    private Task _0xb2e9910b(IEnumerator _0x4593677d)
    {
        var _0x270d9381 = new TaskCompletionSource<bool>();
        StartCoroutine(_0x503c9c19(_0x4593677d, _0x270d9381));
        return _0x270d9381.Task;
    }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0x8d5c37a3 = null;
    private bool _0xd3e4a450()
    {
        var _0x637c635c = Keyboard.current;
        return _0x637c635c != null && _0x637c635c.escapeKey.wasPressedThisFrame;
    }

    private string _0x306710f0 = "";
    internal bool ContainsIgnoreCase(string _0xba6ba24d, string _0x15f4de93)
    {
        if (string.IsNullOrEmpty(_0xba6ba24d) || string.IsNullOrEmpty(_0x15f4de93))
            return false;
        return _0xba6ba24d.IndexOf(_0x15f4de93, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private void StopCurrentFailedLoad(UniWebView _0x66140ede)
    {
        _0x93e6be98(false);
        if (_0x66140ede == null)
            return;
        _0x66140ede.Stop();
        if (_0x66140ede.CanGoBack)
            _0x66140ede.GoBack();
    }

    private bool _0x28acf5b7()
    {
        _0x09e95873.RemoveAll(_0xe9b7512b => _0xe9b7512b == null || !_0xe9b7512b.IsAlive);
        return _0x09e95873.Count > 0;
    }

    private bool _0xab833561(string _0x32a15911)
    {
        if (string.IsNullOrEmpty(_0x32a15911))
            return false;
        try
        {
            using (var _0xe59df8f1 = new AndroidJavaClass(_0x3491765a._0xbc716140(new byte[30] { 177, 189, 191, 252, 167, 188, 187, 166, 171, 225, 182, 252, 162, 190, 179, 171, 183, 160, 252, 135, 188, 187, 166, 171, 130, 190, 179, 171, 183, 160 }, 210)))
            using (var _0x427eb31e = _0xe59df8f1.GetStatic<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[15] { 94, 72, 79, 79, 88, 83, 73, 124, 94, 73, 84, 75, 84, 73, 68 }, 61)))
            using (var _0x21657cfc = _0x427eb31e.Call<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[17] { 242, 240, 225, 197, 244, 246, 254, 244, 242, 240, 216, 244, 251, 244, 242, 240, 231 }, 149)))
            using (var _0x3a377bea = _0x21657cfc.Call<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[25] { 59, 57, 40, 16, 61, 41, 50, 63, 52, 21, 50, 40, 57, 50, 40, 26, 51, 46, 12, 61, 63, 55, 61, 59, 57 }, 92), _0x32a15911))
            {
                if (_0x3a377bea == null)
                    return false;
                WLog(_0x3491765a._0xbc716140(new byte[37] { 127, 84, 78, 83, 81, 89, 112, 85, 87, 89, 28, 80, 93, 73, 82, 95, 84, 28, 85, 82, 79, 72, 93, 80, 80, 89, 88, 28, 76, 93, 95, 87, 93, 91, 89, 6, 28 }, 60) + _0x32a15911);
                _0x3a377bea.Call<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[8] { 14, 11, 11, 41, 3, 14, 8, 28 }, 111), 0x10000000);
                _0x427eb31e.Call(_0x3491765a._0xbc716140(new byte[13] { 80, 87, 66, 81, 87, 98, 64, 87, 74, 85, 74, 87, 90 }, 35), _0x3a377bea);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private string _0x7cc7bea5()
    {
        string _0x1b83d808 = _0x3491765a._0xbc716140(new byte[62] { 72, 75, 74, 77, 76, 79, 78, 65, 64, 67, 66, 69, 68, 71, 70, 89, 88, 91, 90, 93, 92, 95, 94, 81, 80, 83, 104, 107, 106, 109, 108, 111, 110, 97, 96, 99, 98, 101, 100, 103, 102, 121, 120, 123, 122, 125, 124, 127, 126, 113, 112, 115, 25, 24, 27, 26, 29, 28, 31, 30, 17, 16 }, 41);
        System.Random _0x67962042 = new System.Random();
        int _0x9a3a9019 = _0x67962042.Next(8, 16);
        return new string (Enumerable.Repeat(_0x1b83d808, _0x9a3a9019).Select(_0xada3c300 => _0xada3c300[_0x67962042.Next(_0xada3c300.Length)]).ToArray());
    }

    private string _0x08cdaa66 = "";
    private void _0x09cde434()
    {
        if (_0x8d5c37a3 == null)
            return;
        if (_0x4c75da0d)
            _0x8d5c37a3.SetUserAgent(_0xd89619bd());
        else
            _0x8d5c37a3.SetUserAgent("");
    }

    private string _0xfc37461f()
    {
        string _0x0a288fa6 = _0xd89619bd();
        if (string.IsNullOrEmpty(_0x0a288fa6))
            return _0x3491765a._0xbc716140(new byte[7] { 61, 36, 34, 47, 107, 123, 112 }, 75);
        string _0xfea485cf = _0x0a288fa6.Replace(_0x3491765a._0xbc716140(new byte[1] { 234 }, 182), _0x3491765a._0xbc716140(new byte[2] { 86, 86 }, 10)).Replace(_0x3491765a._0xbc716140(new byte[1] { 220 }, 251), _0x3491765a._0xbc716140(new byte[2] { 200, 179 }, 148));
        var _0x920e3c1b = Regex.Match(_0x0a288fa6, _0x3491765a._0xbc716140(new byte[12] { 235, 192, 218, 199, 197, 205, 135, 128, 244, 204, 131, 129 }, 168));
        string _0x9d79e85e = _0x920e3c1b.Success ? _0x920e3c1b.Groups[1].Value : _0x3491765a._0xbc716140(new byte[3] { 238, 237, 239 }, 223);
        return _0x3491765a._0xbc716140(new byte[12] { 143, 193, 210, 201, 196, 211, 206, 200, 201, 143, 142, 220 }, 167) + _0x3491765a._0xbc716140(new byte[8] { 61, 42, 57, 107, 62, 42, 118, 108 }, 75) + _0xfea485cf + _0x3491765a._0xbc716140(new byte[2] { 37, 57 }, 2) + _0x3491765a._0xbc716140(new byte[30] { 0, 23, 4, 86, 6, 4, 25, 2, 25, 75, 56, 23, 0, 31, 17, 23, 2, 25, 4, 88, 6, 4, 25, 2, 25, 2, 15, 6, 19, 77 }, 118) + _0x3491765a._0xbc716140(new byte[121] { 64, 83, 72, 69, 82, 79, 73, 72, 6, 66, 67, 64, 14, 73, 68, 76, 10, 77, 67, 95, 10, 80, 71, 74, 15, 93, 82, 84, 95, 93, 105, 68, 76, 67, 69, 82, 8, 66, 67, 64, 79, 72, 67, 118, 84, 73, 86, 67, 84, 82, 95, 14, 73, 68, 76, 10, 77, 67, 95, 10, 93, 65, 67, 82, 28, 64, 83, 72, 69, 82, 79, 73, 72, 14, 15, 93, 84, 67, 82, 83, 84, 72, 6, 80, 71, 74, 29, 91, 10, 69, 73, 72, 64, 79, 65, 83, 84, 71, 68, 74, 67, 28, 82, 84, 83, 67, 91, 15, 29, 91, 69, 71, 82, 69, 78, 14, 67, 15, 93, 91, 91 }, 38) + _0x3491765a._0xbc716140(new byte[26] { 212, 213, 214, 152, 192, 194, 223, 196, 223, 156, 151, 197, 195, 213, 194, 241, 215, 213, 222, 196, 151, 156, 197, 209, 153, 139 }, 176) + _0x3491765a._0xbc716140(new byte[52] { 242, 243, 240, 190, 230, 228, 249, 226, 249, 186, 177, 247, 230, 230, 192, 243, 228, 229, 255, 249, 248, 177, 186, 227, 247, 184, 228, 243, 230, 250, 247, 245, 243, 190, 185, 200, 219, 249, 236, 255, 250, 250, 247, 202, 185, 185, 186, 177, 177, 191, 191, 173 }, 150) + _0x3491765a._0xbc716140(new byte[37] { 172, 173, 174, 224, 184, 186, 167, 188, 167, 228, 239, 184, 164, 169, 188, 174, 167, 186, 165, 239, 228, 239, 132, 161, 166, 189, 176, 232, 169, 186, 165, 190, 240, 164, 239, 225, 243 }, 200) + _0x3491765a._0xbc716140(new byte[34] { 84, 85, 86, 24, 64, 66, 95, 68, 95, 28, 23, 70, 85, 94, 84, 95, 66, 23, 28, 23, 119, 95, 95, 87, 92, 85, 16, 121, 94, 83, 30, 23, 25, 11 }, 48) + _0x3491765a._0xbc716140(new byte[30] { 222, 223, 220, 146, 202, 200, 213, 206, 213, 150, 157, 215, 219, 194, 238, 213, 207, 217, 210, 234, 213, 211, 212, 206, 201, 157, 150, 143, 147, 129 }, 186) + _0x3491765a._0xbc716140(new byte[48] { 27, 29, 22, 20, 25, 14, 29, 79, 26, 14, 11, 82, 20, 13, 29, 14, 1, 11, 28, 85, 52, 20, 13, 29, 14, 1, 11, 85, 72, 44, 7, 29, 0, 2, 6, 26, 2, 72, 67, 25, 10, 29, 28, 6, 0, 1, 85, 72 }, 111) + _0x9d79e85e + _0x3491765a._0xbc716140(new byte[35] { 217, 131, 210, 133, 156, 140, 159, 144, 154, 196, 217, 185, 145, 145, 153, 146, 155, 222, 189, 150, 140, 145, 147, 155, 217, 210, 136, 155, 140, 141, 151, 145, 144, 196, 217 }, 254) + _0x9d79e85e + _0x3491765a._0xbc716140(new byte[238] { 111, 53, 100, 51, 42, 58, 41, 38, 44, 114, 111, 6, 39, 60, 117, 9, 119, 10, 58, 41, 38, 44, 111, 100, 62, 45, 58, 59, 33, 39, 38, 114, 111, 122, 124, 111, 53, 21, 100, 37, 39, 42, 33, 36, 45, 114, 60, 58, 61, 45, 100, 56, 36, 41, 60, 46, 39, 58, 37, 114, 111, 9, 38, 44, 58, 39, 33, 44, 111, 100, 47, 45, 60, 0, 33, 47, 32, 13, 38, 60, 58, 39, 56, 49, 30, 41, 36, 61, 45, 59, 114, 46, 61, 38, 43, 60, 33, 39, 38, 96, 97, 51, 58, 45, 60, 61, 58, 38, 104, 24, 58, 39, 37, 33, 59, 45, 102, 58, 45, 59, 39, 36, 62, 45, 96, 51, 41, 58, 43, 32, 33, 60, 45, 43, 60, 61, 58, 45, 114, 111, 41, 58, 37, 111, 100, 42, 33, 60, 38, 45, 59, 59, 114, 111, 126, 124, 111, 100, 37, 39, 42, 33, 36, 45, 114, 60, 58, 61, 45, 100, 37, 39, 44, 45, 36, 114, 111, 111, 100, 56, 36, 41, 60, 46, 39, 58, 37, 114, 111, 9, 38, 44, 58, 39, 33, 44, 111, 100, 56, 36, 41, 60, 46, 39, 58, 37, 30, 45, 58, 59, 33, 39, 38, 114, 111, 121, 124, 102, 120, 102, 120, 111, 100, 61, 41, 14, 61, 36, 36, 30, 45, 58, 59, 33, 39, 38, 114, 111 }, 72) + _0x9d79e85e + _0x3491765a._0xbc716140(new byte[117] { 159, 129, 159, 129, 159, 129, 150, 204, 152, 138, 204, 204, 138, 254, 211, 219, 212, 210, 197, 159, 213, 212, 215, 216, 223, 212, 225, 195, 222, 193, 212, 195, 197, 200, 153, 193, 195, 222, 197, 222, 157, 150, 196, 194, 212, 195, 240, 214, 212, 223, 197, 245, 208, 197, 208, 150, 157, 202, 214, 212, 197, 139, 215, 196, 223, 210, 197, 216, 222, 223, 153, 152, 202, 195, 212, 197, 196, 195, 223, 145, 196, 208, 213, 138, 204, 157, 210, 222, 223, 215, 216, 214, 196, 195, 208, 211, 221, 212, 139, 197, 195, 196, 212, 204, 152, 138, 204, 210, 208, 197, 210, 217, 153, 212, 152, 202, 204 }, 177) + _0x3491765a._0xbc716140(new byte[5] { 23, 67, 66, 67, 81 }, 106);
    }

    private bool _0xe513613d(string _0x1397e045)
    {
        try
        {
            using (var _0x5d25066f = new AndroidJavaClass(_0x3491765a._0xbc716140(new byte[30] { 217, 213, 215, 148, 207, 212, 211, 206, 195, 137, 222, 148, 202, 214, 219, 195, 223, 200, 148, 239, 212, 211, 206, 195, 234, 214, 219, 195, 223, 200 }, 186)))
            using (var _0x713246ba = _0x5d25066f.GetStatic<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[15] { 28, 10, 13, 13, 26, 17, 11, 62, 28, 11, 22, 9, 22, 11, 6 }, 127)))
            using (var _0x995192b3 = _0x713246ba.Call<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[17] { 141, 143, 158, 186, 139, 137, 129, 139, 141, 143, 167, 139, 132, 139, 141, 143, 152 }, 234)))
            using (var _0x92b9ccbf = new AndroidJavaClass(_0x3491765a._0xbc716140(new byte[22] { 197, 202, 192, 214, 203, 205, 192, 138, 199, 203, 202, 208, 193, 202, 208, 138, 237, 202, 208, 193, 202, 208 }, 164)))
            using (var _0xc68b5361 = _0x92b9ccbf.CallStatic<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[8] { 8, 25, 10, 11, 29, 45, 10, 17 }, 120), _0x1397e045, 1))
            {
                string _0x8c5d7a34 = _0xc68b5361.Call<string>(_0x3491765a._0xbc716140(new byte[14] { 79, 77, 92, 123, 92, 90, 65, 70, 79, 109, 80, 92, 90, 73 }, 40), _0x3491765a._0xbc716140(new byte[20] { 198, 214, 203, 211, 215, 193, 214, 251, 194, 197, 200, 200, 198, 197, 199, 207, 251, 209, 214, 200 }, 164));
                string _0x197e5e6e = _0xc68b5361.Call<string>(_0x3491765a._0xbc716140(new byte[10] { 133, 135, 150, 178, 131, 129, 137, 131, 133, 135 }, 226));
                _0xc68b5361.Call<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[11] { 139, 142, 142, 169, 139, 158, 143, 141, 133, 152, 147 }, 234), _0x3491765a._0xbc716140(new byte[33] { 91, 84, 94, 72, 85, 83, 94, 20, 83, 84, 78, 95, 84, 78, 20, 89, 91, 78, 95, 93, 85, 72, 67, 20, 120, 104, 117, 109, 105, 123, 120, 118, 127 }, 58));
                _0xc68b5361.Call<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[11] { 76, 91, 83, 81, 72, 91, 123, 70, 74, 76, 95 }, 62), _0x3491765a._0xbc716140(new byte[20] { 3, 19, 14, 22, 18, 4, 19, 62, 7, 0, 13, 13, 3, 0, 2, 10, 62, 20, 19, 13 }, 97));
                if (_0xc68b5361.Call<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[15] { 217, 206, 216, 196, 199, 221, 206, 234, 200, 223, 194, 221, 194, 223, 210 }, 171), _0x995192b3) != null)
                {
                    WLog(_0x3491765a._0xbc716140(new byte[24] { 185, 146, 136, 149, 151, 159, 182, 147, 145, 159, 218, 149, 138, 159, 148, 218, 147, 148, 142, 159, 148, 142, 192, 218 }, 250) + _0x1397e045);
                    _0xc68b5361.Call<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[8] { 195, 198, 198, 228, 206, 195, 197, 209 }, 162), 0x10000000);
                    _0x713246ba.Call(_0x3491765a._0xbc716140(new byte[13] { 130, 133, 144, 131, 133, 176, 146, 133, 152, 135, 152, 133, 136 }, 241), _0xc68b5361);
                    return true;
                }

                if (_0xab833561(_0x197e5e6e))
                    return true;
                if (!string.IsNullOrEmpty(_0x8c5d7a34))
                {
                    WLog(_0x3491765a._0xbc716140(new byte[28] { 195, 232, 242, 239, 237, 229, 204, 233, 235, 229, 160, 233, 238, 244, 229, 238, 244, 160, 230, 225, 236, 236, 226, 225, 227, 235, 186, 160 }, 128) + _0x8c5d7a34);
                    if (_0xc85283d3(_0x8c5d7a34))
                        return _0xe95757c4(_0x8c5d7a34, _0x197e5e6e);
                    return _0xe02ca16b(_0x8c5d7a34);
                }

                WLog(_0x3491765a._0xbc716140(new byte[30] { 39, 12, 22, 11, 9, 1, 40, 13, 15, 1, 68, 13, 10, 16, 1, 10, 16, 68, 10, 11, 68, 12, 5, 10, 0, 8, 1, 22, 94, 68 }, 100) + _0x1397e045);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x3491765a._0xbc716140(new byte[26] { 174, 133, 159, 130, 128, 136, 161, 132, 134, 136, 205, 132, 131, 153, 136, 131, 153, 205, 139, 140, 132, 129, 136, 137, 215, 205 }, 237) + e.Message);
            return true;
        }
    }

    private bool _0x8bf9bece = false;
    // WEB VIEW LOGIC END
    internal void _0xafee2687()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x168635f3 = new AndroidNotificationChannel
        {
            Id = _0x3491765a._0xbc716140(new byte[15] { 192, 193, 194, 197, 209, 200, 208, 251, 199, 204, 197, 202, 202, 193, 200 }, 164),
            Name = _0x3491765a._0xbc716140(new byte[15] { 185, 152, 155, 156, 136, 145, 137, 221, 190, 149, 156, 147, 147, 152, 145 }, 253),
            Importance = Importance.High,
            Description = _0x3491765a._0xbc716140(new byte[21] { 8, 42, 33, 42, 61, 46, 35, 111, 33, 32, 59, 38, 41, 38, 44, 46, 59, 38, 32, 33, 60 }, 79)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x168635f3);
        // Build notification
        var _0x5b117420 = new AndroidNotification
        {
            Title = _0x8ee71bbb[UnityEngine.Random.Range(0, _0x8ee71bbb.Length)],
            Text = _0x3491765a._0xbc716140(new byte[21] { 109, 94, 73, 12, 85, 67, 89, 12, 95, 89, 94, 73, 12, 88, 67, 12, 73, 84, 69, 88, 19 }, 44),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x5b117420, _0x3491765a._0xbc716140(new byte[15] { 163, 162, 161, 166, 178, 171, 179, 152, 164, 175, 166, 169, 169, 162, 171 }, 199));
    }

    private Canvas _0x17cfd06c;
    private string _0x528738ec = "";
    private static bool IsPrivacyItemTrue(Item _0xde22a3ac)
    {
        if (_0xde22a3ac.Key != _0x3491765a._0xbc716140(new byte[9] { 209, 203, 232, 202, 209, 206, 217, 219, 193 }, 184))
            return false;
        try
        {
            var _0xa2a884b0 = _0xde22a3ac.Value.GetAs<object>();
            return _0xa2a884b0 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private IEnumerator _0xd9980a86()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x3491765a._0xbc716140(new byte[26] { 102, 105, 88, 78, 73, 96, 29, 116, 83, 84, 73, 84, 92, 81, 84, 71, 88, 111, 88, 91, 91, 88, 79, 88, 79, 29 }, 61));
            }
#endif
        }

        bool _0x1c98744e = false;
        InstallReferrer.GetReferrer((_0x79cf06df) =>
        {
            Debug.Log(_0x3491765a._0xbc716140(new byte[24] { 40, 39, 22, 0, 7, 83, 33, 22, 21, 22, 1, 1, 22, 1, 46, 83, 20, 22, 7, 83, 145, 245, 225, 83 }, 115) + _0x528738ec);
            if (_0x79cf06df.IsSuccess)
            {
                _0x528738ec = _0x79cf06df.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x3491765a._0xbc716140(new byte[28] { 62, 49, 0, 22, 17, 69, 55, 0, 3, 0, 23, 23, 0, 23, 56, 69, 54, 16, 6, 6, 0, 22, 22, 69, 135, 227, 247, 69 }, 101) + _0x528738ec);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x3491765a._0xbc716140(new byte[27] { 250, 245, 196, 210, 213, 129, 243, 196, 199, 196, 211, 211, 196, 211, 252, 129, 231, 192, 200, 205, 196, 197, 129, 67, 39, 51, 129 }, 161) + _0x79cf06df);
#endif
                }

                _0x528738ec = "";
            }

            _0x62e8e93b = true;
        });
        StartCoroutine(_0xa4555d41(2f));
        yield return new WaitUntil(() => _0x62e8e93b);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x528738ec}");
#endif
        }

        bool _0xc8c3261b = _0x528738ec.Contains(_0x3491765a._0xbc716140(new byte[6] { 171, 175, 160, 165, 168, 241 }, 204));
        _0x1c98744e = _0xc8c3261b || _0x528738ec.Contains(_0x3491765a._0xbc716140(new byte[18] { 17, 0, 0, 3, 94, 25, 30, 3, 4, 17, 23, 2, 17, 29, 94, 19, 31, 29 }, 112)) || _0x528738ec.Contains(_0x3491765a._0xbc716140(new byte[17] { 184, 169, 169, 170, 247, 191, 184, 186, 188, 187, 182, 182, 178, 247, 186, 182, 180 }, 217));
        _0x167c4fd6 = _0xc8c3261b ? "" : (_0x1c98744e ? "" : _0x167c4fd6);
        _0x167c4fd6 = _0x167c4fd6 ?? "";
        _0x406f22ee = _0x406f22ee ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x167c4fd6}");
#endif
        }
    }

    private void _0x93f75e22()
    {
        if (_0x531a739b)
        {
            WLog(_0x3491765a._0xbc716140(new byte[18] { 51, 14, 31, 2, 86, 23, 26, 4, 19, 23, 18, 15, 86, 5, 30, 25, 1, 24 }, 118));
            return;
        }

        _0x93e6be98(false);
        WLog(_0x3491765a._0xbc716140(new byte[46] { 146, 190, 182, 177, 255, 136, 186, 189, 137, 182, 186, 168, 255, 143, 170, 172, 183, 255, 145, 176, 171, 182, 185, 182, 188, 190, 171, 182, 176, 177, 255, 247, 183, 190, 173, 187, 168, 190, 173, 186, 255, 189, 190, 188, 180, 246 }, 223));
        ++_0xe1da6e3b;
        _0xafee2687();
        if (_0xe1da6e3b <= 1)
            return;
        if (_0x28acf5b7())
        {
            WLog(_0x3491765a._0xbc716140(new byte[37] { 191, 130, 147, 142, 218, 137, 145, 147, 138, 138, 159, 158, 218, 215, 196, 218, 138, 149, 138, 143, 138, 137, 218, 137, 142, 147, 150, 150, 218, 149, 138, 159, 148, 159, 158, 192, 218 }, 250) + _0x09e95873.Count);
            return;
        }

        Application.Quit();
    }

    private int _0x358a9a93 = 5, _0x3c92d6be = 5, _0x83a7a109 = 5, _0xf5718e17 = 5;
    internal void _0xbcdfe34b()
    {
        Rect _0x9d696c65 = Screen.safeArea;
        Vector2 _0x71dba1d6 = new Vector2(Screen.width, Screen.height);
        if (_0x9d696c65 == lastSafe && _0x71dba1d6 == lastSize)
            return;
        // Apply manual padding
        _0x9d696c65.xMin += _0x83a7a109;
        _0x9d696c65.xMax -= _0xf5718e17;
        _0x9d696c65.yMin += _0x3c92d6be;
        _0x9d696c65.yMax -= _0x358a9a93;
        // Convert Unity safe area -> native WebView frame
        Rect _0xccf668c3 = new Rect(_0x9d696c65.x, _0x71dba1d6.y - _0x9d696c65.y - _0x9d696c65.height, // Y flip for native coordinate system
 _0x9d696c65.width, _0x9d696c65.height);
        _0x8d5c37a3.Frame = _0xccf668c3;
        lastSafe = Screen.safeArea;
        lastSize = _0x71dba1d6;
    }

    private void _0x5df66c78()
    {
        _0x4c75da0d = true;
        if (_0x8d5c37a3 != null)
            _0x8d5c37a3.SetUserAgent(_0xd89619bd());
    }

    // WEB VIEW LOGIC
    public bool _0xb5e80385 { get; set; }

    private bool _0xc877a14f = false;
    private string _0xacece082()
    {
        try
        {
            using (var _0xe69398b0 = new AndroidJavaClass(_0x3491765a._0xbc716140(new byte[30] { 234, 230, 228, 167, 252, 231, 224, 253, 240, 186, 237, 167, 249, 229, 232, 240, 236, 251, 167, 220, 231, 224, 253, 240, 217, 229, 232, 240, 236, 251 }, 137)))
            {
                var _0x22cb9e7c = _0xe69398b0.GetStatic<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[15] { 114, 100, 99, 99, 116, 127, 101, 80, 114, 101, 120, 103, 120, 101, 104 }, 17));
                var _0x9f4ee7e4 = _0x22cb9e7c.Call<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[21] { 137, 139, 154, 175, 158, 158, 130, 135, 141, 143, 154, 135, 129, 128, 173, 129, 128, 154, 139, 150, 154 }, 238));
                using (var _0xfd920f1f = new AndroidJavaClass(_0x3491765a._0xbc716140(new byte[26] { 80, 95, 85, 67, 94, 88, 85, 31, 70, 84, 83, 90, 88, 69, 31, 102, 84, 83, 98, 84, 69, 69, 88, 95, 86, 66 }, 49)))
                {
                    return _0xfd920f1f.CallStatic<string>(_0x3491765a._0xbc716140(new byte[19] { 223, 221, 204, 252, 221, 222, 217, 205, 212, 204, 237, 203, 221, 202, 249, 223, 221, 214, 204 }, 184), _0x9f4ee7e4);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    private string _0xeca08a3a = "";
    private void _0x93e6be98(bool _0x8c67cbd6)
    {
        _0x547c8b2d();
        _0xb9f7d675.SetActive(_0x8c67cbd6);
        _0xa1d00b9d = _0x8c67cbd6;
        if (_0x8c67cbd6)
        {
            _0xb9f7d675.transform.SetAsLastSibling();
            if (_0x1131ef1e != null)
                _0x1131ef1e.localRotation = Quaternion.identity;
        }
    }

    private bool OpenUrlExternally(string _0xa3722caf)
    {
        return _0xe02ca16b(_0xa3722caf);
    }

    private string _0x616dc027 = "";
    private string _0x167c4fd6 { get; set; }

    private void OnApplicationFocus(bool _0x74281f3a)
    {
        isApplicationFocus = _0x74281f3a;
        if (_0x74281f3a && _0xb5e80385)
        {
            _0x8e555451();
        }
    }

    private string _0x3a858cc8 = "";
    private async Task<bool> _0x8ea624e9(int _0x59e3d549 = 5, int _0xba67b6c1 = 500)
    {
        List<EntityData> _0x54627de4 = new List<EntityData>();
        int _0x4794384c = 0;
        do
        {
            try
            {
                _0x54627de4 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x3491765a._0xbc716140(new byte[8] { 115, 111, 98, 122, 102, 113, 74, 103 }, 3), _0x09b6630b, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x3491765a._0xbc716140(new byte[9] { 14, 20, 55, 21, 14, 17, 6, 4, 30 }, 103) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x3491765a._0xbc716140(new byte[32] { 77, 66, 115, 101, 98, 75, 54, 103, 99, 115, 100, 111, 87, 101, 111, 120, 117, 68, 115, 101, 99, 122, 98, 101, 54, 115, 100, 100, 121, 100, 44, 54 }, 22) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0xba67b6c1);
        }
        while (_0x54627de4.Count == 0 && _0x4794384c++ < _0x59e3d549);
        {
#if B_LOGS
            {
                Debug.Log(_0x3491765a._0xbc716140(new byte[32] { 102, 105, 88, 78, 73, 96, 29, 116, 78, 109, 79, 84, 75, 92, 94, 68, 29, 108, 72, 88, 79, 68, 29, 79, 88, 78, 72, 81, 73, 78, 7, 29 }, 61) + JsonConvert.SerializeObject(_0x54627de4, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x3491765a._0xbc716140(new byte[38] { 189, 178, 131, 149, 146, 187, 198, 175, 149, 182, 148, 143, 144, 135, 133, 159, 198, 183, 147, 131, 148, 159, 198, 148, 131, 149, 147, 138, 146, 149, 198, 133, 137, 147, 136, 146, 220, 198 }, 230) + _0x54627de4.Count);
            }
#endif
        }

        bool _0x6e3124a0 = true;
        if (_0x54627de4.Count == 0)
        {
            _0x6e3124a0 = false;
        }
        else
        {
            _0x6e3124a0 = _0x54627de4.Any(_0xa3c7ef1a => _0xa3c7ef1a.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x3491765a._0xbc716140(new byte[25] { 11, 4, 53, 35, 36, 13, 112, 25, 35, 0, 34, 57, 38, 49, 51, 41, 112, 34, 53, 35, 37, 60, 36, 106, 112 }, 80) + _0x6e3124a0);
            }
#endif
        }

        return _0x6e3124a0;
    }

    private IEnumerator _0xf74d7fc7(string _0xdac755df)
    {
        if (Permission.HasUserAuthorizedPermission(_0xdac755df))
            yield break;
        bool _0x3fe5939e = false;
        var _0xa6f43189 = new PermissionCallbacks();
        _0xa6f43189.PermissionGranted += _0x298fc969 => _0x3fe5939e = true;
        _0xa6f43189.PermissionDenied += _0x298fc969 => _0x3fe5939e = true;
        Permission.RequestUserPermission(_0xdac755df, _0xa6f43189);
        yield return new WaitUntil(() => _0x3fe5939e);
    }

    internal Button _0xbd9904c9(string _0x47390097, Transform _0x85cd75c5)
    {
        var _0x1aa45112 = new GameObject(_0x47390097 + _0x3491765a._0xbc716140(new byte[3] { 168, 158, 132 }, 234), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0xc9b0855f = _0x1aa45112.GetComponent<RectTransform>();
        _0xc9b0855f.SetParent(_0x85cd75c5, false);
        var _0x0ecd3a11 = _0x1aa45112.GetComponent<Image>();
        _0x0ecd3a11.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0xe9908a80 = _0x1aa45112.GetComponent<Button>();
        var _0xbe1f42dc = _0xe9908a80.colors;
        _0xbe1f42dc.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0xbe1f42dc.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0xe9908a80.colors = _0xbe1f42dc;
        var _0xfb71f38c = new GameObject(_0x3491765a._0xbc716140(new byte[4] { 152, 169, 180, 184 }, 204), typeof(RectTransform), typeof(Text));
        var _0x977427c1 = _0xfb71f38c.GetComponent<RectTransform>();
        _0x977427c1.SetParent(_0x1aa45112.transform, false);
        _0x977427c1.anchorMin = Vector2.zero;
        _0x977427c1.anchorMax = Vector2.one;
        _0x977427c1.offsetMin = _0x977427c1.offsetMax = Vector2.zero;
        var _0x32152a3c = _0xfb71f38c.GetComponent<Text>();
        _0x32152a3c.text = _0x47390097;
        _0x32152a3c.alignment = TextAnchor.MiddleCenter;
        _0x32152a3c.color = Color.black;
        _0x32152a3c.font = Resources.GetBuiltinResource<Font>(_0x3491765a._0xbc716140(new byte[9] { 204, 255, 228, 236, 225, 163, 249, 249, 235 }, 141));
        _0x32152a3c.fontSize = 28;
        WLog(_0x3491765a._0xbc716140(new byte[14] { 132, 181, 162, 166, 179, 162, 133, 178, 179, 179, 168, 169, 231, 224 }, 199) + _0x47390097 + _0x3491765a._0xbc716140(new byte[1] { 201 }, 238));
        return _0xe9908a80;
    }

    private bool _0xe02ca16b(string _0x618b72fa)
    {
        try
        {
            using (var _0xb69de63a = new AndroidJavaClass(_0x3491765a._0xbc716140(new byte[30] { 249, 245, 247, 180, 239, 244, 243, 238, 227, 169, 254, 180, 234, 246, 251, 227, 255, 232, 180, 207, 244, 243, 238, 227, 202, 246, 251, 227, 255, 232 }, 154)))
            using (var _0x064dd132 = _0xb69de63a.GetStatic<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[15] { 58, 44, 43, 43, 60, 55, 45, 24, 58, 45, 48, 47, 48, 45, 32 }, 89)))
            using (var _0xd7a4adea = new AndroidJavaClass(_0x3491765a._0xbc716140(new byte[15] { 111, 96, 106, 124, 97, 103, 106, 32, 96, 107, 122, 32, 91, 124, 103 }, 14)))
            using (var _0x4480defb = _0xd7a4adea.CallStatic<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[5] { 27, 10, 25, 24, 14 }, 107), _0x618b72fa))
            using (var _0x436ac961 = new AndroidJavaObject(_0x3491765a._0xbc716140(new byte[22] { 10, 5, 15, 25, 4, 2, 15, 69, 8, 4, 5, 31, 14, 5, 31, 69, 34, 5, 31, 14, 5, 31 }, 107), _0x3491765a._0xbc716140(new byte[26] { 53, 58, 48, 38, 59, 61, 48, 122, 61, 58, 32, 49, 58, 32, 122, 53, 55, 32, 61, 59, 58, 122, 2, 29, 17, 3 }, 84), _0x4480defb))
            {
                WLog(_0x3491765a._0xbc716140(new byte[26] { 103, 76, 86, 75, 73, 65, 104, 77, 79, 65, 4, 75, 84, 65, 74, 4, 65, 92, 80, 65, 86, 74, 69, 72, 30, 4 }, 36) + _0x618b72fa);
                _0x436ac961.Call<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[11] { 139, 142, 142, 169, 139, 158, 143, 141, 133, 152, 147 }, 234), _0x3491765a._0xbc716140(new byte[33] { 90, 85, 95, 73, 84, 82, 95, 21, 82, 85, 79, 94, 85, 79, 21, 88, 90, 79, 94, 92, 84, 73, 66, 21, 121, 105, 116, 108, 104, 122, 121, 119, 126 }, 59));
                _0x436ac961.Call<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[8] { 210, 215, 215, 245, 223, 210, 212, 192 }, 179), 0x10000000);
                _0x064dd132.Call(_0x3491765a._0xbc716140(new byte[13] { 76, 75, 94, 77, 75, 126, 92, 75, 86, 73, 86, 75, 70 }, 63), _0x436ac961);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x3491765a._0xbc716140(new byte[28] { 1, 42, 48, 45, 47, 39, 14, 43, 41, 39, 98, 39, 58, 54, 39, 48, 44, 35, 46, 98, 36, 35, 43, 46, 39, 38, 120, 98 }, 66) + e.Message);
            Application.OpenURL(_0x618b72fa);
            return true;
        }
    }

    private void WLog(string _0xcd5d48ef)
    {
#if B_LOGS
        {
            Debug.Log(_0x3491765a._0xbc716140(new byte[7] { 68, 75, 122, 108, 107, 66, 63 }, 31) + _0xcd5d48ef);
        }
#endif
    }

    private void _0x62271c35()
    {
        {
#if B_LOGS
            Debug.Log(_0x3491765a._0xbc716140(new byte[22] { 147, 156, 173, 187, 188, 149, 232, 155, 188, 167, 186, 173, 140, 173, 190, 161, 171, 173, 129, 166, 174, 167 }, 200));
#endif
        }

        _0x57c45ca6 = SystemInfo.deviceModel;
        _0x08cdaa66 = Application.version;
        _0xcad4d087 = Application.installMode;
        _0x922c57f1 = Application.installerName;
        _0x306710f0 = Application.identifier;
        _0x2f2b91b8 = _0xad740086();
        _0xc1ffb983 = _0xacece082();
        _0xd5f50f6c = SystemInfo.deviceUniqueIdentifier;
        _0x5e5aac4b = SystemInfo.graphicsDeviceName;
        _0x9c33ef27 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x08cdaa66 = _0x3491765a._0xbc716140(new byte[5] { 83, 74, 83, 74, 83 }, 100);
                _0xcad4d087 = ApplicationInstallMode.Store;
                _0x922c57f1 = _0x3491765a._0xbc716140(new byte[19] { 138, 134, 132, 199, 136, 135, 141, 155, 134, 128, 141, 199, 159, 140, 135, 141, 128, 135, 142 }, 233);
                _0xc1ffb983 = _0x3491765a._0xbc716140(new byte[8] { 175, 167, 186, 190, 179, 234, 191, 171 }, 202);
                _0xd5f50f6c = Guid.NewGuid().ToString().Replace(_0x3491765a._0xbc716140(new byte[1] { 44 }, 1), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x3491765a._0xbc716140(new byte[17] { 66, 77, 124, 106, 109, 68, 57, 125, 124, 111, 84, 118, 125, 124, 117, 35, 57 }, 25) + _0x57c45ca6);
            Debug.Log(_0x3491765a._0xbc716140(new byte[19] { 186, 181, 132, 146, 149, 188, 193, 128, 145, 145, 183, 132, 147, 146, 136, 142, 143, 219, 193 }, 225) + _0x08cdaa66);
            Debug.Log(_0x3491765a._0xbc716140(new byte[20] { 203, 196, 245, 227, 228, 205, 176, 249, 254, 227, 228, 241, 252, 252, 221, 255, 244, 245, 170, 176 }, 144) + _0xcad4d087);
            Debug.Log(_0x3491765a._0xbc716140(new byte[23] { 104, 103, 86, 64, 71, 110, 19, 90, 93, 64, 71, 82, 95, 95, 86, 65, 96, 71, 92, 65, 86, 9, 19 }, 51) + _0x922c57f1);
            Debug.Log(_0x3491765a._0xbc716140(new byte[14] { 109, 98, 83, 69, 66, 107, 22, 87, 70, 70, 127, 82, 12, 22 }, 54) + _0x306710f0);
            Debug.Log(_0x3491765a._0xbc716140(new byte[14] { 250, 245, 196, 210, 213, 252, 129, 192, 197, 215, 232, 197, 155, 129 }, 161) + _0x2f2b91b8);
            Debug.Log(_0x3491765a._0xbc716140(new byte[18] { 204, 195, 242, 228, 227, 202, 183, 226, 228, 242, 229, 214, 240, 242, 249, 227, 173, 183 }, 151) + _0xc1ffb983);
            Debug.Log(_0x3491765a._0xbc716140(new byte[17] { 97, 110, 95, 73, 78, 103, 26, 73, 67, 73, 126, 95, 76, 115, 94, 0, 26 }, 58) + _0xd5f50f6c);
            Debug.Log(_0x3491765a._0xbc716140(new byte[12] { 182, 185, 136, 158, 153, 176, 205, 138, 157, 152, 215, 205 }, 237) + _0x5e5aac4b);
            Debug.Log(_0x3491765a._0xbc716140(new byte[12] { 132, 139, 186, 172, 171, 130, 255, 188, 175, 170, 229, 255 }, 223) + _0x9c33ef27);
#endif
        }
    }

    private string _0xd5f50f6c = "";
    private readonly List<UniWebViewPopup> _0x09e95873 = new List<UniWebViewPopup>();
    private bool TryOpenExternalLikeChrome(string _0x02a90379)
    {
        if (string.IsNullOrEmpty(_0x02a90379))
            return false;
        if (_0x02a90379.StartsWith(_0x3491765a._0xbc716140(new byte[9] { 1, 6, 28, 13, 6, 28, 82, 71, 71 }, 104), StringComparison.OrdinalIgnoreCase))
            return _0xe513613d(_0x02a90379);
        if (_0xc85283d3(_0x02a90379))
            return _0xe95757c4(_0x02a90379, null);
        if (!_0x02a90379.StartsWith(_0x3491765a._0xbc716140(new byte[7] { 58, 38, 38, 34, 104, 125, 125 }, 82), StringComparison.OrdinalIgnoreCase) && !_0x02a90379.StartsWith(_0x3491765a._0xbc716140(new byte[8] { 206, 210, 210, 214, 213, 156, 137, 137 }, 166), StringComparison.OrdinalIgnoreCase) && !_0x02a90379.StartsWith(_0x3491765a._0xbc716140(new byte[11] { 182, 181, 184, 162, 163, 237, 181, 187, 182, 185, 188 }, 215), StringComparison.OrdinalIgnoreCase))
        {
            return _0xe02ca16b(_0x02a90379);
        }

        return false;
    }

    private ApplicationInstallMode _0xcad4d087 = ApplicationInstallMode.Unknown;
    private string _0x9c33ef27 = "";
    private bool _0xd95de150 = false;
    private string _0x69e2bf7c = "";
    private void _0x63a0bfad(string _0x1cc3369e)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x3491765a._0xbc716140(new byte[34] { 130, 141, 188, 170, 173, 132, 249, 159, 188, 173, 186, 177, 249, 156, 161, 173, 171, 184, 249, 137, 172, 170, 177, 249, 157, 184, 173, 184, 249, 139, 184, 174, 227, 249 }, 217) + _0x1cc3369e);
#endif
            }
        }

        var _0x2b360020 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x1cc3369e);
        StartCoroutine(_0xd4deaf94(_0x2b360020));
    }

    private string _0x6178e3f3(string _0x681d9f3d, string _0xf23f7237)
    {
        if (string.IsNullOrEmpty(_0xf23f7237))
            return _0x681d9f3d;
        if (_0x681d9f3d.Contains(_0x3491765a._0xbc716140(new byte[1] { 226 }, 221)))
            return _0x681d9f3d + _0x3491765a._0xbc716140(new byte[8] { 242, 167, 177, 186, 176, 189, 176, 233 }, 212) + UnityWebRequest.EscapeURL(_0xf23f7237);
        else
            return _0x681d9f3d + _0x3491765a._0xbc716140(new byte[8] { 191, 243, 229, 238, 228, 233, 228, 189 }, 128) + UnityWebRequest.EscapeURL(_0xf23f7237);
    }

    private string _0x5e5aac4b = "";
    private IEnumerator _0x503c9c19(IEnumerator _0x3706f60d, TaskCompletionSource<bool> _0xfa5d6234)
    {
        yield return _0x3706f60d;
        _0xfa5d6234.SetResult(true);
    }

    internal bool isDestroyedForce = false;
    internal bool _0xc85283d3(string _0x07453197)
    {
        return _0x07453197.StartsWith(_0x3491765a._0xbc716140(new byte[9] { 4, 8, 27, 2, 12, 29, 83, 70, 70 }, 105), StringComparison.OrdinalIgnoreCase) || _0x07453197.StartsWith(_0x3491765a._0xbc716140(new byte[24] { 29, 1, 1, 5, 6, 79, 90, 90, 5, 25, 20, 12, 91, 18, 26, 26, 18, 25, 16, 91, 22, 26, 24, 90 }, 117), StringComparison.OrdinalIgnoreCase) || _0x07453197.StartsWith(_0x3491765a._0xbc716140(new byte[23] { 231, 251, 251, 255, 181, 160, 160, 255, 227, 238, 246, 161, 232, 224, 224, 232, 227, 234, 161, 236, 224, 226, 160 }, 143), StringComparison.OrdinalIgnoreCase);
    }

    private async Task<bool> _0xc1a215e4()
    {
        {
#if B_LOGS
            Debug.Log(_0x3491765a._0xbc716140(new byte[29] { 110, 97, 80, 70, 65, 104, 21, 124, 70, 101, 71, 92, 67, 84, 86, 76, 116, 91, 81, 102, 84, 67, 80, 81, 118, 93, 80, 86, 94 }, 53));
#endif
        }

        string _0xd81815a6 = "";
        for (int _0x076f064e = 0; _0x076f064e < 2; _0x076f064e++)
        {
            if (await _0x8ea624e9(1, 100))
            {
                await _0x7fc01c8f(_0x3491765a._0xbc716140(new byte[7] { 137, 135, 132, 136, 128, 142, 143 }, 235));
                _0xac43ce9b();
                return true;
            }

            _0xd81815a6 = await _0xc96f54f7(1, 100);
            if (!string.IsNullOrEmpty(_0xd81815a6))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0xd81815a6))
            {
                if (!string.IsNullOrEmpty(_0xd422a8a4))
                {
                    _0xd81815a6 = _0x6178e3f3(_0xd81815a6, _0xd422a8a4);
                    {
#if B_LOGS
                        Debug.Log(_0x3491765a._0xbc716140(new byte[53] { 95, 80, 97, 119, 112, 89, 36, 71, 101, 103, 108, 97, 96, 36, 98, 109, 106, 101, 104, 81, 118, 104, 36, 115, 109, 112, 108, 36, 119, 97, 106, 96, 109, 96, 36, 230, 130, 150, 36, 119, 108, 107, 115, 36, 83, 97, 102, 82, 109, 97, 115, 62, 36 }, 4) + _0xd81815a6);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x3491765a._0xbc716140(new byte[39] { 175, 160, 145, 135, 128, 169, 212, 183, 149, 151, 156, 145, 144, 212, 146, 157, 154, 149, 152, 161, 134, 152, 212, 22, 114, 102, 212, 135, 156, 155, 131, 212, 163, 145, 150, 162, 157, 145, 131 }, 244));
#endif
                    }
                }

                _0xc877a14f = true;
                _0x726d616d(_0xd81815a6);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x3491765a._0xbc716140(new byte[44] { 94, 81, 96, 118, 113, 88, 37, 64, 125, 102, 96, 117, 113, 108, 106, 107, 37, 114, 109, 108, 105, 96, 37, 102, 109, 96, 102, 110, 108, 107, 98, 37, 118, 100, 115, 96, 97, 37, 105, 108, 107, 110, 63, 37 }, 5) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private Action _0xa0588481;
    private async Task<string> _0xc96f54f7(int _0xe70379ca = 5, int _0x0da44b06 = 500)
    {
        try
        {
            List<EntityData> _0x7f868348 = new List<EntityData>();
            int _0x2d20769c = 0;
            do
            {
                _0x7f868348 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x3491765a._0xbc716140(new byte[8] { 179, 175, 162, 186, 166, 177, 138, 167 }, 195), _0x09b6630b, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x09b6630b }), new QueryOptions())).ToList();
                await Task.Delay(_0x0da44b06);
            }
            while (_0x7f868348.Count == 0 && _0x2d20769c++ < _0xe70379ca);
            {
#if B_LOGS
                {
                    Debug.Log(_0x3491765a._0xbc716140(new byte[33] { 126, 113, 64, 86, 81, 120, 5, 118, 68, 83, 64, 65, 5, 105, 76, 75, 78, 5, 116, 80, 64, 87, 92, 5, 87, 64, 86, 80, 73, 81, 86, 31, 5 }, 37) + JsonConvert.SerializeObject(_0x7f868348, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x3491765a._0xbc716140(new byte[39] { 173, 162, 147, 133, 130, 171, 214, 165, 151, 128, 147, 146, 214, 186, 159, 152, 157, 214, 167, 131, 147, 132, 143, 214, 132, 147, 133, 131, 154, 130, 133, 214, 149, 153, 131, 152, 130, 204, 214 }, 246) + _0x7f868348.Count);
                }
#endif
            }

            var _0xc5346a8a = _0x7f868348.SelectMany(_0xa3c7ef1a => _0xa3c7ef1a.Data).FirstOrDefault(_0x39206284 => _0x39206284.Key == _0x09b6630b)?.Value.GetAs<string>() ?? string.Empty;
            _0xc5346a8a = Decrypt(_0xc5346a8a, _0x09b6630b);
            {
#if B_LOGS
                {
                    Debug.Log(_0x3491765a._0xbc716140(new byte[24] { 47, 32, 17, 7, 0, 41, 84, 56, 27, 21, 16, 84, 7, 21, 2, 17, 16, 84, 24, 29, 26, 31, 78, 84 }, 116) + _0xc5346a8a);
                }
#endif
            }

            return _0xc5346a8a;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x3491765a._0xbc716140(new byte[39] { 217, 214, 231, 241, 246, 223, 162, 197, 231, 246, 162, 237, 240, 162, 242, 227, 240, 241, 231, 162, 241, 227, 244, 231, 230, 162, 238, 235, 236, 233, 162, 228, 227, 235, 238, 231, 230, 184, 162 }, 130) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private string _0x50c2f798 = "";
    private readonly string[] _0x8ee71bbb = new string[]
    {
        _0x3491765a._0xbc716140(new byte[60] { 150, 249, 232, 214, 70, 50, 14, 3, 70, 20, 3, 3, 10, 21, 70, 7, 20, 3, 70, 14, 9, 18, 70, 20, 15, 1, 14, 18, 70, 8, 9, 17, 70, 132, 230, 245, 70, 2, 9, 8, 132, 230, 255, 18, 70, 11, 15, 21, 21, 70, 31, 9, 19, 20, 70, 21, 22, 15, 8, 71 }, 102),
        _0x3491765a._0xbc716140(new byte[52] { 208, 191, 173, 160, 0, 105, 84, 0, 67, 79, 85, 76, 68, 0, 66, 69, 0, 89, 79, 85, 82, 0, 76, 85, 67, 75, 89, 0, 77, 79, 77, 69, 78, 84, 0, 194, 160, 179, 0, 87, 72, 89, 0, 83, 84, 79, 80, 0, 78, 79, 87, 31 }, 32),
        _0x3491765a._0xbc716140(new byte[66] { 46, 86, 109, 35, 116, 67, 236, 142, 165, 171, 236, 187, 165, 162, 191, 236, 173, 190, 169, 236, 164, 165, 184, 184, 165, 162, 171, 236, 161, 163, 190, 169, 236, 163, 170, 184, 169, 162, 236, 184, 163, 168, 173, 181, 236, 46, 76, 95, 236, 191, 184, 173, 181, 236, 165, 162, 236, 184, 164, 169, 236, 171, 173, 161, 169, 226 }, 204),
        _0x3491765a._0xbc716140(new byte[54] { 132, 235, 225, 230, 84, 32, 28, 29, 7, 84, 29, 7, 84, 4, 6, 29, 25, 17, 84, 0, 29, 25, 17, 84, 150, 244, 231, 84, 0, 28, 17, 84, 22, 17, 7, 0, 84, 4, 24, 21, 13, 17, 6, 7, 84, 4, 24, 21, 13, 84, 26, 27, 3, 90 }, 116),
        _0x3491765a._0xbc716140(new byte[48] { 20, 123, 112, 65, 196, 189, 139, 145, 150, 196, 147, 141, 138, 138, 141, 138, 131, 196, 151, 144, 150, 129, 133, 143, 196, 135, 139, 145, 136, 128, 196, 134, 129, 196, 139, 138, 129, 196, 151, 148, 141, 138, 196, 133, 147, 133, 157, 202 }, 228),
        _0x3491765a._0xbc716140(new byte[65] { 174, 193, 196, 222, 126, 20, 63, 61, 53, 46, 49, 42, 45, 126, 63, 44, 59, 126, 51, 49, 44, 59, 126, 63, 61, 42, 55, 40, 59, 126, 42, 49, 48, 55, 57, 54, 42, 126, 188, 222, 205, 126, 45, 42, 63, 39, 126, 63, 48, 58, 126, 42, 44, 39, 126, 39, 49, 43, 44, 126, 50, 43, 61, 53, 112 }, 94),
        _0x3491765a._0xbc716140(new byte[55] { 152, 247, 230, 218, 72, 45, 30, 13, 26, 17, 72, 27, 24, 1, 6, 72, 11, 7, 29, 6, 28, 27, 72, 138, 232, 251, 72, 28, 0, 13, 72, 6, 13, 16, 28, 72, 7, 6, 13, 72, 11, 7, 29, 4, 12, 72, 10, 13, 72, 17, 7, 29, 26, 27, 70 }, 104),
        _0x3491765a._0xbc716140(new byte[63] { 198, 137, 180, 203, 156, 171, 4, 116, 72, 69, 93, 65, 86, 87, 4, 86, 77, 67, 76, 80, 4, 74, 75, 83, 4, 69, 86, 65, 4, 83, 77, 74, 74, 77, 74, 67, 4, 198, 164, 183, 4, 64, 75, 74, 198, 164, 189, 80, 4, 83, 69, 72, 79, 4, 69, 83, 69, 93, 4, 93, 65, 80, 10 }, 36),
        _0x3491765a._0xbc716140(new byte[51] { 155, 244, 228, 237, 75, 36, 5, 7, 18, 75, 31, 3, 4, 24, 14, 75, 28, 3, 4, 75, 24, 31, 10, 18, 75, 2, 5, 75, 31, 3, 14, 75, 12, 10, 6, 14, 75, 28, 2, 5, 75, 31, 3, 14, 75, 27, 25, 2, 17, 14, 69 }, 107),
        _0x3491765a._0xbc716140(new byte[64] { 48, 72, 115, 61, 106, 93, 242, 159, 189, 191, 183, 188, 166, 167, 191, 242, 187, 161, 242, 183, 164, 183, 160, 171, 166, 186, 187, 188, 181, 242, 48, 82, 65, 242, 185, 183, 183, 162, 242, 161, 162, 187, 188, 188, 187, 188, 181, 242, 180, 189, 160, 242, 171, 189, 167, 160, 242, 177, 186, 179, 188, 177, 183, 252 }, 210)
    };
    private bool _0x18bdb0f6(int _0xc7b2dedf, string _0x1770fc02, string _0xddc8c0b7)
    {
        if (string.IsNullOrEmpty(_0xddc8c0b7))
            return false;
        if (!IsHttpUrl(_0xddc8c0b7))
            return true;
        if (string.IsNullOrEmpty(_0x1770fc02))
            return false;
        return _0x1770fc02.IndexOf(_0x3491765a._0xbc716140(new byte[20] { 119, 96, 96, 109, 113, 125, 124, 124, 119, 113, 102, 123, 125, 124, 109, 96, 119, 97, 119, 102 }, 50), StringComparison.OrdinalIgnoreCase) >= 0 || _0x1770fc02.IndexOf(_0x3491765a._0xbc716140(new byte[22] { 35, 52, 52, 57, 37, 41, 40, 40, 35, 37, 50, 47, 41, 40, 57, 52, 35, 32, 51, 53, 35, 34 }, 102), StringComparison.OrdinalIgnoreCase) >= 0 || _0x1770fc02.IndexOf(_0x3491765a._0xbc716140(new byte[21] { 6, 17, 17, 28, 0, 12, 13, 13, 6, 0, 23, 10, 12, 13, 28, 0, 15, 12, 16, 6, 7 }, 67), StringComparison.OrdinalIgnoreCase) >= 0 || _0x1770fc02.IndexOf(_0x3491765a._0xbc716140(new byte[22] { 199, 208, 208, 221, 215, 204, 201, 204, 205, 213, 204, 221, 215, 208, 206, 221, 209, 193, 202, 199, 207, 199 }, 130), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private bool _0xe95757c4(string _0xfd0889ff, string _0xed266659)
    {
        string _0x802ef838 = _0x8b3e3380(_0xfd0889ff);
        if (string.IsNullOrEmpty(_0x802ef838))
            _0x802ef838 = _0xed266659;
        if (_0xab833561(_0x802ef838))
            return true;
        string _0xa486895b = string.IsNullOrEmpty(_0x802ef838) ? _0x3491765a._0xbc716140(new byte[29] { 128, 156, 156, 152, 155, 210, 199, 199, 152, 132, 137, 145, 198, 143, 135, 135, 143, 132, 141, 198, 139, 135, 133, 199, 155, 156, 135, 154, 141 }, 232) : _0x3491765a._0xbc716140(new byte[46] { 102, 122, 122, 126, 125, 52, 33, 33, 126, 98, 111, 119, 32, 105, 97, 97, 105, 98, 107, 32, 109, 97, 99, 33, 125, 122, 97, 124, 107, 33, 111, 126, 126, 125, 33, 106, 107, 122, 111, 103, 98, 125, 49, 103, 106, 51 }, 14) + _0x802ef838;
        WLog(_0x3491765a._0xbc716140(new byte[35] { 36, 15, 21, 8, 10, 2, 43, 14, 12, 2, 71, 10, 6, 21, 12, 2, 19, 71, 1, 6, 11, 11, 5, 6, 4, 12, 71, 6, 20, 71, 16, 2, 5, 93, 71 }, 103) + _0xa486895b);
        return _0xe02ca16b(_0xa486895b);
    }

    private async Task<bool> _0xe298effd()
    {
        _0xe6b3ba0e.Instance?._0xea3929fb();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x8981307e) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x3491765a._0xbc716140(new byte[32] { 60, 51, 2, 20, 19, 58, 71, 50, 9, 14, 19, 30, 71, 55, 18, 20, 15, 71, 41, 8, 19, 14, 1, 14, 4, 6, 19, 14, 8, 9, 93, 71 }, 103) + string.Join(_0x3491765a._0xbc716140(new byte[1] { 72 }, 65), _0x8981307e));
                }
#endif
            }
        };
        try
        {
            _0x50c2f798 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x3491765a._0xbc716140(new byte[31] { 169, 166, 151, 129, 134, 175, 210, 180, 147, 155, 158, 151, 150, 210, 134, 157, 210, 149, 151, 134, 210, 130, 135, 129, 154, 210, 134, 157, 153, 151, 156 }, 242));
                }
#endif
            }

            _0x50c2f798 = "";
        }

        _0x6568385c = !string.IsNullOrEmpty(_0x50c2f798);
        _0x46cb6548 = _0x64d280ea();
        {
#if B_LOGS
            Debug.Log(_0x3491765a._0xbc716140(new byte[25] { 185, 182, 135, 145, 150, 191, 194, 183, 140, 139, 150, 155, 194, 178, 151, 145, 138, 194, 182, 141, 137, 135, 140, 216, 194 }, 226) + _0x50c2f798);
#endif
        }

        _0xe6b3ba0e.Instance?._0x24aed336();
        return false;
    }

    private bool _0xe4ee5154 = false;
    private void _0x082d130b(string _0x6b331263)
    {
        if (string.IsNullOrEmpty(_0x6b331263))
            return;
        if (TryOpenExternalLikeChrome(_0x6b331263))
            return;
        OpenUrlExternally(_0x6b331263);
    }

    private string _0xceb87870 = "";
    internal bool IsAboutBlank(string _0xb61bce7e)
    {
        if (string.IsNullOrEmpty(_0xb61bce7e))
            return false;
        return _0xb61bce7e.StartsWith(_0x3491765a._0xbc716140(new byte[11] { 225, 226, 239, 245, 244, 186, 226, 236, 225, 238, 235 }, 128), StringComparison.OrdinalIgnoreCase);
    }

    private JObject _0xf3c26f66(params string[] _0x7e896ec5)
    {
        JObject _0xfcf3aadd = new JObject();
        foreach (var _0xadea38a8 in _0x7e896ec5)
        {
            string _0xc44d5e1a = _0x7cc7bea5();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0xc44d5e1a} val={_0xadea38a8}");
#endif
            }

            _0xfcf3aadd.Add(_0xc44d5e1a, _0xadea38a8 == null ? "" : _0xadea38a8);
        }

        return _0xfcf3aadd;
    }

    private string _0xd422a8a4;
    private void _0x726d616d(string _0x7f6a14a6)
    {
        _0x8e555451();
        StartCoroutine(_0x38337e6c(_0x7f6a14a6));
    }

    internal bool IsGoogleAuthFlowUrl(string _0xb5f5ef58)
    {
        if (string.IsNullOrEmpty(_0xb5f5ef58))
            return false;
        return _0xb5f5ef58.IndexOf(_0x3491765a._0xbc716140(new byte[19] { 55, 53, 53, 57, 35, 56, 34, 37, 120, 49, 57, 57, 49, 58, 51, 120, 53, 57, 59 }, 86), StringComparison.OrdinalIgnoreCase) >= 0 || _0xb5f5ef58.IndexOf(_0x3491765a._0xbc716140(new byte[16] { 17, 19, 19, 31, 5, 30, 4, 3, 94, 23, 31, 31, 23, 28, 21, 94 }, 112), StringComparison.OrdinalIgnoreCase) >= 0 || _0xb5f5ef58.IndexOf(_0x3491765a._0xbc716140(new byte[21] { 132, 140, 140, 132, 143, 134, 150, 144, 134, 145, 128, 140, 141, 151, 134, 141, 151, 205, 128, 140, 142 }, 227), StringComparison.OrdinalIgnoreCase) >= 0 || _0xb5f5ef58.IndexOf(_0x3491765a._0xbc716140(new byte[11] { 147, 135, 128, 149, 128, 157, 151, 218, 151, 155, 153 }, 244), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private void _0x406e485b()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0x98931968)
    {
        if (_0x98931968 == null || _0x98931968.Extra == null)
            return null;
        object _0xaa730c02;
        if (!_0x98931968.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0xaa730c02))
            return null;
        return _0xaa730c02 as string;
    }

    private async Task _0x7fc01c8f(string _0x39d2114b)
    {
        if (_0xe4ee5154 || string.IsNullOrEmpty(_0x09b6630b) || string.IsNullOrEmpty(_0x39d2114b) || _0xc877a14f)
            return;
        _0xe4ee5154 = true;
        try
        {
            JObject _0x96380df3 = _0xf3c26f66(_0x39d2114b, _0x09b6630b, _0x64d280ea());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x39d2114b} payload: {_0x96380df3}");
                }
#endif
            }

            var _0xd96aa9d9 = _0x93c108d4(_0x96380df3.ToString(), _0x09b6630b);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x3491765a._0xbc716140(new byte[4] { 224, 227, 237, 232 }, 140) + _0x09b6630b, _0xd96aa9d9 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x3491765a._0xbc716140(new byte[24] { 102, 105, 120, 110, 105, 96, 29, 113, 82, 92, 89, 29, 77, 92, 78, 78, 29, 88, 79, 79, 82, 79, 7, 29 }, 61) + e.Message);
#endif
            }
        }
    }

    internal bool IsHttpUrl(string _0x8a92eac3)
    {
        if (string.IsNullOrEmpty(_0x8a92eac3))
            return false;
        return _0x8a92eac3.StartsWith(_0x3491765a._0xbc716140(new byte[7] { 89, 69, 69, 65, 11, 30, 30 }, 49), StringComparison.OrdinalIgnoreCase) || _0x8a92eac3.StartsWith(_0x3491765a._0xbc716140(new byte[8] { 180, 168, 168, 172, 175, 230, 243, 243 }, 220), StringComparison.OrdinalIgnoreCase);
    }

    private bool _0xd73eb76f()
    {
        if (_0x3b39ee38())
            return true;
        if (_0x8d5c37a3 != null && _0x8d5c37a3.CanGoBack)
        {
            WLog(_0x3491765a._0xbc716140(new byte[36] { 59, 18, 1, 23, 4, 18, 1, 22, 83, 17, 18, 16, 24, 83, 94, 77, 83, 30, 18, 26, 29, 83, 36, 22, 17, 37, 26, 22, 4, 83, 52, 28, 49, 18, 16, 24 }, 115));
            _0x8d5c37a3.GoBack();
            return true;
        }

        return false;
    }

    private async Task<bool> _0x959963d0()
    {
        {
#if B_LOGS
            Debug.Log(_0x3491765a._0xbc716140(new byte[37] { 24, 23, 38, 48, 55, 30, 99, 16, 42, 36, 45, 10, 45, 22, 45, 42, 55, 58, 16, 38, 49, 53, 42, 32, 38, 48, 2, 45, 44, 45, 58, 46, 44, 54, 48, 47, 58 }, 67));
#endif
        }

        try
        {
            var _0x77698f05 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x77698f05);
            {
#if B_LOGS
                Debug.Log(_0x3491765a._0xbc716140(new byte[32] { 34, 45, 28, 10, 13, 36, 89, 44, 23, 16, 13, 0, 42, 28, 11, 15, 16, 26, 28, 10, 89, 48, 23, 16, 13, 16, 24, 21, 16, 3, 28, 29 }, 121));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x3491765a._0xbc716140(new byte[20] { 9, 24, 14, 9, 125, 8, 51, 52, 41, 36, 14, 56, 47, 43, 52, 62, 56, 46, 103, 125 }, 93) + ex.Message);
#endif
            }

            _0x9ab4bb01?._0xac43ce9b();
            return true;
        }

        bool _0x27c3d56a = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x27c3d56a = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x3491765a._0xbc716140(new byte[37] { 88, 87, 102, 112, 119, 94, 35, 80, 106, 100, 109, 46, 106, 109, 35, 66, 109, 108, 109, 122, 110, 108, 118, 112, 45, 35, 83, 111, 98, 122, 102, 113, 35, 74, 71, 57, 35 }, 3) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x09b6630b = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x3491765a._0xbc716140(new byte[25] { 102, 119, 97, 102, 18, 97, 91, 85, 92, 31, 91, 92, 18, 115, 71, 70, 90, 18, 119, 96, 96, 125, 96, 8, 18 }, 50) + ex.Message);
#endif
                }

                _0x9ab4bb01?._0xac43ce9b();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x3491765a._0xbc716140(new byte[28] { 140, 157, 139, 140, 248, 139, 177, 191, 182, 245, 177, 182, 248, 138, 189, 169, 173, 189, 171, 172, 248, 157, 138, 138, 151, 138, 226, 248 }, 216) + ex.Message);
#endif
                }

                _0x9ab4bb01?._0xac43ce9b();
                return true;
            }
        }
        while (!_0x27c3d56a);
        return false;
    }

    private Text _0xcf58f109;
    private bool _0x45d091a1 = false;
    private string _0xb9155443()
    {
        return _0x3491765a._0xbc716140(new byte[12] { 75, 5, 22, 13, 0, 23, 10, 12, 13, 75, 74, 24 }, 99) + _0x3491765a._0xbc716140(new byte[8] { 133, 146, 129, 211, 134, 146, 206, 212 }, 243) + WindowsDesktopUserAgent + _0x3491765a._0xbc716140(new byte[2] { 88, 68 }, 127) + _0x3491765a._0xbc716140(new byte[30] { 27, 12, 31, 77, 29, 31, 2, 25, 2, 80, 35, 12, 27, 4, 10, 12, 25, 2, 31, 67, 29, 31, 2, 25, 2, 25, 20, 29, 8, 86 }, 109) + _0x3491765a._0xbc716140(new byte[121] { 59, 40, 51, 62, 41, 52, 50, 51, 125, 57, 56, 59, 117, 50, 63, 55, 113, 54, 56, 36, 113, 43, 60, 49, 116, 38, 41, 47, 36, 38, 18, 63, 55, 56, 62, 41, 115, 57, 56, 59, 52, 51, 56, 13, 47, 50, 45, 56, 47, 41, 36, 117, 50, 63, 55, 113, 54, 56, 36, 113, 38, 58, 56, 41, 103, 59, 40, 51, 62, 41, 52, 50, 51, 117, 116, 38, 47, 56, 41, 40, 47, 51, 125, 43, 60, 49, 102, 32, 113, 62, 50, 51, 59, 52, 58, 40, 47, 60, 63, 49, 56, 103, 41, 47, 40, 56, 32, 116, 102, 32, 62, 60, 41, 62, 53, 117, 56, 116, 38, 32, 32 }, 93) + _0x3491765a._0xbc716140(new byte[26] { 152, 153, 154, 212, 140, 142, 147, 136, 147, 208, 219, 137, 143, 153, 142, 189, 155, 153, 146, 136, 219, 208, 137, 157, 213, 199 }, 252) + _0x3491765a._0xbc716140(new byte[130] { 197, 196, 199, 137, 209, 211, 206, 213, 206, 141, 134, 192, 209, 209, 247, 196, 211, 210, 200, 206, 207, 134, 141, 134, 148, 143, 145, 129, 137, 246, 200, 207, 197, 206, 214, 210, 129, 239, 245, 129, 144, 145, 143, 145, 154, 129, 246, 200, 207, 151, 149, 154, 129, 217, 151, 149, 136, 129, 224, 209, 209, 205, 196, 246, 196, 195, 234, 200, 213, 142, 148, 146, 150, 143, 146, 151, 129, 137, 234, 233, 245, 236, 237, 141, 129, 205, 200, 202, 196, 129, 230, 196, 194, 202, 206, 136, 129, 226, 201, 211, 206, 204, 196, 142, 144, 147, 145, 143, 145, 143, 145, 143, 145, 129, 242, 192, 199, 192, 211, 200, 142, 148, 146, 150, 143, 146, 151, 134, 136, 154 }, 161) + _0x3491765a._0xbc716140(new byte[30] { 58, 59, 56, 118, 46, 44, 49, 42, 49, 114, 121, 46, 50, 63, 42, 56, 49, 44, 51, 121, 114, 121, 9, 55, 48, 109, 108, 121, 119, 101 }, 94) + _0x3491765a._0xbc716140(new byte[34] { 169, 168, 171, 229, 189, 191, 162, 185, 162, 225, 234, 187, 168, 163, 169, 162, 191, 234, 225, 234, 138, 162, 162, 170, 161, 168, 237, 132, 163, 174, 227, 234, 228, 246 }, 205) + _0x3491765a._0xbc716140(new byte[30] { 204, 205, 206, 128, 216, 218, 199, 220, 199, 132, 143, 197, 201, 208, 252, 199, 221, 203, 192, 248, 199, 193, 198, 220, 219, 143, 132, 152, 129, 147 }, 168) + _0x3491765a._0xbc716140(new byte[449] { 244, 242, 249, 251, 246, 225, 242, 160, 245, 225, 228, 189, 251, 226, 242, 225, 238, 228, 243, 186, 219, 251, 226, 242, 225, 238, 228, 186, 167, 195, 232, 242, 239, 237, 233, 245, 237, 167, 172, 246, 229, 242, 243, 233, 239, 238, 186, 167, 177, 178, 176, 167, 253, 172, 251, 226, 242, 225, 238, 228, 186, 167, 199, 239, 239, 231, 236, 229, 160, 195, 232, 242, 239, 237, 229, 167, 172, 246, 229, 242, 243, 233, 239, 238, 186, 167, 177, 178, 176, 167, 253, 172, 251, 226, 242, 225, 238, 228, 186, 167, 206, 239, 244, 189, 193, 191, 194, 242, 225, 238, 228, 167, 172, 246, 229, 242, 243, 233, 239, 238, 186, 167, 178, 180, 167, 253, 221, 172, 237, 239, 226, 233, 236, 229, 186, 230, 225, 236, 243, 229, 172, 240, 236, 225, 244, 230, 239, 242, 237, 186, 167, 215, 233, 238, 228, 239, 247, 243, 167, 172, 231, 229, 244, 200, 233, 231, 232, 197, 238, 244, 242, 239, 240, 249, 214, 225, 236, 245, 229, 243, 186, 230, 245, 238, 227, 244, 233, 239, 238, 168, 169, 251, 242, 229, 244, 245, 242, 238, 160, 208, 242, 239, 237, 233, 243, 229, 174, 242, 229, 243, 239, 236, 246, 229, 168, 251, 225, 242, 227, 232, 233, 244, 229, 227, 244, 245, 242, 229, 186, 167, 248, 184, 182, 167, 172, 226, 233, 244, 238, 229, 243, 243, 186, 167, 182, 180, 167, 172, 237, 239, 226, 233, 236, 229, 186, 230, 225, 236, 243, 229, 172, 237, 239, 228, 229, 236, 186, 167, 167, 172, 240, 236, 225, 244, 230, 239, 242, 237, 186, 167, 215, 233, 238, 228, 239, 247, 243, 167, 172, 240, 236, 225, 244, 230, 239, 242, 237, 214, 229, 242, 243, 233, 239, 238, 186, 167, 177, 181, 174, 176, 174, 176, 167, 172, 245, 225, 198, 245, 236, 236, 214, 229, 242, 243, 233, 239, 238, 186, 167, 177, 178, 176, 174, 176, 174, 176, 174, 176, 167, 253, 169, 187, 253, 253, 187, 207, 226, 234, 229, 227, 244, 174, 228, 229, 230, 233, 238, 229, 208, 242, 239, 240, 229, 242, 244, 249, 168, 240, 242, 239, 244, 239, 172, 167, 245, 243, 229, 242, 193, 231, 229, 238, 244, 196, 225, 244, 225, 167, 172, 251, 231, 229, 244, 186, 230, 245, 238, 227, 244, 233, 239, 238, 168, 169, 251, 242, 229, 244, 245, 242, 238, 160, 245, 225, 228, 187, 253, 172, 227, 239, 238, 230, 233, 231, 245, 242, 225, 226, 236, 229, 186, 244, 242, 245, 229, 253, 169, 187, 253, 227, 225, 244, 227, 232, 168, 229, 169, 251, 253 }, 128) + _0x3491765a._0xbc716140(new byte[112] { 105, 104, 107, 37, 126, 110, 127, 104, 104, 99, 33, 42, 122, 100, 105, 121, 101, 42, 33, 60, 52, 63, 61, 36, 54, 105, 104, 107, 37, 126, 110, 127, 104, 104, 99, 33, 42, 101, 104, 100, 106, 101, 121, 42, 33, 60, 61, 53, 61, 36, 54, 105, 104, 107, 37, 126, 110, 127, 104, 104, 99, 33, 42, 108, 123, 108, 100, 97, 90, 100, 105, 121, 101, 42, 33, 60, 52, 63, 61, 36, 54, 105, 104, 107, 37, 126, 110, 127, 104, 104, 99, 33, 42, 108, 123, 108, 100, 97, 69, 104, 100, 106, 101, 121, 42, 33, 60, 61, 57, 61, 36, 54 }, 13) + _0x3491765a._0xbc716140(new byte[45] { 130, 132, 143, 141, 129, 159, 152, 146, 153, 129, 216, 153, 152, 130, 153, 131, 149, 158, 133, 130, 151, 132, 130, 203, 131, 152, 146, 147, 144, 159, 152, 147, 146, 205, 139, 149, 151, 130, 149, 158, 222, 147, 223, 141, 139 }, 246) + _0x3491765a._0xbc716140(new byte[721] { 41, 47, 36, 38, 43, 60, 47, 125, 50, 47, 52, 58, 96, 42, 52, 51, 57, 50, 42, 115, 48, 60, 41, 62, 53, 16, 56, 57, 52, 60, 115, 63, 52, 51, 57, 117, 42, 52, 51, 57, 50, 42, 116, 102, 42, 52, 51, 57, 50, 42, 115, 48, 60, 41, 62, 53, 16, 56, 57, 52, 60, 96, 59, 40, 51, 62, 41, 52, 50, 51, 117, 44, 116, 38, 43, 60, 47, 125, 46, 96, 14, 41, 47, 52, 51, 58, 117, 44, 116, 115, 41, 50, 17, 50, 42, 56, 47, 30, 60, 46, 56, 117, 116, 102, 52, 59, 117, 46, 115, 52, 51, 57, 56, 37, 18, 59, 117, 122, 45, 50, 52, 51, 41, 56, 47, 103, 125, 62, 50, 60, 47, 46, 56, 122, 116, 99, 96, 109, 33, 33, 46, 115, 52, 51, 57, 56, 37, 18, 59, 117, 122, 53, 50, 43, 56, 47, 103, 125, 51, 50, 51, 56, 122, 116, 99, 96, 109, 33, 33, 46, 115, 52, 51, 57, 56, 37, 18, 59, 117, 122, 48, 60, 37, 112, 42, 52, 57, 41, 53, 122, 116, 99, 96, 109, 33, 33, 46, 115, 52, 51, 57, 56, 37, 18, 59, 117, 122, 48, 60, 37, 112, 57, 56, 43, 52, 62, 56, 112, 42, 52, 57, 41, 53, 122, 116, 99, 96, 109, 116, 47, 56, 41, 40, 47, 51, 125, 38, 48, 60, 41, 62, 53, 56, 46, 103, 59, 60, 49, 46, 56, 113, 48, 56, 57, 52, 60, 103, 44, 113, 50, 51, 62, 53, 60, 51, 58, 56, 103, 51, 40, 49, 49, 113, 60, 57, 57, 17, 52, 46, 41, 56, 51, 56, 47, 103, 59, 40, 51, 62, 41, 52, 50, 51, 117, 116, 38, 32, 113, 47, 56, 48, 50, 43, 56, 17, 52, 46, 41, 56, 51, 56, 47, 103, 59, 40, 51, 62, 41, 52, 50, 51, 117, 116, 38, 32, 113, 60, 57, 57, 24, 43, 56, 51, 41, 17, 52, 46, 41, 56, 51, 56, 47, 103, 59, 40, 51, 62, 41, 52, 50, 51, 117, 116, 38, 32, 113, 47, 56, 48, 50, 43, 56, 24, 43, 56, 51, 41, 17, 52, 46, 41, 56, 51, 56, 47, 103, 59, 40, 51, 62, 41, 52, 50, 51, 117, 116, 38, 32, 113, 57, 52, 46, 45, 60, 41, 62, 53, 24, 43, 56, 51, 41, 103, 59, 40, 51, 62, 41, 52, 50, 51, 117, 116, 38, 47, 56, 41, 40, 47, 51, 125, 59, 60, 49, 46, 56, 102, 32, 32, 102, 52, 59, 117, 46, 115, 52, 51, 57, 56, 37, 18, 59, 117, 122, 45, 50, 52, 51, 41, 56, 47, 103, 125, 59, 52, 51, 56, 122, 116, 99, 96, 109, 33, 33, 46, 115, 52, 51, 57, 56, 37, 18, 59, 117, 122, 53, 50, 43, 56, 47, 103, 125, 53, 50, 43, 56, 47, 122, 116, 99, 96, 109, 116, 47, 56, 41, 40, 47, 51, 125, 38, 48, 60, 41, 62, 53, 56, 46, 103, 41, 47, 40, 56, 113, 48, 56, 57, 52, 60, 103, 44, 113, 50, 51, 62, 53, 60, 51, 58, 56, 103, 51, 40, 49, 49, 113, 60, 57, 57, 17, 52, 46, 41, 56, 51, 56, 47, 103, 59, 40, 51, 62, 41, 52, 50, 51, 117, 116, 38, 32, 113, 47, 56, 48, 50, 43, 56, 17, 52, 46, 41, 56, 51, 56, 47, 103, 59, 40, 51, 62, 41, 52, 50, 51, 117, 116, 38, 32, 113, 60, 57, 57, 24, 43, 56, 51, 41, 17, 52, 46, 41, 56, 51, 56, 47, 103, 59, 40, 51, 62, 41, 52, 50, 51, 117, 116, 38, 32, 113, 47, 56, 48, 50, 43, 56, 24, 43, 56, 51, 41, 17, 52, 46, 41, 56, 51, 56, 47, 103, 59, 40, 51, 62, 41, 52, 50, 51, 117, 116, 38, 32, 113, 57, 52, 46, 45, 60, 41, 62, 53, 24, 43, 56, 51, 41, 103, 59, 40, 51, 62, 41, 52, 50, 51, 117, 116, 38, 47, 56, 41, 40, 47, 51, 125, 59, 60, 49, 46, 56, 102, 32, 32, 102, 47, 56, 41, 40, 47, 51, 125, 50, 47, 52, 58, 117, 44, 116, 102, 32, 102, 32, 62, 60, 41, 62, 53, 117, 56, 116, 38, 32 }, 93) + _0x3491765a._0xbc716140(new byte[5] { 193, 149, 148, 149, 135 }, 188);
    }

    private void _0x4b1c340a(string _0xb76af93d)
    {
        Dictionary<string, object> _0x995d30c1;
        try
        {
            _0x995d30c1 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xb76af93d);
        }
        catch
        {
            return;
        }

        var _0x21a909bc = ReadPushField(_0x995d30c1, _0x3491765a._0xbc716140(new byte[3] { 192, 199, 217 }, 181));
        if (string.IsNullOrWhiteSpace(_0x21a909bc))
            return;
        _0x21a909bc = _0x21a909bc.Trim();
        if (!IsHttpUrl(_0x21a909bc))
            return;
        if (string.Equals(_0x21a909bc, _0x98497db8, StringComparison.Ordinal))
            return;
        _0x98497db8 = _0x21a909bc;
        OpenUrlExternally(_0x21a909bc);
    }

    private void _0x547c8b2d()
    {
        if (_0xb9f7d675 != null)
            return;
        var _0x918972f4 = _0xcc254594();
        _0xb9f7d675 = new GameObject(_0x3491765a._0xbc716140(new byte[14] { 215, 229, 226, 214, 233, 229, 247, 211, 240, 233, 238, 238, 229, 242 }, 128), typeof(RectTransform), typeof(Text));
        _0x1131ef1e = _0xb9f7d675.GetComponent<RectTransform>();
        _0x1131ef1e.SetParent(_0x918972f4.transform, false);
        _0x1131ef1e.anchorMin = new Vector2(0.5f, 0.5f);
        _0x1131ef1e.anchorMax = new Vector2(0.5f, 0.5f);
        _0x1131ef1e.pivot = new Vector2(0.5f, 0.5f);
        _0x1131ef1e.sizeDelta = new Vector2(600f, 600f);
        _0x1131ef1e.anchoredPosition = Vector2.zero;
        _0xcf58f109 = _0xb9f7d675.GetComponent<Text>();
        _0xcf58f109.text = _0x3491765a._0xbc716140(new byte[1] { 176 }, 159);
        _0xcf58f109.font = Resources.GetBuiltinResource<Font>(_0x3491765a._0xbc716140(new byte[17] { 168, 129, 131, 133, 135, 157, 182, 145, 138, 144, 141, 137, 129, 202, 144, 144, 130 }, 228));
        _0xcf58f109.fontSize = 200;
        _0xcf58f109.alignment = TextAnchor.MiddleCenter;
        _0xcf58f109.color = Color.white;
        _0xcf58f109.raycastTarget = false;
        _0xb9f7d675.SetActive(false);
    }

    private void _0x8e555451()
    {
        using (var _0x7a11e9ac = new AndroidJavaClass(_0x3491765a._0xbc716140(new byte[30] { 170, 166, 164, 231, 188, 167, 160, 189, 176, 250, 173, 231, 185, 165, 168, 176, 172, 187, 231, 156, 167, 160, 189, 176, 153, 165, 168, 176, 172, 187 }, 201)))
        using (var _0xa4b8447d = _0x7a11e9ac.GetStatic<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[15] { 63, 41, 46, 46, 57, 50, 40, 29, 63, 40, 53, 42, 53, 40, 37 }, 92)))
        using (var _0xae336df8 = _0xa4b8447d.Call<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[9] { 247, 245, 228, 217, 254, 228, 245, 254, 228 }, 144)))
        {
            if (_0xae336df8 == null)
                return;
            using (var _0x1068ec44 = _0xae336df8.Call<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[9] { 136, 138, 155, 170, 151, 155, 157, 142, 156 }, 239)))
            {
                if (_0x1068ec44 == null)
                    return;
                using (var _0x855dccbb = new AndroidJavaObject(_0x3491765a._0xbc716140(new byte[19] { 190, 163, 182, 255, 187, 162, 190, 191, 255, 155, 130, 158, 159, 158, 179, 187, 180, 178, 165 }, 209)))
                using (var _0xeb75663d = _0x1068ec44.Call<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[6] { 64, 78, 82, 120, 78, 95 }, 43)))
                using (var _0xf052bc42 = _0xeb75663d.Call<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[8] { 152, 133, 148, 131, 144, 133, 158, 131 }, 241)))
                {
                    while (_0xf052bc42.Call<bool>(_0x3491765a._0xbc716140(new byte[7] { 230, 239, 253, 192, 235, 246, 250 }, 142)))
                    {
                        string _0x4297cc87 = _0xf052bc42.Call<string>(_0x3491765a._0xbc716140(new byte[4] { 14, 5, 24, 20 }, 96));
                        using (var _0x90a992c7 = _0x1068ec44.Call<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[3] { 137, 139, 154 }, 238), _0x4297cc87))
                        {
                            _0x855dccbb.Call<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[3] { 155, 158, 159 }, 235), _0x4297cc87, _0x90a992c7);
                        }
                    }

                    string _0xc1f503c5 = _0x855dccbb.Call<string>(_0x3491765a._0xbc716140(new byte[8] { 144, 139, 183, 144, 150, 141, 138, 131 }, 228));
                    if (!string.IsNullOrEmpty(_0xc1f503c5))
                    {
                        _0x4b1c340a(_0xc1f503c5);
                        _0x63a0bfad(_0xc1f503c5);
                    }
                }
            }
        }
    }

    private AndroidJavaObject _0x50f763da { get; set; }

    private static string ReadPushField(Dictionary<string, object> _0x998ee413, string _0xb9702d88)
    {
        if (_0x998ee413 == null || string.IsNullOrEmpty(_0xb9702d88))
            return string.Empty;
        if (_0x998ee413.TryGetValue(_0x3491765a._0xbc716140(new byte[16] { 238, 239, 244, 233, 230, 233, 227, 225, 244, 233, 239, 238, 196, 225, 244, 225 }, 128), out var raw))
        {
            try
            {
                var _0xf424434d = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0xf424434d != null && _0xf424434d.TryGetValue(_0xb9702d88, out var nestedVal))
                {
                    var _0x993c313b = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x993c313b))
                        return _0x993c313b;
                }
            }
            catch
            {
            }
        }

        if (_0x998ee413.TryGetValue(_0xb9702d88, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private GameObject _0xb9f7d675;
    private IEnumerator _0xd4deaf94(Dictionary<string, object> _0xf538d27a)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x3491765a._0xbc716140(new byte[30] { 237, 226, 211, 197, 194, 235, 150, 240, 211, 194, 213, 222, 150, 243, 206, 194, 196, 215, 150, 230, 195, 197, 222, 150, 242, 215, 194, 215, 140, 150 }, 182) + string.Join(_0x3491765a._0xbc716140(new byte[1] { 61 }, 52), _0xf538d27a));
#endif
            }
        }

        string _0x3ec11a5c = "";
        // Primary source: nested JSON under "notificationData"
        if (_0xf538d27a != null && _0xf538d27a.TryGetValue(_0x3491765a._0xbc716140(new byte[16] { 106, 107, 112, 109, 98, 109, 103, 101, 112, 109, 107, 106, 64, 101, 112, 101 }, 4), out var raw))
        {
            try
            {
                var _0xa031874f = raw?.ToString();
                var _0xb3b0b7dc = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xa031874f);
                if (_0xb3b0b7dc != null && _0xb3b0b7dc.TryGetValue(_0x3491765a._0xbc716140(new byte[6] { 0, 22, 29, 23, 26, 23 }, 115), out var val))
                {
                    _0x3ec11a5c = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x3491765a._0xbc716140(new byte[30] { 154, 149, 164, 178, 181, 225, 145, 180, 178, 169, 156, 225, 139, 146, 142, 143, 225, 177, 160, 179, 178, 164, 225, 164, 179, 179, 174, 179, 251, 225 }, 193) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x3ec11a5c) && _0xf538d27a != null && _0xf538d27a.TryGetValue(_0x3491765a._0xbc716140(new byte[6] { 246, 224, 235, 225, 236, 225 }, 133), out var lab))
        {
            _0x3ec11a5c = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x3491765a._0xbc716140(new byte[38] { 221, 210, 227, 245, 242, 166, 214, 243, 245, 238, 219, 166, 192, 227, 242, 229, 238, 227, 226, 166, 245, 227, 232, 226, 239, 226, 166, 224, 244, 233, 235, 166, 236, 245, 233, 232, 188, 166 }, 134) + _0x3ec11a5c);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x3ec11a5c))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x3491765a._0xbc716140(new byte[38] { 217, 214, 231, 241, 246, 162, 210, 247, 241, 234, 223, 162, 213, 227, 235, 246, 162, 246, 237, 162, 237, 242, 231, 236, 162, 245, 235, 246, 234, 162, 241, 231, 236, 230, 235, 230, 184, 162 }, 130) + _0x3ec11a5c);
            }
#endif
        }

        _0xd422a8a4 = _0x3ec11a5c;
        yield return new WaitUntil(() => _0xb5e80385);
        var _0xe2e7ca9a = _0xc96f54f7(2, 100);
        yield return new WaitUntil(() => _0xe2e7ca9a.IsCompleted);
        string _0xd2ceea9d = _0xe2e7ca9a.Result;
        if (!string.IsNullOrEmpty(_0xd2ceea9d))
        {
            string _0x9bc45152 = _0x6178e3f3(_0xd2ceea9d, _0x3ec11a5c);
            {
#if B_LOGS
                Debug.Log(_0x3491765a._0xbc716140(new byte[33] { 239, 224, 209, 199, 192, 148, 228, 193, 199, 220, 233, 148, 230, 209, 216, 219, 213, 208, 148, 227, 209, 214, 226, 221, 209, 195, 148, 195, 221, 192, 220, 142, 148 }, 180) + _0x9bc45152);
#endif
            }

            _0x8d5c37a3.Load(_0x9bc45152);
        }
    }

    private async Task _0xbde8f85d()
    {
        if (await _0x959963d0())
            return;
        if (await _0xe298effd())
            return;
        if (await _0xc1a215e4())
            return;
        _0x62271c35();
        await _0xb2e9910b(_0xd9980a86());
        _0xeca08a3a = await _0xab6c5cfb();
        await _0x638169fe();
    }

    private int _0xe1da6e3b = 0;
    private void OnApplicationPause(bool _0x291efe44)
    {
        isApplicationPause = _0x291efe44;
    }

    private async void Start()
    {
        await _0xbde8f85d();
    }

    public void _0xac43ce9b()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x3491765a._0xbc716140(new byte[18] { 72, 71, 118, 96, 103, 78, 51, 95, 114, 102, 125, 112, 123, 51, 84, 114, 126, 118 }, 19));
#endif
        }

        _0xe6b3ba0e.Instance?._0xb3585b51();
        _0x84e527ab.Instance._0x24f58fbd(_0x014c750c._0x50016d8c.DEFAULT);
    }

    private string _0xc1ffb983 = "";
    private string _0xd89619bd()
    {
        if (string.IsNullOrEmpty(_0xc1ffb983) && _0x8d5c37a3 != null)
            _0xc1ffb983 = _0x8d5c37a3.GetUserAgent();
        if (string.IsNullOrEmpty(_0xc1ffb983))
            return string.Empty;
        string _0x94c1156c = Regex.Replace(_0xc1ffb983, _0x3491765a._0xbc716140(new byte[11] { 74, 101, 60, 45, 74, 101, 60, 97, 96, 74, 116 }, 22), string.Empty);
        _0x94c1156c = Regex.Replace(_0x94c1156c, _0x3491765a._0xbc716140(new byte[15] { 16, 63, 103, 14, 57, 37, 32, 40, 99, 23, 18, 119, 101, 17, 103 }, 76), string.Empty);
        _0x94c1156c = Regex.Replace(_0x94c1156c, _0x3491765a._0xbc716140(new byte[15] { 90, 105, 126, 127, 101, 99, 98, 35, 56, 80, 34, 60, 80, 127, 38 }, 12), string.Empty);
        return Regex.Replace(_0x94c1156c, _0x3491765a._0xbc716140(new byte[6] { 109, 66, 74, 3, 29, 76 }, 49), _0x3491765a._0xbc716140(new byte[1] { 26 }, 58)).Trim();
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0xac43ce9b();
    }

    private static readonly string WindowsDesktopUserAgent = _0x3491765a._0xbc716140(new byte[111] { 205, 239, 250, 233, 236, 236, 225, 175, 181, 174, 176, 160, 168, 215, 233, 238, 228, 239, 247, 243, 160, 206, 212, 160, 177, 176, 174, 176, 187, 160, 215, 233, 238, 182, 180, 187, 160, 248, 182, 180, 169, 160, 193, 240, 240, 236, 229, 215, 229, 226, 203, 233, 244, 175, 181, 179, 183, 174, 179, 182, 160, 168, 203, 200, 212, 205, 204, 172, 160, 236, 233, 235, 229, 160, 199, 229, 227, 235, 239, 169, 160, 195, 232, 242, 239, 237, 229, 175, 177, 178, 176, 174, 176, 174, 176, 174, 176, 160, 211, 225, 230, 225, 242, 233, 175, 181, 179, 183, 174, 179, 182 }, 128);
    private string _0x2f2b91b8 = "";
    // MAIN FLOW
    private bool _0x62e8e93b { get; set; }

    private RectTransform _0x1131ef1e;
    // PART 3
    private string _0xad740086()
    {
        try
        {
            var _0x9ad867aa = new AndroidJavaClass(_0x3491765a._0xbc716140(new byte[30] { 214, 218, 216, 155, 192, 219, 220, 193, 204, 134, 209, 155, 197, 217, 212, 204, 208, 199, 155, 224, 219, 220, 193, 204, 229, 217, 212, 204, 208, 199 }, 181));
            var _0x13ef41ba = _0x9ad867aa.GetStatic<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[15] { 239, 249, 254, 254, 233, 226, 248, 205, 239, 248, 229, 250, 229, 248, 245 }, 140));
            var _0x471a4315 = new AndroidJavaClass(_0x3491765a._0xbc716140(new byte[57] { 155, 151, 149, 214, 159, 151, 151, 159, 148, 157, 214, 153, 150, 156, 138, 151, 145, 156, 214, 159, 149, 139, 214, 153, 156, 139, 214, 145, 156, 157, 150, 140, 145, 158, 145, 157, 138, 214, 185, 156, 142, 157, 138, 140, 145, 139, 145, 150, 159, 177, 156, 187, 148, 145, 157, 150, 140 }, 248));
            var _0x6477cd37 = _0x471a4315.CallStatic<AndroidJavaObject>(_0x3491765a._0xbc716140(new byte[20] { 218, 216, 201, 252, 217, 203, 216, 207, 201, 212, 206, 212, 211, 218, 244, 217, 244, 211, 219, 210 }, 189), _0x13ef41ba);
            var _0x40ee6a1c = _0x6477cd37.Call<string>(_0x3491765a._0xbc716140(new byte[5] { 122, 120, 105, 84, 121 }, 29));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0x40ee6a1c}");
#endif
            }

            return string.IsNullOrEmpty(_0x40ee6a1c) ? "" : _0x40ee6a1c;
        }
        catch
        {
            return "";
        }
    }

    private string _0x64d280ea()
    {
        float _0x3bf6ca80 = Time.realtimeSinceStartup;
        if (_0x3bf6ca80 < 0f)
            _0x3bf6ca80 = 0f;
        int _0x147a4a6a = (int)(_0x3bf6ca80 * 1000f);
        int _0x3839775e = _0x147a4a6a / 60000;
        int _0x0398cc32 = (_0x147a4a6a / 1000) % 60;
        int _0x7317a569 = _0x147a4a6a % 1000;
        return string.Format(_0x3491765a._0xbc716140(new byte[21] { 28, 87, 93, 87, 87, 26, 93, 28, 86, 93, 87, 87, 26, 93, 28, 85, 93, 87, 87, 87, 26 }, 103), _0x3839775e, _0x0398cc32, _0x7317a569);
    }

    public void _0xf3c2f44d()
    {
        if (_0xb5e80385)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x3491765a._0xbc716140(new byte[33] { 38, 41, 24, 14, 9, 32, 93, 41, 20, 16, 24, 15, 93, 18, 8, 9, 93, 80, 67, 93, 16, 18, 11, 24, 93, 9, 18, 93, 14, 30, 24, 19, 24 }, 125));
            }
#endif
        }

        _0xac43ce9b();
    }

    internal void Update()
    {
        if (_0x8d5c37a3 == null)
            return;
        if (_0xd3e4a450())
            _0x8cd13c7f();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0xbcdfe34b();
        if (_0xa1d00b9d && _0x1131ef1e != null)
            _0x1131ef1e.Rotate(0f, 0f, -360f * Time.deltaTime);
    }
}

internal static class _0x3491765a
{
    internal static string _0xbc716140(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}