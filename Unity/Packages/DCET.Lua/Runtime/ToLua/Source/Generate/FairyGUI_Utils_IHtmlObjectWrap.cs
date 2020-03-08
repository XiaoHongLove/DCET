﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_Utils_IHtmlObjectWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.Utils.IHtmlObject), null);
		L.RegFunction("Create", Create);
		L.RegFunction("SetPosition", SetPosition);
		L.RegFunction("Add", Add);
		L.RegFunction("Remove", Remove);
		L.RegFunction("Release", Release);
		L.RegFunction("Dispose", Dispose);
		L.RegVar("width", get_width, null);
		L.RegFunction("getwidth", get_width);
		L.RegVar("height", get_height, null);
		L.RegFunction("getheight", get_height);
		L.RegVar("displayObject", get_displayObject, null);
		L.RegFunction("getdisplayObject", get_displayObject);
		L.RegVar("element", get_element, null);
		L.RegFunction("getelement", get_element);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Create(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.Utils.IHtmlObject obj = (FairyGUI.Utils.IHtmlObject)ToLua.CheckObject<FairyGUI.Utils.IHtmlObject>(L, 1);
			FairyGUI.RichTextField arg0 = (FairyGUI.RichTextField)ToLua.CheckObject<FairyGUI.RichTextField>(L, 2);
			FairyGUI.Utils.HtmlElement arg1 = (FairyGUI.Utils.HtmlElement)ToLua.CheckObject<FairyGUI.Utils.HtmlElement>(L, 3);
			obj.Create(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPosition(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.Utils.IHtmlObject obj = (FairyGUI.Utils.IHtmlObject)ToLua.CheckObject<FairyGUI.Utils.IHtmlObject>(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			obj.SetPosition(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Add(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.Utils.IHtmlObject obj = (FairyGUI.Utils.IHtmlObject)ToLua.CheckObject<FairyGUI.Utils.IHtmlObject>(L, 1);
			obj.Add();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Remove(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.Utils.IHtmlObject obj = (FairyGUI.Utils.IHtmlObject)ToLua.CheckObject<FairyGUI.Utils.IHtmlObject>(L, 1);
			obj.Remove();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Release(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.Utils.IHtmlObject obj = (FairyGUI.Utils.IHtmlObject)ToLua.CheckObject<FairyGUI.Utils.IHtmlObject>(L, 1);
			obj.Release();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Dispose(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.Utils.IHtmlObject obj = (FairyGUI.Utils.IHtmlObject)ToLua.CheckObject<FairyGUI.Utils.IHtmlObject>(L, 1);
			obj.Dispose();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_width(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Utils.IHtmlObject obj = (FairyGUI.Utils.IHtmlObject)o;
			float ret = obj.width;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index width on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_height(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Utils.IHtmlObject obj = (FairyGUI.Utils.IHtmlObject)o;
			float ret = obj.height;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index height on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_displayObject(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Utils.IHtmlObject obj = (FairyGUI.Utils.IHtmlObject)o;
			FairyGUI.DisplayObject ret = obj.displayObject;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index displayObject on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_element(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Utils.IHtmlObject obj = (FairyGUI.Utils.IHtmlObject)o;
			FairyGUI.Utils.HtmlElement ret = obj.element;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index element on a nil value");
		}
	}
}

