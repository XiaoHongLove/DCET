-- Generated by CSharp.lua Compiler
local System = System
System.namespace("DCET", function (namespace)
  namespace.class("TypeHelper", function (namespace)
    local Init, InitByLua
    Init = function ()
      InitByLua()
    end
    InitByLua = function ()
      for k,v in pairs(DCET) do
      	if v ~= DCET.Runtime then
      		DCET.Game.getEventSystem():AddType(System.typeof(v))
      	end
      end
    end
    return {
      Init = Init
    }
  end)
end)
