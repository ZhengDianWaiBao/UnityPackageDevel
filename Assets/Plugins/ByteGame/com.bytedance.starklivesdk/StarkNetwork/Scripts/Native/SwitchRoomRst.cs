//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace StarkMatchmaking {

public class SwitchRoomRst : MessageBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal SwitchRoomRst(global::System.IntPtr cPtr, bool cMemoryOwn) : base(stark_matchmakingPINVOKE.SwitchRoomRst_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SwitchRoomRst obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          stark_matchmakingPINVOKE.delete_SwitchRoomRst(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public ulong room_id {
    set {
      stark_matchmakingPINVOKE.SwitchRoomRst_room_id_set(swigCPtr, value);
    } 
    get {
      ulong ret = stark_matchmakingPINVOKE.SwitchRoomRst_room_id_get(swigCPtr);
      return ret;
    } 
  }

  public string token {
    set {
      stark_matchmakingPINVOKE.SwitchRoomRst_token_set(swigCPtr, value);
      if (stark_matchmakingPINVOKE.SWIGPendingException.Pending) throw stark_matchmakingPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = stark_matchmakingPINVOKE.SwitchRoomRst_token_get(swigCPtr);
      if (stark_matchmakingPINVOKE.SWIGPendingException.Pending) throw stark_matchmakingPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SwitchRoomRst() : this(stark_matchmakingPINVOKE.new_SwitchRoomRst(), true) {
  }

}

}