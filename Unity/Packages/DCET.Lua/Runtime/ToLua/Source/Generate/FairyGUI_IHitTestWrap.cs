﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_IHitTestWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.IHitTest), null);
		L.RegFunction("HitTest", HitTest);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HitTest(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.IHitTest obj = (FairyGUI.IHitTest)ToLua.CheckObject<FairyGUI.IHitTest>(L, 1);
			UnityEngine.Rect arg0 = StackTraits<UnityEngine.Rect>.Check(L, 2);
			UnityEngine.Vector2 arg1 = ToLua.ToVector2(L, 3);
			bool o = obj.HitTest(arg0, arg1);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

