//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\pfc\\12.net\\security\\pfcsecad\\pfcsecad.pbl\\pfcsecad.pblx\\s_pfcsecurity_user_data.srs"
#line hidden
[Sybase.PowerBuilder.PBGroupAttribute("s_pfcsecurity_user_data",Sybase.PowerBuilder.PBGroupType.Structure,"","c:\\pfc\\12.net\\security\\pfcsecad\\pfcsecad.pbl\\pfcsecad.pblx",null)]
public class c__s_pfcsecurity_user_data : Sybase.PowerBuilder.PBStructure
{
	public Sybase.PowerBuilder.PBString name = Sybase.PowerBuilder.PBString.DefaultValue;
	public Sybase.PowerBuilder.PBString desc = Sybase.PowerBuilder.PBString.DefaultValue;
	public Sybase.PowerBuilder.PBInt priority = Sybase.PowerBuilder.PBInt.DefaultValue;
	public Sybase.PowerBuilder.PBInt user_type = Sybase.PowerBuilder.PBInt.DefaultValue;
	public Sybase.PowerBuilder.PBInt status = Sybase.PowerBuilder.PBInt.DefaultValue;

	public override object Clone()
	{
		c__s_pfcsecurity_user_data vv = (c__s_pfcsecurity_user_data)base.Clone();
 		vv.name = name;
		vv.desc = desc;
		vv.priority = priority;
		vv.user_type = user_type;
		vv.status = status;
		return vv;
	}

	public static explicit operator c__s_pfcsecurity_user_data(Sybase.PowerBuilder.PBAny v)
	{
		if (v.Value is Sybase.PowerBuilder.PBUnboundedArray)
		{
			Sybase.PowerBuilder.PBUnboundedArray a = (Sybase.PowerBuilder.PBUnboundedArray)v;
			c__s_pfcsecurity_user_data vv = new c__s_pfcsecurity_user_data();
			vv.name = (Sybase.PowerBuilder.PBString)((Sybase.PowerBuilder.PBAny)a[1]);
			vv.desc = (Sybase.PowerBuilder.PBString)((Sybase.PowerBuilder.PBAny)a[2]);
			vv.priority = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBAny)a[3]);
			vv.user_type = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBAny)a[4]);
			vv.status = (Sybase.PowerBuilder.PBInt)((Sybase.PowerBuilder.PBAny)a[5]);

			return vv;
		}
		else
		{
			return (c__s_pfcsecurity_user_data) v.Value;
		}
	}

	public override Sybase.PowerBuilder.PBUnboundedAnyArray ToUnboundedAnyArray()
	{
		Sybase.PowerBuilder.PBUnboundedAnyArray a = new Sybase.PowerBuilder.PBUnboundedAnyArray();
		a.Add(new Sybase.PowerBuilder.PBAny(this.name));
		a.Add(new Sybase.PowerBuilder.PBAny(this.desc));
		a.Add(new Sybase.PowerBuilder.PBAny(this.priority));
		a.Add(new Sybase.PowerBuilder.PBAny(this.user_type));
		a.Add(new Sybase.PowerBuilder.PBAny(this.status));

		return a;
	}
}


[Sybase.PowerBuilder.PBStructureLayoutAttribute("s_pfcsecurity_user_data")]
[ System.Runtime.InteropServices.StructLayout( System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1, CharSet = System.Runtime.InteropServices.CharSet.Ansi )]
public struct c__s_pfcsecurity_user_data_ansi
{
	public string name;
	public string desc;
	public short priority;
	public short user_type;
	public short status;

	public static implicit operator c__s_pfcsecurity_user_data_ansi(c__s_pfcsecurity_user_data other)
	{

		c__s_pfcsecurity_user_data_ansi ret = new c__s_pfcsecurity_user_data_ansi();

		ret.name = other.name;

		ret.desc = other.desc;

		ret.priority = other.priority;

		ret.user_type = other.user_type;

		ret.status = other.status;

		return ret;
	}

	public static implicit operator c__s_pfcsecurity_user_data(c__s_pfcsecurity_user_data_ansi other)
	{

		c__s_pfcsecurity_user_data ret = new c__s_pfcsecurity_user_data();

		ret.name = other.name;

		ret.desc = other.desc;

		ret.priority = other.priority;

		ret.user_type = other.user_type;

		ret.status = other.status;

		return ret;
	}
}


[Sybase.PowerBuilder.PBStructureLayoutAttribute("s_pfcsecurity_user_data")]
[ System.Runtime.InteropServices.StructLayout( System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1, CharSet = System.Runtime.InteropServices.CharSet.Unicode )]
public struct c__s_pfcsecurity_user_data_unicode
{
	public string name;
	public string desc;
	public short priority;
	public short user_type;
	public short status;

	public static implicit operator c__s_pfcsecurity_user_data_unicode(c__s_pfcsecurity_user_data other)
	{

		c__s_pfcsecurity_user_data_unicode ret = new c__s_pfcsecurity_user_data_unicode();

		ret.name = other.name;

		ret.desc = other.desc;

		ret.priority = other.priority;

		ret.user_type = other.user_type;

		ret.status = other.status;

		return ret;
	}

	public static implicit operator c__s_pfcsecurity_user_data(c__s_pfcsecurity_user_data_unicode other)
	{

		c__s_pfcsecurity_user_data ret = new c__s_pfcsecurity_user_data();

		ret.name = other.name;

		ret.desc = other.desc;

		ret.priority = other.priority;

		ret.user_type = other.user_type;

		ret.status = other.status;

		return ret;
	}
}
 