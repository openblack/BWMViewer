-- Premake 5 Visual Studio C# project
solution "BWMViewer"
  language  "C#"
  framework "4.0"
  configurations { "Debug", "Release" }
  location  "build"
  targetdir "%{prj.location}/bin/%{cfg.buildcfg}"
	  
  project "BWMLib"
    location  "build/%{prj.name}"
    kind      "SharedLib"
    files     { "src/BWMLib/**.cs" }
	vpaths 	  { ["Source"] = { "src/BWMLib" } }
    links     { "System", "System.Core" }
 
    configuration { "Debug*" }
      defines { "DEBUG" }
      flags   { "Symbols" }
 
    configuration { "Release*" }
	  optimize "On"
	  
  project "BWMViewer"
    location  "build/%{prj.name}"
    kind      "WindowedApp"
    files     { "src/BWMViewer/**.cs" }
	vpaths 	  { ["Source"] = { "src/BWMViewer" } }
    links     { "System", "System.Core", "System.Data", "System.Drawing", "System.Windows.Forms", "BWMLib" }
 
    configuration { "Debug*" }
      defines { "DEBUG" }
      flags   { "Symbols" }
 
    configuration { "Release*" }
	  optimize "On"
	  
  if _ACTION == "clean" then
    os.rmdir("build")
	
    mdbs = os.matchfiles "*.mdb"
      for _,file in ipairs (mdbs) do
        os.remove (file)
      end
    end