//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\tutorial\\pfemain.pbl\\pfemain.pblx\\w_child.srw"
#line hidden
#line 1 "w_child"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("w_child",Sybase.PowerBuilder.PBGroupType.Window,"","c:\\pfc\\12.net\\tutorial\\pfemain.pbl\\pfemain.pblx",null)]
[System.Diagnostics.DebuggerDisplay("",Type="w_child")]
public class c__w_child : c__pfc_w_child
{
	#line hidden

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("create")]
	public override void create()
	{
		#line hidden
		#line hidden
		base.create();
		#line hidden
	}

	#line hidden
	[Sybase.PowerBuilder.PBEventAttribute("destroy")]
	public override void destroy()
	{
		#line hidden
		#line hidden
		base.destroy();
		#line hidden
	}

	void _init()
	{
		this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
		this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
	}

	public c__w_child()
	{
		_init();
	}

}
 